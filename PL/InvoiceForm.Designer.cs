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
            this.dataGridView21 = new Pharmacy.PL.Controls.DataGridView2();
            this.SuspendLayout();
            // 
            // dataGridView21
            // 
            this.dataGridView21.Location = new System.Drawing.Point(59, 434);
            this.dataGridView21.Name = "dataGridView21";
            this.dataGridView21.Size = new System.Drawing.Size(1100, 400);
            this.dataGridView21.TabIndex = 0;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 960);
            this.Controls.Add(this.dataGridView21);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(286, 40);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DataGridView2 dataGridView21;
    }
}