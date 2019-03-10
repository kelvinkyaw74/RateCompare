using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Tests
{
    [TestClass()]
    public class WebClientHelperTests
    {
        [TestMethod()]
        public void DoAPIRequestTest()
        {
            string url = "https://eservices.mas.gov.sg/api/action/datastore/search.json?resource_id=5f2b18a8-0883-4769-a635-879c63d3caac&limit=5&between[end_of_month]=2008-01,2008-05";
            WebClientHelper.GetWebInstance.DoAPIRequest(url);

        }

        [TestMethod()]
        public void GetRateDataFromAPITest()
        {
            RateAPIMamager rateAPI = new RateAPIMamager();
            rateAPI.GetRateDataFromAPI("Jan-2008");
            rateAPI.GetRateDataFromAPI("Jan-2008", "Apr-2008");
        }

        [TestMethod()]
        public void ParseMonthTest()
        {
            RateAPIMamager rateAPI = new RateAPIMamager();
            rateAPI.ParseMonth("Jan-2009");
        }
    }
}