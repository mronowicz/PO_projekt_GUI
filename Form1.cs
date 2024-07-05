using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PO_project
    {
    public enum EmployeeType
    {
        Mechanik,
        Kierownik
    }
    public partial class Form1 : Form
        {
            private List<Klient> klienci = new List<Klient>();
            private List<Pracownik> pracownicy = new List<Pracownik>();

            private string listaKlientowSciezka = "ListaKlientow.txt";
            private string listaPracownikowSciezka = "ListaPracownikow.txt";

            public Form1()
            {
                InitializeComponent();
                LoadEmployeesFromFile();

            if (!File.Exists(listaKlientowSciezka))
                {
                    File.Create(listaKlientowSciezka).Close();
                }

                if (!File.Exists(listaPracownikowSciezka))
                {
                    File.Create(listaPracownikowSciezka).Close();
                }

                
                btnShowClients.Click += BtnShowClients_Click;
                btnAddClient.Click += BtnAddClient_Click;
                btnEditClient.Click += BtnEditClient_Click;
                btnDeleteClient.Click += BtnDeleteClient_Click;
                btnShowGarage.Click += BtnShowGarage_Click;
                btnAddEmployee.Click += BtnAddEmployee_Click;
                btnShowEmployees.Click += BtnShowEmployees_Click;
            }

            private void BtnShowClients_Click(object sender, EventArgs e)
            {
                ShowClients();
            }
        private void LoadEmployeesFromFile()
        {
            if (File.Exists(listaPracownikowSciezka))
            {
                string[] lines = File.ReadAllLines(listaPracownikowSciezka);
                foreach (var line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length < 2) continue;

                    string nazwisko = parts[0];
                    string rodzaj = parts[1];

                    if (rodzaj == "Mechanik")
                    {
                        pracownicy.Add(new Mechanik(nazwisko));
                    }
                    else if (rodzaj == "Kierownik")
                    {
                        pracownicy.Add(new Kierownik(nazwisko));
                    }
                }
            }
        }
        private void BtnAddClient_Click(object sender, EventArgs e)
            {
                AddClient();
            }

            private void ShowEmployees()
        {
            var employeesForm = new EmployeesForm(pracownicy);
            employeesForm.ShowDialog();
        }
            private void BtnEditClient_Click(object sender, EventArgs e)
            {
                EditClient();
            }

            private void BtnDeleteClient_Click(object sender, EventArgs e)
            {
                DeleteClient();
            }

        private void BtnShowGarage_Click(object sender, EventArgs e)
        {
            ShowGarage();
        }

        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            using (var form = new AddEmployeeForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var nazwisko = form.Nazwisko;
                    var selectedType = form.SelectedType;

                    if (selectedType == EmployeeType.Mechanik)
                    {
                        var mechanik = new Mechanik(nazwisko);
                        pracownicy.Add(mechanik);
                        MessageBox.Show("Mechanik dodany");
                    }
                    else if (selectedType == EmployeeType.Kierownik)
                    {
                        var kierownik = new Kierownik(nazwisko);
                        pracownicy.Add(kierownik);
                        MessageBox.Show("Kierownik dodany");
                    }

                    SaveEmployeesToFile();
                }
            }
        }
        private void SaveEmployeesToFile()
        {
            using (StreamWriter writer = new StreamWriter(listaPracownikowSciezka))
            {
                foreach (var pracownik in pracownicy)
                {
                    writer.WriteLine($"{pracownik.Nazwisko};{pracownik.Rodzaj()}");
                }
            }
        }



        private void BtnShowEmployees_Click(object sender, EventArgs e)
        {
            DisplayEmployeesForm();
        }

        private void DisplayEmployeesForm()
        {
            var employeesForm = new EmployeesForm(pracownicy);
            employeesForm.ShowDialog();
        }

        private void ShowClients()
            {
                lstClients.Items.Clear();
                if (!File.Exists(listaKlientowSciezka))
                {
                    MessageBox.Show("Plik ListaKlientow.txt nie istnieje.");
                    return;
                }

                klienci.Clear();
                string[] lines = File.ReadAllLines(listaKlientowSciezka);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');

                    string imie = parts[0];
                    string email = parts[1];
                    string telefon = parts[2];
                    string marka = parts[3];
                    string model = parts[4];
                    int rokProdukcji = int.Parse(parts[5]);
                    string numerRejestracyjny = parts[6];

                    Samochod samochod = new Samochod(marka, model, rokProdukcji, numerRejestracyjny);
                    klienci.Add(new Klient(imie, email, telefon, samochod));
                }

                if (!klienci.Any())
                {
                    MessageBox.Show("nic tu nie ma");
                }
                else
                {
                    foreach (var (klient, index) in klienci.Select((value, i) => (value, i)))
                    {
                        var samochod = klient.Samochod;
                        lstClients.Items.Add($"{index + 1}. {klient.Imie} ({klient.Email}, {klient.Telefon}) - Samochod: {samochod.Marka} {samochod.Model} ({samochod.RokProdukcji}), {samochod.NumerRejestracyjny}");
                    }
                }
            }

            private void AddClient()
            {
               
                using (var form = new AddClientForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        var klient = form.GetClient();
                        klienci.Add(klient);

                        using (StreamWriter wpisz = File.AppendText(listaKlientowSciezka))
                        {
                            var samochod = klient.Samochod;
                            wpisz.WriteLine($"{klient.Imie};{klient.Email};{klient.Telefon};{samochod.Marka};{samochod.Model};{samochod.RokProdukcji};{samochod.NumerRejestracyjny}");
                        }

                        MessageBox.Show("Klient dodany");
                    }
                }
            }

        private void EditClient()
        {
            if (lstClients.SelectedItem == null)
            {
                MessageBox.Show("Wybierz klienta do edycji.");
                return;
            }

            int selectedIndex = lstClients.SelectedIndex;
            Klient selectedKlient = klienci[selectedIndex];

            using (var form = new EditClientForm(selectedKlient))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var editedClient = form.GetClient();
                    klienci[selectedIndex] = editedClient;

                   
                    UpdateClientInFile(selectedKlient, editedClient);

                    MessageBox.Show("Klient zaktualizowany.");
                    ShowClients(); // odśwież dane
                }
            }
        }

        private void UpdateClientInFile(Klient oldClient, Klient newClient)
        {
            var lines = File.ReadAllLines(listaKlientowSciezka).ToList();
            for (int i = 0; i < lines.Count; i++)
            {
                string[] parts = lines[i].Split(';');
                if (parts.Length < 7)
                {
                    continue;
                }

                string imie = parts[0];
                string email = parts[1];
                string telefon = parts[2];
                string marka = parts[3];
                string model = parts[4];
                int rokProdukcji = int.Parse(parts[5]);
                string numerRejestracyjny = parts[6];

                if (oldClient.Imie == imie &&
                    oldClient.Email == email &&
                    oldClient.Telefon == telefon &&
                    oldClient.Samochod.Marka == marka &&
                    oldClient.Samochod.Model == model &&
                    oldClient.Samochod.RokProdukcji == rokProdukcji &&
                    oldClient.Samochod.NumerRejestracyjny == numerRejestracyjny)
                {
                    lines[i] = $"{newClient.Imie};{newClient.Email};{newClient.Telefon};{newClient.Samochod.Marka};{newClient.Samochod.Model};{newClient.Samochod.RokProdukcji};{newClient.Samochod.NumerRejestracyjny}";
                }
            }
            File.WriteAllLines(listaKlientowSciezka, lines);
        }


        private void DeleteClient()
        {
            if (lstClients.SelectedItem == null)
            {
                MessageBox.Show("Wybierz klienta do usunięcia.");
                return;
            }

            int selectedIndex = lstClients.SelectedIndex;
            Klient selectedKlient = klienci[selectedIndex];

            DialogResult result = MessageBox.Show($"Czy na pewno chcesz usunąć klienta: {selectedKlient.Imie}?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                klienci.RemoveAt(selectedIndex);
                DeleteClientFromFile(selectedKlient);

                MessageBox.Show("Klient usunięty.");
                ShowClients(); // odśwież dane
            }
        }

        private void DeleteClientFromFile(Klient klient)
        {
            var linesToKeep = File.ReadAllLines("ListaKlientow.txt").Where(line =>
            {
                string[] parts = line.Split(';');
                if (parts.Length < 7)
                {
                    return true;
                }

                string imie = parts[0];
                string email = parts[1];
                string telefon = parts[2];
                string marka = parts[3];
                string model = parts[4];
                int rokProdukcji = int.Parse(parts[5]);
                string numerRejestracyjny = parts[6];

                return !(klient.Imie == imie &&
                         klient.Email == email &&
                         klient.Telefon == telefon &&
                         klient.Samochod.Marka == marka &&
                         klient.Samochod.Model == model &&
                         klient.Samochod.RokProdukcji == rokProdukcji &&
                         klient.Samochod.NumerRejestracyjny == numerRejestracyjny);
            });

            File.WriteAllLines("ListaKlientow.txt", linesToKeep);
        }

        private void ShowGarage()
        {
            var garageForm = new GarageForm();
            garageForm.LoadGarageData(klienci);
            garageForm.ShowDialog();
        }


        private void AddEmployee()
        {
            
            using (var form = new AddEmployeeForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var employee = form.GetEmployee();
                    Program.pracownicy.Add(employee);
                    
                }
            }
        }

       

        
    }
    }
