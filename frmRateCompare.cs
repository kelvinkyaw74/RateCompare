using Json2KeyValue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RateCompareApp
{
    public partial class frmRateCompare : Form
    {
        public frmRateCompare()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMonthDropDown();
            dataGridView1.DataSource = null;

        }

        private void chkPeriodTo_CheckedChanged(object sender, EventArgs e)
        {
            //dtTo.Enabled = chkPeriodTo.Checked;
            cboYearTo.Enabled= chkPeriodTo.Checked;
            cboMonthTo.Enabled= chkPeriodTo.Checked;
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RateAPIMamager rateAPI = new RateAPIMamager();
            rateAPI.OnResponseData += RateAPI_OnResponseData;
            string dateFrom = string.Format("{0}-{1}", cboMonthFrom.Text, cboYearFrom.Text);
            string dateTo = string.Format("{0}-{1}", cboMonthTo.Text, cboYearTo.Text);

            if (chkPeriodTo.Checked)
            {
                
                if (isValidPerio(dateFrom, dateTo))
                {
                    rateAPI.GetRateDataFromAPI(dateFrom, dateTo);
                }else
                {
                    MessageBox.Show("To date should be greater than from date.");
                }
            }
            else
            {
                rateAPI.GetRateDataFromAPI(dateFrom);
            }
        }

        private bool isValidPerio(string dateFrom, string dateTo)
        {
            var dtFrom =DateTime.Parse( string.Format("1-{0}", dateFrom));
            var dtTo= DateTime.Parse(string.Format("1-{0}", dateTo));
            return dtFrom <= dtTo;
        }

        private void RateAPI_OnResponseData(string message)
        {
            var response = JsonConvert.DeserializeObject<RootObject>(message);
            if (response.success)
            {
                BindDataGrid(response.result.records);
            }
           
        }

        private void BindDataGrid(List<FinanceRate> records)
        {
            dataGridView1.DataSource = records;           
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.ColumnIndex == 7 || e.ColumnIndex == 10 || e.ColumnIndex == 13 || e.ColumnIndex == 14)
            {
                if (Convert.ToDecimal(e.Value) > 0)
                    e.CellStyle.ForeColor = Color.Blue;
                else if(Convert.ToDecimal(e.Value) < 0)
                    e.CellStyle.ForeColor = Color.Red;
            }
        }

        private void LoadMonthDropDown()
        {
            foreach(KeyValuePair<string,string> mth in HelperClass.Months)
            {
                cboMonthFrom.Items.Add(mth.Value);
                cboMonthTo.Items.Add(mth.Value);
            }

            for(int i=1990; i<= DateTime.Now.Year; i++)
            {
                cboYearFrom.Items.Add(i);
                cboYearTo.Items.Add(i);
            }

            cboMonthFrom.SelectedIndex = 0;
            cboMonthTo.SelectedIndex = 0;
            cboYearFrom.Text = "2000";
            cboYearTo.Text = "2000";
        }

    }
}
