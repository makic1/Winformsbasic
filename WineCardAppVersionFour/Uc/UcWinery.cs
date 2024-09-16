using WineCardAppVersionFour.Entities;
using WineCardAppVersionFour.Service;

namespace WineCardAppVersionFour.Uc
{
    public partial class UcWinery : UserControl
    {
        private readonly ServiceWinery _serviceWinery;
        private readonly ServiceRegion _serviceRegion;
        private IsEdit _addOrEdit;
        public UcWinery()
        {
            InitializeComponent();
            var context = new DbContextWineCardApp();
            _serviceRegion = new ServiceRegion(context);
            _serviceWinery = new ServiceWinery(context);
            groupBoxWinery.Visible = false;

            LoadUi();
            ConfDatagridview();
        }

        private void LoadUi()
        {
            dataGridViewWinery.DataSource = _serviceWinery.GetAllWineries();

            comboBoxRegion.DataSource = _serviceRegion.GetAllRegions();
        }

        private void ConfDatagridview()
        {
            dataGridViewWinery.Columns["WineryId"].Visible = false;
            dataGridViewWinery.Columns["Wines"].Visible = false;
            dataGridViewWinery.Columns["WineRegionId"].Visible = false;

            dataGridViewWinery.Columns["WineryName"].HeaderText = "Weingut";
            dataGridViewWinery.Columns["WineRegion"].HeaderText = "Region";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateWinery().Count > 0)
            {
                MessageBox.Show(string.Join("\n", ValidateWinery()), "Vallidierung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var region = (WineRegion)comboBoxRegion.SelectedItem;

            var winery = new Winery
            {
                WineryName = textBoxWineryName.Text,
                WineRegionId = region.WineRegionId
            };

            if (_addOrEdit is IsEdit.Add)
            {
                if (_serviceWinery.CheckForDuplicateWinery(winery))
                {
                    MessageBox.Show("Dieser Weingüter ist bereits vorhanden");
                    return;
                }
                _serviceWinery.AddWinery(winery);
            }
            else if (_addOrEdit is IsEdit.Edit)
            {
                winery.WineryId = CurrentWinery();
                _serviceWinery.UpdateWinery(winery);
            }
            LoadUi();
            groupBoxWinery.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Add;
            groupBoxWinery.Visible = true;

            textBoxWineryName.Text = string.Empty;
            comboBoxRegion.SelectedItem = null;

            groupBoxWinery.Visible = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            _addOrEdit = IsEdit.Edit;
            groupBoxWinery.Visible = true;

            var winery = _serviceWinery.FindWineryById(CurrentWinery());

            textBoxWineryName.Text = winery.WineryName.ToString();
            comboBoxRegion.SelectedItem = winery.WineRegion;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var dialogresult = MessageBox.Show("Sind sie sich sicher das die diesen Weingut löschen möchten", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogresult is DialogResult.Yes)
            {
                _serviceWinery.RemoveWinery(CurrentWinery());
                LoadUi();
            }
        }

        private List<string> ValidateWinery()
        {
            List<string> errors = new List<string>();

            if (string.IsNullOrWhiteSpace(textBoxWineryName.Text))
            {
                errors.Add("Geben sie bitte einen Namen ein");
            }
            if (comboBoxRegion.SelectedItem is null)
            {
                errors.Add("Wählen sie bitte eine Region aus");
            }
            return errors;
        }

        private int CurrentWinery()
        {
            return Convert.ToInt32(dataGridViewWinery.SelectedRows[0].Cells[0].Value);
        }

        private void textBoxWineryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.' || e.KeyChar == ' ');
        }

        private enum IsEdit
        {
            Add,
            Edit
        }
    }
}
