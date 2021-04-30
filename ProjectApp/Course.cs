using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApp
{
   public  class Course
    {
        //definition des attributs
        private string titre;
        private int num_cours, code;
        

        
        //Constructeur Course initialisant les attributs
        public Course(int num_cours, int code, string titre)
        {
            this.titre = titre;
            this.code = code;
            this.num_cours = num_cours;
        }
         
        public string SGtitre
        {
            get { return this.titre; }
            set { this.titre = value; }

        }

        public int SGnum_cours
        {
            get { return this.num_cours; }
            set { this.num_cours = value; }
        }

        public int SGcode
        {
            get { return this.code; }
            set { this.code = value; }
        }

        
        

         

       
    }
}
