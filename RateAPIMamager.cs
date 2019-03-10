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

    public class RateAPIMamager
    {
        public delegate void OnResponseDataHandler(string message);
        public event OnResponseDataHandler OnResponseData;

        const string masAPIURL = "https://eservices.mas.gov.sg/api/action/datastore/search.json";

        string resourceId = "5f2b18a8-0883-4769-a635-879c63d3caac";


        public RateAPIMamager()
        {

        }

        public RateAPIMamager(string resourceId)
        {
            this.resourceId = resourceId;
        }

        public void GetRateDataFromAPI (string period)
        { 
            string endOfMonth = ParseMonth(period);
            string apiUrl = string.Format("{0}?resource_id={1}&filters[end_of_month]={2}", masAPIURL, resourceId, endOfMonth);
            DoAPICall(apiUrl);
        }

        public void GetRateDataFromAPI(string period1, string period2)
        {
            string endOfMonth1 = ParseMonth(period1);
            string endOfMonth2 = ParseMonth(period2);
            string apiUrl = string.Format("{0}?resource_id={1}&between[end_of_month]={2},{3}", masAPIURL, resourceId, endOfMonth1, endOfMonth2);
            DoAPICall(apiUrl);
        }

        private void DoAPICall(string apiUrl)
        {
            WebClientHelper webClient = WebClientHelper.GetWebInstance;            
            webClient.OnResponseData += WebClient_OnResponseData;
            webClient.DoAPIRequest(apiUrl);
        }

        private void WebClient_OnResponseData(string message)
        {
            if (OnResponseData != null)
            {
                OnResponseData(message);
            }
        }

        public string ParseMonth(string period)
        {
            string[]strMonths = period.Split('-');
            if (strMonths.Length > 1)
            {
                string mth = HelperClass.Months.Where(p => p.Value == strMonths[0]).FirstOrDefault().Key;
                return string.Format("{0}-{1}", strMonths[1], mth);
            }
            else return string.Empty;
        }

    }
}
