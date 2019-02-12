namespace Project
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
            this.ddUni = new System.Windows.Forms.ComboBox();
            this.ddlFac = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ddUni
            // 
            this.ddUni.FormattingEnabled = true;
            this.ddUni.Location = new System.Drawing.Point(70, 44);
            this.ddUni.Name = "ddUni";
            this.ddUni.Size = new System.Drawing.Size(121, 21);
            this.ddUni.TabIndex = 0;
            this.ddUni.SelectedIndexChanged += new System.EventHandler(this.ddUni_SelectedIndexChanged);
            // 
            // ddlFac
            // 
            this.ddlFac.FormattingEnabled = true;
            this.ddlFac.Location = new System.Drawing.Point(70, 104);
            this.ddlFac.Name = "ddlFac";
            this.ddlFac.Size = new System.Drawing.Size(121, 21);
            this.ddlFac.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 159);
            this.Controls.Add(this.ddlFac);
            this.Controls.Add(this.ddUni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddUni;
        private System.Windows.Forms.ComboBox ddlFac;
    }
}

