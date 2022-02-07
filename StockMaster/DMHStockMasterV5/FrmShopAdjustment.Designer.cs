namespace DMHStockMasterV5
{
    partial class FrmShopAdjustment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TxtSID = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtTotalLoss = new System.Windows.Forms.TextBox();
            this.txtTotalGain = new System.Windows.Forms.TextBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.stockCodeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransFromQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransToQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrices = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdDeleteFromGrid = new System.Windows.Forms.Button();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtAdjustHangers = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.CmdAddToGrid = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.Label10 = new System.Windows.Forms.Label();
            this.CmdOK = new System.Windows.Forms.Button();
            this.txtCurrentHangers = new System.Windows.Forms.TextBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.txtShopRef = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtStockCode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSID
            // 
            this.TxtSID.Location = new System.Drawing.Point(724, 45);
            this.TxtSID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtSID.Name = "TxtSID";
            this.TxtSID.Size = new System.Drawing.Size(163, 26);
            this.TxtSID.TabIndex = 83;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(508, 48);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(207, 26);
            this.Label11.TabIndex = 82;
            this.Label11.Text = "Shop Adjustment ID";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(240, 649);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(111, 26);
            this.Label9.TabIndex = 71;
            this.Label9.Text = "Total Gain";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(382, 649);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(111, 26);
            this.Label6.TabIndex = 73;
            this.Label6.Text = "Total Loss";
            // 
            // txtTotalLoss
            // 
            this.txtTotalLoss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalLoss.Location = new System.Drawing.Point(389, 686);
            this.txtTotalLoss.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalLoss.Name = "txtTotalLoss";
            this.txtTotalLoss.Size = new System.Drawing.Size(79, 32);
            this.txtTotalLoss.TabIndex = 74;
            // 
            // txtTotalGain
            // 
            this.txtTotalGain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalGain.Location = new System.Drawing.Point(246, 686);
            this.txtTotalGain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTotalGain.Name = "txtTotalGain";
            this.txtTotalGain.Size = new System.Drawing.Size(96, 32);
            this.txtTotalGain.TabIndex = 72;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockCodeCol,
            this.TransFromQty,
            this.TransToQty,
            this.UnitPrices});
            this.dgvItems.Location = new System.Drawing.Point(89, 334);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.Size = new System.Drawing.Size(800, 295);
            this.dgvItems.TabIndex = 75;
            // 
            // stockCodeCol
            // 
            this.stockCodeCol.HeaderText = "Stock Code";
            this.stockCodeCol.MinimumWidth = 6;
            this.stockCodeCol.Name = "stockCodeCol";
            // 
            // TransFromQty
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = null;
            this.TransFromQty.DefaultCellStyle = dataGridViewCellStyle3;
            this.TransFromQty.HeaderText = "Adjustment Type";
            this.TransFromQty.MinimumWidth = 6;
            this.TransFromQty.Name = "TransFromQty";
            // 
            // TransToQty
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.TransToQty.DefaultCellStyle = dataGridViewCellStyle4;
            this.TransToQty.HeaderText = "Adjustment Qty";
            this.TransToQty.MinimumWidth = 6;
            this.TransToQty.Name = "TransToQty";
            // 
            // UnitPrices
            // 
            this.UnitPrices.HeaderText = "UnitPrices";
            this.UnitPrices.MinimumWidth = 6;
            this.UnitPrices.Name = "UnitPrices";
            this.UnitPrices.Visible = false;
            // 
            // CmdDeleteFromGrid
            // 
            this.CmdDeleteFromGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdDeleteFromGrid.Location = new System.Drawing.Point(827, 274);
            this.CmdDeleteFromGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdDeleteFromGrid.Name = "CmdDeleteFromGrid";
            this.CmdDeleteFromGrid.Size = new System.Drawing.Size(42, 51);
            this.CmdDeleteFromGrid.TabIndex = 63;
            this.CmdDeleteFromGrid.Text = "-";
            this.CmdDeleteFromGrid.UseVisualStyleBackColor = true;
            // 
            // cboType
            // 
            this.cboType.AutoCompleteCustomSource.AddRange(new string[] {
            "Gain",
            "Loss"});
            this.cboType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Loss",
            "Gain"});
            this.cboType.Location = new System.Drawing.Point(420, 285);
            this.cboType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(199, 34);
            this.cboType.TabIndex = 60;
            // 
            // txtAdjustHangers
            // 
            this.txtAdjustHangers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjustHangers.Location = new System.Drawing.Point(648, 288);
            this.txtAdjustHangers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAdjustHangers.Name = "txtAdjustHangers";
            this.txtAdjustHangers.Size = new System.Drawing.Size(88, 32);
            this.txtAdjustHangers.TabIndex = 61;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(629, 240);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(168, 26);
            this.Label8.TabIndex = 70;
            this.Label8.Text = "Adjustment Qty:";
            // 
            // CmdAddToGrid
            // 
            this.CmdAddToGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdAddToGrid.Location = new System.Drawing.Point(774, 272);
            this.CmdAddToGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdAddToGrid.Name = "CmdAddToGrid";
            this.CmdAddToGrid.Size = new System.Drawing.Size(42, 52);
            this.CmdAddToGrid.TabIndex = 62;
            this.CmdAddToGrid.Text = "+";
            this.CmdAddToGrid.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(414, 240);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(181, 26);
            this.Label7.TabIndex = 69;
            this.Label7.Text = "Adjustment Type:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(107, 188);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(134, 26);
            this.Label5.TabIndex = 77;
            this.Label5.Text = "Shop Name:";
            // 
            // txtShopName
            // 
            this.txtShopName.Enabled = false;
            this.txtShopName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShopName.Location = new System.Drawing.Point(252, 183);
            this.txtShopName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(205, 32);
            this.txtShopName.TabIndex = 78;
            // 
            // DtpDate
            // 
            this.DtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpDate.Location = new System.Drawing.Point(252, 45);
            this.DtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(244, 32);
            this.DtpDate.TabIndex = 56;
            this.DtpDate.Value = new System.DateTime(2017, 9, 1, 0, 0, 0, 0);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(56, 57);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(182, 26);
            this.Label10.TabIndex = 81;
            this.Label10.Text = "Transaction Date:";
            // 
            // CmdOK
            // 
            this.CmdOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CmdOK.Location = new System.Drawing.Point(544, 639);
            this.CmdOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdOK.Name = "CmdOK";
            this.CmdOK.Size = new System.Drawing.Size(98, 51);
            this.CmdOK.TabIndex = 64;
            this.CmdOK.Text = "Add";
            this.CmdOK.UseVisualStyleBackColor = true;
            // 
            // txtCurrentHangers
            // 
            this.txtCurrentHangers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentHangers.Location = new System.Drawing.Point(264, 288);
            this.txtCurrentHangers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCurrentHangers.Name = "txtCurrentHangers";
            this.txtCurrentHangers.Size = new System.Drawing.Size(146, 32);
            this.txtCurrentHangers.TabIndex = 67;
            // 
            // CmdCancel
            // 
            this.CmdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CmdCancel.Location = new System.Drawing.Point(756, 639);
            this.CmdCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(132, 51);
            this.CmdCancel.TabIndex = 66;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            // 
            // CmdClear
            // 
            this.CmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CmdClear.Location = new System.Drawing.Point(650, 639);
            this.CmdClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(98, 51);
            this.CmdClear.TabIndex = 65;
            this.CmdClear.Text = "Clear";
            this.CmdClear.UseVisualStyleBackColor = true;
            // 
            // txtShopRef
            // 
            this.txtShopRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShopRef.Location = new System.Drawing.Point(252, 140);
            this.txtShopRef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtShopRef.MaxLength = 8;
            this.txtShopRef.Name = "txtShopRef";
            this.txtShopRef.Size = new System.Drawing.Size(85, 32);
            this.txtShopRef.TabIndex = 58;
            // 
            // txtReference
            // 
            this.txtReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReference.Location = new System.Drawing.Point(252, 92);
            this.txtReference.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReference.MaxLength = 50;
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(181, 32);
            this.txtReference.TabIndex = 57;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(124, 100);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(118, 26);
            this.Label1.TabIndex = 80;
            this.Label1.Text = "Reference:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(132, 145);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(109, 26);
            this.Label2.TabIndex = 79;
            this.Label2.Text = "Shop Ref:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(258, 240);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(130, 26);
            this.Label4.TabIndex = 68;
            this.Label4.Text = "Current Qty:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(107, 240);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(131, 26);
            this.Label3.TabIndex = 76;
            this.Label3.Text = "Stock Code:";
            // 
            // txtStockCode
            // 
            this.txtStockCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockCode.Location = new System.Drawing.Point(110, 288);
            this.txtStockCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStockCode.MaxLength = 30;
            this.txtStockCode.Name = "txtStockCode";
            this.txtStockCode.Size = new System.Drawing.Size(145, 32);
            this.txtStockCode.TabIndex = 59;
            // 
            // FrmShopAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1961, 1538);
            this.Controls.Add(this.TxtSID);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtTotalLoss);
            this.Controls.Add(this.txtTotalGain);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.CmdDeleteFromGrid);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtAdjustHangers);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.CmdAddToGrid);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtShopName);
            this.Controls.Add(this.DtpDate);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.CmdOK);
            this.Controls.Add(this.txtCurrentHangers);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.txtShopRef);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtStockCode);
            this.Name = "FrmShopAdjustment";
            this.Text = "FrmShopAdjustment";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TxtSID;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtTotalLoss;
        internal System.Windows.Forms.TextBox txtTotalGain;
        internal System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockCodeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransFromQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransToQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrices;
        internal System.Windows.Forms.Button CmdDeleteFromGrid;
        internal System.Windows.Forms.ComboBox cboType;
        internal System.Windows.Forms.TextBox txtAdjustHangers;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button CmdAddToGrid;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtShopName;
        internal System.Windows.Forms.DateTimePicker DtpDate;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button CmdOK;
        internal System.Windows.Forms.TextBox txtCurrentHangers;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdClear;
        internal System.Windows.Forms.TextBox txtShopRef;
        internal System.Windows.Forms.TextBox txtReference;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtStockCode;
    }
}