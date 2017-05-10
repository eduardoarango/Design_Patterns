namespace Design_Patterns
{
    partial class DelegationFrm
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
            this.btnDelegator = new System.Windows.Forms.Button();
            this.btncliente = new System.Windows.Forms.Button();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDelegator
            // 
            this.btnDelegator.Location = new System.Drawing.Point(36, 24);
            this.btnDelegator.Name = "btnDelegator";
            this.btnDelegator.Size = new System.Drawing.Size(134, 23);
            this.btnDelegator.TabIndex = 0;
            this.btnDelegator.Text = "Empleado";
            this.btnDelegator.UseVisualStyleBackColor = true;
            this.btnDelegator.Click += new System.EventHandler(this.btnDelegator_Click);
            // 
            // btncliente
            // 
            this.btncliente.Location = new System.Drawing.Point(191, 24);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(134, 23);
            this.btncliente.TabIndex = 1;
            this.btncliente.Text = "Cliente";
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(36, 65);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(289, 63);
            this.txtMensaje.TabIndex = 2;
            // 
            // DelegationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 245);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btncliente);
            this.Controls.Add(this.btnDelegator);
            this.Name = "DelegationFrm";
            this.Text = "DelegationFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelegator;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.TextBox txtMensaje;
    }
}