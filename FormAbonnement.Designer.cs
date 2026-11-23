namespace GestionIPTV
{
    partial class FormAbonnement
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
            lblClient = new Label();
            cmbClient = new ComboBox();
            lblOffre = new Label();
            cmbOffre = new ComboBox();
            lblDateDebut = new Label();
            dtpDateDebut = new DateTimePicker();
            lblPrix = new Label();
            txtPrix = new TextBox();
            lblDateFin = new Label();
            dtpDateFin = new DateTimePicker();
            btnAjouter = new Button();
            dgvAbonnements = new DataGridView();
            btnAbonnement = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAbonnements).BeginInit();
            SuspendLayout();
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Location = new Point(44, 32);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(56, 25);
            lblClient.TabIndex = 0;
            lblClient.Text = "Client";
            // 
            // cmbClient
            // 
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(106, 29);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(182, 33);
            cmbClient.TabIndex = 1;
            // 
            // lblOffre
            // 
            lblOffre.AutoSize = true;
            lblOffre.Location = new Point(44, 81);
            lblOffre.Name = "lblOffre";
            lblOffre.Size = new Size(53, 25);
            lblOffre.TabIndex = 2;
            lblOffre.Text = "Offre";
            // 
            // cmbOffre
            // 
            cmbOffre.FormattingEnabled = true;
            cmbOffre.Location = new Point(106, 78);
            cmbOffre.Name = "cmbOffre";
            cmbOffre.Size = new Size(182, 33);
            cmbOffre.TabIndex = 3;
            cmbOffre.SelectedIndexChanged += cmbOffre_SelectedIndexChanged;
            // 
            // lblDateDebut
            // 
            lblDateDebut.AutoSize = true;
            lblDateDebut.Location = new Point(44, 126);
            lblDateDebut.Name = "lblDateDebut";
            lblDateDebut.Size = new Size(101, 25);
            lblDateDebut.TabIndex = 4;
            lblDateDebut.Text = "Date début";
            // 
            // dtpDateDebut
            // 
            dtpDateDebut.Location = new Point(167, 121);
            dtpDateDebut.Name = "dtpDateDebut";
            dtpDateDebut.Size = new Size(300, 31);
            dtpDateDebut.TabIndex = 5;
            dtpDateDebut.ValueChanged += dtpDateDebut_ValueChanged;
            // 
            // lblPrix
            // 
            lblPrix.AutoSize = true;
            lblPrix.Location = new Point(54, 179);
            lblPrix.Name = "lblPrix";
            lblPrix.Size = new Size(40, 25);
            lblPrix.TabIndex = 6;
            lblPrix.Text = "Prix";
            // 
            // txtPrix
            // 
            txtPrix.Location = new Point(167, 173);
            txtPrix.Name = "txtPrix";
            txtPrix.Size = new Size(150, 31);
            txtPrix.TabIndex = 7;
            // 
            // lblDateFin
            // 
            lblDateFin.AutoSize = true;
            lblDateFin.Location = new Point(54, 230);
            lblDateFin.Name = "lblDateFin";
            lblDateFin.Size = new Size(74, 25);
            lblDateFin.TabIndex = 8;
            lblDateFin.Text = "Date fin";
            // 
            // dtpDateFin
            // 
            dtpDateFin.Location = new Point(167, 224);
            dtpDateFin.Name = "dtpDateFin";
            dtpDateFin.Size = new Size(300, 31);
            dtpDateFin.TabIndex = 9;
            // 
            // btnAjouter
            // 
            btnAjouter.Location = new Point(65, 287);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(112, 34);
            btnAjouter.TabIndex = 10;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = true;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // dgvAbonnements
            // 
            dgvAbonnements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAbonnements.Location = new Point(516, 32);
            dgvAbonnements.Name = "dgvAbonnements";
            dgvAbonnements.RowHeadersWidth = 62;
            dgvAbonnements.Size = new Size(719, 292);
            dgvAbonnements.TabIndex = 11;
            // 
            // btnAbonnement
            // 
         
            // 
            // FormAbonnement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 450);
            Controls.Add(btnAbonnement);
            Controls.Add(dgvAbonnements);
            Controls.Add(btnAjouter);
            Controls.Add(dtpDateFin);
            Controls.Add(lblDateFin);
            Controls.Add(txtPrix);
            Controls.Add(lblPrix);
            Controls.Add(dtpDateDebut);
            Controls.Add(lblDateDebut);
            Controls.Add(cmbOffre);
            Controls.Add(lblOffre);
            Controls.Add(cmbClient);
            Controls.Add(lblClient);
            Name = "FormAbonnement";
            Text = "\tPrix";
            ((System.ComponentModel.ISupportInitialize)dgvAbonnements).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClient;
        private ComboBox cmbClient;
        private Label lblOffre;
        private ComboBox cmbOffre;
        private Label lblDateDebut;
        private DateTimePicker dtpDateDebut;
        private Label lblPrix;
        private TextBox txtPrix;
        private Label lblDateFin;
        private DateTimePicker dtpDateFin;
        private Button btnAjouter;
        private DataGridView dataGridView1;
        private DataGridView dgvAbonnements;
        private Button btnAbonnement;
    }
}