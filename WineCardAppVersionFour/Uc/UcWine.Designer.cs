namespace WineCardAppVersionFour.Uc
{
    partial class UcWine
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
            dataGridViewWine = new DataGridView();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            groupBoxWine = new GroupBox();
            buttonSave = new Button();
            labelVintage = new Label();
            labelWinery = new Label();
            labelGrapeVarietie = new Label();
            labelWineType = new Label();
            comboBoxVintage = new ComboBox();
            comboBoxWinery = new ComboBox();
            comboBoxGrapeVariety = new ComboBox();
            comboBoxWineType = new ComboBox();
            labelPrice = new Label();
            textBoxPrice = new TextBox();
            labelWineName = new Label();
            textBoxWineName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWine).BeginInit();
            groupBoxWine.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewWine
            // 
            dataGridViewWine.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewWine.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewWine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWine.Location = new Point(3, 3);
            dataGridViewWine.MultiSelect = false;
            dataGridViewWine.Name = "dataGridViewWine";
            dataGridViewWine.ReadOnly = true;
            dataGridViewWine.RowHeadersWidth = 51;
            dataGridViewWine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewWine.Size = new Size(959, 542);
            dataGridViewWine.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(667, 551);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 58);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Hinzufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(767, 551);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 58);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "Bearbeiten";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(867, 551);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 58);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Löschen";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // groupBoxWine
            // 
            groupBoxWine.Controls.Add(buttonSave);
            groupBoxWine.Controls.Add(labelVintage);
            groupBoxWine.Controls.Add(labelWinery);
            groupBoxWine.Controls.Add(labelGrapeVarietie);
            groupBoxWine.Controls.Add(labelWineType);
            groupBoxWine.Controls.Add(comboBoxVintage);
            groupBoxWine.Controls.Add(comboBoxWinery);
            groupBoxWine.Controls.Add(comboBoxGrapeVariety);
            groupBoxWine.Controls.Add(comboBoxWineType);
            groupBoxWine.Controls.Add(labelPrice);
            groupBoxWine.Controls.Add(textBoxPrice);
            groupBoxWine.Controls.Add(labelWineName);
            groupBoxWine.Controls.Add(textBoxWineName);
            groupBoxWine.Location = new Point(968, 5);
            groupBoxWine.Name = "groupBoxWine";
            groupBoxWine.Size = new Size(334, 302);
            groupBoxWine.TabIndex = 4;
            groupBoxWine.TabStop = false;
            groupBoxWine.Text = "Wein";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(234, 263);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Speichern";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelVintage
            // 
            labelVintage.AutoSize = true;
            labelVintage.Location = new Point(6, 223);
            labelVintage.Name = "labelVintage";
            labelVintage.Size = new Size(69, 20);
            labelVintage.TabIndex = 11;
            labelVintage.Text = "Jahrgang";
            // 
            // labelWinery
            // 
            labelWinery.AutoSize = true;
            labelWinery.Location = new Point(6, 189);
            labelWinery.Name = "labelWinery";
            labelWinery.Size = new Size(64, 20);
            labelWinery.TabIndex = 10;
            labelWinery.Text = "Weingut";
            // 
            // labelGrapeVarietie
            // 
            labelGrapeVarietie.AutoSize = true;
            labelGrapeVarietie.Location = new Point(6, 155);
            labelGrapeVarietie.Name = "labelGrapeVarietie";
            labelGrapeVarietie.Size = new Size(68, 20);
            labelGrapeVarietie.TabIndex = 9;
            labelGrapeVarietie.Text = "Rebsorte";
            // 
            // labelWineType
            // 
            labelWineType.AutoSize = true;
            labelWineType.Location = new Point(6, 121);
            labelWineType.Name = "labelWineType";
            labelWineType.Size = new Size(60, 20);
            labelWineType.TabIndex = 8;
            labelWineType.Text = "Weinart";
            // 
            // comboBoxVintage
            // 
            comboBoxVintage.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVintage.FormattingEnabled = true;
            comboBoxVintage.Location = new Point(119, 220);
            comboBoxVintage.Name = "comboBoxVintage";
            comboBoxVintage.Size = new Size(209, 28);
            comboBoxVintage.TabIndex = 7;
            // 
            // comboBoxWinery
            // 
            comboBoxWinery.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWinery.FormattingEnabled = true;
            comboBoxWinery.Location = new Point(119, 186);
            comboBoxWinery.Name = "comboBoxWinery";
            comboBoxWinery.Size = new Size(209, 28);
            comboBoxWinery.TabIndex = 6;
            // 
            // comboBoxGrapeVariety
            // 
            comboBoxGrapeVariety.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGrapeVariety.FormattingEnabled = true;
            comboBoxGrapeVariety.Location = new Point(119, 152);
            comboBoxGrapeVariety.Name = "comboBoxGrapeVariety";
            comboBoxGrapeVariety.Size = new Size(209, 28);
            comboBoxGrapeVariety.TabIndex = 5;
            // 
            // comboBoxWineType
            // 
            comboBoxWineType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxWineType.FormattingEnabled = true;
            comboBoxWineType.Location = new Point(119, 118);
            comboBoxWineType.Name = "comboBoxWineType";
            comboBoxWineType.Size = new Size(209, 28);
            comboBoxWineType.TabIndex = 4;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(6, 71);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(40, 20);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Preis";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(119, 68);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(209, 27);
            textBoxPrice.TabIndex = 2;
            textBoxPrice.KeyPress += textBoxPrice_KeyPress;
            // 
            // labelWineName
            // 
            labelWineName.AutoSize = true;
            labelWineName.Location = new Point(6, 38);
            labelWineName.Name = "labelWineName";
            labelWineName.Size = new Size(49, 20);
            labelWineName.TabIndex = 1;
            labelWineName.Text = "Name";
            // 
            // textBoxWineName
            // 
            textBoxWineName.Location = new Point(119, 35);
            textBoxWineName.Name = "textBoxWineName";
            textBoxWineName.Size = new Size(209, 27);
            textBoxWineName.TabIndex = 0;
            textBoxWineName.KeyPress += textBoxWineName_KeyPress;
            // 
            // UcWine
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxWine);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewWine);
            Name = "UcWine";
            Size = new Size(1305, 612);
            ((System.ComponentModel.ISupportInitialize)dataGridViewWine).EndInit();
            groupBoxWine.ResumeLayout(false);
            groupBoxWine.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewWine;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private GroupBox groupBoxWine;
        private Label labelWineName;
        private TextBox textBoxWineName;
        private Label labelVintage;
        private Label labelWinery;
        private Label labelGrapeVarietie;
        private Label labelWineType;
        private ComboBox comboBoxVintage;
        private ComboBox comboBoxWinery;
        private ComboBox comboBoxGrapeVariety;
        private ComboBox comboBoxWineType;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Button buttonSave;
    }
}
