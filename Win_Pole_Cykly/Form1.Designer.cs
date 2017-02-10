namespace Win_Pole_Cykly
{
    partial class Form1
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
            this.txt_hraci = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_hraci
            // 
            this.txt_hraci.Location = new System.Drawing.Point(48, 51);
            this.txt_hraci.Multiline = true;
            this.txt_hraci.Name = "txt_hraci";
            this.txt_hraci.Size = new System.Drawing.Size(468, 378);
            this.txt_hraci.TabIndex = 0;
            this.txt_hraci.TextChanged += new System.EventHandler(this.txt_hraci_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 467);
            this.Controls.Add(this.txt_hraci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_hraci;
    }
}

