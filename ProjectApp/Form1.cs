using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProjectApp

{
     
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //string myPath = "Resultat.txt";

        private void Form1_Load(object sender, EventArgs e)
        {
            // Déclarations des arralylist pour chaque objet:
            lst = new ArrayList();
            LST = new ArrayList();
            Liste = new ArrayList();
          
        }
        //arraylist pour l'etudiant (student)
        ArrayList lst;
        private void button1_Click(object sender, EventArgs e)
        {


            Student s = new Student(Convert.ToInt32(textBox1.Text), textBox2.Text, textBox3.Text);
            lst.Add(s);
            



            



        }
         
        //useless
        private void button2_Click(object sender, EventArgs e)
        {

        }

        
        //Remplissage du list view pour afficher les données de l'étudiant:
        private void button8_Click(object sender, EventArgs e)
        {
            lv.Items.Clear();
            for( int i = 0; i< lst.Count; i++)

            {
             
             ListViewItem item = new ListViewItem(new string[] { ((Student)lst[i]).SGnum_etud.ToString(), ((Student)lst[i]).SGprenom, ((Student)lst[i]).SGnom });


             lv.Items.Add(item);
                 



            }
             



        }

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
        //Arraylist pour les cours
        ArrayList LST;
        private void button3_Click(object sender, EventArgs e)
        {
            Course C = new Course(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text), textBox6.Text);
            LST.Add(C);
            
        }
        //Arraylist pour les notes(Grades)
        ArrayList Liste;
        private void button6_Click(object sender, EventArgs e)
        {
            Grade G = new Grade(Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox8.Text), Convert.ToDouble(textBox9.Text));
            Liste.Add(G);
             

        }
        //Remplissage du list view pour affiches les cours
        private void Afficher_cours_Click(object sender, EventArgs e)
        {
            listviewcourse.Items.Clear();
            foreach (Course course in LST)

            {

                ListViewItem item = new ListViewItem(new string[] { course.SGnum_cours.ToString(), course.SGcode.ToString(), course.SGtitre }) ;


                listviewcourse.Items.Add(item);




            }

        }
        //Remplissage du list view pour afficher les notes(Grades)
        private void Afficher_Click(object sender, EventArgs e)
        {
            listviewnote.Items.Clear();
            foreach (Grade grade in Liste)

            {

                ListViewItem item = new ListViewItem(new string[] {grade.num_etud.ToString(), grade.num_cours.ToString(), grade.note.ToString() });


                listviewnote.Items.Add(item);




            }

        }
        //Rechercher un étudiant par rapport à son id:
        private void Rechercher_Click(object sender, EventArgs e)
        {
            foreach(Student student in lst)
            {
                if (student_id.Text == student.SGnum_etud.ToString())
                {
                    MessageBox.Show("Nom de l'etudiant:"+ student.SGnom+ "\n" + "Prénom de l'étudiant : " + student.SGprenom);
                    return;
                }

                

              
            }
            //Afficher ce message si l'etudiant es introuvable
            MessageBox.Show("Etudiant introuvable");
         


        }
        //useless
        private void _TextChanged(object sender, EventArgs e)
        {

        }
        //Générer un fichier txt qui prend et affiche les données de chaque étudiant:

        private void buttonTXT_Click(object sender, EventArgs e)
        {

             
             ofd1.ShowDialog();

            File.AppendAllText(ofd1.FileName, textBox1.Text);

            
            
        }
    }
}
