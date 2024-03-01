namespace AppWeb1
{
    partial class MyDesktop
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
            this.menu = new Wisej.Web.MenuBar();
            this.menuArchivi = new Wisej.Web.MenuItem();
            this.menuClienti = new Wisej.Web.MenuItem();
            this.menuFornitori = new Wisej.Web.MenuItem();
            this.menuReport = new Wisej.Web.MenuItem();
            this.menuReportClienti = new Wisej.Web.MenuItem();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Dock = Wisej.Web.DockStyle.Top;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuArchivi,
            this.menuReport});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1003, 28);
            this.menu.TabIndex = 0;
            this.menu.TabStop = false;
            // 
            // menuArchivi
            // 
            this.menuArchivi.Index = 0;
            this.menuArchivi.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuClienti,
            this.menuFornitori});
            this.menuArchivi.Name = "menuArchivi";
            this.menuArchivi.Text = "Archivi";
            // 
            // menuClienti
            // 
            this.menuClienti.Index = 0;
            this.menuClienti.Name = "menuClienti";
            this.menuClienti.Text = "Clienti";
            this.menuClienti.Click += new System.EventHandler(this.menuClienti_Click);
            // 
            // menuFornitori
            // 
            this.menuFornitori.Index = 1;
            this.menuFornitori.Name = "menuFornitori";
            this.menuFornitori.Text = "Fornitori";
            // 
            // menuReport
            // 
            this.menuReport.Index = 1;
            this.menuReport.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
            this.menuReportClienti});
            this.menuReport.Name = "menuReport";
            this.menuReport.Text = "Report";
            // 
            // menuReportClienti
            // 
            this.menuReportClienti.Index = 0;
            this.menuReportClienti.Name = "menuReportClienti";
            this.menuReportClienti.Text = "Report clienti";
            this.menuReportClienti.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // MyDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.menu);
            this.Name = "MyDesktop";
            this.Size = new System.Drawing.Size(1003, 604);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Wisej.Web.MenuBar menu;
        private Wisej.Web.MenuItem menuArchivi;
        private Wisej.Web.MenuItem menuClienti;
        private Wisej.Web.MenuItem menuFornitori;
        private Wisej.Web.MenuItem menuReport;
        private Wisej.Web.MenuItem menuReportClienti;
    }
}
