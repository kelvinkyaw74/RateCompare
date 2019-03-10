using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class HelperClass
    {
        #region Enum Section
        public enum RateType
        {
            deposits_3m,
            deposits_6m,
            deposits_12m,
            deposits_average,
            saving
        }

        #endregion

        #region Constant Section
        public static List<KeyValuePair< string, string>> Months = new List<KeyValuePair<string, string>>()
                                                        {
                                                            new KeyValuePair<string, string>("01", "Jan"),
                                                            new KeyValuePair<string, string>("02", "Feb"),
                                                            new KeyValuePair<string, string>("03", "Mar"),
                                                            new KeyValuePair<string, string>("04", "Apr"),
                                                            new KeyValuePair<string, string>("05", "May"),
                                                            new KeyValuePair<string, string>("06", "Jun"),
                                                            new KeyValuePair<string, string>("07", "Jul"),
                                                            new KeyValuePair<string, string>("08", "Aug"),
                                                            new KeyValuePair<string, string>("09", "Sep"),
                                                            new KeyValuePair<string, string>("10", "Oct"),
                                                            new KeyValuePair<string, string>("11", "Nov"),
                                                            new KeyValuePair<string, string>("12", "Dec")
                                                        };

        #endregion

    }
}
