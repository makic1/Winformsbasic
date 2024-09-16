namespace WineCardAppVersionFour.Forms
{
    partial class FormWineCard
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
            dataGridViewWineCard = new DataGridView();
            labelWinecardName = new Label();
            panel1 = new Panel();
            checkBoxSortWineType = new CheckBox();
            checkBoxSortWineName = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWineCard).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewWineCard
            // 
            dataGridViewWineCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewWineCard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewWineCard.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewWineCard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWineCard.Location = new Point(6, 110);
            dataGridViewWineCard.MultiSelect = false;
            dataGridViewWineCard.Name = "dataGridViewWineCard";
            dataGridViewWineCard.ReadOnly = true;
            dataGridViewWineCard.RowHeadersWidth = 51;
            dataGridViewWineCard.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewWineCard.Size = new Size(846, 383);
            dataGridViewWineCard.TabIndex = 0;
            // 
            // labelWinecardName
            // 
            labelWinecardName.AutoSize = true;
            labelWinecardName.Font = new Font("Segoe UI", 20F);
            labelWinecardName.Location = new Point(6, 9);
            labelWinecardName.Name = "labelWinecardName";
            labelWinecardName.Size = new Size(300, 46);
            labelWinecardName.TabIndex = 1;
            labelWinecardName.Text = "Heutige Weinkarte";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Location = new Point(15, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 2);
            panel1.TabIndex = 2;
            // 
            // checkBoxSortWineType
            // 
            checkBoxSortWineType.AutoSize = true;
            checkBoxSortWineType.Location = new Point(13, 80);
            checkBoxSortWineType.Name = "checkBoxSortWineType";
            checkBoxSortWineType.Size = new Size(180, 24);
            checkBoxSortWineType.TabIndex = 3;
            checkBoxSortWineType.Text = "Weinart (alphabetisch)";
            checkBoxSortWineType.UseVisualStyleBackColor = true;
            checkBoxSortWineType.CheckedChanged += checkBoxSortWineType_CheckedChanged;
            // 
            // checkBoxSortWineName
            // 
            checkBoxSortWineName.AutoSize = true;
            checkBoxSortWineName.Location = new Point(199, 80);
            checkBoxSortWineName.Name = "checkBoxSortWineName";
            checkBoxSortWineName.Size = new Size(246, 24);
            checkBoxSortWineName.TabIndex = 4;
            checkBoxSortWineName.Text = "Weinbezeichnung (alphabetisch)";
            checkBoxSortWineName.UseVisualStyleBackColor = true;
            checkBoxSortWineName.CheckedChanged += checkBoxSortWineName_CheckedChanged;
            // 
            // FormWineCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 505);
            Controls.Add(checkBoxSortWineName);
            Controls.Add(checkBoxSortWineType);
            Controls.Add(panel1);
            Controls.Add(labelWinecardName);
            Controls.Add(dataGridViewWineCard);
            Name = "FormWineCard";
            Text = "Weinkarte";
            ((System.ComponentModel.ISupportInitialize)dataGridViewWineCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewWineCard;
        private Label labelWinecardName;
        private Panel panel1;
        private CheckBox checkBoxSortWineType;
        private CheckBox checkBoxSortWineName;
    }
}