using System;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Web.UI.WebControls;
using AppLocationVoiture.BLL;
using AppLocationVoiture.DAL;

namespace AppLocationVoiture
{
    public partial class AdminOptions : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindOptions();
            }
        }

        private void BindOptions()
        {
            gvOptions.DataSource = OptionsService.Instance.GetAllOptions();
            gvOptions.DataBind();
        }

        protected void btnAddOption_Click(object sender, EventArgs e)
        {
            var option = new DAL.Options
            {
                Libelle = txtLibelle.Text,
                Description = txtDescription.Text,
                PrixTTC = string.IsNullOrEmpty(txtPrixTTC.Text) ? (decimal?)null : Convert.ToDecimal(txtPrixTTC.Text)
            };

            OptionsService.Instance.AddOption(option);
            BindOptions();
        }

        protected void gvOptions_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            gvOptions.EditIndex = e.NewEditIndex;
            BindOptions();
        }

        protected void gvOptions_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            int optionId = Convert.ToInt32(gvOptions.DataKeys[e.RowIndex].Value);


            OptionsService.Instance.DeleteOption(optionId);
            BindOptions();
        }

        protected void gvOptions_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            int optionId = Convert.ToInt32(gvOptions.DataKeys[e.RowIndex].Value);
            var option = OptionsService.Instance.GetAllOptions().FirstOrDefault(o => o.IdOption == optionId);

            if (option != null)
            {
                option.Libelle = ((TextBox)gvOptions.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
                //(gvOptions.Rows[e.RowIndex].FindControl("txtLibelleEdit") as TextBox).Text;
                option.Description = ((TextBox)gvOptions.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
                option.PrixTTC = 
                     Convert.ToDecimal(((TextBox)gvOptions.Rows[e.RowIndex].Cells[3].Controls[0]).Text);

                OptionsService.Instance.UpdateOption(option);
                gvOptions.EditIndex = -1;
                BindOptions();
            }
        }
    }
}
