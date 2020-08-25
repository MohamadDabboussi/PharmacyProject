namespace Pharmacy.PL.Controls
{
    partial class DropDownButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel = new System.Windows.Forms.Panel();
            this.BtnHeader = new Pharmacy.PL.Controls.HomeButton1();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.BtnHeader);
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.MaximumSize = new System.Drawing.Size(281, 60);
            this.Panel.MinimumSize = new System.Drawing.Size(281, 60);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(281, 60);
            this.Panel.TabIndex = 1;
            // 
            // BtnHeader
            // 
            this.BtnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnHeader.BBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.BtnHeader.BfonyStyle = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHeader.BImage = null;
            this.BtnHeader.BText = "Header Text";
            this.BtnHeader.Location = new System.Drawing.Point(0, 0);
            this.BtnHeader.Name = "BtnHeader";
            this.BtnHeader.Size = new System.Drawing.Size(281, 60);
            this.BtnHeader.TabIndex = 0;
            this.BtnHeader.BClick += new System.EventHandler(this.Btn_Click);
            // 
            // DropDownButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.MaximumSize = new System.Drawing.Size(281, 60);
            this.MinimumSize = new System.Drawing.Size(281, 60);
            this.Name = "DropDownButton";
            this.Size = new System.Drawing.Size(281, 60);
            this.Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private HomeButton1 BtnHeader;
    }
}
