﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WineCardAppVersionFour.Service;

namespace WineCardAppVersionFour.Uc
{
    public partial class UcImportCSV : UserControl
    {
        private readonly ServiceCSv _serviceCsv;
        public UcImportCSV()
        {
            InitializeComponent();

            var context = new DbContextWineCardApp();
            _serviceCsv = new ServiceCSv(context);
        }

        private void buttonImportCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Wähle eine CSV";
            openFileDialog.Filter = "csv files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                if (selectedFilePath is not null)
                {
                    _serviceCsv.ImportCSV(selectedFilePath);
                    MessageBox.Show("Die csv wurde eingelesen");
                }
            }

        }
    }
}
