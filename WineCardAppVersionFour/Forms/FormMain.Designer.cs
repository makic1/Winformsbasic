namespace WineCardAppVersionFour
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMain = new Panel();
            buttonLogout = new Button();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Location = new Point(12, 45);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1319, 651);
            panelMain.TabIndex = 0;
            // 
            // buttonLogout
            // 
            buttonLogout.Location = new Point(1237, 7);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(94, 29);
            buttonLogout.TabIndex = 1;
            buttonLogout.Text = "Abmelden";
            buttonLogout.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 708);
            Controls.Add(buttonLogout);
            Controls.Add(panelMain);
            Name = "FormMain";
            Text = "Wein";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Button buttonLogout;
    }
}
