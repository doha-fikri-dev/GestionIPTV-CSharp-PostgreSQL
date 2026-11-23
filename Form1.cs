using Npgsql;
using System.Data;

namespace GestionIPTV
{
    public partial class Form1 : Form
    {
        int idClientSelectionne = 0;

        public Form1()
        {
            InitializeComponent();


        }

        private void ChargerClients()
        {
            using (NpgsqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = "SELECT * FROM Client";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, cn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvClients.DataSource = dt;
            }
        }




        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {

            try
            {
                using (NpgsqlConnection cn = Connexion.GetConnection())
                {
                    cn.Open();

                    string sql = @"INSERT INTO Client (nom, prenom, telephone, email)
                           VALUES (@nom, @prenom, @tel, @email)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                        cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                        cmd.Parameters.AddWithValue("@tel", txtTelephone.Text);
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Client ajouté avec succès !");
                ChargerClients();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void dgvClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow ligne = dgvClients.Rows[e.RowIndex];

                txtNom.Text = ligne.Cells["nom"].Value.ToString();
                txtPrenom.Text = ligne.Cells["prenom"].Value.ToString();
                txtTelephone.Text = ligne.Cells["telephone"].Value.ToString();
                txtEmail.Text = ligne.Cells["email"].Value.ToString();
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = @"UPDATE Client
                       SET nom = @nom,
                           prenom = @prenom,
                           telephone = @tel,
                           email = @email
                       WHERE id_client = @id";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                {
                    cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                    cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                    cmd.Parameters.AddWithValue("@tel", txtTelephone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);

                    // ID du client à modifier
                    cmd.Parameters.AddWithValue("@id", idClientSelectionne);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Client modifié avec succès !");
            ChargerClients();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (idClientSelectionne == 0)
            {
                MessageBox.Show("Veuillez sélectionner un client !");
                return;
            }

            DialogResult resultat = MessageBox.Show(
                "Voulez-vous vraiment supprimer ce client ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultat == DialogResult.Yes)
            {
                try
                {
                    using (NpgsqlConnection cn = Connexion.GetConnection())
                    {
                        cn.Open();

                        string sql = "DELETE FROM Client WHERE id_client = @id";

                        using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                        {
                            cmd.Parameters.AddWithValue("@id", idClientSelectionne);

                            int lignes = cmd.ExecuteNonQuery();

                            if (lignes > 0)
                            {
                                MessageBox.Show("Client supprimé avec succès !");
                                idClientSelectionne = 0;

                                txtNom.Clear();
                                txtPrenom.Clear();
                                txtTelephone.Clear();
                                txtEmail.Clear();

                                ChargerClients();
                            }
                            else
                            {
                                MessageBox.Show("Client introuvable !");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                }
            }
        }

        private void txtRecherche_TextChanged(object sender, EventArgs e)
        {
            using (NpgsqlConnection cn = Connexion.GetConnection())
            {
                cn.Open();

                string sql = "SELECT * FROM Client WHERE nom ILIKE @nom";

                using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, cn))
                {
                    da.SelectCommand.Parameters.AddWithValue(
                        "@nom", "%" + txtRecherche.Text + "%"
                    );

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvClients.DataSource = dt;
                }
            }
        }

        private void btnAbonnement_Click(object sender, EventArgs e)
        {
            FormAbonnement f = new FormAbonnement();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
