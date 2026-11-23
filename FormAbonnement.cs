using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Npgsql;
using System.Data;

namespace GestionIPTV
{
    public partial class FormAbonnement : Form
    {
        private void ChargerClients()
        {
            using (NpgsqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = "SELECT id_client, nom, prenom FROM Client";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                using (NpgsqlDataReader dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    cmbClient.DataSource = dt;
                    cmbClient.DisplayMember = "nom";
                    cmbClient.ValueMember = "id_client";
                }
            }



        }
        public FormAbonnement()
        {
            InitializeComponent();
            ChargerClients();
            ChargerOffres();
            ChargerAbonnements();

        }

        private void ChargerOffres()
        {
            using (NpgsqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = "SELECT id_offre, nom_offre, duree_mois, prix FROM Offre";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                using (NpgsqlDataReader dr = cmd.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    cmbOffre.DataSource = dt;
                    cmbOffre.DisplayMember = "nom_offre";
                    cmbOffre.ValueMember = "id_offre";
                }
            }
        }
        private void CalculerDateFin()
        {
            if (cmbOffre.SelectedItem != null)
            {
                DataRowView ligne = (DataRowView)cmbOffre.SelectedItem;

                int duree = Convert.ToInt32(ligne["duree_mois"]);

                dtpDateFin.Value = dtpDateDebut.Value.AddMonths(duree);
            }
        }



       

        private void cmbClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbOffre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOffre.SelectedItem != null)
            {
                DataRowView ligne = (DataRowView)cmbOffre.SelectedItem;

                txtPrix.Text = ligne["prix"].ToString();
            }
            CalculerDateFin();

        }

        private void dtpDateDebut_ValueChanged(object sender, EventArgs e)
        {
            CalculerDateFin();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = @"INSERT INTO Abonnement
        (id_client, id_offre, date_debut, date_fin, statut)
        VALUES
        (@client, @offre, @debut, @fin, @statut)";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@client",
                        Convert.ToInt32(cmbClient.SelectedValue));

                    cmd.Parameters.AddWithValue("@offre",
                        Convert.ToInt32(cmbOffre.SelectedValue));

                    cmd.Parameters.AddWithValue("@debut",
                        dtpDateDebut.Value.Date);

                    cmd.Parameters.AddWithValue("@fin",
                        dtpDateFin.Value.Date);

                    cmd.Parameters.AddWithValue("@statut", "Actif");

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Abonnement ajouté avec succès !");
        }

        private void ChargerAbonnements()
        {
            using (NpgsqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = @"
            SELECT a.id_abonnement,
                   c.nom,
                   c.prenom,
                   o.nom_offre,
                   a.date_debut,
                   a.date_fin,
                   a.statut
            FROM Abonnement a
            INNER JOIN Client c ON a.id_client = c.id_client
            INNER JOIN Offre o ON a.id_offre = o.id_offre
            ORDER BY a.id_abonnement";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, cn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvAbonnements.DataSource = dt;
                }
            }
        }


        private void FormAbonnement_Load(object sender, EventArgs e)
        {

        }
    }
}
