using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace JBPanel
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();
        int? selectedIndex = null;
        public Form1()
        {
            employees.Add(new Employee(nom: "Marcus", prenom: "Aurelius",
                email: "missy@clarkmail.com", tel: "1234567890"));
            employees.Add(new Employee(nom: "Leonard", prenom: "Neomoy",
                email: "pb30@kelvinclark.xyz", tel: "1234567890"));
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedIndex == null) return;
            DialogResult result = MessageBox.Show(
                "Voulez-vous supprimer l'entrée actuelle ?", "Confirmation", 
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                empListBox.Items.RemoveAt(selectedIndex.Value);
                employees.RemoveAt(selectedIndex.Value);
                clearTextFields();
                btnAjouter.Enabled = false;
                btnModifier.Enabled = false;
                btnSup.Enabled = false;
                btnConfirmer.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBoxButtons btns = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(
                "Voulez-vous ajouter les entrées actuelles ?", "Confirmation", btns);

            if (result == DialogResult.Yes)
            {
                String nom = tbNom.Text;
                String prenom = tbPrenom.Text;
                String email = tbEmail.Text;
                String tel = tbTel.Text;
                if (nom.Length == 0 || prenom.Length == 0) return;

                Employee emp = new Employee(nom: nom, prenom: prenom, email: email,
                    tel: tel);
                employees.Add(emp);
                empListBox.Items.Add($"{nom} {prenom}");
                clearTextFields();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void empListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = empListBox.SelectedIndex;
            btnAjouter.Enabled = true;
            btnModifier.Enabled = true;
            btnSup.Enabled = true;
            btnConfirmer.Enabled = false;
            if (selectedIndex == null) return;
            Employee emp = employees[selectedIndex.Value];
            tbNom.Text = emp.Nom;
            tbPrenom.Text = emp.Prenom;
            tbEmail.Text = emp.Email;
            tbTel.Text = emp.Tel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            employees.ForEach(emp =>
            {
                empListBox.Items.Add($"{emp.Nom} {emp.Prenom}");
            });
            btnAjouter.Enabled = false;
            btnModifier.Enabled = false;
            btnSup.Enabled = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            clearTextFields();
            selectedIndex = null;
            btnAjouter.Enabled = false;
            btnModifier.Enabled = false;
            btnSup.Enabled = false;
            btnConfirmer.Enabled = true;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (selectedIndex == null) return;
            String nom = tbNom.Text;
            String prenom = tbPrenom.Text;
            String email = tbEmail.Text;
            String tel = tbTel.Text;
            Employee emp = new Employee(nom: nom, prenom: prenom, email: email,
                    tel: tel);
            empListBox.Items.RemoveAt(selectedIndex.Value);
            empListBox.Items.Insert(selectedIndex.Value, $"{nom} {prenom}");
            employees.RemoveAt(selectedIndex.Value);
            employees.Insert(selectedIndex.Value, emp);
            MessageBox.Show(
                "Changements sauvegardés avec succès", "Notification de mise à jour",
                MessageBoxButtons.OK);
        }

        private void clearTextFields()
        {
            tbNom.Text = "";
            tbPrenom.Text = "";
            tbEmail.Text = "";
            tbTel.Text = "";
        }
    }
}
