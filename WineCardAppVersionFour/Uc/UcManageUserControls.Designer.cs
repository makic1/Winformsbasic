namespace WineCardAppVersionFour.Uc
{
    partial class UcManageUserControls
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
            tabControlMain = new TabControl();
            tabPageWine = new TabPage();
            tabPageWinery = new TabPage();
            tabPageVintage = new TabPage();
            tabPageImportCsv = new TabPage();
            tabPageConfWineCard = new TabPage();
            tabControlMain.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageWine);
            tabControlMain.Controls.Add(tabPageWinery);
            tabControlMain.Controls.Add(tabPageVintage);
            tabControlMain.Controls.Add(tabPageConfWineCard);
            tabControlMain.Controls.Add(tabPageImportCsv);
            tabControlMain.Location = new Point(3, 3);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1313, 645);
            tabControlMain.TabIndex = 0;
            tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            // 
            // tabPageWine
            // 
            tabPageWine.Location = new Point(4, 29);
            tabPageWine.Name = "tabPageWine";
            tabPageWine.Padding = new Padding(3);
            tabPageWine.Size = new Size(1305, 612);
            tabPageWine.TabIndex = 0;
            tabPageWine.Text = "Wein";
            tabPageWine.UseVisualStyleBackColor = true;
            // 
            // tabPageWinery
            // 
            tabPageWinery.Location = new Point(4, 29);
            tabPageWinery.Name = "tabPageWinery";
            tabPageWinery.Size = new Size(1305, 612);
            tabPageWinery.TabIndex = 2;
            tabPageWinery.Text = "Weingut";
            tabPageWinery.UseVisualStyleBackColor = true;
            // 
            // tabPageVintage
            // 
            tabPageVintage.Location = new Point(4, 29);
            tabPageVintage.Name = "tabPageVintage";
            tabPageVintage.Size = new Size(1305, 612);
            tabPageVintage.TabIndex = 3;
            tabPageVintage.Text = "Jahrgang";
            tabPageVintage.UseVisualStyleBackColor = true;
            // 
            // tabPageImportCsv
            // 
            tabPageImportCsv.Location = new Point(4, 29);
            tabPageImportCsv.Name = "tabPageImportCsv";
            tabPageImportCsv.Padding = new Padding(3);
            tabPageImportCsv.Size = new Size(1305, 612);
            tabPageImportCsv.TabIndex = 1;
            tabPageImportCsv.Text = "Import CSV";
            tabPageImportCsv.UseVisualStyleBackColor = true;
            // 
            // tabPageConfWineCard
            // 
            tabPageConfWineCard.Location = new Point(4, 29);
            tabPageConfWineCard.Name = "tabPageConfWineCard";
            tabPageConfWineCard.Size = new Size(1305, 612);
            tabPageConfWineCard.TabIndex = 4;
            tabPageConfWineCard.Text = "Weinkarte Erstellen";
            tabPageConfWineCard.UseVisualStyleBackColor = true;
            // 
            // UcManageUserControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControlMain);
            Name = "UcManageUserControls";
            Size = new Size(1319, 651);
            tabControlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPageWine;
        private TabPage tabPageImportCsv;
        private TabPage tabPageWinery;
        private TabPage tabPageVintage;
        private TabPage tabPageConfWineCard;
    }
}
