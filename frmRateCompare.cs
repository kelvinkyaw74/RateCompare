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

namespace WindowsFormsApplication1
{
    public partial class frmRateCompare : Form
    {
        public frmRateCompare()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.CustomFormat = "MMM-yyyy";
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.CustomFormat = "MMM-yyyy";
           
        }

        private void chkPeriodTo_CheckedChanged(object sender, EventArgs e)
        {
            dtTo.Enabled = chkPeriodTo.Checked;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            RateAPIMamager rateAPI = new RateAPIMamager();
            rateAPI.OnResponseData += RateAPI_OnResponseData;
            if (chkPeriodTo.Checked)
            {
                rateAPI.GetRateDataFromAPI(dtFrom.Text, dtTo.Text);
            }
            else
            {
                rateAPI.GetRateDataFromAPI(dtFrom.Text);
            }
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
            if (e.ColumnIndex == 4 || e.ColumnIndex == 7 || e.ColumnIndex == 10 || e.ColumnIndex == 13)
            {
                if (Convert.ToDecimal(e.Value) > 0)
                    e.CellStyle.ForeColor = Color.Blue;
                else if(Convert.ToDecimal(e.Value) < 0)
                    e.CellStyle.ForeColor = Color.Red;
            }
        }


    }
}
