using WineCardAppVersionFour.Entities;
using WineCardAppVersionFour.Forms;
using WineCardAppVersionFour.Service;

namespace WineCardAppVersionFour.Uc
{
    public partial class UcWineCard : UserControl
    {
        private readonly ServiceWine _serviceWine;
        private readonly ServiceWineCard _serviceWineCard;
        public UcWineCard()
        {
            InitializeComponent();
            var context = new DbContextWineCardApp();
            _serviceWine = new ServiceWine(context);
            _serviceWineCard = new ServiceWineCard(context);

            
            LoadWines();
            ConfDataGridView();

            dateTimePickerVintage.Format = DateTimePickerFormat.Custom;
            dateTimePickerVintage.CustomFormat = "yyyy";
            dateTimePickerVintage.ShowUpDown = true;
        }

        private void LoadWines()
        {
            dataGridViewSelectedWineCard.DataSource = _serviceWine.GetAllWines();

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Select";
            checkBoxColumn.Name = "Select";
            dataGridViewSelectedWineCard.Columns.Insert(0, checkBoxColumn);
        }

        private void ConfDataGridView()
        {
            dataGridViewSelectedWineCard.Columns["WineId"].Visible = false;
            dataGridViewSelectedWineCard.Columns["WineTypeId"].Visible = false;
            dataGridViewSelectedWineCard.Columns["GrapeVarietyId"].Visible = false;
            dataGridViewSelectedWineCard.Columns["WineryId"].Visible = false;
            dataGridViewSelectedWineCard.Columns["VintageId"].Visible = false;
            dataGridViewSelectedWineCard.Columns["WineCards"].Visible = false;

            dataGridViewSelectedWineCard.Columns["WineName"].HeaderText = "Name";
            dataGridViewSelectedWineCard.Columns["Price"].HeaderText = "Preis";
            dataGridViewSelectedWineCard.Columns["WineType"].HeaderText = "Weinart";
            dataGridViewSelectedWineCard.Columns["GrapeVariety"].HeaderText = "Rebsorte";
            dataGridViewSelectedWineCard.Columns["Winery"].HeaderText = "Weingut";
            dataGridViewSelectedWineCard.Columns["Vintage"].HeaderText = "Jahrgang";

        }

        private List<int> GetSelectedWineIds()
        {
            var selectedWineIds = new List<int>();

            foreach (DataGridViewRow row in dataGridViewSelectedWineCard.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["Select"].Value);

                if (isSelected)
                {
                    int wineId = Convert.ToInt32(row.Cells["WineId"].Value);
                    selectedWineIds.Add(wineId);
                }
            }

            return selectedWineIds;
        }

        // Todo: anzahl der ausgewählten weine auf max10 beschränken
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Zähle die Anzahl der angehakten Zeilen
            int selectedCount = dataGridViewSelectedWineCard.Rows
                .Cast<DataGridViewRow>()
                .Count(row => Convert.ToBoolean(row.Cells["Select"].Value));

            // Prüfen, ob mehr als 10 Weine ausgewählt wurden
            if (selectedCount > 10)
            {
                MessageBox.Show("Sie können maximal 10 Weine auswählen");
                return;
            }

            // Speichere die ausgewählten Weine
            _serviceWineCard.SaveSelectedWines(GetSelectedWineIds());
            MessageBox.Show("Die Weinkarte kann nun angezeigt werden");
        }
        private void buttonWineCard_Click(object sender, EventArgs e)
        {
            var formWineCard = new FormWineCard();
            formWineCard.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewSelectedWineCard.DataSource = _serviceWineCard.GetFilteredWines(textBoxWineType.Text, textBoxCountry.Text, Convert.ToInt32(dateTimePickerVintage.Text), textBoxWinery.Text, textBoxRegion.Text, textBoxGrapeVariety.Text);
        }
    }
}
