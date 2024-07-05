using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PO_project
{
    public partial class GarageForm : Form
    {
        public GarageForm()
        {
            InitializeComponent();
        }

        public void LoadGarageData(List<Klient> klienci)
        {
            listBoxGarage.Items.Clear();
            foreach (var klient in klienci)
            {
                var samochod = klient.Samochod;
                listBoxGarage.Items.Add($"{samochod.Marka} {samochod.Model} ({samochod.RokProdukcji}), {samochod.NumerRejestracyjny}");
            }
        }
    }
}
