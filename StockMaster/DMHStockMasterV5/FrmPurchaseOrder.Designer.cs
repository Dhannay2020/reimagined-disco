﻿namespace DMHStockMasterV5
{
    partial class FrmPurchaseOrder
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
            this.ColStockCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQtyBoxes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQtyItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColQtyLoose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmdDeleteFromGrid = new System.Windows.Forms.Button();
            this.TxtNetCostLine = new System.Windows.Forms.TextBox();
            this.CmdAddToGrid = new System.Windows.Forms.Button();
            this.Label25 = new System.Windows.Forms.Label();
            this.TxtQtyHangers = new System.Windows.Forms.TextBox();
            this.TxtQtyBoxes = new System.Windows.Forms.TextBox();
            this.Label22 = new System.Windows.Forms.Label();
            this.TxtStockCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtQtyGarments = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.TxtOrderID = new System.Windows.Forms.TextBox();
            this.Label23 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.TxtTotalOrderPrice = new System.Windows.Forms.TextBox();
            this.TxtTotalGarments = new System.Windows.Forms.TextBox();
            this.TxtVATAmount = new System.Windows.Forms.TextBox();
            this.TxtTotalNet = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.TxtShipperName = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.TxtCommission = new System.Windows.Forms.TextBox();
            this.TxtDeliveryCharges = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtShipperInvoiceNumber = new System.Windows.Forms.TextBox();
            this.TxtSuppliersInvoiceNumber = new System.Windows.Forms.TextBox();
            this.TxtTotalBoxes = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.TxtTotalHangers = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.TxtWarehouseName = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.TxtSupplierName = new System.Windows.Forms.TextBox();
            this.TxtOurRef = new System.Windows.Forms.TextBox();
            this.TxtWarehouseRef = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.CboSeasonName = new System.Windows.Forms.ComboBox();
            this.TxtSupplierRef = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.DgvItems = new System.Windows.Forms.DataGridView();
            this.Label15 = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.DteMovementDate = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // ColStockCode
            // 
            this.ColStockCode.FillWeight = 180F;
            this.ColStockCode.HeaderText = "Stock Code";
            this.ColStockCode.MinimumWidth = 8;
            this.ColStockCode.Name = "ColStockCode";
            this.ColStockCode.Width = 180;
            // 
            // ColQtyBoxes
            // 
            this.ColQtyBoxes.FillWeight = 90F;
            this.ColQtyBoxes.HeaderText = "Qty Boxes";
            this.ColQtyBoxes.MinimumWidth = 8;
            this.ColQtyBoxes.Name = "ColQtyBoxes";
            this.ColQtyBoxes.Width = 70;
            // 
            // ColQtyItems
            // 
            this.ColQtyItems.FillWeight = 90F;
            this.ColQtyItems.HeaderText = "Qty Hangers";
            this.ColQtyItems.MinimumWidth = 8;
            this.ColQtyItems.Name = "ColQtyItems";
            this.ColQtyItems.Width = 90;
            // 
            // ColNetAmount
            // 
            this.ColNetAmount.FillWeight = 140F;
            this.ColNetAmount.HeaderText = "Net Amount";
            this.ColNetAmount.MinimumWidth = 8;
            this.ColNetAmount.Name = "ColNetAmount";
            this.ColNetAmount.Width = 140;
            // 
            // ColQtyLoose
            // 
            this.ColQtyLoose.FillWeight = 50F;
            this.ColQtyLoose.HeaderText = "Qty Garments";
            this.ColQtyLoose.MinimumWidth = 8;
            this.ColQtyLoose.Name = "ColQtyLoose";
            this.ColQtyLoose.Width = 80;
            // 
            // CmdDeleteFromGrid
            // 
            this.CmdDeleteFromGrid.Location = new System.Drawing.Point(895, 481);
            this.CmdDeleteFromGrid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CmdDeleteFromGrid.Name = "CmdDeleteFromGrid";
            this.CmdDeleteFromGrid.Size = new System.Drawing.Size(104, 31);
            this.CmdDeleteFromGrid.TabIndex = 242;
            this.CmdDeleteFromGrid.Text = "Remove";
            this.CmdDeleteFromGrid.UseVisualStyleBackColor = true;
            // 
            // TxtNetCostLine
            // 
            this.TxtNetCostLine.Location = new System.Drawing.Point(642, 481);
            this.TxtNetCostLine.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtNetCostLine.Name = "TxtNetCostLine";
            this.TxtNetCostLine.Size = new System.Drawing.Size(124, 26);
            this.TxtNetCostLine.TabIndex = 240;
            // 
            // CmdAddToGrid
            // 
            this.CmdAddToGrid.Location = new System.Drawing.Point(780, 481);
            this.CmdAddToGrid.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CmdAddToGrid.Name = "CmdAddToGrid";
            this.CmdAddToGrid.Size = new System.Drawing.Size(104, 31);
            this.CmdAddToGrid.TabIndex = 241;
            this.CmdAddToGrid.Text = "Add";
            this.CmdAddToGrid.UseVisualStyleBackColor = true;
            // 
            // Label25
            // 
            this.Label25.AutoSize = true;
            this.Label25.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label25.Location = new System.Drawing.Point(660, 456);
            this.Label25.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label25.Name = "Label25";
            this.Label25.Size = new System.Drawing.Size(71, 20);
            this.Label25.TabIndex = 280;
            this.Label25.Text = "Net Cost";
            // 
            // TxtQtyHangers
            // 
            this.TxtQtyHangers.Location = new System.Drawing.Point(529, 481);
            this.TxtQtyHangers.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtQtyHangers.Name = "TxtQtyHangers";
            this.TxtQtyHangers.Size = new System.Drawing.Size(98, 26);
            this.TxtQtyHangers.TabIndex = 239;
            // 
            // TxtQtyBoxes
            // 
            this.TxtQtyBoxes.Location = new System.Drawing.Point(414, 481);
            this.TxtQtyBoxes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtQtyBoxes.Name = "TxtQtyBoxes";
            this.TxtQtyBoxes.Size = new System.Drawing.Size(86, 26);
            this.TxtQtyBoxes.TabIndex = 238;
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label22.Location = new System.Drawing.Point(525, 456);
            this.Label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(98, 20);
            this.Label22.TabIndex = 279;
            this.Label22.Text = "Qty Hangers";
            // 
            // TxtStockCode
            // 
            this.TxtStockCode.Location = new System.Drawing.Point(53, 481);
            this.TxtStockCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtStockCode.Name = "TxtStockCode";
            this.TxtStockCode.Size = new System.Drawing.Size(218, 26);
            this.TxtStockCode.TabIndex = 236;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(420, 456);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 278;
            this.label1.Text = "Qty Boxes";
            // 
            // TxtQtyGarments
            // 
            this.TxtQtyGarments.Location = new System.Drawing.Point(285, 481);
            this.TxtQtyGarments.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtQtyGarments.Name = "TxtQtyGarments";
            this.TxtQtyGarments.Size = new System.Drawing.Size(115, 26);
            this.TxtQtyGarments.TabIndex = 237;
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(755, 405);
            this.Label24.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(18, 20);
            this.Label24.TabIndex = 257;
            this.Label24.Text = "£";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(755, 365);
            this.label28.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(18, 20);
            this.label28.TabIndex = 258;
            this.label28.Text = "£";
            // 
            // TxtOrderID
            // 
            this.TxtOrderID.Location = new System.Drawing.Point(705, 45);
            this.TxtOrderID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtOrderID.Name = "TxtOrderID";
            this.TxtOrderID.Size = new System.Drawing.Size(196, 26);
            this.TxtOrderID.TabIndex = 254;
            // 
            // Label23
            // 
            this.Label23.AutoSize = true;
            this.Label23.Location = new System.Drawing.Point(755, 325);
            this.Label23.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label23.Name = "Label23";
            this.Label23.Size = new System.Drawing.Size(18, 20);
            this.Label23.TabIndex = 259;
            this.Label23.Text = "£";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(295, 456);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 277;
            this.label11.Text = "Qty Garments";
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Location = new System.Drawing.Point(755, 285);
            this.Label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(18, 20);
            this.Label19.TabIndex = 260;
            this.Label19.Text = "£";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(755, 245);
            this.Label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(18, 20);
            this.Label14.TabIndex = 261;
            this.Label14.Text = "£";
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label21.Location = new System.Drawing.Point(59, 438);
            this.Label21.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(92, 20);
            this.Label21.TabIndex = 276;
            this.Label21.Text = "Stock Code";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(702, 245);
            this.Label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(38, 20);
            this.Label6.TabIndex = 262;
            this.Label6.Text = "Net:";
            // 
            // TxtTotalOrderPrice
            // 
            this.TxtTotalOrderPrice.Location = new System.Drawing.Point(786, 401);
            this.TxtTotalOrderPrice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtTotalOrderPrice.Name = "TxtTotalOrderPrice";
            this.TxtTotalOrderPrice.Size = new System.Drawing.Size(133, 26);
            this.TxtTotalOrderPrice.TabIndex = 256;
            // 
            // TxtTotalGarments
            // 
            this.TxtTotalGarments.Location = new System.Drawing.Point(414, 819);
            this.TxtTotalGarments.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtTotalGarments.Name = "TxtTotalGarments";
            this.TxtTotalGarments.Size = new System.Drawing.Size(80, 26);
            this.TxtTotalGarments.TabIndex = 288;
            // 
            // TxtVATAmount
            // 
            this.TxtVATAmount.Location = new System.Drawing.Point(786, 361);
            this.TxtVATAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtVATAmount.Name = "TxtVATAmount";
            this.TxtVATAmount.Size = new System.Drawing.Size(133, 26);
            this.TxtVATAmount.TabIndex = 249;
            this.TxtVATAmount.Text = "0.00";
            // 
            // TxtTotalNet
            // 
            this.TxtTotalNet.Location = new System.Drawing.Point(786, 241);
            this.TxtTotalNet.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtTotalNet.Name = "TxtTotalNet";
            this.TxtTotalNet.Size = new System.Drawing.Size(133, 26);
            this.TxtTotalNet.TabIndex = 255;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(691, 405);
            this.Label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(48, 20);
            this.Label9.TabIndex = 281;
            this.Label9.Text = "Total:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(624, 365);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(115, 20);
            this.label27.TabIndex = 282;
            this.label27.Text = "Purchase VAT:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label7.Location = new System.Drawing.Point(607, 285);
            this.Label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(132, 20);
            this.Label7.TabIndex = 284;
            this.Label7.Text = "Delivery Charges:";
            // 
            // TxtShipperName
            // 
            this.TxtShipperName.Location = new System.Drawing.Point(705, 85);
            this.TxtShipperName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtShipperName.Name = "TxtShipperName";
            this.TxtShipperName.Size = new System.Drawing.Size(196, 26);
            this.TxtShipperName.TabIndex = 244;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label8.Location = new System.Drawing.Point(645, 325);
            this.Label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(99, 20);
            this.Label8.TabIndex = 283;
            this.Label8.Text = "Commission:";
            // 
            // TxtCommission
            // 
            this.TxtCommission.Location = new System.Drawing.Point(786, 321);
            this.TxtCommission.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtCommission.Name = "TxtCommission";
            this.TxtCommission.Size = new System.Drawing.Size(133, 26);
            this.TxtCommission.TabIndex = 248;
            this.TxtCommission.Text = "0.00";
            // 
            // TxtDeliveryCharges
            // 
            this.TxtDeliveryCharges.Location = new System.Drawing.Point(786, 281);
            this.TxtDeliveryCharges.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtDeliveryCharges.Name = "TxtDeliveryCharges";
            this.TxtDeliveryCharges.Size = new System.Drawing.Size(133, 26);
            this.TxtDeliveryCharges.TabIndex = 247;
            this.TxtDeliveryCharges.Text = "0.00";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label2.Location = new System.Drawing.Point(624, 90);
            this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 20);
            this.Label2.TabIndex = 266;
            this.Label2.Text = "Shipper:";
            // 
            // TxtShipperInvoiceNumber
            // 
            this.TxtShipperInvoiceNumber.Location = new System.Drawing.Point(705, 125);
            this.TxtShipperInvoiceNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtShipperInvoiceNumber.Name = "TxtShipperInvoiceNumber";
            this.TxtShipperInvoiceNumber.Size = new System.Drawing.Size(196, 26);
            this.TxtShipperInvoiceNumber.TabIndex = 245;
            // 
            // TxtSuppliersInvoiceNumber
            // 
            this.TxtSuppliersInvoiceNumber.Location = new System.Drawing.Point(705, 165);
            this.TxtSuppliersInvoiceNumber.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtSuppliersInvoiceNumber.Name = "TxtSuppliersInvoiceNumber";
            this.TxtSuppliersInvoiceNumber.Size = new System.Drawing.Size(196, 26);
            this.TxtSuppliersInvoiceNumber.TabIndex = 246;
            // 
            // TxtTotalBoxes
            // 
            this.TxtTotalBoxes.Location = new System.Drawing.Point(529, 819);
            this.TxtTotalBoxes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtTotalBoxes.Name = "TxtTotalBoxes";
            this.TxtTotalBoxes.Size = new System.Drawing.Size(80, 26);
            this.TxtTotalBoxes.TabIndex = 287;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label3.Location = new System.Drawing.Point(541, 130);
            this.Label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(146, 20);
            this.Label3.TabIndex = 265;
            this.Label3.Text = "Shipper Invoice No:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label4.Location = new System.Drawing.Point(531, 170);
            this.Label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(157, 20);
            this.Label4.TabIndex = 264;
            this.Label4.Text = "Suppliers Invoice No:";
            // 
            // TxtTotalHangers
            // 
            this.TxtTotalHangers.Location = new System.Drawing.Point(624, 819);
            this.TxtTotalHangers.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtTotalHangers.Name = "TxtTotalHangers";
            this.TxtTotalHangers.Size = new System.Drawing.Size(80, 26);
            this.TxtTotalHangers.TabIndex = 286;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label31.Location = new System.Drawing.Point(135, 332);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(55, 20);
            this.label31.TabIndex = 275;
            this.label31.Text = "Notes:";
            // 
            // TxtNotes
            // 
            this.TxtNotes.Location = new System.Drawing.Point(204, 327);
            this.TxtNotes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.Size = new System.Drawing.Size(314, 93);
            this.TxtNotes.TabIndex = 243;
            // 
            // TxtWarehouseName
            // 
            this.TxtWarehouseName.Location = new System.Drawing.Point(204, 85);
            this.TxtWarehouseName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtWarehouseName.Name = "TxtWarehouseName";
            this.TxtWarehouseName.Size = new System.Drawing.Size(314, 26);
            this.TxtWarehouseName.TabIndex = 253;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(1470, 719);
            this.label26.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(96, 20);
            this.label26.TabIndex = 291;
            this.label26.Text = "Total Loose:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(613, 50);
            this.Label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(77, 20);
            this.Label13.TabIndex = 267;
            this.Label13.Text = "Order No:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1301, 165);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 290;
            this.label12.Text = "Total Boxes:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(1301, 181);
            this.Label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(92, 20);
            this.Label10.TabIndex = 289;
            this.Label10.Text = "Total Items:";
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(73, 170);
            this.Label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(117, 20);
            this.Label17.TabIndex = 271;
            this.Label17.Text = "Supplier Name:";
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Location = new System.Drawing.Point(48, 90);
            this.Label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(141, 20);
            this.Label20.TabIndex = 269;
            this.Label20.Text = "Warehouse Name:";
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label18.Location = new System.Drawing.Point(65, 50);
            this.Label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(125, 20);
            this.Label18.TabIndex = 268;
            this.Label18.Text = "Warehouse Ref:";
            // 
            // TxtSupplierName
            // 
            this.TxtSupplierName.Location = new System.Drawing.Point(204, 165);
            this.TxtSupplierName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtSupplierName.Name = "TxtSupplierName";
            this.TxtSupplierName.Size = new System.Drawing.Size(314, 26);
            this.TxtSupplierName.TabIndex = 252;
            // 
            // TxtOurRef
            // 
            this.TxtOurRef.Location = new System.Drawing.Point(204, 245);
            this.TxtOurRef.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtOurRef.Name = "TxtOurRef";
            this.TxtOurRef.Size = new System.Drawing.Size(264, 26);
            this.TxtOurRef.TabIndex = 234;
            // 
            // TxtWarehouseRef
            // 
            this.TxtWarehouseRef.Location = new System.Drawing.Point(204, 45);
            this.TxtWarehouseRef.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtWarehouseRef.Name = "TxtWarehouseRef";
            this.TxtWarehouseRef.Size = new System.Drawing.Size(196, 26);
            this.TxtWarehouseRef.TabIndex = 231;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(121, 250);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(69, 20);
            this.label30.TabIndex = 273;
            this.label30.Text = "Our Ref:";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label16.Location = new System.Drawing.Point(90, 130);
            this.Label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(101, 20);
            this.Label16.TabIndex = 270;
            this.Label16.Text = "Supplier Ref:";
            // 
            // CboSeasonName
            // 
            this.CboSeasonName.FormattingEnabled = true;
            this.CboSeasonName.Location = new System.Drawing.Point(204, 285);
            this.CboSeasonName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CboSeasonName.Name = "CboSeasonName";
            this.CboSeasonName.Size = new System.Drawing.Size(314, 28);
            this.CboSeasonName.TabIndex = 235;
            // 
            // TxtSupplierRef
            // 
            this.TxtSupplierRef.Location = new System.Drawing.Point(204, 125);
            this.TxtSupplierRef.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtSupplierRef.Name = "TxtSupplierRef";
            this.TxtSupplierRef.Size = new System.Drawing.Size(196, 26);
            this.TxtSupplierRef.TabIndex = 232;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label29.Location = new System.Drawing.Point(123, 290);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(68, 20);
            this.label29.TabIndex = 274;
            this.label29.Text = "Season:";
            // 
            // DgvItems
            // 
            this.DgvItems.AllowUserToAddRows = false;
            this.DgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColStockCode,
            this.ColQtyLoose,
            this.ColQtyBoxes,
            this.ColQtyItems,
            this.ColNetAmount});
            this.DgvItems.Location = new System.Drawing.Point(53, 521);
            this.DgvItems.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DgvItems.Name = "DgvItems";
            this.DgvItems.RowHeadersWidth = 51;
            this.DgvItems.Size = new System.Drawing.Size(932, 289);
            this.DgvItems.TabIndex = 285;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label15.Location = new System.Drawing.Point(81, 215);
            this.Label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(107, 20);
            this.Label15.TabIndex = 272;
            this.Label15.Text = "Delivery Date:";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(885, 819);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(114, 43);
            this.cmdCancel.TabIndex = 251;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(759, 819);
            this.cmdOK.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(114, 43);
            this.cmdOK.TabIndex = 250;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            // 
            // DteMovementDate
            // 
            this.DteMovementDate.Location = new System.Drawing.Point(204, 205);
            this.DteMovementDate.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DteMovementDate.Name = "DteMovementDate";
            this.DteMovementDate.Size = new System.Drawing.Size(314, 26);
            this.DteMovementDate.TabIndex = 233;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Red;
            this.Label5.Location = new System.Drawing.Point(733, 205);
            this.Label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(168, 29);
            this.Label5.TabIndex = 263;
            this.Label5.Text = "Order Totals:";
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckBox1.Location = new System.Drawing.Point(919, 1082);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(141, 24);
            this.CheckBox1.TabIndex = 292;
            this.CheckBox1.Text = "Direct To Shop";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.Visible = false;
            // 
            // FrmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2470, 1607);
            this.Controls.Add(this.CmdDeleteFromGrid);
            this.Controls.Add(this.TxtNetCostLine);
            this.Controls.Add(this.CmdAddToGrid);
            this.Controls.Add(this.Label25);
            this.Controls.Add(this.TxtQtyHangers);
            this.Controls.Add(this.TxtQtyBoxes);
            this.Controls.Add(this.Label22);
            this.Controls.Add(this.TxtStockCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtQtyGarments);
            this.Controls.Add(this.Label24);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.TxtOrderID);
            this.Controls.Add(this.Label23);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Label19);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label21);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TxtTotalOrderPrice);
            this.Controls.Add(this.TxtTotalGarments);
            this.Controls.Add(this.TxtVATAmount);
            this.Controls.Add(this.TxtTotalNet);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.TxtShipperName);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.TxtCommission);
            this.Controls.Add(this.TxtDeliveryCharges);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtShipperInvoiceNumber);
            this.Controls.Add(this.TxtSuppliersInvoiceNumber);
            this.Controls.Add(this.TxtTotalBoxes);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.TxtTotalHangers);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.TxtNotes);
            this.Controls.Add(this.TxtWarehouseName);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label20);
            this.Controls.Add(this.Label18);
            this.Controls.Add(this.TxtSupplierName);
            this.Controls.Add(this.TxtOurRef);
            this.Controls.Add(this.TxtWarehouseRef);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.CboSeasonName);
            this.Controls.Add(this.TxtSupplierRef);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.DgvItems);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.DteMovementDate);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.CheckBox1);
            this.Name = "FrmPurchaseOrder";
            this.Text = "FrmPurchaseOrder";
            ((System.ComponentModel.ISupportInitialize)(this.DgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn ColStockCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQtyBoxes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQtyItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColQtyLoose;
        private System.Windows.Forms.Button CmdDeleteFromGrid;
        private System.Windows.Forms.TextBox TxtNetCostLine;
        private System.Windows.Forms.Button CmdAddToGrid;
        internal System.Windows.Forms.Label Label25;
        private System.Windows.Forms.TextBox TxtQtyHangers;
        private System.Windows.Forms.TextBox TxtQtyBoxes;
        internal System.Windows.Forms.Label Label22;
        private System.Windows.Forms.TextBox TxtStockCode;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtQtyGarments;
        internal System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.Label label28;
        public System.Windows.Forms.TextBox TxtOrderID;
        internal System.Windows.Forms.Label Label23;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label Label19;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label21;
        internal System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox TxtTotalOrderPrice;
        private System.Windows.Forms.TextBox TxtTotalGarments;
        private System.Windows.Forms.TextBox TxtVATAmount;
        private System.Windows.Forms.TextBox TxtTotalNet;
        internal System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label label27;
        internal System.Windows.Forms.Label Label7;
        private System.Windows.Forms.TextBox TxtShipperName;
        internal System.Windows.Forms.Label Label8;
        private System.Windows.Forms.TextBox TxtCommission;
        private System.Windows.Forms.TextBox TxtDeliveryCharges;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox TxtShipperInvoiceNumber;
        private System.Windows.Forms.TextBox TxtSuppliersInvoiceNumber;
        private System.Windows.Forms.TextBox TxtTotalBoxes;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox TxtTotalHangers;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.TextBox TxtWarehouseName;
        internal System.Windows.Forms.Label label26;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label20;
        internal System.Windows.Forms.Label Label18;
        private System.Windows.Forms.TextBox TxtSupplierName;
        private System.Windows.Forms.TextBox TxtOurRef;
        private System.Windows.Forms.TextBox TxtWarehouseRef;
        private System.Windows.Forms.Label label30;
        internal System.Windows.Forms.Label Label16;
        private System.Windows.Forms.ComboBox CboSeasonName;
        private System.Windows.Forms.TextBox TxtSupplierRef;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DataGridView DgvItems;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.DateTimePicker DteMovementDate;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.CheckBox CheckBox1;
    }
}