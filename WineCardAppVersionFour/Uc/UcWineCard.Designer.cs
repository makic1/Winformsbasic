namespace WineCardAppVersionFour.Uc
{
    partial class UcWineCard
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
            buttonSave = new Button();
            buttonWineCard = new Button();
            dataGridViewSelectedWineCard = new DataGridView();
            labelWineType = new Label();
            textBoxWineType = new TextBox();
            buttonSearch = new Button();
            textBoxCountry = new TextBox();
            label1 = new Label();
            labelVintage = new Label();
            textBoxWinery = new TextBox();
            labelWinery = new Label();
            textBoxRegion = new TextBox();
            label4 = new Label();
            textBoxGrapeVariety = new TextBox();
            labelGrapeVariety = new Label();
            dateTimePickerVintage = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSelectedWineCard).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(12, 566);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Speichern";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonWineCard
            // 
            buttonWineCard.Location = new Point(1197, 566);
            buttonWineCard.Name = "buttonWineCard";
            buttonWineCard.Size = new Size(94, 29);
            buttonWineCard.TabIndex = 2;
            buttonWineCard.Text = "Weinkarte";
            buttonWineCard.UseVisualStyleBackColor = true;
            buttonWineCard.Click += buttonWineCard_Click;
            // 
            // dataGridViewSelectedWineCard
            // 
            dataGridViewSelectedWineCard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSelectedWineCard.Location = new Point(12, 91);
            dataGridViewSelectedWineCard.Name = "dataGridViewSelectedWineCard";
            dataGridViewSelectedWineCard.RowHeadersWidth = 51;
            dataGridViewSelectedWineCard.Size = new Size(1279, 457);
            dataGridViewSelectedWineCard.TabIndex = 3;
            // 
            // labelWineType
            // 
            labelWineType.AutoSize = true;
            labelWineType.Location = new Point(12, 21);
            labelWineType.Name = "labelWineType";
            labelWineType.Size = new Size(60, 20);
            labelWineType.TabIndex = 4;
            labelWineType.Text = "Weinart";
            // 
            // textBoxWineType
            // 
            textBoxWineType.Location = new Point(119, 18);
            textBoxWineType.Name = "textBoxWineType";
            textBoxWineType.Size = new Size(124, 27);
            textBoxWineType.TabIndex = 5;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(1197, 32);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(83, 29);
            buttonSearch.TabIndex = 6;
            buttonSearch.Text = "Suchen";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(119, 58);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(124, 27);
            textBoxCountry.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 61);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 7;
            label1.Text = "Herkunftsland";
            // 
            // labelVintage
            // 
            labelVintage.AutoSize = true;
            labelVintage.Location = new Point(269, 21);
            labelVintage.Name = "labelVintage";
            labelVintage.Size = new Size(69, 20);
            labelVintage.TabIndex = 9;
            labelVintage.Text = "Jahrgang";
            // 
            // textBoxWinery
            // 
            textBoxWinery.Location = new Point(342, 58);
            textBoxWinery.Name = "textBoxWinery";
            textBoxWinery.Size = new Size(124, 27);
            textBoxWinery.TabIndex = 12;
            // 
            // labelWinery
            // 
            labelWinery.AutoSize = true;
            labelWinery.Location = new Point(269, 61);
            labelWinery.Name = "labelWinery";
            labelWinery.Size = new Size(64, 20);
            labelWinery.TabIndex = 11;
            labelWinery.Text = "Weingut";
            // 
            // textBoxRegion
            // 
            textBoxRegion.Location = new Point(565, 19);
            textBoxRegion.Name = "textBoxRegion";
            textBoxRegion.Size = new Size(124, 27);
            textBoxRegion.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(492, 22);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 13;
            label4.Text = "Region";
            // 
            // textBoxGrapeVariety
            // 
            textBoxGrapeVariety.Location = new Point(565, 58);
            textBoxGrapeVariety.Name = "textBoxGrapeVariety";
            textBoxGrapeVariety.Size = new Size(124, 27);
            textBoxGrapeVariety.TabIndex = 16;
            // 
            // labelGrapeVariety
            // 
            labelGrapeVariety.AutoSize = true;
            labelGrapeVariety.Location = new Point(492, 61);
            labelGrapeVariety.Name = "labelGrapeVariety";
            labelGrapeVariety.Size = new Size(68, 20);
            labelGrapeVariety.TabIndex = 15;
            labelGrapeVariety.Text = "Rebsorte";
            // 
            // dateTimePickerVintage
            // 
            dateTimePickerVintage.Location = new Point(344, 18);
            dateTimePickerVintage.Name = "dateTimePickerVintage";
            dateTimePickerVintage.Size = new Size(101, 27);
            dateTimePickerVintage.TabIndex = 17;
            // 
            // UcWineCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePickerVintage);
            Controls.Add(textBoxGrapeVariety);
            Controls.Add(labelGrapeVariety);
            Controls.Add(textBoxRegion);
            Controls.Add(label4);
            Controls.Add(textBoxWinery);
            Controls.Add(labelWinery);
            Controls.Add(labelVintage);
            Controls.Add(textBoxCountry);
            Controls.Add(label1);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxWineType);
            Controls.Add(labelWineType);
            Controls.Add(dataGridViewSelectedWineCard);
            Controls.Add(buttonWineCard);
            Controls.Add(buttonSave);
            Name = "UcWineCard";
            Size = new Size(1305, 612);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSelectedWineCard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Button buttonWineCard;
        private DataGridView dataGridViewSelectedWineCard;
        private Label labelWineType;
        private TextBox textBoxWineType;
        private Button buttonSearch;
        private TextBox textBoxCountry;
        private Label label1;
        private Label labelVintage;
        private TextBox textBoxWinery;
        private Label labelWinery;
        private TextBox textBoxRegion;
        private Label label4;
        private TextBox textBoxGrapeVariety;
        private Label labelGrapeVariety;
        private DateTimePicker dateTimePickerVintage;
    }
}
