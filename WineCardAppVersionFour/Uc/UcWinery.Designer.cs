namespace WineCardAppVersionFour.Uc
{
    partial class UcWinery
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
            groupBoxWinery = new GroupBox();
            labelName = new Label();
            comboBoxRegion = new ComboBox();
            buttonSave = new Button();
            labelWineRegion = new Label();
            textBoxWineryName = new TextBox();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            dataGridViewWinery = new DataGridView();
            groupBoxWinery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWinery).BeginInit();
            SuspendLayout();
            // 
            // groupBoxWinery
            // 
            groupBoxWinery.Controls.Add(labelName);
            groupBoxWinery.Controls.Add(comboBoxRegion);
            groupBoxWinery.Controls.Add(buttonSave);
            groupBoxWinery.Controls.Add(labelWineRegion);
            groupBoxWinery.Controls.Add(textBoxWineryName);
            groupBoxWinery.Location = new Point(968, 5);
            groupBoxWinery.Name = "groupBoxWinery";
            groupBoxWinery.Size = new Size(334, 229);
            groupBoxWinery.TabIndex = 9;
            groupBoxWinery.TabStop = false;
            groupBoxWinery.Text = "Weingut";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(6, 38);
            labelName.Name = "labelName";
            labelName.Size = new Size(49, 20);
            labelName.TabIndex = 14;
            labelName.Text = "Name";
            // 
            // comboBoxRegion
            // 
            comboBoxRegion.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRegion.FormattingEnabled = true;
            comboBoxRegion.Location = new Point(119, 91);
            comboBoxRegion.Name = "comboBoxRegion";
            comboBoxRegion.Size = new Size(209, 28);
            comboBoxRegion.TabIndex = 13;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(234, 182);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Speichern";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelWineRegion
            // 
            labelWineRegion.AutoSize = true;
            labelWineRegion.Location = new Point(6, 94);
            labelWineRegion.Name = "labelWineRegion";
            labelWineRegion.Size = new Size(56, 20);
            labelWineRegion.TabIndex = 8;
            labelWineRegion.Text = "Region";
            // 
            // textBoxWineryName
            // 
            textBoxWineryName.Location = new Point(119, 35);
            textBoxWineryName.Name = "textBoxWineryName";
            textBoxWineryName.Size = new Size(209, 27);
            textBoxWineryName.TabIndex = 0;
            textBoxWineryName.KeyPress += textBoxWineryName_KeyPress;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(867, 551);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 58);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Löschen";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(767, 551);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 58);
            buttonUpdate.TabIndex = 7;
            buttonUpdate.Text = "Bearbeiten";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(667, 551);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 58);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Hinzufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewWinery
            // 
            dataGridViewWinery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewWinery.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewWinery.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWinery.Location = new Point(3, 3);
            dataGridViewWinery.MultiSelect = false;
            dataGridViewWinery.Name = "dataGridViewWinery";
            dataGridViewWinery.ReadOnly = true;
            dataGridViewWinery.RowHeadersWidth = 51;
            dataGridViewWinery.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewWinery.Size = new Size(959, 542);
            dataGridViewWinery.TabIndex = 5;
            // 
            // UcWinery
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxWinery);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewWinery);
            Name = "UcWinery";
            Size = new Size(1305, 612);
            groupBoxWinery.ResumeLayout(false);
            groupBoxWinery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWinery).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxWinery;
        private Button buttonSave;
        private Label labelVintage;
        private Label labelWinery;
        private Label labelGrapeVarietie;
        private Label labelWineRegion;
        private ComboBox comboBoxVintage;
        private ComboBox comboBoxWinery;
        private ComboBox comboBoxGrapeVariety;
        private ComboBox comboBoxWineType;
        private Label labelPrice;
        private TextBox textBoxPrice;
        private Label labelWineName;
        private TextBox textBoxWineryName;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
        private DataGridView dataGridViewWinery;
        private Label labelName;
        private ComboBox comboBoxRegion;
    }
}
