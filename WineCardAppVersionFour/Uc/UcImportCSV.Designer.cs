namespace WineCardAppVersionFour.Uc
{
    partial class UcImportCSV
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
            buttonImportCSV = new Button();
            SuspendLayout();
            // 
            // buttonImportCSV
            // 
            buttonImportCSV.Location = new Point(457, 163);
            buttonImportCSV.Name = "buttonImportCSV";
            buttonImportCSV.Size = new Size(434, 240);
            buttonImportCSV.TabIndex = 0;
            buttonImportCSV.Text = "IMPORT CSV";
            buttonImportCSV.UseVisualStyleBackColor = true;
            buttonImportCSV.Click += buttonImportCSV_Click;
            // 
            // UcImportCSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonImportCSV);
            Name = "UcImportCSV";
            Size = new Size(1305, 612);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonImportCSV;
    }
}
