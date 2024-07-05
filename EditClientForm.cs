using System;
using System.Windows.Forms;

namespace PO_project
{
    public partial class EditClientForm : Form
    {
        private Klient originalClient;

        public EditClientForm(Klient client)
        {
            InitializeComponent();
            originalClient = client;
            LoadClientData();
        }

        private void LoadClientData()
        {
            txtName.Text = originalClient.Imie;
            txtEmail.Text = originalClient.Email;
            txtPhone.Text = originalClient.Telefon;
            txtBrand.Text = originalClient.Samochod.Marka;
            txtModel.Text = originalClient.Samochod.Model;
            txtYear.Text = originalClient.Samochod.RokProdukcji.ToString();
            txtRegistration.Text = originalClient.Samochod.NumerRejestracyjny;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidInput())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Invalid input, please check your entries.");
            }
        }

        public Klient GetClient()
        {
            var imie = txtName.Text;
            var email = txtEmail.Text;
            var telefon = txtPhone.Text;
            var marka = txtBrand.Text;
            var model = txtModel.Text;
            var rokProdukcji = int.Parse(txtYear.Text);
            var numerRejestracyjny = txtRegistration.Text;

            var samochod = new Samochod(marka, model, rokProdukcji, numerRejestracyjny);
            return new Klient(imie, email, telefon, samochod);
        }

        private bool IsValidInput()
        {
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}