using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppLocationVoiture.BLL;
using AppLocationVoiture.DAL;

namespace AppLocationVoiture
{
    public partial class Commande : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Agence> agences = (List<Agence>)Cache["agences"];
            Agence agence = agences.Where(x => x.IdAgence.ToString() == Session["Agence"].ToString()).FirstOrDefault();
            lbAgenceDepart.Text = agence.NomCommercial;
            lbAgenceRetour.Text = agence.NomCommercial;
            lbDateDepart.Text = Session["DateDepart"]?.ToString();
            lbDateRetour.Text = Session["DateRetour"]?.ToString();
            lbHeureDepart.Text = Session["HeureDepart"]?.ToString();
            lbHeureRetour.Text = Session["HeureRetour"]?.ToString();

            List<Offre> offres = (List<Offre>)Session["offres"];
            int idVoiture = int.Parse(Request.QueryString["id"]);

            Offre offreSelectionnee = offres.FirstOrDefault(o => o.Voiture.IdVoiture == idVoiture);
            if (offreSelectionnee != null)
            {
                lbNomVoiture.Text = offreSelectionnee.Voiture.NomCommercial;
                imgVoiture.ImageUrl = "./img/"+offreSelectionnee.Voiture.ImageURL;
                lbTotalTtc.Text = offreSelectionnee.PrixTotalTtc.ToString();

            }
            ChargerAssurance();


        }
        private void ChargerAssurance()
        {
            Cache["assurances"] = AssuranceService.Instance.RechercherAssurance();
            rptAssurances.DataSource = (List<Assurance>)Cache["assurances"];
            rptAssurances.DataBind();

        }

    }

}