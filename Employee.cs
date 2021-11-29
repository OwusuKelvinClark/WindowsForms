using System;
using System.Collections.Generic;
using System.Text;

namespace JBPanel
{
    public class Employee
    {
        private static int _id = 0;

        private int id;
        private String nom;
        private String prenom;
        private String email;
        private String tel;

        public int ID { get; set; }
        public String Nom { get { return nom; } set { nom = value; } }
        public String Prenom { get { return prenom; } set { prenom = value; } }
        public String Email { get { return email; } set { email = value; } }
        public String Tel { get { return tel; } set { tel = value; } }

        public Employee(String nom, String prenom, String email, String tel)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.tel = tel;
            id = _id++;
        }
    }
}
