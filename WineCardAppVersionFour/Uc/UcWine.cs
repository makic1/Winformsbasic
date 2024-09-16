using WineCardAppVersionFour.Entities;
using WineCardAppVersionFour.Service;

namespace WineCardAppVersionFour.Uc
{
    public partial class UcWine : UserControl
    {
        private readonly ServiceWine _serviceWine;
        private readonly ServiceWineType _serviceWineType;
        private readonly ServiceGrapeVarieties _serviceGrapeVarieties;
        private readonly ServiceWinery _serviceWinery;
        private readonly ServiceVintage _serviceVintage;

        private IsEdit _addOrEdit;

        public UcWine()
        {
            InitializeComponent();
            var context = new DbContextWineCardApp();
            _serviceWine = new ServiceWine(context);
            _serviceWineType = new ServiceWineType(context);
            _serviceGrapeVarieties = new ServiceGrapeVarieties(context);
            _serviceWinery = new ServiceWinery(context);
            _serviceVintage = new ServiceVintage(context);

            groupBoxWine.Visible = false;

            LoadUi();
            ConfDatagridview();
        }

        public void LoadUi()
        {
            dataGridViewWine.DataSource = _serviceWine.GetAllWines();

            comboBoxWineType.DataSource = _serviceWineType.GetAllWineTypes();
            comboBoxGrapeVariety.DataSource = _serviceGrapeVarieties.GetAllGrapeVarieties();
            comboBoxWinery.DataSource = _serviceWinery.GetAllWineries();
            comboBoxVintage.DataSource = _serviceVintage.GetAllVintages();
        }

        public void ConfDatagridview()
        {
            dataGridViewWine.Columns["WineId"].Visible = false;
            dataGridViewWine.Columns["WineTypeId"].Visible = false;
            dataGridViewWine.Columns["GrapeVarietyId"].Visible = false;
            dataGridViewWine.Columns["WineryId"].Visible = false;
            dataGridViewWine.Columns["VintageId"].Visible = false;


            dataGridViewWine.Columns["WineName"].HeaderText = "Name";
            dataGridViewWine.Columns["Price"].HeaderText = "Preis";
            dataGridViewWine.Columns["WineType"].HeaderText = "Weinart";
            dataGridViewWine.Columns["GrapeVariety"].HeaderText = "Rebsorte";
            dataGridViewWine.Columns["Winery"].HeaderText = "Weingut";
            dataGridViewWine.Columns["Vintage"].HeaderText = "Jahrgang";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateWine().Count > 0)
            {
                MessageBox.Show(string.Join("\n", ValidateWine()), "Vallidation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var winetype = (WineType)comboBoxWineType.SelectedItem;
            var grapeVariety = (GrapeVariety)comboBoxGrapeVariety.SelectedItem;
            var winery = (Winery)comboBoxWinery.SelectedItem;
            var vintage = (Vintage)comboBoxVintage.SelectedItem;

            var wine = new Wine
            {
                WineName = textBoxWineName.Text,
                Price = Convert.ToDecimal(textBoxPrice.Text),
                WineTypeId = winetype.WineTypeId,
                GrapeVarietyId = grapeVariety.GrapeVarietyId,
                WineryId = winery.WineryId,
                VintageId = vintage.VintageId
            };

            if (_addOrEdit is IsEdit.Add)
            {
                _serviceWine.AddWine(wine);
            }
            if (_addOrEdit is IsEdit.Edit)
            {
                wine.WineId = CurrentWineId();
                _serviceWine.UpdateWine(wine);
            }

            LoadUi();
            groupBoxWine.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Add;
            groupBoxWine.Visible = true;

            textBoxPrice.Text = string.Empty;
            textBoxWineName.Text = string.Empty;

            comboBoxGrapeVariety.SelectedItem = null;
            comboBoxVintage.SelectedItem = null;
            comboBoxWinery.SelectedItem = null;
            comboBoxWineType.SelectedItem = null;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Edit;
            groupBoxWine.Visible = true;

            var wine = _serviceWine.FindWineById(CurrentWineId());

            textBoxWineName.Text = wine.WineName;
            textBoxPrice.Text = wine.Price.ToString();

            comboBoxGrapeVariety.SelectedItem = wine.GrapeVariety;
            comboBoxVintage.SelectedItem = wine.Vintage;
            comboBoxWinery.SelectedItem = wine.Winery;
            comboBoxWineType.SelectedItem = wine.WineType;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var dialogresult = MessageBox.Show("Sind sie sich sicher das sie diesen Wein löschen möchten", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogresult is DialogResult.Yes)
            {
                _serviceWine.RemoveWineById(CurrentWineId());
                LoadUi();
            }
        }

        private List<string> ValidateWine()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(textBoxWineName.Text))
            {
                errors.Add("Bitte geben sie einen Weinnamen ein");
            }
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                errors.Add("Geben sie bitte einen preis ein");
            }
            if (comboBoxWineType.SelectedItem is null)
            {
                errors.Add("Bitte wählen sie eine Weinart aus");
            }
            if (comboBoxWinery.SelectedItem is null)
            {
                errors.Add("Bitte wählen sie ein Weingüter aus");
            }
            if (comboBoxVintage.SelectedItem is null)
            {
                errors.Add("Bitte wählen sie einen Jahrgang aus");
            }
            if (comboBoxGrapeVariety.SelectedItem is null)
            {
                errors.Add("Bitte wähle eine Rebsorte aus");
            }

            return errors;
        }

        private int CurrentWineId()
        {
            return Convert.ToInt32(dataGridViewWine.SelectedRows[0].Cells[0].Value);
        }

        private void textBoxWineName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == ' ');
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back);
        }

        private enum IsEdit
        {
            Add,
            Edit,
        }
    }
}
