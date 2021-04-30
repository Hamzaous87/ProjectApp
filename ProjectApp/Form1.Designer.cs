
namespace ProjectApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Rechercher = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lv = new System.Windows.Forms.ListView();
            this.NumEtud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prenom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listviewcourse = new System.Windows.Forms.ListView();
            this.Numeroducours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Titre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Afficher_cours = new System.Windows.Forms.Button();
            this.Afficher = new System.Windows.Forms.Button();
            this.listviewnote = new System.Windows.Forms.ListView();
            this.Etud = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cours = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.student_id = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonTXT = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etudiant:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro d\'étudiant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nom";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(305, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(305, 120);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cours:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Numéro du cours";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Code";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 404);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "titre";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(305, 311);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(305, 359);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(305, 404);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rechercher
            // 
            this.Rechercher.Location = new System.Drawing.Point(247, 224);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(201, 24);
            this.Rechercher.TabIndex = 21;
            this.Rechercher.Text = "Chercher";
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 27);
            this.button3.TabIndex = 22;
            this.button3.Text = "Ajouter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 522);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "Notes:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 556);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Numéro d\'étudiant";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 595);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "Numéro du cours";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(55, 632);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "Note";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(305, 553);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 28;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(305, 595);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 29;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(305, 632);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 30;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(247, 665);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(201, 26);
            this.button6.TabIndex = 31;
            this.button6.Text = "Ajouter";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(938, 109);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(223, 28);
            this.button8.TabIndex = 34;
            this.button8.Text = "Afficher";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumEtud,
            this.Prenom,
            this.Nom});
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(574, 21);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(363, 211);
            this.lv.TabIndex = 35;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // NumEtud
            // 
            this.NumEtud.Text = "Numéro d\'étudiant";
            this.NumEtud.Width = 132;
            // 
            // Prenom
            // 
            this.Prenom.Text = "Prénom";
            this.Prenom.Width = 81;
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 92;
            // 
            // listviewcourse
            // 
            this.listviewcourse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Numeroducours,
            this.Code,
            this.Titre});
            this.listviewcourse.HideSelection = false;
            this.listviewcourse.Location = new System.Drawing.Point(574, 279);
            this.listviewcourse.Name = "listviewcourse";
            this.listviewcourse.Size = new System.Drawing.Size(363, 180);
            this.listviewcourse.TabIndex = 36;
            this.listviewcourse.UseCompatibleStateImageBehavior = false;
            this.listviewcourse.View = System.Windows.Forms.View.Details;
            // 
            // Numeroducours
            // 
            this.Numeroducours.Text = "Numéro du cours";
            this.Numeroducours.Width = 120;
            // 
            // Code
            // 
            this.Code.Text = "Code";
            this.Code.Width = 80;
            // 
            // Titre
            // 
            this.Titre.Text = "Titre";
            this.Titre.Width = 85;
            // 
            // Afficher_cours
            // 
            this.Afficher_cours.Location = new System.Drawing.Point(938, 338);
            this.Afficher_cours.Name = "Afficher_cours";
            this.Afficher_cours.Size = new System.Drawing.Size(223, 25);
            this.Afficher_cours.TabIndex = 37;
            this.Afficher_cours.Text = "Afficher";
            this.Afficher_cours.UseVisualStyleBackColor = true;
            this.Afficher_cours.Click += new System.EventHandler(this.Afficher_cours_Click);
            // 
            // Afficher
            // 
            this.Afficher.Location = new System.Drawing.Point(938, 584);
            this.Afficher.Name = "Afficher";
            this.Afficher.Size = new System.Drawing.Size(223, 28);
            this.Afficher.TabIndex = 39;
            this.Afficher.Text = "Afficher";
            this.Afficher.UseVisualStyleBackColor = true;
            this.Afficher.Click += new System.EventHandler(this.Afficher_Click);
            // 
            // listviewnote
            // 
            this.listviewnote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Etud,
            this.cours,
            this.note});
            this.listviewnote.HideSelection = false;
            this.listviewnote.Location = new System.Drawing.Point(574, 537);
            this.listviewnote.Name = "listviewnote";
            this.listviewnote.Size = new System.Drawing.Size(358, 154);
            this.listviewnote.TabIndex = 40;
            this.listviewnote.UseCompatibleStateImageBehavior = false;
            this.listviewnote.View = System.Windows.Forms.View.Details;
            // 
            // Etud
            // 
            this.Etud.Text = "Numéro d\'étudiant";
            this.Etud.Width = 125;
            // 
            // cours
            // 
            this.cours.Text = "Numéro du cours";
            this.cours.Width = 120;
            // 
            // note
            // 
            this.note.Text = "Note";
            this.note.Width = 78;
            // 
            // student_id
            // 
            this.student_id.Location = new System.Drawing.Point(247, 193);
            this.student_id.Name = "student_id";
            this.student_id.Size = new System.Drawing.Size(201, 22);
            this.student_id.TabIndex = 41;
            this.student_id.TextChanged += new System.EventHandler(this._TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(145, 17);
            this.label13.TabIndex = 42;
            this.label13.Text = "Chercher un étudiant:";
            // 
            // buttonTXT
            // 
            this.buttonTXT.Location = new System.Drawing.Point(270, 484);
            this.buttonTXT.Name = "buttonTXT";
            this.buttonTXT.Size = new System.Drawing.Size(150, 25);
            this.buttonTXT.TabIndex = 43;
            this.buttonTXT.Text = "Générer le fichier txt\r\n\r\n";
            this.buttonTXT.UseVisualStyleBackColor = true;
            this.buttonTXT.Click += new System.EventHandler(this.buttonTXT_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialogue";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 743);
            this.Controls.Add(this.buttonTXT);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.student_id);
            this.Controls.Add(this.listviewnote);
            this.Controls.Add(this.Afficher);
            this.Controls.Add(this.Afficher_cours);
            this.Controls.Add(this.listviewcourse);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ProjetAQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader NumEtud;
        private System.Windows.Forms.ColumnHeader Prenom;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ListView listviewcourse;
        private System.Windows.Forms.ColumnHeader Numeroducours;
        private System.Windows.Forms.ColumnHeader Code;
        private System.Windows.Forms.ColumnHeader Titre;
        private System.Windows.Forms.Button Afficher_cours;
        private System.Windows.Forms.Button Afficher;
        private System.Windows.Forms.ListView listviewnote;
        private System.Windows.Forms.ColumnHeader Etud;
        private System.Windows.Forms.ColumnHeader cours;
        private System.Windows.Forms.ColumnHeader note;
        private System.Windows.Forms.TextBox student_id;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonTXT;
        private System.Windows.Forms.OpenFileDialog ofd1;
    }
}

