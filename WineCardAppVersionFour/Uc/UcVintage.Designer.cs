namespace WineCardAppVersionFour.Uc
{
    partial class UcVintage
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
            groupBoxVintage = new GroupBox();
            dateTimePickerVintage = new DateTimePicker();
            labelVintage = new Label();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            dataGridViewVintage = new DataGridView();
            groupBoxVintage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVintage).BeginInit();
            SuspendLayout();
            // 
            // groupBoxVintage
            // 
            groupBoxVintage.Controls.Add(dateTimePickerVintage);
            groupBoxVintage.Controls.Add(labelVintage);
            groupBoxVintage.Controls.Add(buttonSave);
            groupBoxVintage.Location = new Point(968, 5);
            groupBoxVintage.Name = "groupBoxVintage";
            groupBoxVintage.Size = new Size(334, 229);
            groupBoxVintage.TabIndex = 14;
            groupBoxVintage.TabStop = false;
            groupBoxVintage.Text = "Jahrgang";
            // 
            // dateTimePickerVintage
            // 
            dateTimePickerVintage.Location = new Point(84, 33);
            dateTimePickerVintage.Name = "dateTimePickerVintage";
            dateTimePickerVintage.Size = new Size(250, 27);
            dateTimePickerVintage.TabIndex = 15;
            // 
            // labelVintage
            // 
            labelVintage.AutoSize = true;
            labelVintage.Location = new Point(6, 38);
            labelVintage.Name = "labelVintage";
            labelVintage.Size = new Size(77, 20);
            labelVintage.TabIndex = 14;
            labelVintage.Text = "Jahrgänge";
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
            // buttonDelete
            // 
            buttonDelete.Location = new Point(867, 551);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 58);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Löschen";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(767, 551);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 58);
            buttonUpdate.TabIndex = 12;
            buttonUpdate.Text = "Bearbeiten";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(667, 551);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 58);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Hinzufügen";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewVintage
            // 
            dataGridViewVintage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewVintage.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewVintage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVintage.Location = new Point(3, 3);
            dataGridViewVintage.MultiSelect = false;
            dataGridViewVintage.Name = "dataGridViewVintage";
            dataGridViewVintage.ReadOnly = true;
            dataGridViewVintage.RowHeadersWidth = 51;
            dataGridViewVintage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewVintage.Size = new Size(959, 542);
            dataGridViewVintage.TabIndex = 10;
            // 
            // UcVintage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBoxVintage);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewVintage);
            Name = "UcVintage";
            Size = new Size(1305, 612);
            groupBoxVintage.ResumeLayout(false);
            groupBoxVintage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVintage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxVintage;
        private Label labelVintage;
        private Button buttonSave;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
        private DataGridView dataGridViewVintage;
        private DateTimePicker dateTimePickerVintage;
    }
}
