using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Configuration;

namespace Gestionnaire_Licences
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString());

        //Creation d'une liste d'objet licence
        List<Licence> lesLicences = new List<Licence>();
        //Creation d'une liste d'objet fonction
        List<Fonction> lesFonctions = new List<Fonction>();
        //Creation d'une liste d'objet integrateur
        List<Integrateur> lesIntegrateurs = new List<Integrateur>();
        //Creation d'une liste d'objet client
        List<Client> lesClients = new List<Client>();


        private void Form1_Load(object sender, EventArgs e)
        {
            //Suppressions des boutons du tabcontrol
            tc_Licences.Appearance = TabAppearance.FlatButtons;
            tc_Licences.ItemSize = new Size(0, 1);
            tc_Licences.SizeMode = TabSizeMode.Fixed;

            tc_Clients.Appearance = TabAppearance.FlatButtons;
            tc_Clients.ItemSize = new Size(0, 1);
            tc_Clients.SizeMode = TabSizeMode.Fixed;

            tc_Fonctions.Appearance = TabAppearance.FlatButtons;
            tc_Fonctions.ItemSize = new Size(0, 1);
            tc_Fonctions.SizeMode = TabSizeMode.Fixed;

            tc_Integrateurs.Appearance = TabAppearance.FlatButtons;
            tc_Integrateurs.ItemSize = new Size(0, 1);
            tc_Integrateurs.SizeMode = TabSizeMode.Fixed;

            //Remplie les DataGridViews de l'application
            fill_dgv_Licences();
            fill_dgv_Integrateurs();
            fill_dgv_Clients();
            fill_dgv_Fonctions();
        }

        //Pour la date de creation d'une licence
        private void Timer_DateCreation_Tick(object sender, EventArgs e)
        {
            //Met la date du jour sur chaque champ où la date est un saisie automatique
            tb_DateCreation.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_C_DateMiseAJourClient.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_C_DateMiseAJourFonction.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_C_DateMiseAJour_Integrateur.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_U_DateMiseAJourClient.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_U_DateMiseAJourFonction.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_U_DateMiseAJourInteg.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }


        //Remet a jour (depuis la bdd) les listes, les datagridview et les classes
        private void fill_dgv_Licences()
        {
            //Definition de la procédure stockée
            SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.get_Licences", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Alimentation de la DataGridView
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgv_Licences.DataSource = dt;

            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                lesLicences.Clear();
                #region lecture des licences
                while (rdr.Read())
                {
                    int ID = Convert.ToInt32(rdr[0]);
                    DateTime Date_creation = Convert.ToDateTime(rdr[1]);
                    DateTime Date_expiration = Convert.ToDateTime(rdr[2]);
                    int Nb_equipements = Convert.ToInt32(rdr[3]);
                    int Nb_variables = Convert.ToInt32(rdr[4]);
                    string Checksum = Convert.ToString(rdr[5]);
                    int Code_integrateur = Convert.ToInt32(rdr[6]);
                    int Code_client = Convert.ToInt32(rdr[7]);
                    int Code_fonction1 = 0;
                    int Code_fonction2 = 0;
                    int Code_fonction3 = 0;
                    int Code_fonction4 = 0;
                    int Code_fonction5 = 0;
                    int Code_fonction6 = 0;
                    int Code_fonction7 = 0;
                    int Code_fonction8 = 0;
                    int Code_fonction9 = 0;
                    int Code_fonction10 = 0;
                    int Code_fonction11 = 0;
                    int Code_fonction12 = 0;
                    int Code_fonction13 = 0;
                    int Code_fonction14 = 0;
                    int Code_fonction15 = 0;
                    int Code_fonction16 = 0;
                    int Code_fonction17 = 0;
                    int Code_fonction18 = 0;
                    int Code_fonction19 = 0;
                    int Code_fonction20 = 0;
                    if (rdr[8].ToString() != "")
                    {
                        Code_fonction1 = Convert.ToInt32(rdr[8]);
                    }
                    if (rdr[9].ToString() != "")
                    {
                        Code_fonction2 = Convert.ToInt32(rdr[9]);
                    }
                    if (rdr[10].ToString() != "")
                    {
                        Code_fonction3 = Convert.ToInt32(rdr[10]);
                    }
                    if (rdr[11].ToString() != "")
                    {
                        Code_fonction4 = Convert.ToInt32(rdr[11]);
                    }
                    if (rdr[12].ToString() != "")
                    {
                        Code_fonction5 = Convert.ToInt32(rdr[12]);
                    }
                    if (rdr[13].ToString() != "")
                    {
                        Code_fonction6 = Convert.ToInt32(rdr[13]);
                    }
                    if (rdr[14].ToString() != "")
                    {
                        Code_fonction7 = Convert.ToInt32(rdr[14]);
                    }
                    if (rdr[15].ToString() != "")
                    {
                        Code_fonction8 = Convert.ToInt32(rdr[15]);
                    }
                    if (rdr[16].ToString() != "")
                    {
                        Code_fonction9 = Convert.ToInt32(rdr[16]);
                    }
                    if (rdr[17].ToString() != "")
                    {
                        Code_fonction10 = Convert.ToInt32(rdr[17]);
                    }
                    if (rdr[18].ToString() != "")
                    {
                        Code_fonction11 = Convert.ToInt32(rdr[18]);
                    }
                    if (rdr[19].ToString() != "")
                    {
                        Code_fonction12 = Convert.ToInt32(rdr[19]);
                    }
                    if (rdr[20].ToString() != "")
                    {
                        Code_fonction13 = Convert.ToInt32(rdr[20]);
                    }
                    if (rdr[21].ToString() != "")
                    {
                        Code_fonction14 = Convert.ToInt32(rdr[21]);
                    }
                    if (rdr[22].ToString() != "")
                    {
                        Code_fonction15 = Convert.ToInt32(rdr[22]);
                    }
                    if (rdr[23].ToString() != "")
                    {
                        Code_fonction16 = Convert.ToInt32(rdr[23]);
                    }
                    if (rdr[24].ToString() != "")
                    {
                        Code_fonction17 = Convert.ToInt32(rdr[24]);
                    }
                    if (rdr[25].ToString() != "")
                    {
                        Code_fonction18 = Convert.ToInt32(rdr[25]);
                    }
                    if (rdr[26].ToString() != "")
                    {
                        Code_fonction19 = Convert.ToInt32(rdr[26]);
                    }
                    if (rdr[27].ToString() != "")
                    {
                        Code_fonction20 = Convert.ToInt32(rdr[27]);
                    }
                    Licence newLicence = new Licence(ID, Date_creation, Date_expiration, Nb_equipements, Nb_variables, Checksum, Code_integrateur, Code_client
                        , Code_fonction1, Code_fonction2, Code_fonction3, Code_fonction4, Code_fonction5, Code_fonction6, Code_fonction7, Code_fonction8, Code_fonction9, Code_fonction10
                        , Code_fonction11, Code_fonction12, Code_fonction13, Code_fonction14, Code_fonction15, Code_fonction16, Code_fonction17, Code_fonction18, Code_fonction19, Code_fonction20);
                    lesLicences.Add(newLicence);
                }
                #endregion
                con.Close();
            } catch (Exception err)
            {
                MessageBox.Show("Erreur lecture/récuperation des licences : " + err.Message);
            }
        }
        private void fill_dgv_Integrateurs()
        {
            //Definition de la procédure stockée
            SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.get_Integrateurs", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Alimentation de la DataGridView
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgv_Integrateurs.DataSource = dt;
            dgv_Integrateurs.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Licence_AllIntegrateurs.DataSource = dt;
            dgv_Licence_AllIntegrateurs2.DataSource = dt;

            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                lesIntegrateurs.Clear();
                #region lecture des integrateurs
                while (rdr.Read())
                {
                    int ID = Convert.ToInt32(rdr[0]);
                    string Nom = Convert.ToString(rdr[1]);
                    DateTime Date_update = Convert.ToDateTime(rdr[2]);
                    string Description = Convert.ToString(rdr[3]);
                    Integrateur newIntegrateur = new Integrateur(ID, Nom, Date_update, Description);
                    lesIntegrateurs.Add(newIntegrateur);
                }
                #endregion
                con.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur lecture/récuperation des Integrateurs : " + err.Message);
            }
        }
        private void fill_dgv_Clients()
        {
            //Definition de la procédure stockée
            SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.get_Clients", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Alimentation de la DataGridView
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgv_Clients.DataSource = dt;
            dgv_Clients.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Licence_AllClients.DataSource = dt;
            dgv_Licence_AllClients2.DataSource = dt;

            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                lesClients.Clear();
                #region lecture des clients
                while (rdr.Read())
                {
                    int ID = Convert.ToInt32(rdr[0]);
                    string Nom = Convert.ToString(rdr[1]);
                    DateTime Date_update = Convert.ToDateTime(rdr[2]);
                    string Description = Convert.ToString(rdr[3]);
                    Client newClient = new Client(ID, Nom, Date_update, Description);
                    lesClients.Add(newClient);
                }
                #endregion
                con.Close();
            } catch(Exception err)
            {
                MessageBox.Show("Erreur lecture/récupération des Clients : " + err.Message);
            }
        }
        private void fill_dgv_Fonctions()
        {
            //Definition de la procédure stockée
            SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.get_Fonctions", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //Alimentation de la DataGridView
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dgv_Fonctions.DataSource = dt;
            dgv_Fonctions.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_Licence_AllFonctions.DataSource = dt;
            dgv_Licence_AllFonctions2.DataSource = dt;

            try
            {
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                lesFonctions.Clear();
                #region lecture des Fonctions
                while (rdr.Read())
                {
                    int ID = Convert.ToInt32(rdr[0]);
                    string Nom = Convert.ToString(rdr[1]);
                    DateTime Date_update = Convert.ToDateTime(rdr[2]);
                    string Description = Convert.ToString(rdr[3]);
                    Fonction newFonction = new Fonction(ID, Nom, Date_update, Description);
                    lesFonctions.Add(newFonction);
                }
                #endregion
                con.Close();
            } catch(Exception err)
            {
                MessageBox.Show("Erreur lecture/récupération des Fonction : " + err.Message);
            }
        }

        //Permet de revenir sur la page précedente
        private void retour(object sender, EventArgs e)
        {
            if (sender == btn_RetourLicence)
            {
                tc_Licences.Height = 493;
                dgv_Licence_AllClients2.Visible = true;
                dgv_Licence_AllFonctions2.Visible = true;
                dgv_Licence_AllIntegrateurs2.Visible = true;
                lb_dgv_AllClients2.Visible = true;
                lb_dgv_AllFonctions2.Visible = true;
                lb_dgv_AllIntegrateurs2.Visible = true;
                tc_Licences.SelectedIndex = 0;
            }
            if (sender == btn_RetourInteg)
            {
                tc_Integrateurs.SelectedIndex = 0;
            }
            if (sender == btn_RetourClient)
            {
                tc_Clients.SelectedIndex = 0;
            } if (sender == btn_RetourFonction)
            {
                tc_Fonctions.SelectedIndex = 0;
            }
        }


        //CRUD Licences
        private void create_Licence(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.create_Licence", con);
                cmd.CommandType = CommandType.StoredProcedure;
                DateTime Date_creation = Convert.ToDateTime(tb_DateCreation.Text);
                DateTime Date_expiration = Convert.ToDateTime(dtp_C_DateExpirationLicence.Value.ToString("dd/MM/yyyy"));
                int Nb_equipements = Convert.ToInt32(tb_NbEquipepments.Text);
                int Nb_variables = Convert.ToInt32(tb_NbVariables.Text);
                string Checksum = Convert.ToString(tb_Checksum.Text);
                int Code_integrateur = Convert.ToInt32(tb_CodeIntegrateur.Text);
                int Code_client = Convert.ToInt32(tb_CodeClient.Text);
                char[] charsToTrim = { ' ' };


                cmd.Parameters.Add("@Date_creation", SqlDbType.DateTime).Value = Date_creation;
                cmd.Parameters.Add("@Date_expiration", SqlDbType.DateTime).Value = Date_expiration;
                cmd.Parameters.Add("@Nb_equipements", SqlDbType.Int).Value = Nb_equipements;
                cmd.Parameters.Add("@Nb_variables", SqlDbType.Int).Value = Nb_variables;
                cmd.Parameters.Add("@Checksum", SqlDbType.VarChar).Value = Checksum;
                cmd.Parameters.Add("@Code_integrateur", SqlDbType.Int).Value = Code_integrateur;
                cmd.Parameters.Add("@Code_client", SqlDbType.Int).Value = Code_client;

                #region parametres code_fonctionX
                if (tb_CodeFonction1.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction1", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction1", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction1.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction2.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction2", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction2", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction2.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction3.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction3", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction3", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction3.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction4.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction4", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction4", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction4.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction5.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction5", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction5", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction5.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction6.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction6", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction6", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction6.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction7.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction7", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction7", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction7.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction8.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction8", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction8", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction8.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction9.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction9", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction9", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction9.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction10.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction10", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction10", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction10.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction11.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction11", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction11", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction11.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction12.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction12", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction12", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction12.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction13.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction13", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction13", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction13.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction14.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction14", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction14", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction14.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction15.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction15", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction15", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction15.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction16.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction16", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction16", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction16.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction17.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction17", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction17", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction17.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction18.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction18", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction18", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction18.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction19.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction19", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction19", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction19.Text.Trim(charsToTrim));
                }

                if (tb_CodeFonction20.Text.Trim(charsToTrim) == "")
                {
                    cmd.Parameters.Add("@Code_fonction20", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction20", SqlDbType.Int).Value = Convert.ToInt32(tb_CodeFonction20.Text.Trim(charsToTrim));
                }

                #endregion
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                fill_dgv_Licences();
            } catch(Exception err)
            {
                MessageBox.Show("Erreur create licence : " + err.Message);
            }
        }
        private void Delete_Licence(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(tb_R_IDLicence.Text);
            //Definition de la procédure stockée
            SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.delete_Licence", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            fill_dgv_Licences();
            tc_Licences.Height = 493;
            dgv_Licence_AllClients2.Visible = true;
            dgv_Licence_AllFonctions2.Visible = true;
            dgv_Licence_AllIntegrateurs2.Visible = true;
            lb_dgv_AllClients2.Visible = true;
            lb_dgv_AllFonctions2.Visible = true;
            lb_dgv_AllIntegrateurs2.Visible = true;
            tc_Licences.SelectedIndex = 0;
        }
        private void Update_Licence(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.update_Licence", con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Convert.ToInt32(tb_R_IDLicence.Text);
                cmd.Parameters.Add("@Date_expiration", SqlDbType.DateTime).Value = Convert.ToDateTime(dtp_U_DateExpirationLicence.Value.ToString("dd/MM/yyyy"));
                cmd.Parameters.Add("@Nb_equipements", SqlDbType.Int).Value = Convert.ToInt32(tb_C_NbrEquipements.Text);
                cmd.Parameters.Add("@Nb_variables", SqlDbType.Int).Value = Convert.ToInt32(tb_C_NbrVariables.Text);
                cmd.Parameters.Add("@Checksum", SqlDbType.VarChar).Value = Convert.ToString(tb_C_Checksum.Text);
                cmd.Parameters.Add("@Code_integrateur", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeIntegrateur.Text);
                cmd.Parameters.Add("@Code_client", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeClient.Text);
                char[] charsToTrim = { ' ' };


                #region Parametres code fonction
                if (tb_C_CodeFonction1.Text.Trim(charsToTrim) == "" | tb_C_CodeFonction1.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction1", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction1", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction1.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction2.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction2.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction2", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction2", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction2.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction3.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction3.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction3", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction3", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction3.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction4.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction4.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction4", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction4", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction4.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction5.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction5.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction5", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction5", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction5.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction6.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction6.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction6", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction6", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction6.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction7.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction7.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction7", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction7", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction7.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction8.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction8.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction8", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction8", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction8.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction9.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction9.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction9", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction9", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction9.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction10.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction10.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction10", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction10", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction10.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction11.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction11.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction11", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction11", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction11.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction12.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction12.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction12", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction12", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction12.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction13.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction13.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction13", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction13", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction13.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction14.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction14.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction14", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction14", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction14.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction15.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction15.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction15", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction15", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction15.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction16.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction16.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction16", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction16", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction16.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction17.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction17.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction17", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction17", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction17.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction18.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction18.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction18", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction18", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction18.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction19.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction19.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction19", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction19", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction19.Text.Trim(charsToTrim));
                }

                if (tb_C_CodeFonction20.Text.Trim(charsToTrim) == "" || tb_C_CodeFonction20.Text.Trim(charsToTrim) == "0")
                {
                    cmd.Parameters.Add("@Code_fonction20", SqlDbType.Int).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@Code_fonction20", SqlDbType.Int).Value = Convert.ToInt32(tb_C_CodeFonction20.Text.Trim(charsToTrim));
                }
                #endregion

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                fill_dgv_Licences();
                tc_Licences.SelectedIndex = 0;

            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur update licence : " + err.Message);
            }
        }
        private void Dgv_Licences_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(dgv_Licences.Rows[e.RowIndex].Cells[0].Value);
            tc_Licences.SelectedIndex = 1;
            tc_Licences.Height = 580;
            dgv_Licence_AllClients2.Visible = false;
            dgv_Licence_AllFonctions2.Visible = false;
            dgv_Licence_AllIntegrateurs2.Visible = false;

            lb_dgv_AllClients2.Visible = false;
            lb_dgv_AllFonctions2.Visible = false;
            lb_dgv_AllIntegrateurs2.Visible = false;

            tb_R_IDLicence.Text = ID.ToString();
            foreach (Licence licence in lesLicences)
            {
                if (licence.ID == ID)
                {
                    #region alimentation des tb_CodeFonction
                    tb_R_CodeFonction1.Text = licence.Code_fonction1.ToString() + ". " + getFonctionName(licence.Code_fonction1);
                    tb_R_CodeFonction2.Text = licence.Code_fonction2.ToString() + ". " + getFonctionName(licence.Code_fonction2);
                    tb_R_CodeFonction3.Text = licence.Code_fonction3.ToString() + ". " + getFonctionName(licence.Code_fonction3);
                    tb_R_CodeFonction4.Text = licence.Code_fonction4.ToString() + ". " + getFonctionName(licence.Code_fonction4);
                    tb_R_CodeFonction5.Text = licence.Code_fonction5.ToString() + ". " + getFonctionName(licence.Code_fonction5);
                    tb_R_CodeFonction6.Text = licence.Code_fonction6.ToString() + ". " + getFonctionName(licence.Code_fonction6);
                    tb_R_CodeFonction7.Text = licence.Code_fonction7.ToString() + ". " + getFonctionName(licence.Code_fonction7);
                    tb_R_CodeFonction8.Text = licence.Code_fonction8.ToString() + ". " + getFonctionName(licence.Code_fonction8);
                    tb_R_CodeFonction9.Text = licence.Code_fonction9.ToString() + ". " + getFonctionName(licence.Code_fonction9);
                    tb_R_CodeFonction10.Text = licence.Code_fonction10.ToString() + ". " + getFonctionName(licence.Code_fonction10);
                    tb_R_CodeFonction11.Text = licence.Code_fonction11.ToString() + ". " + getFonctionName(licence.Code_fonction11);
                    tb_R_CodeFonction12.Text = licence.Code_fonction12.ToString() + ". " + getFonctionName(licence.Code_fonction12);
                    tb_R_CodeFonction13.Text = licence.Code_fonction13.ToString() + ". " + getFonctionName(licence.Code_fonction13);
                    tb_R_CodeFonction14.Text = licence.Code_fonction14.ToString() + ". " + getFonctionName(licence.Code_fonction14);
                    tb_R_CodeFonction15.Text = licence.Code_fonction15.ToString() + ". " + getFonctionName(licence.Code_fonction15);
                    tb_R_CodeFonction16.Text = licence.Code_fonction16.ToString() + ". " + getFonctionName(licence.Code_fonction16);
                    tb_R_CodeFonction17.Text = licence.Code_fonction17.ToString() + ". " + getFonctionName(licence.Code_fonction17);
                    tb_R_CodeFonction18.Text = licence.Code_fonction18.ToString() + ". " + getFonctionName(licence.Code_fonction18);
                    tb_R_CodeFonction19.Text = licence.Code_fonction19.ToString() + ". " + getFonctionName(licence.Code_fonction19);
                    tb_R_CodeFonction20.Text = licence.Code_fonction20.ToString() + ". " + getFonctionName(licence.Code_fonction20);

                    tb_C_CodeFonction1.Text = licence.Code_fonction1.ToString();
                    tb_C_CodeFonction2.Text = licence.Code_fonction2.ToString();
                    tb_C_CodeFonction3.Text = licence.Code_fonction3.ToString();
                    tb_C_CodeFonction4.Text = licence.Code_fonction4.ToString();
                    tb_C_CodeFonction5.Text = licence.Code_fonction5.ToString();
                    tb_C_CodeFonction6.Text = licence.Code_fonction6.ToString();
                    tb_C_CodeFonction7.Text = licence.Code_fonction7.ToString();
                    tb_C_CodeFonction8.Text = licence.Code_fonction8.ToString();
                    tb_C_CodeFonction9.Text = licence.Code_fonction9.ToString();
                    tb_C_CodeFonction10.Text = licence.Code_fonction10.ToString();
                    tb_C_CodeFonction11.Text = licence.Code_fonction11.ToString();
                    tb_C_CodeFonction12.Text = licence.Code_fonction12.ToString();
                    tb_C_CodeFonction13.Text = licence.Code_fonction13.ToString();
                    tb_C_CodeFonction14.Text = licence.Code_fonction14.ToString();
                    tb_C_CodeFonction15.Text = licence.Code_fonction15.ToString();
                    tb_C_CodeFonction16.Text = licence.Code_fonction16.ToString();
                    tb_C_CodeFonction17.Text = licence.Code_fonction17.ToString();
                    tb_C_CodeFonction18.Text = licence.Code_fonction18.ToString();
                    tb_C_CodeFonction19.Text = licence.Code_fonction19.ToString();
                    tb_C_CodeFonction20.Text = licence.Code_fonction20.ToString();
                    #endregion

                    dtp_R_DateExpirationLicence.Value = Convert.ToDateTime(licence.Date_expiration.ToString("dd/MM/yyyy"));
                    tb_R_Licence_DateCreation.Text = licence.Date_creation.ToString("dd/MM/yyyy");
                    tb_R_NbrEquipements.Text = licence.Nb_equipements.ToString();
                    tb_R_NbrVariables.Text = licence.Nb_variables.ToString();
                    tb_R_CodeIntegrateur.Text = licence.Code_integrateur.ToString();
                    tb_R_CodeClient.Text = licence.Code_client.ToString();
                    tb_R_Checksum.Text = licence.Checksum.ToString();

                    tb_C_Checksum.Text = licence.Checksum.ToString();
                    tb_C_NbrEquipements.Text = licence.Nb_equipements.ToString();
                    tb_C_NbrVariables.Text = licence.Nb_variables.ToString();
                    tb_C_CodeIntegrateur.Text = licence.Code_integrateur.ToString();
                    tb_C_CodeClient.Text = licence.Code_client.ToString();
                    dtp_U_DateExpirationLicence.Value = Convert.ToDateTime(licence.Date_expiration.ToString("dd/MM/yyyy"));
                }
            }
        }

        //CRUD Integrateurs
        private void create_Integrateur(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.create_Integrateur", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Convert.ToString(tb_C_NomIntegrateur.Text);
                cmd.Parameters.Add("@Date_update", SqlDbType.DateTime).Value = Convert.ToDateTime(tb_C_DateMiseAJour_Integrateur.Text);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Convert.ToString(tb_C_DescriptionIntegrateur.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                fill_dgv_Integrateurs();
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur create integrateur : " + err.Message);
            }
        }
        private void delete_Integrateur(object sender, EventArgs e)
        {
            int Code_integrateur = Convert.ToInt32(tb_R_CodeInteg.Text);
            SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.delete_Integrateur", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Code_integrateur", SqlDbType.Int).Value = Code_integrateur;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            fill_dgv_Integrateurs();
            tc_Integrateurs.SelectedIndex = 0;
        }
        private void update_Integrateur(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.update_Integrateur", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                int Code_integrateur = Convert.ToInt32(tb_R_CodeInteg.Text);
                String Nom = Convert.ToString(tb_U_NomInteg.Text);
                String Description = Convert.ToString(tb_U_DescriptionInteg.Text);
                DateTime Date_update = Convert.ToDateTime(tb_U_DateMiseAJourInteg.Text);

                cmd.Parameters.Add("@Code_integrateur", SqlDbType.Int).Value = Code_integrateur;
                cmd.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Nom;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Description;
                cmd.Parameters.Add("@Date_update", SqlDbType.DateTime).Value = Date_update;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                fill_dgv_Integrateurs();
                tc_Integrateurs.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur update intgrateur : " + err.Message);
            }
        }
        private void Dgv_Integrateurs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Code_integrateur = Convert.ToInt32(dgv_Integrateurs.Rows[e.RowIndex].Cells[0].Value);
            foreach (Integrateur integrateur in lesIntegrateurs)
            {
                if (integrateur.codeIntegrateur == Code_integrateur)
                {
                    tb_R_CodeInteg.Text = integrateur.codeIntegrateur.ToString();
                    tb_R_NomInteg.Text = integrateur.nom.ToString();
                    tb_R_DescriptionInteg.Text = integrateur.description.ToString();
                    tb_R_DateMiseAJourInteg.Text = integrateur.dateUpdate.ToString("dd/MM/yyyy");

                    tb_U_NomInteg.Text = integrateur.nom.ToString();
                    tb_U_DescriptionInteg.Text = integrateur.description.ToString();
                }
            }
            tc_Integrateurs.SelectedIndex = 1;
        }

        //CRUD Clients
        private void create_Client(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.create_Client", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Convert.ToString(tb_C_NomClient.Text);
                cmd.Parameters.Add("@Date_update", SqlDbType.DateTime).Value = Convert.ToDateTime(tb_C_DateMiseAJourClient.Text);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Convert.ToString(tb_C_DescriptionClient.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                fill_dgv_Clients();
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur create Client : " + err.Message);
            }
        }
        private void delete_Client(object sender, EventArgs e)
        {
            int Code_client = Convert.ToInt32(tb_R_CodeCli.Text);
            SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.delete_Client", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Code_client", SqlDbType.Int).Value = Code_client;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            fill_dgv_Clients();
            tc_Clients.SelectedIndex = 0;
        }
        private void update_Client(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.update_Client", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                int Code_client = Convert.ToInt32(tb_R_CodeCli.Text);
                String Nom = Convert.ToString(tb_U_NomClient.Text);
                String Description = Convert.ToString(tb_U_DescriptionClient.Text);
                DateTime Date_update = Convert.ToDateTime(tb_U_DateMiseAJourClient.Text);

                cmd.Parameters.Add("@Code_Client", SqlDbType.Int).Value = Code_client;
                cmd.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Nom;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Description;
                cmd.Parameters.Add("@Date_update", SqlDbType.DateTime).Value = Date_update;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                fill_dgv_Clients();
                tc_Clients.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur update intgrateur : " + err.Message);
            }
        }
        private void Dgv_Clients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Code_client = Convert.ToInt32(dgv_Clients.Rows[e.RowIndex].Cells[0].Value);
            foreach (Client client in lesClients)
            {
                if (client.codeClient == Code_client)
                {
                    tb_R_CodeCli.Text = client.codeClient.ToString();
                    tb_R_NomClient.Text = client.nom.ToString();
                    tb_R_Description_Client.Text = client.description.ToString();
                    tb_R_DateMiseAJourClient.Text = client.dateUpdate.ToString("dd/MM/yyyy");

                    tb_U_NomClient.Text = client.nom.ToString();
                    tb_U_DescriptionClient.Text = client.description.ToString();
                }
            }
            tc_Clients.SelectedIndex = 1;
        }

        //CRUD Fonctions
        private void create_Fonction(object sender, EventArgs e)
        {

            try
            {
                SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.create_Fonction", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Convert.ToString(tb_C_NomFonction.Text);
                cmd.Parameters.Add("@Date_update", SqlDbType.DateTime).Value = Convert.ToDateTime(tb_C_DateMiseAJourFonction.Text);
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Convert.ToString(tb_C_DescriptionFonction.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                fill_dgv_Fonctions();
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur create Fonction : " + err.Message);
            }
        }
        private void delete_Fonction(object sender, EventArgs e)
        {
            int Code_fonction = Convert.ToInt32(tb_R_CodeFonction.Text);
            SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.delete_Fonction", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Code_Fonction", SqlDbType.Int).Value = Code_fonction;

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            fill_dgv_Fonctions();
            tc_Fonctions.SelectedIndex = 0;
        }
        private void update_Fonction(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Base_NewLicences.dbo.update_Fonction", con);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                int Code_fonction = Convert.ToInt32(tb_R_CodeFonction.Text);
                String Nom = Convert.ToString(tb_U_NomFonction.Text);
                String Description = Convert.ToString(tb_U_DescriptionFonction.Text);
                DateTime Date_update = Convert.ToDateTime(tb_U_DateMiseAJourFonction.Text);

                cmd.Parameters.Add("@Code_fonction", SqlDbType.Int).Value = Code_fonction;
                cmd.Parameters.Add("@Nom", SqlDbType.VarChar).Value = Nom;
                cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = Description;
                cmd.Parameters.Add("@Date_update", SqlDbType.DateTime).Value = Date_update;

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                fill_dgv_Fonctions();
                tc_Fonctions.SelectedIndex = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show("Erreur update Fonction : " + err.Message);
            }
        }
        private void Dgv_Fonctions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Code_fonction = Convert.ToInt32(dgv_Fonctions.Rows[e.RowIndex].Cells[0].Value);
            foreach (Fonction fonction in lesFonctions)
            {
                if (fonction.codeFonction == Code_fonction)
                {
                    tb_R_CodeFonction.Text = fonction.codeFonction.ToString();
                    tb_R_NomFonction.Text = fonction.nom.ToString();
                    tb_R_DescriptionFonction.Text = fonction.description.ToString();
                    tb_R_DateMiseAJourFonction.Text = fonction.dateUpdate.ToString("dd/MM/yyyy");

                    tb_U_NomFonction.Text = fonction.nom.ToString();
                    tb_U_DescriptionFonction.Text = fonction.description.ToString();
                }
            }
            tc_Fonctions.SelectedIndex = 1;
        }


        //Utilisation interactif des datagridview (Aide saisie utilisateur quand double clique sur element, met la valeur dans la case)
        private void Dgv_Licence_AllFonctions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Code_fonction = Convert.ToInt32(dgv_Licence_AllFonctions.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (tb_C_CodeFonction1.Text == "0")
            {
                tb_C_CodeFonction1.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction2.Text == "0")
            {
                tb_C_CodeFonction2.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction3.Text == "0")
            {
                tb_C_CodeFonction3.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction4.Text == "0")
            {
                tb_C_CodeFonction4.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction5.Text == "0")
            {
                tb_C_CodeFonction5.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction6.Text == "0")
            {
                tb_C_CodeFonction6.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction7.Text == "0")
            {
                tb_C_CodeFonction7.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction8.Text == "0")
            {
                tb_C_CodeFonction8.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction9.Text == "0")
            {
                tb_C_CodeFonction9.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction10.Text == "0")
            {
                tb_C_CodeFonction10.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction11.Text == "0")
            {
                tb_C_CodeFonction11.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction12.Text == "0")
            {
                tb_C_CodeFonction12.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction13.Text == "0")
            {
                tb_C_CodeFonction13.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction14.Text == "0")
            {
                tb_C_CodeFonction14.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction15.Text == "0")
            {
                tb_C_CodeFonction15.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction16.Text == "0")
            {
                tb_C_CodeFonction16.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction17.Text == "0")
            {
                tb_C_CodeFonction17.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction18.Text == "0")
            {
                tb_C_CodeFonction18.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction19.Text == "0")
            {
                tb_C_CodeFonction19.Text = Code_fonction.ToString();
            }
            else if (tb_C_CodeFonction20.Text == "0")
            {
                tb_C_CodeFonction20.Text = Code_fonction.ToString();
            }
        }
        private void Dgv_Licence_AllIntegrateurs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_C_CodeIntegrateur.Text = dgv_Licence_AllIntegrateurs.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void Dgv_Licence_AllClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_C_CodeClient.Text = dgv_Licence_AllClients.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void Dgv_Licence_AllIntegrateurs2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_CodeIntegrateur.Text = dgv_Licence_AllIntegrateurs2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void Dgv_Licence_AllClients2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_CodeClient.Text = dgv_Licence_AllClients2.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void Dgv_Licence_AllFonctions2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Code_fonction = Convert.ToInt32(dgv_Licence_AllFonctions2.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (tb_CodeFonction1.Text == "")
            {
                tb_CodeFonction1.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction2.Text == "")
            {
                tb_CodeFonction2.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction3.Text == "")
            {
                tb_CodeFonction3.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction4.Text == "")
            {
                tb_CodeFonction4.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction5.Text == "")
            {
                tb_CodeFonction5.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction6.Text == "")
            {
                tb_CodeFonction6.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction7.Text == "")
            {
                tb_CodeFonction7.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction8.Text == "")
            {
                tb_CodeFonction8.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction9.Text == "")
            {
                tb_CodeFonction9.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction10.Text == "")
            {
                tb_CodeFonction10.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction11.Text == "")
            {
                tb_CodeFonction11.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction12.Text == "")
            {
                tb_CodeFonction12.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction13.Text == "")
            {
                tb_CodeFonction13.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction14.Text == "")
            {
                tb_CodeFonction14.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction15.Text == "")
            {
                tb_CodeFonction15.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction16.Text == "")
            {
                tb_CodeFonction16.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction17.Text == "")
            {
                tb_CodeFonction17.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction18.Text == "")
            {
                tb_CodeFonction18.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction19.Text == "")
            {
                tb_CodeFonction19.Text = Code_fonction.ToString();
            }
            else if (tb_CodeFonction20.Text == "")
            {
                tb_CodeFonction20.Text = Code_fonction.ToString();
            }
        }


        //Fonctionnalitées supplémentaires
        private void ResetUpdateLicence(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(tb_R_IDLicence.Text);
            foreach (Licence licence in lesLicences)
            {
                if (licence.ID == ID)
                {
                    #region alimentation des tb_CodeFoncion
                    tb_C_CodeFonction1.Text = licence.Code_fonction1.ToString();
                    tb_C_CodeFonction2.Text = licence.Code_fonction2.ToString();
                    tb_C_CodeFonction3.Text = licence.Code_fonction3.ToString();
                    tb_C_CodeFonction4.Text = licence.Code_fonction4.ToString();
                    tb_C_CodeFonction5.Text = licence.Code_fonction5.ToString();
                    tb_C_CodeFonction6.Text = licence.Code_fonction6.ToString();
                    tb_C_CodeFonction7.Text = licence.Code_fonction7.ToString();
                    tb_C_CodeFonction8.Text = licence.Code_fonction8.ToString();
                    tb_C_CodeFonction9.Text = licence.Code_fonction9.ToString();
                    tb_C_CodeFonction10.Text = licence.Code_fonction10.ToString();
                    tb_C_CodeFonction11.Text = licence.Code_fonction11.ToString();
                    tb_C_CodeFonction12.Text = licence.Code_fonction12.ToString();
                    tb_C_CodeFonction13.Text = licence.Code_fonction13.ToString();
                    tb_C_CodeFonction14.Text = licence.Code_fonction14.ToString();
                    tb_C_CodeFonction15.Text = licence.Code_fonction15.ToString();
                    tb_C_CodeFonction16.Text = licence.Code_fonction16.ToString();
                    tb_C_CodeFonction17.Text = licence.Code_fonction17.ToString();
                    tb_C_CodeFonction18.Text = licence.Code_fonction18.ToString();
                    tb_C_CodeFonction19.Text = licence.Code_fonction19.ToString();
                    tb_C_CodeFonction20.Text = licence.Code_fonction20.ToString();
                    #endregion
                    tb_C_Checksum.Text = licence.Checksum.ToString();
                    tb_C_NbrEquipements.Text = licence.Nb_equipements.ToString();
                    tb_C_NbrVariables.Text = licence.Nb_variables.ToString();
                    tb_C_CodeIntegrateur.Text = licence.Code_integrateur.ToString();
                    tb_C_CodeClient.Text = licence.Code_client.ToString();
                    dtp_U_DateExpirationLicence.Value = Convert.ToDateTime(licence.Date_expiration.ToString("dd/MM/yyyy"));
                }
            }
        }
        private void ResetUpdateLicenceTo0(object sender, EventArgs e)
        {
            tb_C_CodeFonction1.Text = "0";
            tb_C_CodeFonction2.Text = "0";
            tb_C_CodeFonction3.Text = "0";
            tb_C_CodeFonction4.Text = "0";
            tb_C_CodeFonction5.Text = "0";
            tb_C_CodeFonction6.Text = "0";
            tb_C_CodeFonction7.Text = "0";
            tb_C_CodeFonction8.Text = "0";
            tb_C_CodeFonction9.Text = "0";
            tb_C_CodeFonction10.Text = "0";
            tb_C_CodeFonction11.Text = "0";
            tb_C_CodeFonction12.Text = "0";
            tb_C_CodeFonction13.Text = "0";
            tb_C_CodeFonction14.Text = "0";
            tb_C_CodeFonction15.Text = "0";
            tb_C_CodeFonction16.Text = "0";
            tb_C_CodeFonction17.Text = "0";
            tb_C_CodeFonction18.Text = "0";
            tb_C_CodeFonction19.Text = "0";
            tb_C_CodeFonction20.Text = "0";
            tb_C_CodeClient.Text = "0";
            tb_C_CodeIntegrateur.Text = "0";
            tb_C_NbrEquipements.Text = "0";
            tb_C_NbrVariables.Text = "0";
            tb_C_Checksum.Text = "0";
            dtp_U_DateExpirationLicence.Value = DateTime.Now;
        }
        private void ResetCreateLicence(object sender, EventArgs e)
        {
            tb_NbEquipepments.Text = "";
            tb_NbVariables.Text = "";
            tb_CodeIntegrateur.Text = "";
            tb_CodeClient.Text = "";

            tb_CodeFonction1.Text = "";
            tb_CodeFonction2.Text = "";
            tb_CodeFonction3.Text = "";
            tb_CodeFonction4.Text = "";
            tb_CodeFonction5.Text = "";
            tb_CodeFonction6.Text = "";
            tb_CodeFonction7.Text = "";
            tb_CodeFonction8.Text = "";
            tb_CodeFonction9.Text = "";
            tb_CodeFonction10.Text = "";
            tb_CodeFonction11.Text = "";
            tb_CodeFonction12.Text = "";
            tb_CodeFonction13.Text = "";
            tb_CodeFonction14.Text = "";
            tb_CodeFonction15.Text = "";
            tb_CodeFonction16.Text = "";
            tb_CodeFonction17.Text = "";
            tb_CodeFonction18.Text = "";
            tb_CodeFonction19.Text = "";
            tb_CodeFonction20.Text = "";

            dtp_C_DateExpirationLicence.Value = DateTime.Now;
        }
        private void Btn_ResetFonctionsTo0_Click(object sender, EventArgs e)
        {
            tb_CodeFonction1.Text = "";
            tb_CodeFonction2.Text = "";
            tb_CodeFonction3.Text = "";
            tb_CodeFonction4.Text = "";
            tb_CodeFonction5.Text = "";
            tb_CodeFonction6.Text = "";
            tb_CodeFonction7.Text = "";
            tb_CodeFonction8.Text = "";
            tb_CodeFonction9.Text = "";
            tb_CodeFonction10.Text = "";
            tb_CodeFonction11.Text = "";
            tb_CodeFonction12.Text = "";
            tb_CodeFonction13.Text = "";
            tb_CodeFonction14.Text = "";
            tb_CodeFonction15.Text = "";
            tb_CodeFonction16.Text = "";
            tb_CodeFonction17.Text = "";
            tb_CodeFonction18.Text = "";
            tb_CodeFonction19.Text = "";
            tb_CodeFonction20.Text = "";
        }

        private string getFonctionName(int CodeFonction)
        {
            foreach(Fonction fonction in lesFonctions)
            {
                if (fonction.codeFonction == CodeFonction) {
                    return fonction.nom;
                }
            }
            return "NULL";
        }
    }
}
