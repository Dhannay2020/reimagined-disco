namespace DMHStockMasterV5
{
    partial class FrmWarehouseReturn
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
            this.cmdCancel = new System.Windows.Forms.Button();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.cmdOK = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtReturnID = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.DtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.txtCurrentQty = new System.Windows.Forms.TextBox();
            this.txtStockCode = new System.Windows.Forms.TextBox();
            this.txtWarehouseRef = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdClearGrid = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalItems = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtTransferQty = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.txtSupplierRef = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.DgvRecords = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(582, 901);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(122, 58);
            this.cmdCancel.TabIndex = 19;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // txtReference
            // 
            this.txtReference.Location = new System.Drawing.Point(166, 75);
            this.txtReference.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtReference.MaxLength = 50;
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(274, 26);
            this.txtReference.TabIndex = 1;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(458, 129);
            this.Label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(55, 20);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Name:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(57, 222);
            this.Label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(94, 20);
            this.Label4.TabIndex = 9;
            this.Label4.Text = "Current Qty:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(52, 177);
            this.Label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(96, 20);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Stock Code:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 128);
            this.Label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(125, 20);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Warehouse Ref:";
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(454, 901);
            this.cmdOK.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(122, 58);
            this.cmdOK.TabIndex = 18;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtReturnID);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.DtpDate);
            this.GroupBox1.Controls.Add(this.txtWarehouseName);
            this.GroupBox1.Controls.Add(this.txtCurrentQty);
            this.GroupBox1.Controls.Add(this.txtStockCode);
            this.GroupBox1.Controls.Add(this.txtWarehouseRef);
            this.GroupBox1.Controls.Add(this.txtReference);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(17, 18);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.GroupBox1.Size = new System.Drawing.Size(820, 325);
            this.GroupBox1.TabIndex = 16;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Current";
            // 
            // txtReturnID
            // 
            this.txtReturnID.Enabled = false;
            this.txtReturnID.Location = new System.Drawing.Point(166, 26);
            this.txtReturnID.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtReturnID.Name = "txtReturnID";
            this.txtReturnID.Size = new System.Drawing.Size(274, 26);
            this.txtReturnID.TabIndex = 14;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(76, 31);
            this.Label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(75, 20);
            this.Label11.TabIndex = 13;
            this.Label11.Text = "ReturnID";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(458, 34);
            this.Label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(48, 20);
            this.Label9.TabIndex = 11;
            this.Label9.Text = "Date:";
            // 
            // DtpDate
            // 
            this.DtpDate.CustomFormat = "dd-MM-yyyy";
            this.DtpDate.Location = new System.Drawing.Point(522, 31);
            this.DtpDate.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.DtpDate.Name = "DtpDate";
            this.DtpDate.Size = new System.Drawing.Size(278, 26);
            this.DtpDate.TabIndex = 0;
            this.DtpDate.Value = new System.DateTime(2016, 2, 7, 0, 0, 0, 0);
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(522, 123);
            this.txtWarehouseName.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(278, 26);
            this.txtWarehouseName.TabIndex = 12;
            this.txtWarehouseName.TabStop = false;
            // 
            // txtCurrentQty
            // 
            this.txtCurrentQty.Location = new System.Drawing.Point(166, 223);
            this.txtCurrentQty.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtCurrentQty.Name = "txtCurrentQty";
            this.txtCurrentQty.Size = new System.Drawing.Size(274, 26);
            this.txtCurrentQty.TabIndex = 5;
            // 
            // txtStockCode
            // 
            this.txtStockCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStockCode.Location = new System.Drawing.Point(166, 174);
            this.txtStockCode.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtStockCode.MaxLength = 30;
            this.txtStockCode.Name = "txtStockCode";
            this.txtStockCode.Size = new System.Drawing.Size(274, 26);
            this.txtStockCode.TabIndex = 4;
            // 
            // txtWarehouseRef
            // 
            this.txtWarehouseRef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWarehouseRef.Location = new System.Drawing.Point(166, 125);
            this.txtWarehouseRef.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtWarehouseRef.MaxLength = 8;
            this.txtWarehouseRef.Name = "txtWarehouseRef";
            this.txtWarehouseRef.Size = new System.Drawing.Size(274, 26);
            this.txtWarehouseRef.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(62, 74);
            this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 20);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Reference:";
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Location = new System.Drawing.Point(1463, 189);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(168, 24);
            this.CheckBox1.TabIndex = 15;
            this.CheckBox1.Text = "Return To Supplier";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(16, 29);
            this.Label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(101, 20);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Supplier Ref:";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Value";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            this.Column5.Width = 125;
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(716, 901);
            this.cmdClear.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(122, 58);
            this.cmdClear.TabIndex = 20;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            // 
            // cmdClearGrid
            // 
            this.cmdClearGrid.Location = new System.Drawing.Point(543, 74);
            this.cmdClearGrid.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cmdClearGrid.Name = "cmdClearGrid";
            this.cmdClearGrid.Size = new System.Drawing.Size(126, 43);
            this.cmdClearGrid.TabIndex = 2;
            this.cmdClearGrid.Text = "Delete";
            this.cmdClearGrid.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtTotalItems);
            this.GroupBox2.Controls.Add(this.cmdClearGrid);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.cmdAdd);
            this.GroupBox2.Controls.Add(this.txtTransferQty);
            this.GroupBox2.Controls.Add(this.txtSupplierName);
            this.GroupBox2.Controls.Add(this.txtSupplierRef);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.DgvRecords);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Location = new System.Drawing.Point(14, 361);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.GroupBox2.Size = new System.Drawing.Size(824, 522);
            this.GroupBox2.TabIndex = 17;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Return To:";
            // 
            // txtTotalItems
            // 
            this.txtTotalItems.Location = new System.Drawing.Point(568, 472);
            this.txtTotalItems.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtTotalItems.Name = "txtTotalItems";
            this.txtTotalItems.Size = new System.Drawing.Size(157, 26);
            this.txtTotalItems.TabIndex = 7;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(435, 483);
            this.Label10.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(92, 20);
            this.Label10.TabIndex = 6;
            this.Label10.Text = "Total Items:";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(405, 74);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(123, 43);
            this.cmdAdd.TabIndex = 1;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // txtTransferQty
            // 
            this.txtTransferQty.Location = new System.Drawing.Point(134, 74);
            this.txtTransferQty.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtTransferQty.Name = "txtTransferQty";
            this.txtTransferQty.Size = new System.Drawing.Size(169, 26);
            this.txtTransferQty.TabIndex = 0;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Location = new System.Drawing.Point(405, 29);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(398, 26);
            this.txtSupplierName.TabIndex = 7;
            this.txtSupplierName.TabStop = false;
            // 
            // txtSupplierRef
            // 
            this.txtSupplierRef.Location = new System.Drawing.Point(134, 25);
            this.txtSupplierRef.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.txtSupplierRef.MaxLength = 8;
            this.txtSupplierRef.Name = "txtSupplierRef";
            this.txtSupplierRef.Size = new System.Drawing.Size(169, 26);
            this.txtSupplierRef.TabIndex = 6;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(16, 82);
            this.Label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(100, 20);
            this.Label8.TabIndex = 5;
            this.Label8.Text = "Transfer Qty:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(320, 29);
            this.Label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(55, 20);
            this.Label7.TabIndex = 4;
            this.Label7.Text = "Name:";
            // 
            // DgvRecords
            // 
            this.DgvRecords.AllowUserToAddRows = false;
            this.DgvRecords.AllowUserToDeleteRows = false;
            this.DgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgvRecords.Location = new System.Drawing.Point(3, 123);
            this.DgvRecords.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.DgvRecords.Name = "DgvRecords";
            this.DgvRecords.RowHeadersWidth = 51;
            this.DgvRecords.Size = new System.Drawing.Size(712, 343);
            this.DgvRecords.TabIndex = 5;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stock Code";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Qty";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // FrmWarehouseReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1720, 1139);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.GroupBox2);
            this.Name = "FrmWarehouseReturn";
            this.Text = "FrmWarehouseReturn";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.TextBox txtReference;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Button cmdOK;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtReturnID;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.DateTimePicker DtpDate;
        internal System.Windows.Forms.TextBox txtWarehouseName;
        internal System.Windows.Forms.TextBox txtCurrentQty;
        internal System.Windows.Forms.TextBox txtStockCode;
        internal System.Windows.Forms.TextBox txtWarehouseRef;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        internal System.Windows.Forms.Button cmdClear;
        internal System.Windows.Forms.Button cmdClearGrid;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox txtTotalItems;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button cmdAdd;
        internal System.Windows.Forms.TextBox txtTransferQty;
        internal System.Windows.Forms.TextBox txtSupplierName;
        internal System.Windows.Forms.TextBox txtSupplierRef;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.DataGridView DgvRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}