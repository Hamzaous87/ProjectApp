using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectApp
{
    class Grade
    {
        //Definition des attributs /Proprietes
        public int num_etud;
        public int num_cours;
        public double note;
         
        //Contructeur Grade initialisant les attributs
         
        public Grade(int num_etud, int num_cours, double note)
        {
            this.note = note;
            this.num_cours = num_cours;
            this.num_etud = num_etud;
             
            
        }
        


    }
}
