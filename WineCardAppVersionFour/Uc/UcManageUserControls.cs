using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WineCardAppVersionFour.Uc
{
    public partial class UcManageUserControls : UserControl
    {
        public UcManageUserControls()
        {
            InitializeComponent();

            tabPageImportCsv.Controls.Add(new UcImportCSV());
            tabPageWine.Controls.Add(new UcWine());
            tabPageWinery.Controls.Add(new UcWinery());
            tabPageVintage.Controls.Add(new UcVintage());
            tabPageConfWineCard.Controls.Add(new UcWineCard());
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab == tabPageImportCsv)
            {
                tabPageImportCsv.Controls.Clear();
                tabPageImportCsv.Controls.Add(new UcImportCSV());
            }
            if (tabControlMain.SelectedTab == tabPageWine)
            {
                tabPageWine.Controls.Clear();
                tabPageWine.Controls.Add(new UcWine());
            }
            if (tabControlMain.SelectedTab == tabPageWinery)
            {
                tabPageWinery.Controls.Clear();
                tabPageWinery.Controls.Add(new UcWinery());
            }
            if (tabControlMain.SelectedTab == tabPageVintage)
            {
                tabPageVintage.Controls.Clear();
                tabPageVintage.Controls.Add(new UcVintage());
            }
            if (tabControlMain.SelectedTab == tabPageConfWineCard)
            {
                tabPageConfWineCard.Controls.Clear();
                tabPageConfWineCard.Controls.Add(new UcWineCard());
            }
        }
    }
}
