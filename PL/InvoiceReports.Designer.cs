namespace Pharmacy.PL
{
    partial class InvoiceReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceReports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.dataGridView11 = new Pharmacy.PL.Controls.DataGridView1();
            this.Medecine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Margin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LblFromDate = new System.Windows.Forms.Label();
            this.FromDatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnPDF1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnPrint1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BtnExcell1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SupplierComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblSupplier = new System.Windows.Forms.Label();
            this.LblToDate = new System.Windows.Forms.Label();
            this.ToDatePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.splitContainerTotal = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView12 = new Pharmacy.PL.Controls.DataGridView1();
            this.InvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPayed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panelDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTotal)).BeginInit();
            this.splitContainerTotal.Panel1.SuspendLayout();
            this.splitContainerTotal.Panel2.SuspendLayout();
            this.splitContainerTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDataGridView.Controls.Add(this.dataGridView11);
            this.panelDataGridView.Location = new System.Drawing.Point(0, 401);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(1192, 352);
            this.panelDataGridView.TabIndex = 8;
            // 
            // dataGridView11
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView11.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView11.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView11.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.dataGridView11.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView11.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView11.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView11.ColumnHeadersHeight = 30;
            this.dataGridView11.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Medecine,
            this.Date,
            this.VAT,
            this.Quantity,
            this.PublicPrice,
            this.Margin,
            this.Discount,
            this.TotalPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView11.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView11.EnableHeadersVisualStyles = false;
            this.dataGridView11.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.dataGridView11.Location = new System.Drawing.Point(0, 0);
            this.dataGridView11.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView11.Name = "dataGridView11";
            this.dataGridView11.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView11.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView11.RowHeadersWidth = 40;
            this.dataGridView11.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView11.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.dataGridView11.RowTemplate.DividerHeight = 1;
            this.dataGridView11.RowTemplate.Height = 50;
            this.dataGridView11.Size = new System.Drawing.Size(1192, 352);
            this.dataGridView11.TabIndex = 6;
            // 
            // Medecine
            // 
            this.Medecine.FillWeight = 250F;
            this.Medecine.HeaderText = "Medecine";
            this.Medecine.MinimumWidth = 6;
            this.Medecine.Name = "Medecine";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // VAT
            // 
            this.VAT.FillWeight = 60F;
            this.VAT.HeaderText = "VAT";
            this.VAT.MinimumWidth = 6;
            this.VAT.Name = "VAT";
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 70F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // PublicPrice
            // 
            this.PublicPrice.HeaderText = "Public Price";
            this.PublicPrice.MinimumWidth = 6;
            this.PublicPrice.Name = "PublicPrice";
            this.PublicPrice.ReadOnly = true;
            // 
            // Margin
            // 
            this.Margin.FillWeight = 60F;
            this.Margin.HeaderText = "Margin";
            this.Margin.MinimumWidth = 6;
            this.Margin.Name = "Margin";
            this.Margin.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            // 
            // TotalPrice
            // 
            this.TotalPrice.FillWeight = 150F;
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            // 
            // BtnSave
            // 
            this.BtnSave.ActiveBorderThickness = 1;
            this.BtnSave.ActiveCornerRadius = 20;
            this.BtnSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnSave.ActiveForecolor = System.Drawing.Color.White;
            this.BtnSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnSave.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.ButtonText = "Save";
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.IdleBorderThickness = 1;
            this.BtnSave.IdleCornerRadius = 20;
            this.BtnSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.BtnSave.IdleForecolor = System.Drawing.Color.White;
            this.BtnSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.BtnSave.Location = new System.Drawing.Point(551, 830);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(5);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(179, 59);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnEdit
            // 
            this.BtnEdit.ActiveBorderThickness = 1;
            this.BtnEdit.ActiveCornerRadius = 20;
            this.BtnEdit.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnEdit.ActiveForecolor = System.Drawing.Color.White;
            this.BtnEdit.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEdit.BackgroundImage")));
            this.BtnEdit.ButtonText = "Edit";
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.IdleBorderThickness = 1;
            this.BtnEdit.IdleCornerRadius = 20;
            this.BtnEdit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.BtnEdit.IdleForecolor = System.Drawing.Color.White;
            this.BtnEdit.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.BtnEdit.Location = new System.Drawing.Point(331, 830);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(179, 59);
            this.BtnEdit.TabIndex = 10;
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDelete
            // 
            this.BtnDelete.ActiveBorderThickness = 1;
            this.BtnDelete.ActiveCornerRadius = 20;
            this.BtnDelete.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.BtnDelete.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.ButtonText = "Delete";
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.IdleBorderThickness = 1;
            this.BtnDelete.IdleCornerRadius = 20;
            this.BtnDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.BtnDelete.IdleForecolor = System.Drawing.Color.White;
            this.BtnDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.BtnDelete.Location = new System.Drawing.Point(772, 830);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(180, 59);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblFromDate
            // 
            this.LblFromDate.AutoSize = true;
            this.LblFromDate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFromDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.LblFromDate.Location = new System.Drawing.Point(2, 157);
            this.LblFromDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblFromDate.Name = "LblFromDate";
            this.LblFromDate.Size = new System.Drawing.Size(114, 23);
            this.LblFromDate.TabIndex = 15;
            this.LblFromDate.Text = "From Date :";
            // 
            // FromDatePicker
            // 
            this.FromDatePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.FromDatePicker.BorderRadius = 0;
            this.FromDatePicker.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDatePicker.ForeColor = System.Drawing.Color.White;
            this.FromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.FromDatePicker.FormatCustom = null;
            this.FromDatePicker.Location = new System.Drawing.Point(125, 150);
            this.FromDatePicker.Margin = new System.Windows.Forms.Padding(7);
            this.FromDatePicker.Name = "FromDatePicker";
            this.FromDatePicker.Size = new System.Drawing.Size(378, 38);
            this.FromDatePicker.TabIndex = 14;
            this.FromDatePicker.Value = new System.DateTime(2020, 8, 25, 12, 43, 37, 60);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.BtnPDF1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnPrint1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnExcell1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(368, 309);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(478, 57);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // BtnPDF1
            // 
            this.BtnPDF1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnPDF1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnPDF1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPDF1.BorderRadius = 0;
            this.BtnPDF1.ButtonText = "PDF";
            this.BtnPDF1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPDF1.DisabledColor = System.Drawing.Color.Gray;
            this.BtnPDF1.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnPDF1.Iconimage = null;
            this.BtnPDF1.Iconimage_right = null;
            this.BtnPDF1.Iconimage_right_Selected = null;
            this.BtnPDF1.Iconimage_Selected = null;
            this.BtnPDF1.IconMarginLeft = 0;
            this.BtnPDF1.IconMarginRight = 0;
            this.BtnPDF1.IconRightVisible = true;
            this.BtnPDF1.IconRightZoom = 0D;
            this.BtnPDF1.IconVisible = true;
            this.BtnPDF1.IconZoom = 90D;
            this.BtnPDF1.IsTab = false;
            this.BtnPDF1.Location = new System.Drawing.Point(163, 4);
            this.BtnPDF1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnPDF1.Name = "BtnPDF1";
            this.BtnPDF1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnPDF1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnPDF1.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnPDF1.selected = false;
            this.BtnPDF1.Size = new System.Drawing.Size(151, 49);
            this.BtnPDF1.TabIndex = 4;
            this.BtnPDF1.Text = "PDF";
            this.BtnPDF1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPDF1.Textcolor = System.Drawing.Color.White;
            this.BtnPDF1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnPrint1
            // 
            this.BtnPrint1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnPrint1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnPrint1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPrint1.BorderRadius = 0;
            this.BtnPrint1.ButtonText = "Print";
            this.BtnPrint1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrint1.DisabledColor = System.Drawing.Color.Gray;
            this.BtnPrint1.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnPrint1.Iconimage = null;
            this.BtnPrint1.Iconimage_right = null;
            this.BtnPrint1.Iconimage_right_Selected = null;
            this.BtnPrint1.Iconimage_Selected = null;
            this.BtnPrint1.IconMarginLeft = 0;
            this.BtnPrint1.IconMarginRight = 0;
            this.BtnPrint1.IconRightVisible = true;
            this.BtnPrint1.IconRightZoom = 0D;
            this.BtnPrint1.IconVisible = true;
            this.BtnPrint1.IconZoom = 90D;
            this.BtnPrint1.IsTab = false;
            this.BtnPrint1.Location = new System.Drawing.Point(4, 4);
            this.BtnPrint1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnPrint1.Name = "BtnPrint1";
            this.BtnPrint1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnPrint1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnPrint1.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnPrint1.selected = false;
            this.BtnPrint1.Size = new System.Drawing.Size(151, 49);
            this.BtnPrint1.TabIndex = 3;
            this.BtnPrint1.Text = "Print";
            this.BtnPrint1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPrint1.Textcolor = System.Drawing.Color.White;
            this.BtnPrint1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BtnExcell1
            // 
            this.BtnExcell1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnExcell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnExcell1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnExcell1.BorderRadius = 0;
            this.BtnExcell1.ButtonText = "Excell";
            this.BtnExcell1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcell1.DisabledColor = System.Drawing.Color.Gray;
            this.BtnExcell1.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnExcell1.Iconimage = null;
            this.BtnExcell1.Iconimage_right = null;
            this.BtnExcell1.Iconimage_right_Selected = null;
            this.BtnExcell1.Iconimage_Selected = null;
            this.BtnExcell1.IconMarginLeft = 0;
            this.BtnExcell1.IconMarginRight = 0;
            this.BtnExcell1.IconRightVisible = true;
            this.BtnExcell1.IconRightZoom = 0D;
            this.BtnExcell1.IconVisible = true;
            this.BtnExcell1.IconZoom = 90D;
            this.BtnExcell1.IsTab = false;
            this.BtnExcell1.Location = new System.Drawing.Point(322, 4);
            this.BtnExcell1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExcell1.Name = "BtnExcell1";
            this.BtnExcell1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnExcell1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.BtnExcell1.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnExcell1.selected = false;
            this.BtnExcell1.Size = new System.Drawing.Size(152, 49);
            this.BtnExcell1.TabIndex = 2;
            this.BtnExcell1.Text = "Excell";
            this.BtnExcell1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnExcell1.Textcolor = System.Drawing.Color.White;
            this.BtnExcell1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // SupplierComboBox
            // 
            this.SupplierComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.SupplierComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.SupplierComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.SupplierComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SupplierComboBox.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierComboBox.ForeColor = System.Drawing.Color.White;
            this.SupplierComboBox.FormattingEnabled = true;
            this.SupplierComboBox.ItemHeight = 21;
            this.SupplierComboBox.Location = new System.Drawing.Point(123, 229);
            this.SupplierComboBox.Name = "SupplierComboBox";
            this.SupplierComboBox.Size = new System.Drawing.Size(380, 29);
            this.SupplierComboBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(21, 231);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Supplier :";
            // 
            // LblSupplier
            // 
            this.LblSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.Font = new System.Drawing.Font("Century Gothic", 31.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.LblSupplier.Location = new System.Drawing.Point(361, 24);
            this.LblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(424, 63);
            this.LblSupplier.TabIndex = 19;
            this.LblSupplier.Text = "Invoice Reports";
            // 
            // LblToDate
            // 
            this.LblToDate.AutoSize = true;
            this.LblToDate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.LblToDate.Location = new System.Drawing.Point(560, 157);
            this.LblToDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblToDate.Name = "LblToDate";
            this.LblToDate.Size = new System.Drawing.Size(89, 23);
            this.LblToDate.TabIndex = 21;
            this.LblToDate.Text = "To Date :";
            // 
            // ToDatePicker
            // 
            this.ToDatePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ToDatePicker.BorderRadius = 0;
            this.ToDatePicker.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDatePicker.ForeColor = System.Drawing.Color.White;
            this.ToDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ToDatePicker.FormatCustom = null;
            this.ToDatePicker.Location = new System.Drawing.Point(663, 150);
            this.ToDatePicker.Margin = new System.Windows.Forms.Padding(7);
            this.ToDatePicker.Name = "ToDatePicker";
            this.ToDatePicker.Size = new System.Drawing.Size(378, 38);
            this.ToDatePicker.TabIndex = 20;
            this.ToDatePicker.Value = new System.DateTime(2020, 8, 25, 12, 43, 37, 60);
            // 
            // splitContainerTotal
            // 
            this.splitContainerTotal.IsSplitterFixed = true;
            this.splitContainerTotal.Location = new System.Drawing.Point(856, 753);
            this.splitContainerTotal.Name = "splitContainerTotal";
            // 
            // splitContainerTotal.Panel1
            // 
            this.splitContainerTotal.Panel1.Controls.Add(this.label2);
            // 
            // splitContainerTotal.Panel2
            // 
            this.splitContainerTotal.Panel2.Controls.Add(this.label8);
            this.splitContainerTotal.Size = new System.Drawing.Size(336, 57);
            this.splitContainerTotal.SplitterDistance = 166;
            this.splitContainerTotal.SplitterWidth = 1;
            this.splitContainerTotal.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(-2, -1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 60);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total Price :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.label8.Location = new System.Drawing.Point(-4, -1);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 60);
            this.label8.TabIndex = 22;
            this.label8.Text = "5000 L.L";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView12
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView12.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView12.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView12.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.dataGridView12.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dataGridView12.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView12.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView12.ColumnHeadersHeight = 30;
            this.dataGridView12.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceID,
            this.InvoiceDate,
            this.Amount,
            this.IsPayed});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView12.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView12.EnableHeadersVisualStyles = false;
            this.dataGridView12.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.dataGridView12.Location = new System.Drawing.Point(13, 373);
            this.dataGridView12.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView12.Name = "dataGridView12";
            this.dataGridView12.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView12.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView12.RowHeadersWidth = 40;
            this.dataGridView12.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView12.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.dataGridView12.RowTemplate.DividerHeight = 1;
            this.dataGridView12.RowTemplate.Height = 50;
            this.dataGridView12.Size = new System.Drawing.Size(1192, 352);
            this.dataGridView12.TabIndex = 25;
            // 
            // InvoiceID
            // 
            this.InvoiceID.HeaderText = "Invoice ID";
            this.InvoiceID.MinimumWidth = 6;
            this.InvoiceID.Name = "InvoiceID";
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.HeaderText = "Date";
            this.InvoiceDate.MinimumWidth = 6;
            this.InvoiceDate.Name = "InvoiceDate";
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            // 
            // IsPayed
            // 
            this.IsPayed.FillWeight = 30F;
            this.IsPayed.HeaderText = "Payed";
            this.IsPayed.MinimumWidth = 6;
            this.IsPayed.Name = "IsPayed";
            this.IsPayed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsPayed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // InvoiceReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1192, 913);
            this.Controls.Add(this.dataGridView12);
            this.Controls.Add(this.splitContainerTotal);
            this.Controls.Add(this.LblToDate);
            this.Controls.Add(this.ToDatePicker);
            this.Controls.Add(this.LblSupplier);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SupplierComboBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LblFromDate);
            this.Controls.Add(this.FromDatePicker);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.panelDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoiceReports";
            this.Text = "InvoiceReports";
            this.panelDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainerTotal.Panel1.ResumeLayout(false);
            this.splitContainerTotal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTotal)).EndInit();
            this.splitContainerTotal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDataGridView;
        public Controls.DataGridView1 dataGridView11;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnSave;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnDelete;
        private System.Windows.Forms.Label LblFromDate;
        private Bunifu.Framework.UI.BunifuDatepicker FromDatePicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnPDF1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnPrint1;
        private Bunifu.Framework.UI.BunifuFlatButton BtnExcell1;
        private System.Windows.Forms.ComboBox SupplierComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSupplier;
        private System.Windows.Forms.Label LblToDate;
        private Bunifu.Framework.UI.BunifuDatepicker ToDatePicker;
        private System.Windows.Forms.SplitContainer splitContainerTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        public Controls.DataGridView1 dataGridView12;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medecine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Margin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}