
namespace JBPanel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelEmp = new System.Windows.Forms.Label();
            this.empListBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnAnnuler);
            this.panel1.Controls.Add(this.btnConfirmer);
            this.panel1.Controls.Add(this.btnSup);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAnnuler.FlatAppearance.BorderSize = 0;
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnnuler.Image = global::JBPanel.Properties.Resources.close_adobespark;
            this.btnAnnuler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnnuler.Location = new System.Drawing.Point(9, 329);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(170, 35);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.BackColor = System.Drawing.Color.MediumBlue;
            this.btnConfirmer.FlatAppearance.BorderSize = 0;
            this.btnConfirmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConfirmer.Image = global::JBPanel.Properties.Resources.confirm_adobespark;
            this.btnConfirmer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmer.Location = new System.Drawing.Point(9, 279);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(170, 35);
            this.btnConfirmer.TabIndex = 4;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = false;
            this.btnConfirmer.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSup
            // 
            this.btnSup.BackColor = System.Drawing.Color.MediumBlue;
            this.btnSup.FlatAppearance.BorderSize = 0;
            this.btnSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSup.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSup.Image = global::JBPanel.Properties.Resources.delete_user_adobespark;
            this.btnSup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSup.Location = new System.Drawing.Point(9, 228);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(170, 35);
            this.btnSup.TabIndex = 3;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = false;
            this.btnSup.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.MediumBlue;
            this.btnModifier.FlatAppearance.BorderSize = 0;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModifier.Image = global::JBPanel.Properties.Resources.edit_adobespark;
            this.btnModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifier.Location = new System.Drawing.Point(9, 174);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(170, 35);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.MediumBlue;
            this.btnAjouter.FlatAppearance.BorderSize = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjouter.Image = global::JBPanel.Properties.Resources.add_user__2__adobespark;
            this.btnAjouter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.Location = new System.Drawing.Point(9, 122);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(170, 35);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BackgroundImage = global::JBPanel.Properties.Resources.bg;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 0;
            // 
            // labelEmp
            // 
            this.labelEmp.AutoSize = true;
            this.labelEmp.Location = new System.Drawing.Point(265, 31);
            this.labelEmp.Name = "labelEmp";
            this.labelEmp.Size = new System.Drawing.Size(74, 19);
            this.labelEmp.TabIndex = 1;
            this.labelEmp.Text = "Employees";
            // 
            // empListBox
            // 
            this.empListBox.FormattingEnabled = true;
            this.empListBox.Location = new System.Drawing.Point(368, 31);
            this.empListBox.Name = "empListBox";
            this.empListBox.Size = new System.Drawing.Size(192, 27);
            this.empListBox.TabIndex = 2;
            this.empListBox.SelectedIndexChanged += new System.EventHandler(this.empListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tel";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(368, 122);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(219, 26);
            this.tbNom.TabIndex = 7;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(368, 164);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(219, 26);
            this.tbPrenom.TabIndex = 8;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(368, 202);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(219, 26);
            this.tbEmail.TabIndex = 9;
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(368, 236);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(219, 26);
            this.tbTel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbTel);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empListBox);
            this.Controls.Add(this.labelEmp);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelEmp;
        private System.Windows.Forms.ComboBox empListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Button btnAnnuler;
    }
}

