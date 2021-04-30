using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApp
{
    public class Student
    {
        // definition des propriétés
        private String  nom_etud, prenom_etud;
        private int num_etud;
        
         

         
        
         
        //Constructeur  initialsant les attributs
        public Student(int num_etud, String prenom_etud,String nom_etud)
        {
            this.num_etud = num_etud;
            this.prenom_etud = prenom_etud;
            this.nom_etud = nom_etud;
             
             
             
        }


         
        public string SGnom
        {
            get { return this.nom_etud; }
            set { this.nom_etud = value; }
        }

        public string SGprenom
        {
            get { return this.prenom_etud; }
            set { this.prenom_etud = value; }
        }
        

        public int SGnum_etud
        {
            get { return this.num_etud; }
            set { this.num_etud = value; }
        }


        


        

         

         


    }
}
