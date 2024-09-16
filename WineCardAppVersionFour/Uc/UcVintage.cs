using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WineCardAppVersionFour.Entities;
using WineCardAppVersionFour.Service;

namespace WineCardAppVersionFour.Uc
{
    public partial class UcVintage : UserControl
    {
        private IsEdit _addOrEdit;
        private readonly ServiceVintage _serviceVintage;
        public UcVintage()
        {
            InitializeComponent();
            var context = new DbContextWineCardApp();
            _serviceVintage = new ServiceVintage(context);

            LoadUi();
            ConfDataGridView();
            groupBoxVintage.Visible = false;
        }

        private void LoadUi()
        {
            dataGridViewVintage.DataSource = _serviceVintage.GetAllVintages();
        }

        private void ConfDataGridView()
        {
            dateTimePickerVintage.Format = DateTimePickerFormat.Custom;
            dateTimePickerVintage.CustomFormat = "yyyy";
            dateTimePickerVintage.ShowUpDown = true;

            dataGridViewVintage.Columns["VintageId"] .Visible = false;   
            dataGridViewVintage.Columns["Wines"] .Visible = false;      
            dataGridViewVintage.Columns["VintageYear"].HeaderText = "Jahrgang";      
            
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var vintage = new Vintage
            {
                VintageYear = dateTimePickerVintage.Value.Year,
            };

            if (_addOrEdit is IsEdit.Add)
            {
                if (_serviceVintage.CheckDuplicateVintage(vintage))
                {
                    MessageBox.Show("Dieser Jahrgang wurde schon hinzugefügt");
                    return;
                }
                _serviceVintage.AddVintage(vintage);
            }
            else if (_addOrEdit is IsEdit.Edit)
            {
                vintage.VintageId = CurrentVintageId();
                _serviceVintage.UpdateVintage(vintage);
            }
            LoadUi();
            groupBoxVintage.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Add;
            groupBoxVintage.Visible = true;


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Edit;
            groupBoxVintage.Visible = true;

            var vintage = _serviceVintage.FindVintageById(CurrentVintageId());

            dateTimePickerVintage.Value = new DateTime(vintage.VintageYear, 1, 1);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var dialogresult = MessageBox.Show("Sind sie sich sicher das sie diesen Jahrgang löschen möchtem?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogresult is DialogResult.Yes)
            {
                _serviceVintage.RemoveVintageById(CurrentVintageId());
            }
        }

        private int CurrentVintageId()
        {
            return Convert.ToInt32(dataGridViewVintage.SelectedRows[0].Cells[0].Value);
        }

        private enum IsEdit
        {
            Add,
            Edit
        }
    }
}
