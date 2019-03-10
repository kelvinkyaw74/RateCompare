namespace RateCompareApp
{
    partial class frmRateCompare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkPeriodTo = new System.Windows.Forms.CheckBox();
            this.endofmonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fcfixeddeposits3mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banksfixeddeposits3mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposits3mcomparismDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fcfixeddeposits6mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banksfixeddeposits6mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposits6mcomparismDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fcfixeddeposits12mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banksfixeddeposits12mDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deposits12mcomparismDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fcsavingsdepositsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankssavingsdepositsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.savingdepositcomparismDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fchirepurchasemotor3yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fchousingloans15yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depositsaveragecomparismDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primelendingrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financeRateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeRateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "MMM/yyyy";
            this.dtFrom.Location = new System.Drawing.Point(61, 31);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(112, 22);
            this.dtFrom.TabIndex = 0;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(58, 11);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(85, 17);
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "Period From";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "MMM/yyyy";
            this.dtTo.Enabled = false;
            this.dtTo.Location = new System.Drawing.Point(213, 34);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(120, 22);
            this.dtTo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.endofmonthDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.fcfixeddeposits3mDataGridViewTextBoxColumn,
            this.banksfixeddeposits3mDataGridViewTextBoxColumn,
            this.deposits3mcomparismDataGridViewTextBoxColumn,
            this.fcfixeddeposits6mDataGridViewTextBoxColumn,
            this.banksfixeddeposits6mDataGridViewTextBoxColumn,
            this.deposits6mcomparismDataGridViewTextBoxColumn,
            this.fcfixeddeposits12mDataGridViewTextBoxColumn,
            this.banksfixeddeposits12mDataGridViewTextBoxColumn,
            this.deposits12mcomparismDataGridViewTextBoxColumn,
            this.fcsavingsdepositsDataGridViewTextBoxColumn,
            this.bankssavingsdepositsDataGridViewTextBoxColumn,
            this.savingdepositcomparismDataGridViewTextBoxColumn,
            this.fchirepurchasemotor3yDataGridViewTextBoxColumn,
            this.fchousingloans15yDataGridViewTextBoxColumn,
            this.depositsaveragecomparismDataGridViewTextBoxColumn,
            this.primelendingrateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.financeRateBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1900, 604);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(369, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 41);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Show  Rates";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkPeriodTo
            // 
            this.chkPeriodTo.AutoSize = true;
            this.chkPeriodTo.Location = new System.Drawing.Point(213, 10);
            this.chkPeriodTo.Name = "chkPeriodTo";
            this.chkPeriodTo.Size = new System.Drawing.Size(92, 21);
            this.chkPeriodTo.TabIndex = 6;
            this.chkPeriodTo.Text = "Period To";
            this.chkPeriodTo.UseVisualStyleBackColor = true;
            this.chkPeriodTo.CheckedChanged += new System.EventHandler(this.chkPeriodTo_CheckedChanged);
            // 
            // endofmonthDataGridViewTextBoxColumn
            // 
            this.endofmonthDataGridViewTextBoxColumn.DataPropertyName = "end_of_month";
            this.endofmonthDataGridViewTextBoxColumn.HeaderText = "Period";
            this.endofmonthDataGridViewTextBoxColumn.Name = "endofmonthDataGridViewTextBoxColumn";
            this.endofmonthDataGridViewTextBoxColumn.Visible = false;
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "Period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            this.periodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fcfixeddeposits3mDataGridViewTextBoxColumn
            // 
            this.fcfixeddeposits3mDataGridViewTextBoxColumn.DataPropertyName = "fc_fixed_deposits_3m";
            this.fcfixeddeposits3mDataGridViewTextBoxColumn.HeaderText = "FC Deposit 3mth";
            this.fcfixeddeposits3mDataGridViewTextBoxColumn.Name = "fcfixeddeposits3mDataGridViewTextBoxColumn";
            // 
            // banksfixeddeposits3mDataGridViewTextBoxColumn
            // 
            this.banksfixeddeposits3mDataGridViewTextBoxColumn.DataPropertyName = "banks_fixed_deposits_3m";
            this.banksfixeddeposits3mDataGridViewTextBoxColumn.HeaderText = "BK Deposit 3mth";
            this.banksfixeddeposits3mDataGridViewTextBoxColumn.Name = "banksfixeddeposits3mDataGridViewTextBoxColumn";
            // 
            // deposits3mcomparismDataGridViewTextBoxColumn
            // 
            this.deposits3mcomparismDataGridViewTextBoxColumn.DataPropertyName = "deposits_3m_comparism";
            this.deposits3mcomparismDataGridViewTextBoxColumn.HeaderText = "Compare 3mth";
            this.deposits3mcomparismDataGridViewTextBoxColumn.Name = "deposits3mcomparismDataGridViewTextBoxColumn";
            this.deposits3mcomparismDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fcfixeddeposits6mDataGridViewTextBoxColumn
            // 
            this.fcfixeddeposits6mDataGridViewTextBoxColumn.DataPropertyName = "fc_fixed_deposits_6m";
            this.fcfixeddeposits6mDataGridViewTextBoxColumn.HeaderText = "FC Deposit 6mth";
            this.fcfixeddeposits6mDataGridViewTextBoxColumn.Name = "fcfixeddeposits6mDataGridViewTextBoxColumn";
            // 
            // banksfixeddeposits6mDataGridViewTextBoxColumn
            // 
            this.banksfixeddeposits6mDataGridViewTextBoxColumn.DataPropertyName = "banks_fixed_deposits_6m";
            this.banksfixeddeposits6mDataGridViewTextBoxColumn.HeaderText = "BK Deposit 6mth";
            this.banksfixeddeposits6mDataGridViewTextBoxColumn.Name = "banksfixeddeposits6mDataGridViewTextBoxColumn";
            // 
            // deposits6mcomparismDataGridViewTextBoxColumn
            // 
            this.deposits6mcomparismDataGridViewTextBoxColumn.DataPropertyName = "deposits_6m_comparism";
            this.deposits6mcomparismDataGridViewTextBoxColumn.HeaderText = "Compare 6mth";
            this.deposits6mcomparismDataGridViewTextBoxColumn.Name = "deposits6mcomparismDataGridViewTextBoxColumn";
            this.deposits6mcomparismDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fcfixeddeposits12mDataGridViewTextBoxColumn
            // 
            this.fcfixeddeposits12mDataGridViewTextBoxColumn.DataPropertyName = "fc_fixed_deposits_12m";
            this.fcfixeddeposits12mDataGridViewTextBoxColumn.HeaderText = "FC Deposit 12mth";
            this.fcfixeddeposits12mDataGridViewTextBoxColumn.Name = "fcfixeddeposits12mDataGridViewTextBoxColumn";
            // 
            // banksfixeddeposits12mDataGridViewTextBoxColumn
            // 
            this.banksfixeddeposits12mDataGridViewTextBoxColumn.DataPropertyName = "banks_fixed_deposits_12m";
            this.banksfixeddeposits12mDataGridViewTextBoxColumn.HeaderText = "BK Deposit 12mth";
            this.banksfixeddeposits12mDataGridViewTextBoxColumn.Name = "banksfixeddeposits12mDataGridViewTextBoxColumn";
            // 
            // deposits12mcomparismDataGridViewTextBoxColumn
            // 
            this.deposits12mcomparismDataGridViewTextBoxColumn.DataPropertyName = "deposits_12m_comparism";
            this.deposits12mcomparismDataGridViewTextBoxColumn.HeaderText = "Compare 12mth";
            this.deposits12mcomparismDataGridViewTextBoxColumn.Name = "deposits12mcomparismDataGridViewTextBoxColumn";
            this.deposits12mcomparismDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fcsavingsdepositsDataGridViewTextBoxColumn
            // 
            this.fcsavingsdepositsDataGridViewTextBoxColumn.DataPropertyName = "fc_savings_deposits";
            this.fcsavingsdepositsDataGridViewTextBoxColumn.HeaderText = "FC Saving";
            this.fcsavingsdepositsDataGridViewTextBoxColumn.Name = "fcsavingsdepositsDataGridViewTextBoxColumn";
            // 
            // bankssavingsdepositsDataGridViewTextBoxColumn
            // 
            this.bankssavingsdepositsDataGridViewTextBoxColumn.DataPropertyName = "banks_savings_deposits";
            this.bankssavingsdepositsDataGridViewTextBoxColumn.HeaderText = "BK Saving";
            this.bankssavingsdepositsDataGridViewTextBoxColumn.Name = "bankssavingsdepositsDataGridViewTextBoxColumn";
            // 
            // savingdepositcomparismDataGridViewTextBoxColumn
            // 
            this.savingdepositcomparismDataGridViewTextBoxColumn.DataPropertyName = "saving_deposit_comparism";
            this.savingdepositcomparismDataGridViewTextBoxColumn.HeaderText = "Compare Saving";
            this.savingdepositcomparismDataGridViewTextBoxColumn.Name = "savingdepositcomparismDataGridViewTextBoxColumn";
            this.savingdepositcomparismDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fchirepurchasemotor3yDataGridViewTextBoxColumn
            // 
            this.fchirepurchasemotor3yDataGridViewTextBoxColumn.DataPropertyName = "fc_hire_purchase_motor_3y";
            this.fchirepurchasemotor3yDataGridViewTextBoxColumn.HeaderText = "fc_hire_purchase_motor_3y";
            this.fchirepurchasemotor3yDataGridViewTextBoxColumn.Name = "fchirepurchasemotor3yDataGridViewTextBoxColumn";
            this.fchirepurchasemotor3yDataGridViewTextBoxColumn.Visible = false;
            // 
            // fchousingloans15yDataGridViewTextBoxColumn
            // 
            this.fchousingloans15yDataGridViewTextBoxColumn.DataPropertyName = "fc_housing_loans_15y";
            this.fchousingloans15yDataGridViewTextBoxColumn.HeaderText = "fc_housing_loans_15y";
            this.fchousingloans15yDataGridViewTextBoxColumn.Name = "fchousingloans15yDataGridViewTextBoxColumn";
            this.fchousingloans15yDataGridViewTextBoxColumn.Visible = false;
            // 
            // depositsaveragecomparismDataGridViewTextBoxColumn
            // 
            this.depositsaveragecomparismDataGridViewTextBoxColumn.DataPropertyName = "deposits_average_comparism";
            this.depositsaveragecomparismDataGridViewTextBoxColumn.HeaderText = "Average Comparism";
            this.depositsaveragecomparismDataGridViewTextBoxColumn.Name = "depositsaveragecomparismDataGridViewTextBoxColumn";
            this.depositsaveragecomparismDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // primelendingrateDataGridViewTextBoxColumn
            // 
            this.primelendingrateDataGridViewTextBoxColumn.DataPropertyName = "prime_lending_rate";
            this.primelendingrateDataGridViewTextBoxColumn.HeaderText = "prime_lending_rate";
            this.primelendingrateDataGridViewTextBoxColumn.Name = "primelendingrateDataGridViewTextBoxColumn";
            this.primelendingrateDataGridViewTextBoxColumn.Visible = false;
            // 
            // financeRateBindingSource
            // 
            this.financeRateBindingSource.DataSource = typeof(RateCompareApp.FinanceRate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 712);
            this.Controls.Add(this.chkPeriodTo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtFrom);
            this.Name = "Form1";
            this.Text = "frmRate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeRateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkPeriodTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn endofmonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcfixeddeposits3mDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banksfixeddeposits3mDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposits3mcomparismDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcfixeddeposits6mDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banksfixeddeposits6mDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposits6mcomparismDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcfixeddeposits12mDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn banksfixeddeposits12mDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deposits12mcomparismDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fcsavingsdepositsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankssavingsdepositsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn savingdepositcomparismDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fchirepurchasemotor3yDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fchousingloans15yDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depositsaveragecomparismDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primelendingrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource financeRateBindingSource;
    }
}

