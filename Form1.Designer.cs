namespace GestionIPTV
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
            txtNom = new TextBox();
            lblNom = new Label();
            lblPrenom = new Label();
            txtPrenom = new TextBox();
            lblTelephone = new Label();
            txtTelephone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            lblRecherche = new Label();
            txtRecherche = new TextBox();
            dgvClients = new DataGridView();
            btnAbonnement = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // txtNom
            // 
            txtNom.Location = new Point(149, 26);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(150, 31);
            txtNom.TabIndex = 0;
            txtNom.TextChanged += txtNom_TextChanged;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(47, 32);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(52, 25);
            lblNom.TabIndex = 1;
            lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            lblPrenom.AutoSize = true;
            lblPrenom.Location = new Point(47, 83);
            lblPrenom.Name = "lblPrenom";
            lblPrenom.Size = new Size(74, 25);
            lblPrenom.TabIndex = 2;
            lblPrenom.Text = "Prénom";
            // 
            // txtPrenom
            // 
            txtPrenom.Location = new Point(159, 77);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(150, 31);
            txtPrenom.TabIndex = 3;
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new Point(47, 127);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new Size(92, 25);
            lblTelephone.TabIndex = 4;
            lblTelephone.Text = "Téléphone";
            // 
            // txtTelephone
            // 
            txtTelephone.Location = new Point(159, 121);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(150, 31);
            txtTelephone.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(47, 172);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(159, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 7;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(12, 284);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(112, 34);
            btnAjouter.TabIndex = 8;
            btnAjouter.Text = "\tAjouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(220, 284);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(112, 34);
            btnModifier.TabIndex = 9;
            btnModifier.Text = "\tModifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(9, 389);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(112, 34);
            btnSupprimer.TabIndex = 10;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // lblRecherche
            // 
            lblRecherche.AutoSize = true;
            lblRecherche.Location = new Point(478, 113);
            lblRecherche.Name = "lblRecherche";
            lblRecherche.Size = new Size(91, 25);
            lblRecherche.TabIndex = 11;
            lblRecherche.Text = "Recherche";
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(624, 107);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(438, 31);
            txtRecherche.TabIndex = 12;
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(478, 169);
            dgvClients.Name = "dgvClients";
            dgvClients.RowHeadersWidth = 62;
            dgvClients.Size = new Size(654, 280);
            dgvClients.TabIndex = 13;
            dgvClients.CellClick += dgvClients_CellClick;
            dgvClients.CellContentClick += dgvClients_CellContentClick;
            // 
            // btnAbonnement
            // 
            btnAbonnement.Location = new Point(186, 389);
            btnAbonnement.Name = "btnAbonnement";
            btnAbonnement.Size = new Size(252, 34);
            btnAbonnement.TabIndex = 14;
            btnAbonnement.Text = "Gestion des abonnements";
            btnAbonnement.UseVisualStyleBackColor = true;
            btnAbonnement.Click += btnAbonnement_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 588);
            Controls.Add(btnAbonnement);
            Controls.Add(dgvClients);
            Controls.Add(txtRecherche);
            Controls.Add(lblRecherche);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifier);
            Controls.Add(btnAjouter);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelephone);
            Controls.Add(lblTelephone);
            Controls.Add(txtPrenom);
            Controls.Add(lblPrenom);
            Controls.Add(lblNom);
            Controls.Add(txtNom);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNom;
        private Label lblNom;
        private Label lblPrenom;
        private TextBox txtPrenom;
        private Label lblTelephone;
        private TextBox txtTelephone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private Label lblRecherche;
        private TextBox txtRecherche;
        private DataGridView dgvClients;
        private Button btnAbonnement;
        private Button button1;
        private Button button2;
    }
}
