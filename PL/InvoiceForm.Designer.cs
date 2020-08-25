namespace Pharmacy.PL
{
    partial class InvoiceForm
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
            this.dataGridView11 = new Pharmacy.PL.Controls.DataGridView1();
            this.panelDataGridView = new System.Windows.Forms.Panel();
            this.Medecine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VAT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublicPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Margin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.LblDateTime = new System.Windows.Forms.Label();
            this.LblInvoice = new System.Windows.Forms.Label();
            this.LblSupplier = new System.Windows.Forms.Label();
            this.Textbox1ID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).BeginInit();
            this.panelDataGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView11
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView11.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.VAT,
            this.Quantity,
            this.PublicPrice,
            this.Margin,
            this.Price,
            this.TotalPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView11.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView11.EnableHeadersVisualStyles = false;
            this.dataGridView11.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.dataGridView11.Location = new System.Drawing.Point(0, 0);
            this.dataGridView11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dataGridView11.Size = new System.Drawing.Size(1664, 525);
            this.dataGridView11.TabIndex = 6;
            // 
            // panelDataGridView
            // 
            this.panelDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDataGridView.Controls.Add(this.dataGridView11);
            this.panelDataGridView.Location = new System.Drawing.Point(1, 511);
            this.panelDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDataGridView.Name = "panelDataGridView";
            this.panelDataGridView.Size = new System.Drawing.Size(1661, 525);
            this.panelDataGridView.TabIndex = 7;
            // 
            // Medecine
            // 
            this.Medecine.FillWeight = 300F;
            this.Medecine.HeaderText = "Medecine";
            this.Medecine.MinimumWidth = 6;
            this.Medecine.Name = "Medecine";
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
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            // 
            // TotalPrice
            // 
            this.TotalPrice.FillWeight = 150F;
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(949, 276);
            this.bunifuDatepicker1.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(481, 51);
            this.bunifuDatepicker1.TabIndex = 10;
            this.bunifuDatepicker1.Value = new System.DateTime(2020, 8, 25, 12, 43, 37, 60);
            // 
            // LblDateTime
            // 
            this.LblDateTime.AutoSize = true;
            this.LblDateTime.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.LblDateTime.Location = new System.Drawing.Point(825, 282);
            this.LblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDateTime.Name = "LblDateTime";
            this.LblDateTime.Size = new System.Drawing.Size(81, 28);
            this.LblDateTime.TabIndex = 11;
            this.LblDateTime.Text = "Date :";
            // 
            // LblInvoice
            // 
            this.LblInvoice.AutoSize = true;
            this.LblInvoice.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.LblInvoice.Location = new System.Drawing.Point(76, 276);
            this.LblInvoice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInvoice.Name = "LblInvoice";
            this.LblInvoice.Size = new System.Drawing.Size(142, 28);
            this.LblInvoice.TabIndex = 12;
            this.LblInvoice.Text = "Invoice ID :";
            // 
            // LblSupplier
            // 
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.Font = new System.Drawing.Font("Century Gothic", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.LblSupplier.Location = new System.Drawing.Point(600, 52);
            this.LblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(392, 70);
            this.LblSupplier.TabIndex = 13;
            this.LblSupplier.Text = "New Invoice";
            // 
            // Textbox1ID
            // 
            this.Textbox1ID.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.Textbox1ID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Textbox1ID.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.Textbox1ID.BorderThickness = 3;
            this.Textbox1ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Textbox1ID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Textbox1ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.Textbox1ID.isPassword = false;
            this.Textbox1ID.Location = new System.Drawing.Point(237, 262);
            this.Textbox1ID.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Textbox1ID.Name = "Textbox1ID";
            this.Textbox1ID.Size = new System.Drawing.Size(320, 58);
            this.Textbox1ID.TabIndex = 15;
            this.Textbox1ID.Text = "ID";
            this.Textbox1ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1664, 1102);
            this.Controls.Add(this.Textbox1ID);
            this.Controls.Add(this.LblSupplier);
            this.Controls.Add(this.LblInvoice);
            this.Controls.Add(this.LblDateTime);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.panelDataGridView);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(286, 40);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView11)).EndInit();
            this.panelDataGridView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Controls.DataGridView1 dataGridView11;
        private System.Windows.Forms.Panel panelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medecine;
        private System.Windows.Forms.DataGridViewTextBoxColumn VAT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublicPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Margin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.Label LblDateTime;
        private System.Windows.Forms.Label LblInvoice;
        private System.Windows.Forms.Label LblSupplier;
        private Bunifu.Framework.UI.BunifuMetroTextbox Textbox1ID;
    }
}