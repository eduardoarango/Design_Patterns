namespace Design_Patterns
{
    partial class ProxyFrm
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
            this.btnproxy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnproxy
            // 
            this.btnproxy.Location = new System.Drawing.Point(59, 28);
            this.btnproxy.Name = "btnproxy";
            this.btnproxy.Size = new System.Drawing.Size(108, 23);
            this.btnproxy.TabIndex = 0;
            this.btnproxy.Text = "Ver";
            this.btnproxy.UseVisualStyleBackColor = true;
            this.btnproxy.Click += new System.EventHandler(this.btnproxy_Click);
            // 
            // ProxyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 304);
            this.Controls.Add(this.btnproxy);
            this.Name = "ProxyFrm";
            this.Text = "ProxyFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnproxy;
    }
}