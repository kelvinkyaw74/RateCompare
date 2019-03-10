using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RateCompareApp
{
    /*
        Applying singleton pattern as only one instant of this is required for application
    */
    public sealed class WebClientHelper
    {
        public delegate void OnResponseDataHandler(string message);
        public event OnResponseDataHandler OnResponseData;
               
        private static WebClientHelper webInstance = null;

        public static WebClientHelper GetWebInstance
        {
            get
            {
                if (webInstance == null)
                    webInstance = new WebClientHelper();
                return webInstance = new WebClientHelper();
               
            }
        }

        private WebClientHelper()
        {
           
        }

        public void DoAPIRequest(string strUri)
        {
            try
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                       | SecurityProtocolType.Tls11
                       | SecurityProtocolType.Tls12
                       | SecurityProtocolType.Ssl3;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strUri);
                request.Method = "GET";
                using (WebResponse response = request.GetResponse())
                {
                    using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
                    {                       
                        string strData = streamReader.ReadToEnd();
                        if (OnResponseData != null)
                        {
                            OnResponseData(strData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
