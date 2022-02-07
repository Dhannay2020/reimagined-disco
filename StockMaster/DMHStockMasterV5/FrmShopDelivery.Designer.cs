﻿namespace DMHStockMasterV5
{
    partial class FrmShopDelivery
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
            this.txtQty = new System.Windows.Forms.TextBox();
            this.DgvRecords = new System.Windows.Forms.DataGridView();
            this.StockCodeDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GarmentsDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label8 = new System.Windows.Forms.Label();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Deliverlabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cmdClearForm = new System.Windows.Forms.Button();
            this.txtStockCode = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtWarehouseRef = new System.Windows.Forms.TextBox();
            this.cmdAddItem = new System.Windows.Forms.Button();
            this.txtQtyHangers = new System.Windows.Forms.TextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.DteDate = new System.Windows.Forms.DateTimePicker();
            this.txtShopRef = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtShopName = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtTotalGarments = new System.Windows.Forms.TextBox();
            this.txtDelNoteNumber = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtWarehouseName = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).BeginInit();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.ForeColor = System.Drawing.Color.Red;
            this.txtQty.Location = new System.Drawing.Point(253, 429);
            this.txtQty.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(170, 30);
            this.txtQty.TabIndex = 74;
            // 
            // DgvRecords
            // 
            this.DgvRecords.AllowUserToAddRows = false;
            this.DgvRecords.AllowUserToDeleteRows = false;
            this.DgvRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StockCodeDG,
            this.GarmentsDG,
            this.ValueCol});
            this.DgvRecords.Location = new System.Drawing.Point(102, 524);
            this.DgvRecords.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.DgvRecords.Name = "DgvRecords";
            this.DgvRecords.RowHeadersWidth = 51;
            this.DgvRecords.Size = new System.Drawing.Size(690, 315);
            this.DgvRecords.TabIndex = 85;
            // 
            // StockCodeDG
            // 
            this.StockCodeDG.HeaderText = "Stock Code";
            this.StockCodeDG.MinimumWidth = 6;
            this.StockCodeDG.Name = "StockCodeDG";
            // 
            // GarmentsDG
            // 
            this.GarmentsDG.HeaderText = "Garments";
            this.GarmentsDG.MinimumWidth = 6;
            this.GarmentsDG.Name = "GarmentsDG";
            // 
            // ValueCol
            // 
            this.ValueCol.HeaderText = "Value";
            this.ValueCol.MinimumWidth = 6;
            this.ValueCol.Name = "ValueCol";
            this.ValueCol.Visible = false;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(120, 424);
            this.Label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(119, 20);
            this.Label8.TabIndex = 76;
            this.Label8.Text = "Warehouse Qty";
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.Deliverlabel});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 1282);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Padding = new System.Windows.Forms.Padding(4, 0, 36, 0);
            this.StatusStrip1.Size = new System.Drawing.Size(1132, 32);
            this.StatusStrip1.TabIndex = 89;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(148, 25);
            this.ToolStripStatusLabel1.Text = "Delivery Lines :    ";
            // 
            // Deliverlabel
            // 
            this.Deliverlabel.Name = "Deliverlabel";
            this.Deliverlabel.Size = new System.Drawing.Size(180, 25);
            this.Deliverlabel.Text = "ToolStripStatusLabel2";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label21.Location = new System.Drawing.Point(147, 387);
            this.Label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(92, 20);
            this.Label21.TabIndex = 77;
            this.Label21.Text = "Stock Code";
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label22.Location = new System.Drawing.Point(145, 469);
            this.Label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(92, 20);
            this.Label22.TabIndex = 75;
            this.Label22.Text = "Delivery Qty";
            // 
            // cmdClear
            // 
            this.cmdClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear.Location = new System.Drawing.Point(511, 469);
            this.cmdClear.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(42, 45);
            this.cmdClear.TabIndex = 67;
            this.cmdClear.Text = "-";
            this.cmdClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdClear.UseVisualStyleBackColor = true;
            // 
            // cmdClearForm
            // 
            this.cmdClearForm.Location = new System.Drawing.Point(603, 893);
            this.cmdClearForm.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cmdClearForm.Name = "cmdClearForm";
            this.cmdClearForm.Size = new System.Drawing.Size(189, 54);
            this.cmdClearForm.TabIndex = 70;
            this.cmdClearForm.Text = "Clear";
            this.cmdClearForm.UseVisualStyleBackColor = true;
            // 
            // txtStockCode
            // 
            this.txtStockCode.Location = new System.Drawing.Point(253, 382);
            this.txtStockCode.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtStockCode.MaxLength = 30;
            this.txtStockCode.Name = "txtStockCode";
            this.txtStockCode.Size = new System.Drawing.Size(250, 26);
            this.txtStockCode.TabIndex = 64;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label16.Location = new System.Drawing.Point(159, 206);
            this.Label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(81, 20);
            this.Label16.TabIndex = 81;
            this.Label16.Text = "Shop Ref:";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(143, 249);
            this.Label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(97, 20);
            this.Label17.TabIndex = 80;
            this.Label17.Text = "Shop Name:";
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(201, 895);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(189, 54);
            this.cmdAdd.TabIndex = 68;
            this.cmdAdd.Text = "Add";
            this.cmdAdd.UseVisualStyleBackColor = true;
            // 
            // txtWarehouseRef
            // 
            this.txtWarehouseRef.Location = new System.Drawing.Point(253, 290);
            this.txtWarehouseRef.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtWarehouseRef.Name = "txtWarehouseRef";
            this.txtWarehouseRef.Size = new System.Drawing.Size(139, 26);
            this.txtWarehouseRef.TabIndex = 63;
            // 
            // cmdAddItem
            // 
            this.cmdAddItem.Location = new System.Drawing.Point(457, 469);
            this.cmdAddItem.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cmdAddItem.Name = "cmdAddItem";
            this.cmdAddItem.Size = new System.Drawing.Size(42, 45);
            this.cmdAddItem.TabIndex = 66;
            this.cmdAddItem.Text = "+";
            this.cmdAddItem.UseVisualStyleBackColor = true;
            // 
            // txtQtyHangers
            // 
            this.txtQtyHangers.Location = new System.Drawing.Point(251, 478);
            this.txtQtyHangers.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtQtyHangers.Name = "txtQtyHangers";
            this.txtQtyHangers.Size = new System.Drawing.Size(170, 26);
            this.txtQtyHangers.TabIndex = 65;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(402, 895);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(189, 54);
            this.cmdCancel.TabIndex = 69;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // DteDate
            // 
            this.DteDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DteDate.Location = new System.Drawing.Point(251, 106);
            this.DteDate.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.DteDate.Name = "DteDate";
            this.DteDate.Size = new System.Drawing.Size(286, 26);
            this.DteDate.TabIndex = 60;
            // 
            // txtShopRef
            // 
            this.txtShopRef.Location = new System.Drawing.Point(251, 198);
            this.txtShopRef.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtShopRef.MaxLength = 8;
            this.txtShopRef.Name = "txtShopRef";
            this.txtShopRef.Size = new System.Drawing.Size(146, 26);
            this.txtShopRef.TabIndex = 62;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Red;
            this.Label4.Location = new System.Drawing.Point(323, 847);
            this.Label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(182, 29);
            this.Label4.TabIndex = 86;
            this.Label4.Text = "Delivery Total:";
            // 
            // txtShopName
            // 
            this.txtShopName.Location = new System.Drawing.Point(251, 244);
            this.txtShopName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtShopName.Name = "txtShopName";
            this.txtShopName.Size = new System.Drawing.Size(446, 26);
            this.txtShopName.TabIndex = 72;
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label18.Location = new System.Drawing.Point(114, 295);
            this.Label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(125, 20);
            this.Label18.TabIndex = 79;
            this.Label18.Text = "Warehouse Ref:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(105, 161);
            this.Label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(130, 20);
            this.Label3.TabIndex = 82;
            this.Label3.Text = "Delivery Note No:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label2.Location = new System.Drawing.Point(131, 115);
            this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(107, 20);
            this.Label2.TabIndex = 83;
            this.Label2.Text = "Delivery Date:";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(97, 341);
            this.Label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(141, 20);
            this.Label20.TabIndex = 78;
            this.Label20.Text = "Warehouse Name:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(551, 106);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 20);
            this.Label1.TabIndex = 84;
            this.Label1.Text = "Record No:";
            // 
            // txtTotalGarments
            // 
            this.txtTotalGarments.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTotalGarments.Location = new System.Drawing.Point(661, 847);
            this.txtTotalGarments.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtTotalGarments.Name = "txtTotalGarments";
            this.txtTotalGarments.Size = new System.Drawing.Size(98, 26);
            this.txtTotalGarments.TabIndex = 88;
            // 
            // txtDelNoteNumber
            // 
            this.txtDelNoteNumber.Location = new System.Drawing.Point(551, 133);
            this.txtDelNoteNumber.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtDelNoteNumber.Name = "txtDelNoteNumber";
            this.txtDelNoteNumber.Size = new System.Drawing.Size(139, 26);
            this.txtDelNoteNumber.TabIndex = 71;
            // 
            // txtReference
            // 
            this.txtReference.BackColor = System.Drawing.SystemColors.Window;
            this.txtReference.Location = new System.Drawing.Point(251, 152);
            this.txtReference.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtReference.MaxLength = 90;
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(247, 26);
            this.txtReference.TabIndex = 61;
            // 
            // txtWarehouseName
            // 
            this.txtWarehouseName.Location = new System.Drawing.Point(253, 336);
            this.txtWarehouseName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtWarehouseName.Name = "txtWarehouseName";
            this.txtWarehouseName.Size = new System.Drawing.Size(422, 26);
            this.txtWarehouseName.TabIndex = 73;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(527, 852);
            this.Label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(123, 20);
            this.Label5.TabIndex = 87;
            this.Label5.Text = "Total Garments:";
            // 
            // FrmShopDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 1314);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.DgvRecords);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdClearForm);
            this.Controls.Add(this.txtStockCode);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtWarehouseRef);
            this.Controls.Add(this.cmdAddItem);
            this.Controls.Add(this.txtQtyHangers);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.DteDate);
            this.Controls.Add(this.txtShopRef);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtShopName);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtTotalGarments);
            this.Controls.Add(this.txtDelNoteNumber);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.txtWarehouseName);
            this.Controls.Add(this.Label5);
            this.Name = "FrmShopDelivery";
            this.Text = "FrmShopDelivery";
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecords)).EndInit();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.DataGridView DgvRecords;
        internal System.Windows.Forms.DataGridViewTextBoxColumn StockCodeDG;
        internal System.Windows.Forms.DataGridViewTextBoxColumn GarmentsDG;
        internal System.Windows.Forms.DataGridViewTextBoxColumn ValueCol;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.StatusStrip StatusStrip1;
        internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.ToolStripStatusLabel Deliverlabel;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label22;
        internal System.Windows.Forms.Button cmdClear;
        internal System.Windows.Forms.Button cmdClearForm;
        internal System.Windows.Forms.TextBox txtStockCode;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Button cmdAdd;
        internal System.Windows.Forms.TextBox txtWarehouseRef;
        internal System.Windows.Forms.Button cmdAddItem;
        internal System.Windows.Forms.TextBox txtQtyHangers;
        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.DateTimePicker DteDate;
        internal System.Windows.Forms.TextBox txtShopRef;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtShopName;
        internal System.Windows.Forms.Label Label18;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtTotalGarments;
        internal System.Windows.Forms.TextBox txtDelNoteNumber;
        internal System.Windows.Forms.TextBox txtReference;
        internal System.Windows.Forms.TextBox txtWarehouseName;
        internal System.Windows.Forms.Label Label5;
    }
}