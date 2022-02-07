namespace DMHStockMasterV5
{
    partial class FrmStock
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
            System.Windows.Forms.Label StockCodeLabel;
            System.Windows.Forms.Label SupplierRefLabel;
            System.Windows.Forms.Label DeadCodeLabel;
            System.Windows.Forms.Label AmountTakenLabel;
            System.Windows.Forms.Label CostValueLabel;
            System.Windows.Forms.Label PCMarkUpLabel;
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DgvLocationQty = new System.Windows.Forms.DataGridView();
            this.TxtDelHangersQty = new System.Windows.Forms.TextBox();
            this.TxtDelGarmentsQty = new System.Windows.Forms.TextBox();
            this.TxtDelBoxesQty = new System.Windows.Forms.TextBox();
            this.TxtPcMarkUp = new System.Windows.Forms.TextBox();
            this.TxtCostValue = new System.Windows.Forms.TextBox();
            this.TxtAmountTaken = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CboSeason = new System.Windows.Forms.ComboBox();
            this.TxtSupplierRef = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkZeroQty = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtStockCode = new System.Windows.Forms.TextBox();
            this.CmdCancel = new System.Windows.Forms.Button();
            this.CmdOK = new System.Windows.Forms.Button();
            this.ChkDeadCode = new System.Windows.Forms.CheckBox();
            StockCodeLabel = new System.Windows.Forms.Label();
            SupplierRefLabel = new System.Windows.Forms.Label();
            DeadCodeLabel = new System.Windows.Forms.Label();
            AmountTakenLabel = new System.Windows.Forms.Label();
            CostValueLabel = new System.Windows.Forms.Label();
            PCMarkUpLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocationQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 342);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 124;
            this.label7.Text = "Hangers:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 20);
            this.label6.TabIndex = 123;
            this.label6.Text = "Location Stock Levels";
            // 
            // DgvLocationQty
            // 
            this.DgvLocationQty.AllowUserToAddRows = false;
            this.DgvLocationQty.AllowUserToDeleteRows = false;
            this.DgvLocationQty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLocationQty.Location = new System.Drawing.Point(483, 86);
            this.DgvLocationQty.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DgvLocationQty.Name = "DgvLocationQty";
            this.DgvLocationQty.ReadOnly = true;
            this.DgvLocationQty.RowHeadersWidth = 62;
            this.DgvLocationQty.Size = new System.Drawing.Size(392, 343);
            this.DgvLocationQty.TabIndex = 122;
            // 
            // TxtDelHangersQty
            // 
            this.TxtDelHangersQty.Location = new System.Drawing.Point(247, 342);
            this.TxtDelHangersQty.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtDelHangersQty.Name = "TxtDelHangersQty";
            this.TxtDelHangersQty.Size = new System.Drawing.Size(108, 26);
            this.TxtDelHangersQty.TabIndex = 121;
            // 
            // TxtDelGarmentsQty
            // 
            this.TxtDelGarmentsQty.Location = new System.Drawing.Point(250, 450);
            this.TxtDelGarmentsQty.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtDelGarmentsQty.Name = "TxtDelGarmentsQty";
            this.TxtDelGarmentsQty.Size = new System.Drawing.Size(104, 26);
            this.TxtDelGarmentsQty.TabIndex = 120;
            // 
            // TxtDelBoxesQty
            // 
            this.TxtDelBoxesQty.Location = new System.Drawing.Point(247, 398);
            this.TxtDelBoxesQty.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtDelBoxesQty.Name = "TxtDelBoxesQty";
            this.TxtDelBoxesQty.Size = new System.Drawing.Size(108, 26);
            this.TxtDelBoxesQty.TabIndex = 119;
            // 
            // TxtPcMarkUp
            // 
            this.TxtPcMarkUp.Location = new System.Drawing.Point(227, 269);
            this.TxtPcMarkUp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtPcMarkUp.Name = "TxtPcMarkUp";
            this.TxtPcMarkUp.Size = new System.Drawing.Size(163, 26);
            this.TxtPcMarkUp.TabIndex = 118;
            // 
            // TxtCostValue
            // 
            this.TxtCostValue.Location = new System.Drawing.Point(227, 189);
            this.TxtCostValue.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtCostValue.Name = "TxtCostValue";
            this.TxtCostValue.Size = new System.Drawing.Size(163, 26);
            this.TxtCostValue.TabIndex = 117;
            // 
            // TxtAmountTaken
            // 
            this.TxtAmountTaken.Location = new System.Drawing.Point(227, 229);
            this.TxtAmountTaken.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtAmountTaken.Name = "TxtAmountTaken";
            this.TxtAmountTaken.Size = new System.Drawing.Size(163, 26);
            this.TxtAmountTaken.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 453);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 115;
            this.label5.Text = "Garments:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 401);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 114;
            this.label4.Text = "Boxes:";
            // 
            // CboSeason
            // 
            this.CboSeason.FormattingEnabled = true;
            this.CboSeason.Location = new System.Drawing.Point(227, 116);
            this.CboSeason.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CboSeason.Name = "CboSeason";
            this.CboSeason.Size = new System.Drawing.Size(241, 28);
            this.CboSeason.TabIndex = 113;
            // 
            // TxtSupplierRef
            // 
            this.TxtSupplierRef.Location = new System.Drawing.Point(227, 76);
            this.TxtSupplierRef.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtSupplierRef.Name = "TxtSupplierRef";
            this.TxtSupplierRef.Size = new System.Drawing.Size(241, 26);
            this.TxtSupplierRef.TabIndex = 112;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 111;
            this.label3.Text = "Zero Qty:";
            // 
            // ChkZeroQty
            // 
            this.ChkZeroQty.AutoSize = true;
            this.ChkZeroQty.Location = new System.Drawing.Point(394, 158);
            this.ChkZeroQty.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ChkZeroQty.Name = "ChkZeroQty";
            this.ChkZeroQty.Size = new System.Drawing.Size(22, 21);
            this.ChkZeroQty.TabIndex = 110;
            this.ChkZeroQty.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 109;
            this.label2.Text = "Delivered Qty:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 108;
            this.label1.Text = "Season:";
            // 
            // TxtStockCode
            // 
            this.TxtStockCode.Location = new System.Drawing.Point(227, 36);
            this.TxtStockCode.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtStockCode.Name = "TxtStockCode";
            this.TxtStockCode.Size = new System.Drawing.Size(241, 26);
            this.TxtStockCode.TabIndex = 107;
            // 
            // CmdCancel
            // 
            this.CmdCancel.Location = new System.Drawing.Point(779, 441);
            this.CmdCancel.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.CmdCancel.Name = "CmdCancel";
            this.CmdCancel.Size = new System.Drawing.Size(94, 46);
            this.CmdCancel.TabIndex = 100;
            this.CmdCancel.Text = "Cancel";
            this.CmdCancel.UseVisualStyleBackColor = true;
            // 
            // CmdOK
            // 
            this.CmdOK.Location = new System.Drawing.Point(673, 439);
            this.CmdOK.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.CmdOK.Name = "CmdOK";
            this.CmdOK.Size = new System.Drawing.Size(92, 46);
            this.CmdOK.TabIndex = 99;
            this.CmdOK.Text = "Button1";
            this.CmdOK.UseVisualStyleBackColor = true;
            // 
            // StockCodeLabel
            // 
            StockCodeLabel.AutoSize = true;
            StockCodeLabel.Location = new System.Drawing.Point(118, 38);
            StockCodeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            StockCodeLabel.Name = "StockCodeLabel";
            StockCodeLabel.Size = new System.Drawing.Size(96, 20);
            StockCodeLabel.TabIndex = 101;
            StockCodeLabel.Text = "Stock Code:";
            // 
            // SupplierRefLabel
            // 
            SupplierRefLabel.AutoSize = true;
            SupplierRefLabel.Location = new System.Drawing.Point(115, 81);
            SupplierRefLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            SupplierRefLabel.Name = "SupplierRefLabel";
            SupplierRefLabel.Size = new System.Drawing.Size(101, 20);
            SupplierRefLabel.TabIndex = 102;
            SupplierRefLabel.Text = "Supplier Ref:";
            // 
            // DeadCodeLabel
            // 
            DeadCodeLabel.AutoSize = true;
            DeadCodeLabel.Location = new System.Drawing.Point(121, 159);
            DeadCodeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            DeadCodeLabel.Name = "DeadCodeLabel";
            DeadCodeLabel.Size = new System.Drawing.Size(94, 20);
            DeadCodeLabel.TabIndex = 103;
            DeadCodeLabel.Text = "Dead Code:";
            // 
            // ChkDeadCode
            // 
            this.ChkDeadCode.Location = new System.Drawing.Point(227, 144);
            this.ChkDeadCode.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.ChkDeadCode.Name = "ChkDeadCode";
            this.ChkDeadCode.Size = new System.Drawing.Size(52, 51);
            this.ChkDeadCode.TabIndex = 98;
            this.ChkDeadCode.UseVisualStyleBackColor = true;
            // 
            // AmountTakenLabel
            // 
            AmountTakenLabel.AutoSize = true;
            AmountTakenLabel.Location = new System.Drawing.Point(97, 229);
            AmountTakenLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            AmountTakenLabel.Name = "AmountTakenLabel";
            AmountTakenLabel.Size = new System.Drawing.Size(117, 20);
            AmountTakenLabel.TabIndex = 104;
            AmountTakenLabel.Text = "Amount Taken:";
            // 
            // CostValueLabel
            // 
            CostValueLabel.AutoSize = true;
            CostValueLabel.Location = new System.Drawing.Point(125, 189);
            CostValueLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            CostValueLabel.Name = "CostValueLabel";
            CostValueLabel.Size = new System.Drawing.Size(91, 20);
            CostValueLabel.TabIndex = 105;
            CostValueLabel.Text = "Cost Value:";
            // 
            // PCMarkUpLabel
            // 
            PCMarkUpLabel.AutoSize = true;
            PCMarkUpLabel.Location = new System.Drawing.Point(119, 273);
            PCMarkUpLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            PCMarkUpLabel.Name = "PCMarkUpLabel";
            PCMarkUpLabel.Size = new System.Drawing.Size(94, 20);
            PCMarkUpLabel.TabIndex = 106;
            PCMarkUpLabel.Text = "PCMark Up:";
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1823, 1024);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DgvLocationQty);
            this.Controls.Add(this.TxtDelHangersQty);
            this.Controls.Add(this.TxtDelGarmentsQty);
            this.Controls.Add(this.TxtDelBoxesQty);
            this.Controls.Add(this.TxtPcMarkUp);
            this.Controls.Add(this.TxtCostValue);
            this.Controls.Add(this.TxtAmountTaken);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CboSeason);
            this.Controls.Add(this.TxtSupplierRef);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChkZeroQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtStockCode);
            this.Controls.Add(this.CmdCancel);
            this.Controls.Add(this.CmdOK);
            this.Controls.Add(StockCodeLabel);
            this.Controls.Add(SupplierRefLabel);
            this.Controls.Add(DeadCodeLabel);
            this.Controls.Add(this.ChkDeadCode);
            this.Controls.Add(AmountTakenLabel);
            this.Controls.Add(CostValueLabel);
            this.Controls.Add(PCMarkUpLabel);
            this.Name = "FrmStock";
            this.Text = "FrmStock";
            ((System.ComponentModel.ISupportInitialize)(this.DgvLocationQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DgvLocationQty;
        private System.Windows.Forms.TextBox TxtDelHangersQty;
        private System.Windows.Forms.TextBox TxtDelGarmentsQty;
        private System.Windows.Forms.TextBox TxtDelBoxesQty;
        private System.Windows.Forms.TextBox TxtPcMarkUp;
        private System.Windows.Forms.TextBox TxtCostValue;
        private System.Windows.Forms.TextBox TxtAmountTaken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CboSeason;
        private System.Windows.Forms.TextBox TxtSupplierRef;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ChkZeroQty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TxtStockCode;
        internal System.Windows.Forms.Button CmdCancel;
        internal System.Windows.Forms.Button CmdOK;
        internal System.Windows.Forms.CheckBox ChkDeadCode;
    }
}