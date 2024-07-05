using System;
using System.Windows.Forms;

namespace PO_project
{
    public partial class AddEmployeeForm : Form
    {
        public Pracownik GetEmployee()
        {
            string nazwisko = Nazwisko;
            EmployeeType selectedType = SelectedType;

            if (selectedType == EmployeeType.Mechanik)
            {
                return new Mechanik(nazwisko);
            }
            else if (selectedType == EmployeeType.Kierownik)
            {
                return new Kierownik(nazwisko);
            }

            return null;
        }
        public string Nazwisko { get; private set; }
        public EmployeeType SelectedType { get; private set; }

        public AddEmployeeForm()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            comboBoxType.Items.Add("Mechanik");
            comboBoxType.Items.Add("Kierownik");
            comboBoxType.SelectedIndex = 0; // Default selection
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNazwisko.Text))
            {
                MessageBox.Show("Wprowadź nazwisko pracownika.");
                return;
            }

            Nazwisko = txtNazwisko.Text;

            if (comboBoxType.SelectedItem.ToString() == "Mechanik")
            {
                SelectedType = EmployeeType.Mechanik;
            }
            else if (comboBoxType.SelectedItem.ToString() == "Kierownik")
            {
                SelectedType = EmployeeType.Kierownik;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
