namespace MyBrowser
{
    partial class FormBrowser
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
            this.panelBrowser = new System.Windows.Forms.Panel();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtUriBar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panelBrowser
            // 
            this.panelBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBrowser.Location = new System.Drawing.Point(-3, 53);
            this.panelBrowser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBrowser.Name = "panelBrowser";
            this.panelBrowser.Size = new System.Drawing.Size(1184, 498);
            this.panelBrowser.TabIndex = 5;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(1100, 10);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(84, 28);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtUriBar
            // 
            this.txtUriBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUriBar.Location = new System.Drawing.Point(10, 10);
            this.txtUriBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUriBar.Name = "txtUriBar";
            this.txtUriBar.Size = new System.Drawing.Size(1082, 28);
            this.txtUriBar.TabIndex = 3;
            // 
            // FormBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 551);
            this.Controls.Add(this.panelBrowser);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtUriBar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBrowser";
            this.Text = "FormBrowser";
            this.Load += new System.EventHandler(this.FormBrowser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBrowser;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtUriBar;
    }
}

