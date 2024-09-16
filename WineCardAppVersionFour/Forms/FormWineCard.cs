using WineCardAppVersionFour.Service;

namespace WineCardAppVersionFour.Forms
{
    public partial class FormWineCard : Form
    {
        private readonly ServiceWineCard _serviceWineCard;
        public FormWineCard()
        {
            InitializeComponent();
            var context = new DbContextWineCardApp();
            _serviceWineCard = new ServiceWineCard(context);

            this.WindowState = FormWindowState.Maximized;
            this.MinimizeBox = false;

            LoadUi();
            ConfDatagridView();
        }

        private void LoadUi()
        {
            dataGridViewWineCard.DataSource = _serviceWineCard.LoadSelectedWines(false, false);
        }

        private void ConfDatagridView()
        {
            dataGridViewWineCard.Columns["WineId"].Visible = false;
            dataGridViewWineCard.Columns["WineTypeId"].Visible = false;
            dataGridViewWineCard.Columns["GrapeVarietyId"].Visible = false;
            dataGridViewWineCard.Columns["WineryId"].Visible = false;
            dataGridViewWineCard.Columns["VintageId"].Visible = false;
            dataGridViewWineCard.Columns["WineCards"].Visible = false;

            dataGridViewWineCard.Columns["WineName"].HeaderText = "Name";
            dataGridViewWineCard.Columns["Price"].HeaderText = "Preis";
            dataGridViewWineCard.Columns["WineType"].HeaderText = "Weinart";
            dataGridViewWineCard.Columns["GrapeVariety"].HeaderText = "Rebsorte";
            dataGridViewWineCard.Columns["Winery"].HeaderText = "Weingut";
            dataGridViewWineCard.Columns["Vintage"].HeaderText = "Jahrgang";
        }

        private void checkBoxSortWineType_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSortWineType.Checked == true)
            {
                dataGridViewWineCard.DataSource = _serviceWineCard.LoadSelectedWines(true, false);
            }
        }

        private void checkBoxSortWineName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSortWineName.Checked == true)
            {
                dataGridViewWineCard.DataSource = _serviceWineCard.LoadSelectedWines(false, true);
            }
        }
    }
}
