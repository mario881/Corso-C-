namespace AppWeb1
{
    partial class frmClienti
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
            this.tabControl1 = new Wisej.Web.TabControl();
            this.tabPage1 = new Wisej.Web.TabPage();
            this.btnNuovo = new Wisej.Web.Button();
            this.btnApri = new Wisej.Web.Button();
            this.grRicerca = new Wisej.Web.DataGridView();
            this.tabPage2 = new Wisej.Web.TabPage();
            this.ctrNumericBox1 = new Controlli.ctrNumericBox();
            this.btnConferma = new Wisej.Web.Button();
            this.txtPI = new AppWeb1.ctrTextBox();
            this.txtLocalita = new AppWeb1.ctrTextBox();
            this.txtIndirizzo = new AppWeb1.ctrTextBox();
            this.txtRagSoc = new AppWeb1.ctrTextBox();
            this.txtCodice = new AppWeb1.ctrTextBox();
            this.txtValoreFiltra = new Wisej.Web.TextBox();
            this.btnFiltra = new Wisej.Web.Button();
            this.cmbCampiRicerca = new Wisej.Web.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grRicerca)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = Wisej.Web.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageInsets = new Wisej.Web.Padding(1, 35, 1, 1);
            this.tabControl1.Size = new System.Drawing.Size(838, 525);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmbCampiRicerca);
            this.tabPage1.Controls.Add(this.btnFiltra);
            this.tabPage1.Controls.Add(this.txtValoreFiltra);
            this.tabPage1.Controls.Add(this.btnNuovo);
            this.tabPage1.Controls.Add(this.btnApri);
            this.tabPage1.Controls.Add(this.grRicerca);
            this.tabPage1.Location = new System.Drawing.Point(1, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(836, 489);
            this.tabPage1.Text = "Ricerca";
            // 
            // btnNuovo
            // 
            this.btnNuovo.Location = new System.Drawing.Point(168, 364);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(100, 27);
            this.btnNuovo.TabIndex = 2;
            this.btnNuovo.Text = "Nuovo";
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // btnApri
            // 
            this.btnApri.Location = new System.Drawing.Point(37, 364);
            this.btnApri.Name = "btnApri";
            this.btnApri.Size = new System.Drawing.Size(100, 27);
            this.btnApri.TabIndex = 1;
            this.btnApri.Text = "Apri";
            this.btnApri.Click += new System.EventHandler(this.btnApri_Click);
            // 
            // grRicerca
            // 
            this.grRicerca.Location = new System.Drawing.Point(3, 122);
            this.grRicerca.Name = "grRicerca";
            this.grRicerca.Size = new System.Drawing.Size(830, 194);
            this.grRicerca.TabIndex = 0;
            this.grRicerca.DoubleClick += new System.EventHandler(this.grRicerca_DoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctrNumericBox1);
            this.tabPage2.Controls.Add(this.btnConferma);
            this.tabPage2.Controls.Add(this.txtPI);
            this.tabPage2.Controls.Add(this.txtLocalita);
            this.tabPage2.Controls.Add(this.txtIndirizzo);
            this.tabPage2.Controls.Add(this.txtRagSoc);
            this.tabPage2.Controls.Add(this.txtCodice);
            this.tabPage2.Location = new System.Drawing.Point(1, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(836, 489);
            this.tabPage2.Text = "Dati";
            // 
            // ctrNumericBox1
            // 
            this.ctrNumericBox1.LabelText = "Numero";
            this.ctrNumericBox1.Location = new System.Drawing.Point(402, 291);
            this.ctrNumericBox1.Name = "ctrNumericBox1";
            this.ctrNumericBox1.Size = new System.Drawing.Size(273, 42);
            this.ctrNumericBox1.TabIndex = 6;
            this.ctrNumericBox1.Text = "";
            this.ctrNumericBox1.zNomeCampo = "Numero";
            this.ctrNumericBox1.zNomeTabella = "Tainte";
            // 
            // btnConferma
            // 
            this.btnConferma.Location = new System.Drawing.Point(641, 447);
            this.btnConferma.Name = "btnConferma";
            this.btnConferma.Size = new System.Drawing.Size(100, 27);
            this.btnConferma.TabIndex = 5;
            this.btnConferma.Text = "Conferma";
            this.btnConferma.Click += new System.EventHandler(this.btnConferma_Click);
            // 
            // txtPI
            // 
            this.txtPI.LabelText = "Partita Iva";
            this.txtPI.Location = new System.Drawing.Point(69, 291);
            this.txtPI.Name = "txtPI";
            this.txtPI.Size = new System.Drawing.Size(186, 42);
            this.txtPI.TabIndex = 4;
            this.txtPI.zNomeCampo = "PI";
            this.txtPI.zNomeTabella = "Tainte";
            // 
            // txtLocalita
            // 
            this.txtLocalita.LabelText = "Località";
            this.txtLocalita.Location = new System.Drawing.Point(402, 217);
            this.txtLocalita.Name = "txtLocalita";
            this.txtLocalita.Size = new System.Drawing.Size(305, 42);
            this.txtLocalita.TabIndex = 3;
            this.txtLocalita.zNomeCampo = "Localita";
            this.txtLocalita.zNomeTabella = "Tainte";
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.LabelText = "Indirizzo";
            this.txtIndirizzo.Location = new System.Drawing.Point(69, 217);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(305, 42);
            this.txtIndirizzo.TabIndex = 2;
            this.txtIndirizzo.zNomeCampo = "Indirizzo";
            this.txtIndirizzo.zNomeTabella = "Tainte";
            // 
            // txtRagSoc
            // 
            this.txtRagSoc.LabelText = "Ragione sociale";
            this.txtRagSoc.Location = new System.Drawing.Point(69, 136);
            this.txtRagSoc.Name = "txtRagSoc";
            this.txtRagSoc.Size = new System.Drawing.Size(305, 42);
            this.txtRagSoc.TabIndex = 1;
            this.txtRagSoc.zNomeCampo = "RagSoc";
            this.txtRagSoc.zNomeTabella = "Tainte";
            // 
            // txtCodice
            // 
            this.txtCodice.LabelText = "Codice";
            this.txtCodice.Location = new System.Drawing.Point(69, 65);
            this.txtCodice.Name = "txtCodice";
            this.txtCodice.Size = new System.Drawing.Size(100, 42);
            this.txtCodice.TabIndex = 0;
            this.txtCodice.zNomeCampo = "Cod";
            this.txtCodice.zNomeTabella = "Tainte";
            // 
            // txtValoreFiltra
            // 
            this.txtValoreFiltra.LabelText = "Valore";
            this.txtValoreFiltra.Location = new System.Drawing.Point(254, 60);
            this.txtValoreFiltra.Name = "txtValoreFiltra";
            this.txtValoreFiltra.Size = new System.Drawing.Size(199, 42);
            this.txtValoreFiltra.TabIndex = 3;
            // 
            // btnFiltra
            // 
            this.btnFiltra.Location = new System.Drawing.Point(469, 75);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(100, 27);
            this.btnFiltra.TabIndex = 4;
            this.btnFiltra.Text = "Filtra";
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // cmbCampiRicerca
            // 
            this.cmbCampiRicerca.Location = new System.Drawing.Point(37, 80);
            this.cmbCampiRicerca.Name = "cmbCampiRicerca";
            this.cmbCampiRicerca.Size = new System.Drawing.Size(211, 22);
            this.cmbCampiRicerca.TabIndex = 5;
            // 
            // frmClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 525);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmClienti";
            this.Text = "frmClienti";
            this.Load += new System.EventHandler(this.frmGenerico_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grRicerca)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.TabControl tabControl1;
        private Wisej.Web.TabPage tabPage1;
        private Wisej.Web.TabPage tabPage2;
        private Wisej.Web.DataGridView grRicerca;
        private Wisej.Web.Button btnApri;
        private ctrTextBox txtLocalita;
        private ctrTextBox txtIndirizzo;
        private ctrTextBox txtRagSoc;
        private ctrTextBox txtCodice;
        private ctrTextBox txtPI;
        private Wisej.Web.Button btnConferma;
        private Wisej.Web.Button btnNuovo;
        private Controlli.ctrNumericBox ctrNumericBox1;
        private Wisej.Web.Button btnFiltra;
        private Wisej.Web.TextBox txtValoreFiltra;
        private Wisej.Web.ComboBox cmbCampiRicerca;
    }
}