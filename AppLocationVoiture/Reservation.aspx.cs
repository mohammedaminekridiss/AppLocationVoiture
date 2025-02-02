using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppLocationVoiture.BLL;
using AppLocationVoiture.DAL;
using Microsoft.Ajax.Utilities;

namespace AppLocationVoiture
{
    public partial class PageReservation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ChargerAgences();
            }
        }

        private void ChargerAgences()
        {
            Cache["agences"] = LocationService.Instance.RechercherAgences();
            dlAgences.DataSource = (List<Agence>)Cache["agences"];
            dlAgences.DataTextField = "NomCommercial";
            dlAgences.DataValueField = "IdAgence";
            dlAgences.DataBind();

            dlAgences.Items.Insert(0, new ListItem("Départ et lieu de retour", "0"));
        }

        protected void btnValider_Click(object sender, EventArgs e)
        {
            lbErreur.Text = string.Empty;
            int idAgence = int.Parse(dlAgences.SelectedValue);
            DateTime dateDepart, dateRetour;

            if (!DateTime.TryParse(tbDateDepart.Text, out dateDepart) ||
                !DateTime.TryParse(tbDateRetour.Text, out dateRetour))
            {
                lbErreur.Text = "Veuillez entrer des dates valides.";
                return;
            }

            if (idAgence == 0)
            {
                lbErreur.Text = "Veuillez sélectionner une agence.";
                return;
            }

            List<Offre> offres = VoitureService.Instance.RechercherVoiture(idAgence, idAgence, dateDepart, dateRetour);
            Session["offres"]= offres;

            EnregistrerSession();

            rptVoitures.DataSource = offres;
            rptVoitures.DataBind();
        }
        private void EnregistrerSession()
        {
            Session["Agence"] = dlAgences.SelectedValue;
            Session["HeureDepart"] = dlHeureDepart.SelectedValue;
            Session["HeureRetour"] = dlHeureRetour.SelectedValue;
            Session["DateDepart"] = tbDateDepart.Text;
            Session["DateRetour"] = tbDateRetour.Text;

        }
        protected void rptVoitures_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var id_voiture = int.Parse(e.CommandArgument.ToString());
            Response.Redirect("./Commande.aspx?id=" + id_voiture);

        }
    }
}

