using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PO_project
{
    public partial class EmployeesForm : Form
    {
        private List<Pracownik> pracownicy;
        public EmployeesForm(List<Pracownik> pracownicy)
        {
            InitializeComponent();
            this.pracownicy = pracownicy;
            DisplayEmployees();
        }

        private void DisplayEmployees()
        {
            foreach (var pracownik in pracownicy)
            {
                listBoxEmployees.Items.Add($"{pracownik.Nazwisko} ({pracownik.Rodzaj()})");
            }
        }
    }
}
