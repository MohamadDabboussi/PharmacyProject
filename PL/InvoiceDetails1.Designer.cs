namespace Pharmacy.PL
{
    partial class InvoiceDetails1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceDetails1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblInvoice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainerTotal = new System.Windows.Forms.SplitContainer();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.LblInvoiceid2 = new System.Windows.Forms.Label();
            this.LblInvoiceDetails = new System.Windows.Forms.Label();
            this.LblPrice2 = new System.Windows.Forms.Label();
            this.BtnSaveDetails = new Bunifu.Framework.UI.BunifuThinButton2();
            this.FromDatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.ComboBoxMedecine = new System.Windows.Forms.ComboBox();
            this.Textbox1VAT = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Textbox1Quantity = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Textbox1Price = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Textbox1Margin = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Textbox1PublicPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTotal)).BeginInit();
            this.splitContainerTotal.Panel1.SuspendLayout();
            this.splitContainerTotal.Panel2.SuspendLayout();
            this.splitContainerTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 44);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // LblInvoice
            // 
            this.LblInvoice.AutoSize = true;
            this.LblInvoice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.LblInvoice.Location = new System.Drawing.Point(95, 156);
            this.LblInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInvoice.Name = "LblInvoice";
            this.LblInvoice.Size = new System.Drawing.Size(142, 28);
            this.LblInvoice.TabIndex = 13;
            this.LblInvoice.Text = "Invoice ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(93, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Medecine :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(113, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.label3.Location = new System.Drawing.Point(166, 324);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "VAT :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.label4.Location = new System.Drawing.Point(14, 436);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Public Price in L.L :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.label5.Location = new System.Drawing.Point(-1, -1);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 61);
            this.label5.TabIndex = 18;
            this.label5.Text = "Total Price :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.label6.Location = new System.Drawing.Point(129, 492);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Margin :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.label7.Location = new System.Drawing.Point(156, 268);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Date :";
            // 
            // splitContainerTotal
            // 
            this.splitContainerTotal.IsSplitterFixed = true;
            this.splitContainerTotal.Location = new System.Drawing.Point(74, 613);
            this.splitContainerTotal.Name = "splitContainerTotal";
            // 
            // splitContainerTotal.Panel1
            // 
            this.splitContainerTotal.Panel1.Controls.Add(this.label5);
            // 
            // splitContainerTotal.Panel2
            // 
            this.splitContainerTotal.Panel2.Controls.Add(this.LblTotalPrice);
            this.splitContainerTotal.Size = new System.Drawing.Size(336, 58);
            this.splitContainerTotal.SplitterDistance = 166;
            this.splitContainerTotal.SplitterWidth = 1;
            this.splitContainerTotal.TabIndex = 21;
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.LblTotalPrice.Location = new System.Drawing.Point(-4, 0);
            this.LblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(173, 61);
            this.LblTotalPrice.TabIndex = 22;
            this.LblTotalPrice.Text = "5000 L.L";
            this.LblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblInvoiceid2
            // 
            this.LblInvoiceid2.AutoSize = true;
            this.LblInvoiceid2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInvoiceid2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.LblInvoiceid2.Location = new System.Drawing.Point(275, 155);
            this.LblInvoiceid2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInvoiceid2.Name = "LblInvoiceid2";
            this.LblInvoiceid2.Size = new System.Drawing.Size(33, 28);
            this.LblInvoiceid2.TabIndex = 22;
            this.LblInvoiceid2.Text = "...";
            // 
            // LblInvoiceDetails
            // 
            this.LblInvoiceDetails.AutoSize = true;
            this.LblInvoiceDetails.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInvoiceDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.LblInvoiceDetails.Location = new System.Drawing.Point(130, 66);
            this.LblInvoiceDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInvoiceDetails.Name = "LblInvoiceDetails";
            this.LblInvoiceDetails.Size = new System.Drawing.Size(269, 40);
            this.LblInvoiceDetails.TabIndex = 29;
            this.LblInvoiceDetails.Text = "Invoice Details ";
            // 
            // LblPrice2
            // 
            this.LblPrice2.AutoSize = true;
            this.LblPrice2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.LblPrice2.Location = new System.Drawing.Point(154, 546);
            this.LblPrice2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrice2.Name = "LblPrice2";
            this.LblPrice2.Size = new System.Drawing.Size(83, 28);
            this.LblPrice2.TabIndex = 30;
            this.LblPrice2.Text = "Price :";
            // 
            // BtnSaveDetails
            // 
            this.BtnSaveDetails.ActiveBorderThickness = 1;
            this.BtnSaveDetails.ActiveCornerRadius = 20;
            this.BtnSaveDetails.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnSaveDetails.ActiveForecolor = System.Drawing.Color.White;
            this.BtnSaveDetails.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnSaveDetails.BackColor = System.Drawing.Color.White;
            this.BtnSaveDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSaveDetails.BackgroundImage")));
            this.BtnSaveDetails.ButtonText = "Save";
            this.BtnSaveDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSaveDetails.ForeColor = System.Drawing.Color.White;
            this.BtnSaveDetails.IdleBorderThickness = 1;
            this.BtnSaveDetails.IdleCornerRadius = 20;
            this.BtnSaveDetails.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.BtnSaveDetails.IdleForecolor = System.Drawing.Color.White;
            this.BtnSaveDetails.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.BtnSaveDetails.Location = new System.Drawing.Point(186, 703);
            this.BtnSaveDetails.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSaveDetails.Name = "BtnSaveDetails";
            this.BtnSaveDetails.Size = new System.Drawing.Size(180, 59);
            this.BtnSaveDetails.TabIndex = 33;
            this.BtnSaveDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSaveDetails.Click += new System.EventHandler(this.BtnSaveDetails_Click);
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.FromDatePicker.BorderRadius = 0;
            this.FromDatePicker.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDatePicker.ForeColor = System.Drawing.Color.White;
            this.FromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FromDatePicker.FormatCustom = null;
            this.FromDatePicker.Location = new System.Drawing.Point(248, 268);
            this.FromDatePicker.Margin = new System.Windows.Forms.Padding(7);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.Size = new System.Drawing.Size(297, 31);
            this.FromDatePicker.TabIndex = 34;
            this.FromDatePicker.Value = new System.DateTime(2020, 8, 25, 12, 43, 37, 60);
            // 
            // ComboBoxMedecine
            // 
            this.ComboBoxMedecine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ComboBoxMedecine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxMedecine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.ComboBoxMedecine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxMedecine.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMedecine.ForeColor = System.Drawing.Color.White;
            this.ComboBoxMedecine.FormattingEnabled = true;
            this.ComboBoxMedecine.ItemHeight = 21;
            this.ComboBoxMedecine.Location = new System.Drawing.Point(248, 212);
            this.ComboBoxMedecine.Name = "ComboBoxMedecine";
            this.ComboBoxMedecine.Size = new System.Drawing.Size(297, 29);
            this.ComboBoxMedecine.TabIndex = 35;
            // 
            // Textbox1VAT
            // 
            this.Textbox1VAT.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.Textbox1VAT.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox1VAT.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.Textbox1VAT.BorderThickness = 3;
            this.Textbox1VAT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox1VAT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox1VAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.Textbox1VAT.isPassword = false;
            this.Textbox1VAT.Location = new System.Drawing.Point(248, 323);
            this.Textbox1VAT.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Textbox1VAT.Name = "Textbox1VAT";
            this.Textbox1VAT.Size = new System.Drawing.Size(297, 34);
            this.Textbox1VAT.TabIndex = 36;
            this.Textbox1VAT.Text = "VAT";
            this.Textbox1VAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Textbox1Quantity
            // 
            this.Textbox1Quantity.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.Textbox1Quantity.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox1Quantity.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.Textbox1Quantity.BorderThickness = 3;
            this.Textbox1Quantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox1Quantity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox1Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.Textbox1Quantity.isPassword = false;
            this.Textbox1Quantity.Location = new System.Drawing.Point(248, 380);
            this.Textbox1Quantity.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Textbox1Quantity.Name = "Textbox1Quantity";
            this.Textbox1Quantity.Size = new System.Drawing.Size(297, 34);
            this.Textbox1Quantity.TabIndex = 37;
            this.Textbox1Quantity.Text = "Quantity";
            this.Textbox1Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Textbox1Price
            // 
            this.Textbox1Price.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.Textbox1Price.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox1Price.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.Textbox1Price.BorderThickness = 3;
            this.Textbox1Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox1Price.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox1Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.Textbox1Price.isPassword = false;
            this.Textbox1Price.Location = new System.Drawing.Point(248, 546);
            this.Textbox1Price.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Textbox1Price.Name = "Textbox1Price";
            this.Textbox1Price.Size = new System.Drawing.Size(297, 34);
            this.Textbox1Price.TabIndex = 38;
            this.Textbox1Price.Text = "Price";
            this.Textbox1Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Textbox1Margin
            // 
            this.Textbox1Margin.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.Textbox1Margin.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox1Margin.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.Textbox1Margin.BorderThickness = 3;
            this.Textbox1Margin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox1Margin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox1Margin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.Textbox1Margin.isPassword = false;
            this.Textbox1Margin.Location = new System.Drawing.Point(248, 492);
            this.Textbox1Margin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Textbox1Margin.Name = "Textbox1Margin";
            this.Textbox1Margin.Size = new System.Drawing.Size(297, 34);
            this.Textbox1Margin.TabIndex = 40;
            this.Textbox1Margin.Text = "Margin";
            this.Textbox1Margin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Textbox1PublicPrice
            // 
            this.Textbox1PublicPrice.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.Textbox1PublicPrice.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox1PublicPrice.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.Textbox1PublicPrice.BorderThickness = 3;
            this.Textbox1PublicPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox1PublicPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Textbox1PublicPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.Textbox1PublicPrice.isPassword = false;
            this.Textbox1PublicPrice.Location = new System.Drawing.Point(248, 435);
            this.Textbox1PublicPrice.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Textbox1PublicPrice.Name = "Textbox1PublicPrice";
            this.Textbox1PublicPrice.Size = new System.Drawing.Size(297, 34);
            this.Textbox1PublicPrice.TabIndex = 39;
            this.Textbox1PublicPrice.Text = "PublicPrice";
            this.Textbox1PublicPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::Pharmacy.Properties.Resources.close_icon;
            this.BtnClose.Location = new System.Drawing.Point(530, 6);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(32, 31);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 41;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // InvoiceDetails1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 772);
            this.Controls.Add(this.Textbox1Margin);
            this.Controls.Add(this.Textbox1PublicPrice);
            this.Controls.Add(this.Textbox1Price);
            this.Controls.Add(this.Textbox1Quantity);
            this.Controls.Add(this.Textbox1VAT);
            this.Controls.Add(this.ComboBoxMedecine);
            this.Controls.Add(this.FromDatePicker);
            this.Controls.Add(this.BtnSaveDetails);
            this.Controls.Add(this.LblPrice2);
            this.Controls.Add(this.LblInvoiceDetails);
            this.Controls.Add(this.LblInvoiceid2);
            this.Controls.Add(this.splitContainerTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblInvoice);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoiceDetails1";
            this.Text = "InvoiceDetails1";
            this.Load += new System.EventHandler(this.InvoiceDetails1_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainerTotal.Panel1.ResumeLayout(false);
            this.splitContainerTotal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTotal)).EndInit();
            this.splitContainerTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblInvoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainerTotal;
        private System.Windows.Forms.Label LblTotalPrice;
        private System.Windows.Forms.Label LblInvoiceid2;
        private System.Windows.Forms.Label LblInvoiceDetails;
        private System.Windows.Forms.Label LblPrice2;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnSaveDetails;
        private Bunifu.Framework.UI.BunifuDatepicker FromDatePicker;
        private System.Windows.Forms.ComboBox ComboBoxMedecine;
        private Bunifu.Framework.UI.BunifuMetroTextbox Textbox1VAT;
        private Bunifu.Framework.UI.BunifuMetroTextbox Textbox1Quantity;
        private Bunifu.Framework.UI.BunifuMetroTextbox Textbox1Price;
        private Bunifu.Framework.UI.BunifuMetroTextbox Textbox1Margin;
        private Bunifu.Framework.UI.BunifuMetroTextbox Textbox1PublicPrice;
        private System.Windows.Forms.PictureBox BtnClose;
    }
}