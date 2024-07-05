using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PO_project
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
