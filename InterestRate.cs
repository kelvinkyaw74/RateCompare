using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RateCompareApp
{
    [Serializable]
    public class Result
    {
        public List<string> resource_id { get; set; }
        public int limit { get; set; }
        public string total { get; set; }
        public List<FinanceRate> records { get; set; }
    }
    [Serializable]
    public class RootObject
    {
        public bool success { get; set; }
        public Result result { get; set; }
    }


    [Serializable]
    public class FinanceRate
    {
        /*
         *    This class using decorator pattern, adding resposibilites to compare the interest rate dynamically base on the type
        */
        public string end_of_month { get; set; }
        public string prime_lending_rate { get; set; }
        public string banks_fixed_deposits_3m { get; set; }
        public string banks_fixed_deposits_6m { get; set; }
        public string banks_fixed_deposits_12m { get; set; }
        public string banks_savings_deposits { get; set; }
        public string fc_hire_purchase_motor_3y { get; set; }
        public string fc_housing_loans_15y { get; set; }
        public string fc_fixed_deposits_3m { get; set; }
        public string fc_fixed_deposits_6m { get; set; }
        public string fc_fixed_deposits_12m { get; set; }
        public string fc_savings_deposits { get; set; }      

        public string Period
        {
            get
            {
                return GetPeriod(end_of_month);
            }
        }

      

        public string deposits_3m_comparism {
            get
            {
                return fnCompareRate(HelperClass.RateType.deposits_3m);
            }

        }

        public string deposits_6m_comparism
        {
            get
            {
                return fnCompareRate(HelperClass.RateType.deposits_3m);
            }

        }

        public string deposits_12m_comparism
        {
            get
            {
                return fnCompareRate(HelperClass.RateType.deposits_3m);
            }

        }

        public string deposits_average_comparism
        {
            get
            {
                return fnCompareRate(HelperClass.RateType.deposits_3m);
            }

        }

        public string saving_deposit_comparism
        {
            get
            {
                return fnCompareRate(HelperClass.RateType.saving);
            }

        }

        private string fnCompareRate(HelperClass.RateType rateType)
        {
            decimal compareRate = 0.0M;
            decimal bank_depo_3m = RateInDecimal(banks_fixed_deposits_3m);
            decimal bank_depo_6m = RateInDecimal(banks_fixed_deposits_6m);
            decimal bank_depo_12m = RateInDecimal(banks_fixed_deposits_12m);
            decimal bank_depo_saving = RateInDecimal(banks_savings_deposits);
            decimal fc_depo_3m = RateInDecimal(fc_fixed_deposits_3m);
            decimal fc_depo_6m = RateInDecimal(fc_fixed_deposits_6m);
            decimal fc_depo_12m = RateInDecimal(fc_fixed_deposits_12m);
            decimal fc_depo_saving= RateInDecimal(fc_savings_deposits);

            switch (rateType)
            {
                case HelperClass.RateType.deposits_3m :
                    compareRate = fc_depo_3m - bank_depo_3m;
                    break;
                case HelperClass.RateType.deposits_6m:
                    compareRate = fc_depo_6m - bank_depo_6m;
                    break;
                case HelperClass.RateType.deposits_12m:
                    compareRate = fc_depo_12m - bank_depo_12m;
                    break;
                case HelperClass.RateType.deposits_average:
                    compareRate = (((fc_depo_3m + fc_depo_6m + fc_depo_12m) /3) - ((bank_depo_3m + bank_depo_6m + bank_depo_12m) / 3));
                    break;
                case HelperClass.RateType.saving:
                    compareRate = fc_depo_saving - bank_depo_saving;
                    break;

            }

            return compareRate.ToString("N6");   //to six decimal
        }

        private decimal RateInDecimal(string strRate)
        {
            return Convert.ToDecimal(string.IsNullOrEmpty(strRate) ? "0" : strRate);
        }

        private string GetPeriod(string strMonth)
        {
            string[] strDuration = strMonth.Split('-');
            if (strDuration.Length > 1)
            {
                string mth = HelperClass.Months.Where(p => p.Key == strDuration[1]).FirstOrDefault().Value;
                return string.Format("{0}-{1}", mth, strDuration[0]);
            }
            else return string.Empty;

        }
    }

}
