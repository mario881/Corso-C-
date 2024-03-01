namespace AppWeb1
{
    partial class frmLogin
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUtente = new Wisej.Web.TextBox();
            this.txtPassword = new Wisej.Web.TextBox();
            this.btnConferma = new Wisej.Web.Button();
            this.SuspendLayout();
            // 
            // txtUtente
            // 
            this.txtUtente.Font = new System.Drawing.Font("default, Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUtente.LabelText = "Utente";
            this.txtUtente.Location = new System.Drawing.Point(166, 81);
            this.txtUtente.Name = "txtUtente";
            this.txtUtente.Size = new System.Drawing.Size(224, 46);
            this.txtUtente.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("default, Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.LabelText = "Password";
            this.txtPassword.Location = new System.Drawing.Point(166, 161);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(224, 46);
            this.txtPassword.TabIndex = 1;
            // 
            // btnConferma
            // 
            this.btnConferma.Font = new System.Drawing.Font("default, Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnConferma.Location = new System.Drawing.Point(222, 246);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(116, 27);
            this.btnConferma.TabIndex = 2;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 440);
            this.ControlBox = false;
            this.Controls.Add(this.btnConferma);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUtente);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.TextBox txtUtente;
        private Wisej.Web.TextBox txtPassword;
        private Wisej.Web.Button btnConferma;
    }
}