using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JBPanel
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();
        int? selectedIndex = null;
        bool isDelete = false;
        Repository repository;
        public Form1()
        {
            InitializeComponent();
            btnAjouter.Enabled = true;
            btnModifier.Enabled = false;
            btnSup.Enabled = false;
            btnAnnuler.Enabled = false;
            btnConfirmer.Enabled = false;
            tbEmail.Enabled = false;
            tbNom.Enabled = false;
            tbPrenom.Enabled = false;
            tbEmail.Enabled = false;
            tbTel.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedIndex == null) return;
            isDelete = true;
            btnAjouter.Enabled = false;
            btnModifier.Enabled = false;
            btnSup.Enabled = false;
            btnConfirmer.Enabled = true;
            btnAnnuler.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (selectedIndex == null)
            {
                String nom = tbNom.Text;
                String prenom = tbPrenom.Text;
                String email = tbEmail.Text;
                String tel = tbTel.Text;
                if (nom.Length == 0 || prenom.Length == 0) return;

                Employee emp = new Employee(nom: nom, prenom: prenom, email: email,
                    tel: tel);
                repository.insertEmployee(emp);
                populateComboBox();
                clearTextFields();
                btnAjouter.Enabled = true;
                btnModifier.Enabled = false;
                btnSup.Enabled = false;
                btnAnnuler.Enabled = false;
                btnConfirmer.Enabled = false;
                tbEmail.Enabled = false;
                tbNom.Enabled = false;
                tbPrenom.Enabled = false;
                tbEmail.Enabled = false;
                tbTel.Enabled = false;
            }
            else if (isDelete)
            {
                Employee emp = employees[selectedIndex.Value];
                repository.deleteFromEmployee(emp.ID);
                populateComboBox();
                clearTextFields();
                btnModifier.Enabled = false;
                btnSup.Enabled = false;
                btnConfirmer.Enabled = false;
                btnAnnuler.Enabled = false;
                tbEmail.Enabled = false;
                tbNom.Enabled = false;
                tbPrenom.Enabled = false;
                tbEmail.Enabled = false;
                tbTel.Enabled = false;
            }
            else
            {
                String nom = tbNom.Text;
                String prenom = tbPrenom.Text;
                String email = tbEmail.Text;
                String tel = tbTel.Text;
                Employee empOld = employees[selectedIndex.Value];
                Employee emp = new Employee(nom: nom, prenom: prenom, email: email,
                        tel: tel, id: empOld.ID);
                repository.updateEmployee(emp);
                populateComboBox();
                empListBox.Text = $"{nom} {prenom}";
                btnModifier.Enabled = true;
                btnSup.Enabled = true;
                btnConfirmer.Enabled = false;
                btnAnnuler.Enabled = false;
            }

            btnAjouter.Enabled = true;
            isDelete = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void empListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbEmail.Enabled = true;
            tbNom.Enabled = true;
            tbEmail.Enabled = true;
            tbTel.Enabled = true;
            tbPrenom.Enabled = true;
            selectedIndex = empListBox.SelectedIndex;
            btnAjouter.Enabled = true;
            btnModifier.Enabled = true;
            btnSup.Enabled = true;
            btnConfirmer.Enabled = false;
            btnAnnuler.Enabled = false;
            if (selectedIndex == null) return;
            Employee emp = employees[selectedIndex.Value];
            tbNom.Text = emp.Nom;
            tbPrenom.Text = emp.Prenom;
            tbEmail.Text = emp.Email;
            tbTel.Text = emp.Tel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repository = Repository.initRepo();
            populateComboBox();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            tbEmail.Enabled = true;
            tbNom.Enabled = true;
            tbEmail.Enabled = true;
            tbTel.Enabled = true;
            tbPrenom.Enabled = true;
            clearTextFields();
            selectedIndex = null;
            btnAjouter.Enabled = false;
            btnModifier.Enabled = false;
            btnSup.Enabled = false;
            btnConfirmer.Enabled = true;
            btnAnnuler.Enabled = true;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (selectedIndex == null) return;
            btnAjouter.Enabled = false;
            btnModifier.Enabled = false;
            btnSup.Enabled = false;
            btnConfirmer.Enabled = true;
            btnAnnuler.Enabled = true;
        }

        /// <summary>Clears the text fields.</summary>
        private void clearTextFields()
        {
            tbNom.Text = "";
            tbPrenom.Text = "";
            tbEmail.Text = "";
            tbTel.Text = "";
            empListBox.Text = "";
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            if (selectedIndex == null)
            {
                clearTextFields();
                btnAjouter.Enabled = true;
                btnModifier.Enabled = false;
                btnSup.Enabled = false;
                btnConfirmer.Enabled = false;
                btnAnnuler.Enabled = false;
                tbNom.Enabled = false;
                tbPrenom.Enabled = false;
                tbEmail.Enabled = false;
                tbTel.Enabled = false;
            }
            else
            {
                btnAjouter.Enabled = true;
                btnModifier.Enabled = true;
                btnSup.Enabled = true;
                btnConfirmer.Enabled = false;
                btnAnnuler.Enabled = false;
            }

            isDelete = false;
        }

        /// <summary>Takes care of filling the combobox with data</summary>
        private void populateComboBox()
        {
            empListBox.Items.Clear();
            employees.Clear();
            employees = repository.GetEmployees();
            employees.ForEach(emp =>
            {
                empListBox.Items.Add($"{emp.Nom} {emp.Prenom}");
            });
        }
    }
}
