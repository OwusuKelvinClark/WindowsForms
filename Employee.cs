using System;
using System.Collections.Generic;
using System.Text;

namespace JBPanel
{
    public class Employee
    {

        private int id;
        private String nom;
        private String prenom;
        private String email;
        private String tel;

        public int ID { get { return id; } }
        public String Nom { get { return nom; } set { nom = value; } }
        public String Prenom { get { return prenom; } set { prenom = value; } }
        public String Email { get { return email; } set { email = value; } }
        public String Tel { get { return tel; } set { tel = value; } }

        public Employee(String nom, String prenom, String email = "", 
            String tel = "", int id = 0)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.tel = tel;
            this.id = id;
        }
    }
}
