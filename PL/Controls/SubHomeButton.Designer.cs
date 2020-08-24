namespace Pharmacy.PL.Controls
{
    partial class SubHomeButton
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
            this.SubButton = new Pharmacy.PL.Controls.HomeButton1();
            this.SuspendLayout();
            // 
            // SubButton
            // 
            this.SubButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(49)))), ((int)(((byte)(53)))));
            this.SubButton.BBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.SubButton.BfonyStyle = new System.Drawing.Font("Century Gothic", 10F);
            this.SubButton.BImage = null;
            this.SubButton.BText = "";
            this.SubButton.Location = new System.Drawing.Point(0, 0);
            this.SubButton.Name = "SubButton";
            this.SubButton.Size = new System.Drawing.Size(281, 34);
            this.SubButton.TabIndex = 3;
            // 
            // SubHomeButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SubButton);
            this.Name = "SubHomeButton";
            this.Size = new System.Drawing.Size(281, 34);
            this.ResumeLayout(false);

        }

        #endregion

        private HomeButton1 SubButton;
    }
}
