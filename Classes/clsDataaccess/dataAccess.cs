using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_poullailler.Classes.clsDataaccess
{
    class dataAccess
    {
        SqlConnection con;
        //===================================METHODE AJOUT CATEGORIE MEDICAMENT===================
        public int addcategorimed(clscategoriemedicament clscm)
        {
            try { 

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_categoriemedicament @designation";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prdesignation = new SqlParameter("@designation", clscm.Designation);
                    cmd.Parameters.Add(prdesignation);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch ( Exception ex) {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE Modification CATEGORIE MEDICAMENT===================
        public int editcategorimed(clscategoriemedicament clscm)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_update_categoriemedicament @idcategoriemed, @designation";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idcategoriemed", clscm.Idcategorie);
                    SqlParameter prdesignation = new SqlParameter("@designation", clscm.Designation);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prdesignation);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE SUPPRIMER CATEGORIE MEDICAMENT===================
        public int deletecategorimed(clscategoriemedicament clscm)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_categoriemedicament @idcategoriemed";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idcategoriemed", clscm.Idcategorie);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //=======================LIST CATEGORIE MEDICAMENT =========================
        public List<clscategoriemedicament> gestlistcatemed()
        {
            List<clscategoriemedicament> list = new List<clscategoriemedicament>();
            con = new clsConnection.Connexion().DBConnect();
            string strquery = "select * from Categoriemedicament ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clscategoriemedicament clscM = new clscategoriemedicament();
                clscM.Idcategorie = dr["idcategoriemed"].ToString();
                clscM.Designation = dr["designation"].ToString();
                list.Add(clscM);
            }
            return list;
        }

        //=========================================================================================
        //===================================METHODE AJOUT CATEGORIE ALIMENT===================
        //===============================CHARGEMENT COMBOBOX===================================
        public void chargercombobox(ComboBox list)
        {
            con = new clsConnection.Connexion().DBConnect();
            try
            {
                var chrg = new SqlCommand("cherche_categorie", con)
                {
                    CommandType= CommandType.StoredProcedure
                };

                chrg.ExecuteNonQuery();
                var da = new SqlDataAdapter(chrg);
                var ds = new DataSet();
                da.Fill(ds, "categorie");
                list.DataSource = ds.Tables["categorie"];
                list.ValueMember = "idcategoriealiment";
                list.DisplayMember = "designation";
                
            }
            catch ( Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void chargercomboboxfournisseur(ComboBox list)
        {
            con = new clsConnection.Connexion().DBConnect();
            try
            {
                var chrg = new SqlCommand("chargement_fournisseur", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                chrg.ExecuteNonQuery();
                var da = new SqlDataAdapter(chrg);
                var ds = new DataSet();
                da.Fill(ds, "fournisseur");
                list.DataSource = ds.Tables["fournisseur"];
                list.ValueMember = "idfournisseur";
                list.DisplayMember = "noms";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void chargercomboboxclient(ComboBox list)
        {
            con = new clsConnection.Connexion().DBConnect();
            try
            {
                var chrg = new SqlCommand("chargement_client", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                chrg.ExecuteNonQuery();
                var da = new SqlDataAdapter(chrg);
                var ds = new DataSet();
                da.Fill(ds, "client");
                list.DataSource = ds.Tables["client"];
                list.ValueMember = "idclient";
                list.DisplayMember = "nom";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void chargercomboboxagent(ComboBox list)
        {
            con = new clsConnection.Connexion().DBConnect();
            try
            {
                var chrg = new SqlCommand("chargement_agent", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                chrg.ExecuteNonQuery();
                var da = new SqlDataAdapter(chrg);
                var ds = new DataSet();
                da.Fill(ds, "agent");
                list.DataSource = ds.Tables["agent"];
                list.ValueMember = "idagent";
                list.DisplayMember = "noms";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void chargercomboboxCommande(ComboBox list)
        {
            con = new clsConnection.Connexion().DBConnect();
            try
            {
                var chrg = new SqlCommand("chargement_commande", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                chrg.ExecuteNonQuery();
                var da = new SqlDataAdapter(chrg);
                var ds = new DataSet();
                da.Fill(ds, "commande");
                list.DataSource = ds.Tables["commande"];
                list.ValueMember = "numcommande";
                list.DisplayMember = "numcommande";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void chargercomboboxaliment(ComboBox list)
        {
            con = new clsConnection.Connexion().DBConnect();
            try
            {
                var chrg = new SqlCommand("charcgement_aliment", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                chrg.ExecuteNonQuery();
                var da = new SqlDataAdapter(chrg);
                var ds = new DataSet();
                da.Fill(ds, "aliment");
                list.DataSource = ds.Tables["aliment"];
                list.ValueMember = "idaliment";
                list.DisplayMember = "designation";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void chargercomboboxpoule(ComboBox list)
        {
            con = new clsConnection.Connexion().DBConnect();
            try
            {
                var chrg = new SqlCommand("chargement_poule", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                chrg.ExecuteNonQuery();
                var da = new SqlDataAdapter(chrg);
                var ds = new DataSet();
                da.Fill(ds, "poule");
                list.DataSource = ds.Tables["poule"];
                list.ValueMember = "idpoule";
                list.DisplayMember = "poule";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void chargercomboboxcatemed(ComboBox list)
        {
            con = new clsConnection.Connexion().DBConnect();
            try
            {
                var chrg = new SqlCommand("chargement_categoriemed", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                chrg.ExecuteNonQuery();
                var da = new SqlDataAdapter(chrg);
                var ds = new DataSet();
                da.Fill(ds, "categorie");
                list.DataSource = ds.Tables["categorie"];
                list.ValueMember = "idcategoriemed";
                list.DisplayMember = "designation";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void chargercomboboxcmedicament(ComboBox list)
        {
            con = new clsConnection.Connexion().DBConnect();
            try
            {
                var chrg = new SqlCommand("chargement_medicament", con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                chrg.ExecuteNonQuery();
                var da = new SqlDataAdapter(chrg);
                var ds = new DataSet();
                da.Fill(ds, "medicament");
                list.DataSource = ds.Tables["medicament"];
                list.ValueMember = "idmedicament";
                list.DisplayMember = "designation";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public int addcategoriealiment(clscategoriealiment clsca)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_categoriealiment @designation";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prdesignation = new SqlParameter("@designation", clsca.Designation);
                    cmd.Parameters.Add(prdesignation);
                    value = cmd.ExecuteNonQuery();
                    
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE Modification CATEGORIE ALIMENT===================
        public int editcategoriealiment(clscategoriealiment clsca)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_update_categoriealiment @idcategoriealim, @designation";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idcategoriealim", clsca.Idcatealiment);
                    SqlParameter prdesignation = new SqlParameter("@designation", clsca.Designation);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prdesignation);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE SUPPRIMER CATEGORIE ALIMENT===================
        public int deletecategoriealiment(clscategoriealiment clsca)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_categoriealiment @idcategoriealim";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idcategoriealim", clsca.Idcatealiment);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //=======================LIST CATEGORIE ALIMENT =========================
        public List<clscategoriealiment> gestlistcatealiment()
        {
            List<clscategoriealiment> list = new List<clscategoriealiment>();
            con = new clsConnection.Connexion().DBConnect();
            string strquery = "select * from Categoriealiment ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clscategoriealiment clsca = new clscategoriealiment();
                clsca.Idcatealiment = dr["idcategoriealiment"].ToString();
                clsca.Designation = dr["designation"].ToString();
                list.Add(clsca);
            }
            return list;
        }
        //=========================================================================================
        //===================================METHODE AJOUT CATEGORIE POULE===================
        public int addcategoriepoule(clscategoriepoule clscp)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_categoriepoule @designation";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prdesignation = new SqlParameter("@designation", clscp.Designation);
                    cmd.Parameters.Add(prdesignation);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE Modification CATEGORIE ALIMENT===================
        public int editcategoriepoule(clscategoriepoule clscp)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_update_categoriepoule @idcategoriepoule, @designation";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idcategoriepoule", clscp.Idcatepoule);
                    SqlParameter prdesignation = new SqlParameter("@designation", clscp.Designation);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prdesignation);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE SUPPRIMER CATEGORIE POULE===================
        public int deletecategoriepoule(clscategoriepoule clscp)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_categoriepoule @idcategoriepoule";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idcategoriepoule", clscp.Idcatepoule);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //=======================LIST CATEGORIE ALIMENT =========================
        public List<clscategoriepoule> gestlistcatepoule()
        {
            List<clscategoriepoule> list = new List<clscategoriepoule>();
            con = new clsConnection.Connexion().DBConnect();
            string strquery = "select * from Categoriepoule ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clscategoriepoule clscp = new clscategoriepoule();
                clscp.Idcatepoule =dr["idcategoriepoule"].ToString();
                clscp.Designation = dr["designation"].ToString();
                list.Add(clscp);
            }
            return list;
        }
        //=========================================================================================
        //===================================METHODE AJOUT POULE===================
        public int addpoule(clspoule clsp)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_poule @categoriepoule, @designation,@quantite,@poids,@unite,@prixu";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prcategoriepoule = new SqlParameter("@categoriepoule", clsp.Categoriepoule);
                    SqlParameter prdesignation = new SqlParameter("@designation", clsp.Designation);
                    SqlParameter prquantite = new SqlParameter("@quantite", clsp.Quantite);
                    SqlParameter prpoids = new SqlParameter("@poids", clsp.Poids);
                    SqlParameter prunite = new SqlParameter("@unite", clsp.Unite);
                    SqlParameter prprixu = new SqlParameter("@prixu", clsp.Prixu);
                    cmd.Parameters.Add(prcategoriepoule);
                    cmd.Parameters.Add(prdesignation);
                    cmd.Parameters.Add(prquantite);
                    cmd.Parameters.Add(prpoids);
                    cmd.Parameters.Add(prunite);
                    cmd.Parameters.Add(prprixu);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE Modification POULE===================
        public int editpoule(clspoule clsp)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_update_poule @idpoule, @categoriepoule, @designation,@quantite,@poids,@unite,@prixu";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter pridpoule = new SqlParameter("@idpoule", clsp.Codepole);
                    SqlParameter prcategoriepoule = new SqlParameter("@categoriepoule", clsp.Categoriepoule);
                    SqlParameter prdesignation = new SqlParameter("@designation", clsp.Designation);
                    SqlParameter prquantite = new SqlParameter("@quantite", clsp.Quantite);
                    SqlParameter prpoids = new SqlParameter("@poids", clsp.Poids);
                    SqlParameter prunite = new SqlParameter("@unite", clsp.Unite);
                    SqlParameter prprixu = new SqlParameter("@prixu", clsp.Prixu);
                    cmd.Parameters.Add(pridpoule);
                    cmd.Parameters.Add(prcategoriepoule);
                    cmd.Parameters.Add(prdesignation);
                    cmd.Parameters.Add(prquantite);
                    cmd.Parameters.Add(prpoids);
                    cmd.Parameters.Add(prunite);
                    cmd.Parameters.Add(prprixu);
                    
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE SUPPRIMER POULE===================
        public int deletepoule(clspoule clsp)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_poule @idpoule";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idcategoriepoule", clsp.Codepole);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //=======================LIST POULE =========================
        public List<clspoule> gestlistpoule()
        {
            List<clspoule> list = new List<clspoule>();
            con = new clsConnection.Connexion().DBConnect();
            string strquery = "select * from Vpoule ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clspoule clsp = new clspoule();
                clsp.Codepole = dr["idpoule"].ToString();
                clsp.Categoriepoule = dr["categorie"].ToString();
                clsp.Designation = dr["designation"].ToString();
                clsp.Quantite = Convert.ToInt32(dr["quantite"]);
                clsp.Prixu = Convert.ToDecimal(dr["prixu"]);
                clsp.Poids = Convert.ToDecimal(dr["poids"]);
                clsp.Unite = dr["unite"].ToString();
                list.Add(clsp);
            }
            return list;
        }
        //==========================================================================================
        //===================================METHODE AJOUT ALIMENT===================
        public int addaliment(clsaliment clsa)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_aliment @categoriealiment,@fournisseur,@designation,@quantite,@prixu,@unite";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prcategoriealiement = new SqlParameter("@categoriealiment", clsa.Categoriealiment);
                    SqlParameter prfournisseur = new SqlParameter("@fournisseur", clsa.Fournisseur);
                    SqlParameter prdesignation = new SqlParameter("@designation", clsa.Designation);
                    SqlParameter prquantite = new SqlParameter("@quantite", clsa.Quantite);
                    SqlParameter prprixu = new SqlParameter("@prixu", clsa.Prixu);
                    SqlParameter prunite = new SqlParameter("@unite", clsa.Unite);
                    cmd.Parameters.Add(prcategoriealiement);
                    cmd.Parameters.Add(prfournisseur);
                    cmd.Parameters.Add(prdesignation);
                    cmd.Parameters.Add(prquantite);
                    cmd.Parameters.Add(prprixu);
                    cmd.Parameters.Add(prunite);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE Modification ALIMENT===================
        public int editaliment(clsaliment clsa)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_update_aliment @idaliment, @categoriealiment,@fournisseur,@designation,@quantite,@prixu,@unite";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idaliment", clsa.Codealiment);
                    SqlParameter prcategoriealiement = new SqlParameter("@categoriealiment", clsa.Categoriealiment);
                    SqlParameter prfournisseur = new SqlParameter("@fournisseur", clsa.Fournisseur);
                    SqlParameter prdesignation = new SqlParameter("@designation", clsa.Designation);
                    SqlParameter prquantite = new SqlParameter("@quantite", clsa.Quantite);
                    SqlParameter prprixu = new SqlParameter("@prixu", clsa.Prixu);
                    SqlParameter prunite = new SqlParameter("@unite", clsa.Unite);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prcategoriealiement);
                    cmd.Parameters.Add(prfournisseur);
                    cmd.Parameters.Add(prdesignation);
                    cmd.Parameters.Add(prquantite);
                    cmd.Parameters.Add(prprixu);
                    cmd.Parameters.Add(prunite);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE SUPPRIMER ALIMENT===================
        public int deletealiment(clsaliment clsa)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_aliemnt @idaliment";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idaliment", clsa.Codealiment);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //=======================LIST ALIMENT =========================
        public List<clsaliment> gestlistaliemnt()
        {
            List<clsaliment> list = new List<clsaliment>();
            con = new clsConnection.Connexion().DBConnect();
            string strquery = "select * from Valiment ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsaliment clsa = new clsaliment();
                clsa.Codealiment = dr["idaliment"].ToString();
                clsa.Categoriealiment = dr["categorie"].ToString();
                clsa.Designation = dr["designation"].ToString();
                clsa.Fournisseur = dr["fournisseur"].ToString();
                clsa.Quantite = Convert.ToInt32(dr["quantite"]);
                clsa.Prixu = Convert.ToDecimal(dr["prixu"]);
                clsa.Unite = dr["unite"].ToString();
                list.Add(clsa);
            }
            return list;
        }
        //==========================================================================================
        //===================================METHODE AJOUT CONSOMMATION===================
        public int addconsommation(clsconsommation clscons)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_consommation @poule,@aliment,@quantite,@unite";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prpoule = new SqlParameter("@poule", clscons.Poule);
                    SqlParameter praliment = new SqlParameter("@aliment", clscons.Aliment);
                    SqlParameter prquantite = new SqlParameter("@quantite", clscons.Quantite);
                    SqlParameter prunite = new SqlParameter("@unite", clscons.Unite);
                    cmd.Parameters.Add(prpoule);
                    cmd.Parameters.Add(praliment);
                    cmd.Parameters.Add(prquantite);
                    cmd.Parameters.Add(prunite);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE Modification CONSOMMATION===================
        public int editconsommation(clsconsommation clscons)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_update_consommation @idconsommation,@poule,@aliment,@quantite,@unite";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prpoule = new SqlParameter("@poule", clscons.Poule);
                    SqlParameter praliment = new SqlParameter("@aliment", clscons.Aliment);
                    SqlParameter prquantite = new SqlParameter("@quantite", clscons.Quantite);
                    SqlParameter prunite = new SqlParameter("@unite", clscons.Unite);
                    SqlParameter prid = new SqlParameter("@idconsommation", clscons.Codeconsommation);
                    cmd.Parameters.Add(prpoule);
                    cmd.Parameters.Add(praliment);
                    cmd.Parameters.Add(prquantite);
                    cmd.Parameters.Add(prunite);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE SUPPRIMER CONSOMMATION===================
        public int deleteconsommation(clsconsommation clscons)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_consommation @idconsommation";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idconsommation", clscons.Codeconsommation);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //=======================LIST CONSOMMATION =========================
        public List<clsconsommation> gestlistconsommation()
        {
            List<clsconsommation> list = new List<clsconsommation>();
            con = new clsConnection.Connexion().DBConnect();
            string strquery = "select * from Vconsommation ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsconsommation clscons = new clsconsommation();
                clscons.Codeconsommation =dr["idconsommamtion"].ToString();
                clscons.Poule = dr["poule"].ToString();
                clscons.Aliment = dr["aliment"].ToString();
                clscons.Quantite =Convert.ToInt32( dr["quantite"]);
                clscons.Unite = dr["unite"].ToString();
                clscons.Dateconsommation = Convert.ToDateTime(dr["dateconsomation"]);
                list.Add(clscons);
            }
            return list;
        }
        //==========================================================================================
        //===================================METHODE AJOUT MORTALITE===================
        public int addmortalite(clsmortalite clsmort)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_mortalite @poule,@nombrevivant,@nombremalade,@nombremort";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prpoule = new SqlParameter("@poule", clsmort.Poule);
                    SqlParameter prvivant = new SqlParameter("@nombrevivant", clsmort.Nombre_vivant);
                    SqlParameter prmalade = new SqlParameter("@nombremalade", clsmort.Nombre_malade);
                    SqlParameter prmort = new SqlParameter("@nombremort", clsmort.Nombre_mort);
                    cmd.Parameters.Add(prpoule);
                    cmd.Parameters.Add(prvivant);
                    cmd.Parameters.Add(prmalade);
                    cmd.Parameters.Add(prmort);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE Modification MORTALITE===================
        public int editmortalite(clsmortalite clsmort)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_update_mortalite @idmortalite,@poule,@nombrevivant,@nombremalade,@nombremort";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idmortalite", clsmort.Idmortalite);
                    SqlParameter prpoule = new SqlParameter("@poule", clsmort.Poule);
                    SqlParameter prvivant = new SqlParameter("@nombrevivant", clsmort.Nombre_vivant);
                    SqlParameter prmalade = new SqlParameter("@nombremalade", clsmort.Nombre_malade);
                    SqlParameter prmort = new SqlParameter("@nombremort", clsmort.Nombre_mort);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prpoule);
                    cmd.Parameters.Add(prvivant);
                    cmd.Parameters.Add(prmalade);
                    cmd.Parameters.Add(prmort);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE SUPPRIMER MORTALITE===================
        public int deletemortalite(clsmortalite clsmort)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_mortalite @idmortalite";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idmortalite", clsmort.Idmortalite);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //=======================LIST MORTALITE =========================
        public List<clsmortalite> gestlistmortalite()
        {
            List<clsmortalite> list = new List<clsmortalite>();
            con = new clsConnection.Connexion().DBConnect();
            string strquery = "select * from Vmortalite ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsmortalite clsmort = new clsmortalite();
                clsmort.Idmortalite = dr["idmortalite"].ToString();
                clsmort.Poule = dr["poule"].ToString();
                clsmort.Nombre_vivant = Convert.ToInt32(dr["nbr_vivant"]);
                clsmort.Nombre_malade = Convert.ToInt32(dr["nbr_malade"]);
                clsmort.Nombre_mort = Convert.ToInt32(dr["nbr_mort"]);
                clsmort.Dateprelevement = Convert.ToDateTime(dr["daterelevemnt"]);
                list.Add(clsmort);
            }
            return list; 
        }
        //==========================================================================================
        //===================================METHODE AJOUT MEDICAMENT===================
        public int addmedicament(clsmedicament clscm)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_medicament @categorie,@designation";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prcategorie = new SqlParameter("@categorie", clscm.Categoriemedicament);
                    SqlParameter prdesignation = new SqlParameter("@designation", clscm.Designation);
                    cmd.Parameters.Add(prdesignation);
                    cmd.Parameters.Add(prcategorie);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE Modification  MEDICAMENT===================
        public int editmedicament(clsmedicament clscm)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_update_medicament @idmedicament,@categorie,@designation";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idmedicament", clscm.Codemedicament);
                    SqlParameter prcategorie = new SqlParameter("@categorie", clscm.Categoriemedicament);
                    SqlParameter prdesignation = new SqlParameter("@designation", clscm.Designation);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prdesignation);
                    cmd.Parameters.Add(prcategorie);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE SUPPRIMER  MEDICAMENT===================
        public int deletemedicament(clsmedicament clscm)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_medicament @idmedicament";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idmedicament", clscm.Codemedicament);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //=======================LIST  MEDICAMENT =========================
        public List<clsmedicament> gestlistmedicament()
        {
            List<clsmedicament> list = new List<clsmedicament>();
            con = new clsConnection.Connexion().DBConnect();
            string strquery = "select * from Vmedicament ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsmedicament clscM = new clsmedicament();
                clscM.Codemedicament = dr["idmedicament"].ToString();
                clscM.Categoriemedicament = dr["categorie"].ToString();
                clscM.Designation = dr["designation"].ToString();
                list.Add(clscM);
            }
            return list;
        }
        //==========================================================================================
        //===================================METHODE AJOUT TRAITEMENT===================
        public int addtraitement(clstraitement clstr)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_traitement @poule,@medicament,@dose,@unite";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prpoule = new SqlParameter("@poule", clstr.Poule);
                    SqlParameter prmedicament = new SqlParameter("@medicament", clstr.Medicament);
                    SqlParameter prdose = new SqlParameter("@dose", clstr.Dose);
                    SqlParameter prunite = new SqlParameter("@unite", clstr.Unite);
                    cmd.Parameters.Add(prpoule);
                    cmd.Parameters.Add(prmedicament);
                    cmd.Parameters.Add(prdose);
                    cmd.Parameters.Add(prunite);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE Modification TRAITEMENT===================
        public int edittraitement(clstraitement clstr)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_update_traitement @idtraitement,@poule,@medicament,@dose,@unite";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idtraitement", clstr.Codetraitement);
                    SqlParameter prpoule = new SqlParameter("@poule", clstr.Poule);
                    SqlParameter prmedicament = new SqlParameter("@medicament", clstr.Medicament);
                    SqlParameter prdose = new SqlParameter("@dose", clstr.Dose);
                    SqlParameter prunite = new SqlParameter("@unite", clstr.Unite);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prpoule);
                    cmd.Parameters.Add(prmedicament);
                    cmd.Parameters.Add(prdose);
                    cmd.Parameters.Add(prunite);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE SUPPRIMER TRAITEMENT===================
        public int deletetraitement(clstraitement clstr)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_traitement @idtraitement";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idtraitement", clstr.Codetraitement);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //=======================LIST TRAITEMENT =========================
        public List<clstraitement> gestlisttraitement()
        {
            List<clstraitement> list = new List<clstraitement>();
            con = new clsConnection.Connexion().DBConnect();
            string strquery = "select * from Vtraitement ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clstraitement clstr = new clstraitement();
                clstr.Codetraitement =dr["idtraitement"].ToString();
                clstr.Poule = dr["poule"].ToString();
                clstr.Medicament = dr["medicament"].ToString();
                clstr.Dose = Convert.ToInt32(dr["dose"]);
                clstr.Unite = dr["unite"].ToString();
                clstr.Datetraitement = Convert.ToDateTime(dr["datetraitement"]);
                list.Add(clstr);
            }
            return list;
        }
        //==========================================================================================
        //===================================METHODE AJOUT CLIENT===================
        public int addclient(clsclient clscl)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_client @nom,@postnom,@prenom,@genre,@adresse,@telephone,@mail";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prnom = new SqlParameter("@nom", clscl.Nom);
                    SqlParameter prpostnom = new SqlParameter("@postnom", clscl.Postnom);
                    SqlParameter prprenom = new SqlParameter("@prenom", clscl.Prenom);
                    SqlParameter prgenre = new SqlParameter("@genre", clscl.Genre);
                    SqlParameter pradresse = new SqlParameter("@adresse", clscl.Adresse);
                    SqlParameter prtelephone = new SqlParameter("@telephone", clscl.Telephone);
                    SqlParameter prmail = new SqlParameter("@mail", clscl.Mail);
                    cmd.Parameters.Add(prnom);
                    cmd.Parameters.Add(prpostnom);
                    cmd.Parameters.Add(prprenom);
                    cmd.Parameters.Add(prgenre);
                    cmd.Parameters.Add(pradresse);
                    cmd.Parameters.Add(prtelephone);
                    cmd.Parameters.Add(prmail);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE Modification CLIENT===================
        public int editclient(clsclient clscl)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_update_client @idclient,@nom,@postnom,@prenom,@genre,@adresse,@telephone,@mail";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idclient", clscl.Codeclient);
                    SqlParameter prnom = new SqlParameter("@nom", clscl.Nom);
                    SqlParameter prpostnom = new SqlParameter("@postnom", clscl.Postnom);
                    SqlParameter prprenom = new SqlParameter("@prenom", clscl.Prenom);
                    SqlParameter prgenre = new SqlParameter("@genre", clscl.Genre);
                    SqlParameter pradresse = new SqlParameter("@adresse", clscl.Adresse);
                    SqlParameter prtelephone = new SqlParameter("@telephone", clscl.Telephone);
                    SqlParameter prmail = new SqlParameter("@mail", clscl.Mail);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prnom);
                    cmd.Parameters.Add(prpostnom);
                    cmd.Parameters.Add(prprenom);
                    cmd.Parameters.Add(prgenre);
                    cmd.Parameters.Add(pradresse);
                    cmd.Parameters.Add(prtelephone);
                    cmd.Parameters.Add(prmail);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE SUPPRIMER CLIENT===================
        public int deleteclient(clsclient clscl)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_client @idclient";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idclient", clscl.Codeclient);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //=======================LIST CLIENT =========================
        public List<clsclient> gestlistclient()
        {
            List<clsclient> list = new List<clsclient>();
            con = new clsConnection.Connexion().DBConnect();
            string strquery = "select * from client ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsclient clscl = new clsclient();
                clscl.Codeclient = dr["idclient"].ToString();
                clscl.Nom = dr["nom"].ToString();
                clscl.Postnom = dr["postnom"].ToString();
                clscl.Prenom = dr["prenom"].ToString();
                clscl.Genre = dr["genre"].ToString();
                clscl.Adresse = dr["adresse"].ToString();
                clscl.Telephone = dr["telephone"].ToString();
                clscl.Mail = dr["mail"].ToString();
                list.Add(clscl);
            }
            return list;
        }
        //==========================================================================================
        //===================================METHODE AJOUT FOURNISSEUR===================
        public int addfournisseur(clsfournisseur clscl)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_fournisseur @noms,@genre,@adresse,@telephone,@mail";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prnom = new SqlParameter("@noms", clscl.Noms);
                    SqlParameter prgenre = new SqlParameter("@genre", clscl.Genre);
                    SqlParameter pradresse = new SqlParameter("@adresse", clscl.Adresse);
                    SqlParameter prtelephone = new SqlParameter("@telephone", clscl.Telephone);
                    SqlParameter prmail = new SqlParameter("@mail", clscl.Mail);
                    cmd.Parameters.Add(prnom);
                    cmd.Parameters.Add(prgenre);
                    cmd.Parameters.Add(pradresse);
                    cmd.Parameters.Add(prtelephone);
                    cmd.Parameters.Add(prmail);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE Modification FOURNISSEUR===================
        public int editfournisseur(clsfournisseur clscl)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_update_fournisseur @idfournisseur,@noms,@genre,@adresse,@telephone,@mail";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idfournisseur", clscl.Codefournisseur);
                    SqlParameter prnom = new SqlParameter("@noms", clscl.Noms);
                    SqlParameter prgenre = new SqlParameter("@genre", clscl.Genre);
                    SqlParameter pradresse = new SqlParameter("@adresse", clscl.Adresse);
                    SqlParameter prtelephone = new SqlParameter("@telephone", clscl.Telephone);
                    SqlParameter prmail = new SqlParameter("@mail", clscl.Mail);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prnom);
                    cmd.Parameters.Add(prgenre);
                    cmd.Parameters.Add(pradresse);
                    cmd.Parameters.Add(prtelephone);
                    cmd.Parameters.Add(prmail);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE SUPPRIMER FOURNISSEUR===================
        public int deletefournisseur(clsfournisseur clscl)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_fournisseur @idfournisseur";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idfournisseur", clscl.Codefournisseur);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //=======================LIST FOURNISSEUR =========================
        public List<clsfournisseur> gestlistfournisseur()
        {
            List<clsfournisseur> list = new List<clsfournisseur>();
            con = new clsConnection.Connexion().DBConnect();
            string strquery = "select * from fournisseur ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsfournisseur clscl = new clsfournisseur();
                clscl.Codefournisseur = dr["idfournisseur"].ToString();
                clscl.Noms = dr["noms"].ToString();
                clscl.Genre = dr["genre"].ToString();
                clscl.Adresse = dr["adresse"].ToString();
                clscl.Telephone = dr["telephone"].ToString();
                clscl.Mail = dr["mail"].ToString();
                list.Add(clscl);
            }
            return list;
        }
        //==========================================================================================
        //===================================METHODE AJOUT AGENT===================
        public int addagent(clsagent clscl)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_agent @noms,@genre,@adresse,@telephone,@mail";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prnom = new SqlParameter("@noms", clscl.Noms);
                    SqlParameter prgenre = new SqlParameter("@genre", clscl.Genre);
                    SqlParameter pradresse = new SqlParameter("@adresse", clscl.Adresse);
                    SqlParameter prtelephone = new SqlParameter("@telephone", clscl.Telephone);
                    SqlParameter prmail = new SqlParameter("@mail", clscl.Mail);
                    cmd.Parameters.Add(prnom);
                    cmd.Parameters.Add(prgenre);
                    cmd.Parameters.Add(pradresse);
                    cmd.Parameters.Add(prtelephone);
                    cmd.Parameters.Add(prmail);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE Modification AGENT===================
        public int editagent(clsagent clscl)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_update_agent @idagent,@noms,@genre,@adresse,@telephone,@mail";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idagent", clscl.Codeagent);
                    SqlParameter prnom = new SqlParameter("@noms", clscl.Noms);
                    SqlParameter prgenre = new SqlParameter("@genre", clscl.Genre);
                    SqlParameter pradresse = new SqlParameter("@adresse", clscl.Adresse);
                    SqlParameter prtelephone = new SqlParameter("@telephone", clscl.Telephone);
                    SqlParameter prmail = new SqlParameter("@mail", clscl.Mail);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prnom);
                    cmd.Parameters.Add(prgenre);
                    cmd.Parameters.Add(pradresse);
                    cmd.Parameters.Add(prtelephone);
                    cmd.Parameters.Add(prmail);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE SUPPRIMER AGENT===================
        public int deleteagent(clsagent clscl)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_agent @idagent";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idagent", clscl.Codeagent);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //=======================LIST AGENT =========================
        public List<clsagent> gestlistagent()
        {
            List<clsagent> list = new List<clsagent>();
            con = new clsConnection.Connexion().DBConnect();
            string strquery = "select * from agent ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsagent clscl = new clsagent();
                clscl.Codeagent = dr["idagent"].ToString();
                clscl.Noms = dr["noms"].ToString();
                clscl.Genre = dr["genre"].ToString();
                clscl.Adresse = dr["adresse"].ToString();
                clscl.Telephone = dr["telephone"].ToString();
                clscl.Mail = dr["mail"].ToString();
                list.Add(clscl);
            }
            return list;
        }
        //==========================================================================================
        //===================================METHODE AJOUT COMMANDE===================
        public int addcommande(clscommande clscons)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_commande @poule,@client,@quantite,@prixu";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prpoule = new SqlParameter("@poule", clscons.Poule);
                    SqlParameter prclient = new SqlParameter("@client", clscons.Client);
                    SqlParameter prquantite = new SqlParameter("@quantite", clscons.Quantite);
                    SqlParameter prunite = new SqlParameter("@prixu", clscons.Prixu);
                    cmd.Parameters.Add(prpoule);
                    cmd.Parameters.Add(prclient);
                    cmd.Parameters.Add(prquantite);
                    cmd.Parameters.Add(prunite);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE Modification COMMANDE===================
        public int editcommande(clscommande clscons)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_update_commande @idcommande,@poule,@client,@quantite,@prixu";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idcommande", clscons.Codecommande);
                    SqlParameter prpoule = new SqlParameter("@poule", clscons.Poule);
                    SqlParameter prclient = new SqlParameter("@client", clscons.Client);
                    SqlParameter prquantite = new SqlParameter("@quantite", clscons.Quantite);
                    SqlParameter prunite = new SqlParameter("@prixu", clscons.Prixu);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prpoule);
                    cmd.Parameters.Add(prclient);
                    cmd.Parameters.Add(prquantite);
                    cmd.Parameters.Add(prunite);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE SUPPRIMER COMMANDE===================
        public int deletecommande(clscommande clscons)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_commande @idcommande";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idcommande", clscons.Codecommande);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //=======================LIST COMMANDE =========================
        public List<clscommande> gestlistcommande()
        {
            List<clscommande> list = new List<clscommande>();
            con = new clsConnection.Connexion().DBConnect();
            string strquery = "select * from Vcommande ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clscommande clscons = new clscommande();
                clscons.Codecommande = dr["numcommande"].ToString();
                clscons.Poule = dr["poule"].ToString();
                clscons.Client = dr["client"].ToString();
                clscons.Quantite = Convert.ToInt32(dr["quantite"]);
                clscons.Prixu =Convert.ToDecimal(dr["prixU"]);
                clscons.Datecommande = Convert.ToDateTime(dr["datecommande"]);
                list.Add(clscons);
            }
            return list;
        }
        //==========================================================================================
        //===================================METHODE AJOUT LIVRAISON===================
        public int addlivraison(clslivraison clsli)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_insert_livraison @commande,@agent,@quantite,@prixu,@lieulivraison";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prcommande = new SqlParameter("@commande", clsli.Commande);
                    SqlParameter pragent = new SqlParameter("@agent", clsli.Agent);
                    SqlParameter prquantite = new SqlParameter("@quantite", clsli.Quantite);
                    SqlParameter prprixu = new SqlParameter("@prixu", clsli.Prixu);
                    SqlParameter prlieu = new SqlParameter("@lieulivraison", clsli.Lieulivraison);
                    cmd.Parameters.Add(prcommande);
                    cmd.Parameters.Add(pragent);
                    cmd.Parameters.Add(prquantite);
                    cmd.Parameters.Add(prprixu);
                    cmd.Parameters.Add(prlieu);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE Modification LIVRAISON===================
        public int editlivraison(clslivraison clsli)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_update_livraison @idlivraison,@commande,@agent,@quantite,@prixu,@lieu";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idlivraison", clsli.Codelivraison);
                    SqlParameter prcommande = new SqlParameter("@commande", clsli.Commande);
                    SqlParameter pragent = new SqlParameter("@agent", clsli.Agent);
                    SqlParameter prquantite = new SqlParameter("@quantite", clsli.Quantite);
                    SqlParameter prprixu = new SqlParameter("@prixu", clsli.Prixu);
                    SqlParameter prlieu = new SqlParameter("@lieu", clsli.Lieulivraison);
                    cmd.Parameters.Add(prid);
                    cmd.Parameters.Add(prcommande);
                    cmd.Parameters.Add(pragent);
                    cmd.Parameters.Add(prquantite);
                    cmd.Parameters.Add(prprixu);
                    cmd.Parameters.Add(prlieu);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //===================================METHODE SUPPRIMER LIVRAISON===================
        public int deletelivraison(clslivraison clsli)
        {
            try
            {

                int value = 0;
                con = new clsConnection.Connexion().DBConnect();
                if (con != null)
                {
                    string query = " exec sp_delete_livraison @idlivraison";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlParameter prid = new SqlParameter("@idlivraison", clsli.Codelivraison);
                    cmd.Parameters.Add(prid);
                    value = cmd.ExecuteNonQuery();
                }
                return value;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //=======================LIST LIVRAISON =========================
        public List<clslivraison> gestlistlivraison()
        {
            List<clslivraison> list = new List<clslivraison>();
            con = new clsConnection.Connexion().DBConnect();
            string strquery = "select * from Vlivraison ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clslivraison clsli = new clslivraison();
                clsli.Codelivraison =  dr["idlivraison"].ToString();
                clsli.Commande = dr["commande"].ToString();
                clsli.Agent = dr["agent"].ToString();
                clsli.Quantite = Convert.ToInt32(dr["quantite"]);
                clsli.Prixu = Convert.ToDecimal(dr["prixU"]);
                clsli.Lieulivraison = dr["lieulivraison"].ToString();
                clsli.Datelivraison = Convert.ToDateTime(dr["datelivraision"]);
                list.Add(clsli);
            }
            return list;
        }
    }
}
