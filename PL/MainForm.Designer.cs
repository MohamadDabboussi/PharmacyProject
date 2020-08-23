namespace Pharmacy
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TabHorizontal = new System.Windows.Forms.Panel();
            this.BtnRestore = new System.Windows.Forms.PictureBox();
            this.BtnMinimize = new System.Windows.Forms.PictureBox();
            this.BtnMaximize = new System.Windows.Forms.PictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.LblNameEnglish = new System.Windows.Forms.Label();
            this.LblNameArabic = new System.Windows.Forms.Label();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PanelReports = new System.Windows.Forms.Panel();
            this.LblCopyrights = new System.Windows.Forms.Label();
            this.PicPharmacyLogo = new System.Windows.Forms.PictureBox();
            this.PanelForms = new System.Windows.Forms.TableLayoutPanel();
            this.BtnPaymentsReports = new Pharmacy.PL.Controls.HomeButton1();
            this.BtnHome = new Pharmacy.PL.Controls.HomeButton1();
            this.BtnSalesReports = new Pharmacy.PL.Controls.HomeButton1();
            this.BtnSuppliers = new Pharmacy.PL.Controls.HomeButton1();
            this.BtnStocks = new Pharmacy.PL.Controls.HomeButton1();
            this.BtnInvoice = new Pharmacy.PL.Controls.HomeButton1();
            this.BtnPayments = new Pharmacy.PL.Controls.HomeButton1();
            this.BtnSales = new Pharmacy.PL.Controls.HomeButton1();
            this.BtnCharts = new Pharmacy.PL.Controls.HomeButton1();
            this.BtnReports = new Pharmacy.PL.Controls.HomeButton1();
            this.BtnSettings = new Pharmacy.PL.Controls.HomeButton1();
            this.TabHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.MenuVertical.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PanelReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPharmacyLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TabHorizontal
            // 
            this.TabHorizontal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.TabHorizontal.Controls.Add(this.BtnRestore);
            this.TabHorizontal.Controls.Add(this.BtnMinimize);
            this.TabHorizontal.Controls.Add(this.BtnMaximize);
            this.TabHorizontal.Controls.Add(this.BtnClose);
            this.TabHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabHorizontal.Location = new System.Drawing.Point(0, 0);
            this.TabHorizontal.Name = "TabHorizontal";
            this.TabHorizontal.Size = new System.Drawing.Size(1500, 35);
            this.TabHorizontal.TabIndex = 0;
            this.TabHorizontal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TabHorizontal_MouseDown);
            // 
            // BtnRestore
            // 
            this.BtnRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestore.BackColor = System.Drawing.Color.Transparent;
            this.BtnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestore.Image = global::Pharmacy.Properties.Resources.restoreIcon;
            this.BtnRestore.Location = new System.Drawing.Point(1412, 3);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(25, 25);
            this.BtnRestore.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnRestore.TabIndex = 6;
            this.BtnRestore.TabStop = false;
            this.BtnRestore.Visible = false;
            this.BtnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.Image = global::Pharmacy.Properties.Resources.minusIcon;
            this.BtnMinimize.Location = new System.Drawing.Point(1363, 3);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(25, 25);
            this.BtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMinimize.TabIndex = 5;
            this.BtnMinimize.TabStop = false;
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximize.Image")));
            this.BtnMaximize.Location = new System.Drawing.Point(1412, 3);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(25, 25);
            this.BtnMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMaximize.TabIndex = 4;
            this.BtnMaximize.TabStop = false;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::Pharmacy.Properties.Resources.close_icon;
            this.BtnClose.Location = new System.Drawing.Point(1461, 2);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 3;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.BtnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // LblNameEnglish
            // 
            this.LblNameEnglish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblNameEnglish.AutoSize = true;
            this.LblNameEnglish.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameEnglish.ForeColor = System.Drawing.Color.White;
            this.LblNameEnglish.Location = new System.Drawing.Point(49, 148);
            this.LblNameEnglish.Name = "LblNameEnglish";
            this.LblNameEnglish.Size = new System.Drawing.Size(197, 23);
            this.LblNameEnglish.TabIndex = 3;
            this.LblNameEnglish.Text = "Istikama Pharmacy";
            // 
            // LblNameArabic
            // 
            this.LblNameArabic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblNameArabic.AutoSize = true;
            this.LblNameArabic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNameArabic.ForeColor = System.Drawing.Color.White;
            this.LblNameArabic.Location = new System.Drawing.Point(83, 180);
            this.LblNameArabic.Name = "LblNameArabic";
            this.LblNameArabic.Size = new System.Drawing.Size(100, 23);
            this.LblNameArabic.TabIndex = 4;
            this.LblNameArabic.Text = "صيدلية الإستقامة";
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.MenuVertical.Controls.Add(this.flowLayoutPanel1);
            this.MenuVertical.Controls.Add(this.LblCopyrights);
            this.MenuVertical.Controls.Add(this.LblNameArabic);
            this.MenuVertical.Controls.Add(this.LblNameEnglish);
            this.MenuVertical.Controls.Add(this.PicPharmacyLogo);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 35);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(283, 965);
            this.MenuVertical.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.BtnHome);
            this.flowLayoutPanel1.Controls.Add(this.BtnSuppliers);
            this.flowLayoutPanel1.Controls.Add(this.BtnStocks);
            this.flowLayoutPanel1.Controls.Add(this.BtnInvoice);
            this.flowLayoutPanel1.Controls.Add(this.BtnPayments);
            this.flowLayoutPanel1.Controls.Add(this.BtnSales);
            this.flowLayoutPanel1.Controls.Add(this.BtnCharts);
            this.flowLayoutPanel1.Controls.Add(this.PanelReports);
            this.flowLayoutPanel1.Controls.Add(this.BtnSettings);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 233);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(283, 683);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // PanelReports
            // 
            this.PanelReports.Controls.Add(this.BtnPaymentsReports);
            this.PanelReports.Controls.Add(this.BtnSalesReports);
            this.PanelReports.Controls.Add(this.BtnReports);
            this.PanelReports.Location = new System.Drawing.Point(3, 465);
            this.PanelReports.MaximumSize = new System.Drawing.Size(281, 130);
            this.PanelReports.MinimumSize = new System.Drawing.Size(281, 60);
            this.PanelReports.Name = "PanelReports";
            this.PanelReports.Size = new System.Drawing.Size(281, 60);
            this.PanelReports.TabIndex = 0;
            // 
            // LblCopyrights
            // 
            this.LblCopyrights.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblCopyrights.AutoSize = true;
            this.LblCopyrights.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCopyrights.ForeColor = System.Drawing.Color.White;
            this.LblCopyrights.Location = new System.Drawing.Point(4, 942);
            this.LblCopyrights.Name = "LblCopyrights";
            this.LblCopyrights.Size = new System.Drawing.Size(156, 19);
            this.LblCopyrights.TabIndex = 15;
            this.LblCopyrights.Text = "© copyrights MDsoft";
            // 
            // PicPharmacyLogo
            // 
            this.PicPharmacyLogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PicPharmacyLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicPharmacyLogo.BackgroundImage = global::Pharmacy.Properties.Resources.pharmaLOGO;
            this.PicPharmacyLogo.Image = global::Pharmacy.Properties.Resources.pharmaLOGO;
            this.PicPharmacyLogo.Location = new System.Drawing.Point(92, 24);
            this.PicPharmacyLogo.Name = "PicPharmacyLogo";
            this.PicPharmacyLogo.Size = new System.Drawing.Size(100, 109);
            this.PicPharmacyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicPharmacyLogo.TabIndex = 2;
            this.PicPharmacyLogo.TabStop = false;
            // 
            // PanelForms
            // 
            this.PanelForms.ColumnCount = 1;
            this.PanelForms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelForms.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForms.Location = new System.Drawing.Point(283, 35);
            this.PanelForms.Name = "PanelForms";
            this.PanelForms.RowCount = 1;
            this.PanelForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PanelForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 965F));
            this.PanelForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 965F));
            this.PanelForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 965F));
            this.PanelForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 965F));
            this.PanelForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 965F));
            this.PanelForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 965F));
            this.PanelForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 965F));
            this.PanelForms.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 965F));
            this.PanelForms.Size = new System.Drawing.Size(1217, 965);
            this.PanelForms.TabIndex = 2;
            // 
            // BtnPaymentsReports
            // 
            this.BtnPaymentsReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnPaymentsReports.BBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnPaymentsReports.BfonyStyle = new System.Drawing.Font("Century Gothic", 10F);
            this.BtnPaymentsReports.BImage = null;
            this.BtnPaymentsReports.BText = "Payments Reports";
            this.BtnPaymentsReports.Location = new System.Drawing.Point(0, 94);
            this.BtnPaymentsReports.Name = "BtnPaymentsReports";
            this.BtnPaymentsReports.Size = new System.Drawing.Size(281, 34);
            this.BtnPaymentsReports.TabIndex = 2;
            // 
            // BtnHome
            // 
            this.BtnHome.BBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnHome.BfonyStyle = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.BImage = global::Pharmacy.Properties.Resources.home32;
            this.BtnHome.BText = "Home";
            this.BtnHome.Location = new System.Drawing.Point(3, 3);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(281, 60);
            this.BtnHome.TabIndex = 0;
            // 
            // BtnSalesReports
            // 
            this.BtnSalesReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnSalesReports.BBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.BtnSalesReports.BfonyStyle = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalesReports.BImage = null;
            this.BtnSalesReports.BText = "Sales Reports";
            this.BtnSalesReports.Location = new System.Drawing.Point(0, 60);
            this.BtnSalesReports.Name = "BtnSalesReports";
            this.BtnSalesReports.Size = new System.Drawing.Size(281, 34);
            this.BtnSalesReports.TabIndex = 1;
            // 
            // BtnSuppliers
            // 
            this.BtnSuppliers.BBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnSuppliers.BfonyStyle = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuppliers.BImage = global::Pharmacy.Properties.Resources.supplier32;
            this.BtnSuppliers.BText = "Suppliers";
            this.BtnSuppliers.Location = new System.Drawing.Point(3, 69);
            this.BtnSuppliers.Name = "BtnSuppliers";
            this.BtnSuppliers.Size = new System.Drawing.Size(281, 60);
            this.BtnSuppliers.TabIndex = 1;
            // 
            // BtnStocks
            // 
            this.BtnStocks.BBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnStocks.BfonyStyle = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStocks.BImage = global::Pharmacy.Properties.Resources.icons8_pill_bottle_32;
            this.BtnStocks.BText = "Stocks";
            this.BtnStocks.Location = new System.Drawing.Point(3, 135);
            this.BtnStocks.Name = "BtnStocks";
            this.BtnStocks.Size = new System.Drawing.Size(281, 60);
            this.BtnStocks.TabIndex = 2;
            // 
            // BtnInvoice
            // 
            this.BtnInvoice.BBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnInvoice.BfonyStyle = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInvoice.BImage = global::Pharmacy.Properties.Resources.invoice3;
            this.BtnInvoice.BText = "Invoice";
            this.BtnInvoice.Location = new System.Drawing.Point(3, 201);
            this.BtnInvoice.Name = "BtnInvoice";
            this.BtnInvoice.Size = new System.Drawing.Size(281, 60);
            this.BtnInvoice.TabIndex = 3;
            // 
            // BtnPayments
            // 
            this.BtnPayments.BBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnPayments.BfonyStyle = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPayments.BImage = global::Pharmacy.Properties.Resources.icons8_online_payment_32;
            this.BtnPayments.BText = "Payments";
            this.BtnPayments.Location = new System.Drawing.Point(3, 267);
            this.BtnPayments.Name = "BtnPayments";
            this.BtnPayments.Size = new System.Drawing.Size(281, 60);
            this.BtnPayments.TabIndex = 4;
            // 
            // BtnSales
            // 
            this.BtnSales.BBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnSales.BfonyStyle = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSales.BImage = global::Pharmacy.Properties.Resources.sales32;
            this.BtnSales.BText = "Sales";
            this.BtnSales.Location = new System.Drawing.Point(3, 333);
            this.BtnSales.Name = "BtnSales";
            this.BtnSales.Size = new System.Drawing.Size(281, 60);
            this.BtnSales.TabIndex = 5;
            // 
            // BtnCharts
            // 
            this.BtnCharts.BBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnCharts.BfonyStyle = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCharts.BImage = global::Pharmacy.Properties.Resources.charts32;
            this.BtnCharts.BText = "Charts";
            this.BtnCharts.Location = new System.Drawing.Point(3, 399);
            this.BtnCharts.Name = "BtnCharts";
            this.BtnCharts.Size = new System.Drawing.Size(281, 60);
            this.BtnCharts.TabIndex = 6;
            // 
            // BtnReports
            // 
            this.BtnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnReports.BBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnReports.BfonyStyle = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReports.BImage = global::Pharmacy.Properties.Resources.reports32;
            this.BtnReports.BText = "Reports";
            this.BtnReports.Location = new System.Drawing.Point(0, 0);
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.Size = new System.Drawing.Size(281, 60);
            this.BtnReports.TabIndex = 0;
            this.BtnReports.BClick += new System.EventHandler(this.BtnReports_BClick);
            // 
            // BtnSettings
            // 
            this.BtnSettings.BBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnSettings.BfonyStyle = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.BImage = global::Pharmacy.Properties.Resources.settings32;
            this.BtnSettings.BText = "Settings";
            this.BtnSettings.Location = new System.Drawing.Point(3, 531);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(281, 60);
            this.BtnSettings.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1500, 1000);
            this.Controls.Add(this.PanelForms);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.TabHorizontal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "صيدلية الا ستقامة - Istikama Pharmacy";
            this.TabHorizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PanelReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicPharmacyLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TabHorizontal;
        private System.Windows.Forms.PictureBox BtnMinimize;
        private System.Windows.Forms.PictureBox BtnMaximize;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.PictureBox BtnRestore;
        private System.Windows.Forms.PictureBox PicPharmacyLogo;
        private System.Windows.Forms.Label LblNameEnglish;
        private System.Windows.Forms.Label LblNameArabic;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Label LblCopyrights;
        private System.Windows.Forms.TableLayoutPanel PanelForms;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private PL.Controls.HomeButton1 BtnHome;
        private PL.Controls.HomeButton1 BtnSuppliers;
        private PL.Controls.HomeButton1 BtnStocks;
        private PL.Controls.HomeButton1 BtnInvoice;
        private PL.Controls.HomeButton1 BtnPayments;
        private PL.Controls.HomeButton1 BtnSales;
        private PL.Controls.HomeButton1 BtnCharts;
        private System.Windows.Forms.Panel PanelReports;
        private PL.Controls.HomeButton1 BtnReports;
        private PL.Controls.HomeButton1 BtnSalesReports;
        private PL.Controls.HomeButton1 BtnPaymentsReports;
        private PL.Controls.HomeButton1 BtnSettings;
    }
}

