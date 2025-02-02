<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Commande.aspx.cs" Inherits="AppLocationVoiture.Commande" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-5">
            <div class="step_container">
                <span class="step">1</span>Agences de location
            <div class="row">
                <div class="col-md-6">
                    Départ<br />
                    <asp:Label ID="lbAgenceDepart" runat="server"></asp:Label><br />
                    <span>
                        <asp:Label ID="lbDateDepart" runat="server"></asp:Label>
                        <asp:Label ID="lbHeureDepart" runat="server"></asp:Label>
                    </span>
                </div>
                <div class="col-md-6">
                    Retour
                    <br />
                    <asp:Label ID="lbAgenceRetour" runat="server"></asp:Label>
                    <span>
                        <asp:Label ID="lbDateRetour" runat="server"></asp:Label>
                        <asp:Label ID="lbHeureRetour" runat="server"></asp:Label>
                    </span>

                </div>

            </div>

            </div>
        </div>


        <div class="col-md-2">
            <div class="step_container">
                <span class="step">2</span>Véhicules
            <asp:Label ID="lbNomVoiture" runat="server"></asp:Label>
                <asp:Image ID="imgVoiture" runat="server" Style="max-height: 50px;" />
                <asp:Label ID="lbTotalTtc" runat="server"></asp:Label>€
            </div>
        </div>

        <div class="col-md-3">
            <div class="step_container actif">

                <span class="step">3</span>Protection et options
              <div class="row">
                  <div class="col-md-6">


                      <asp:Label ID="lbAssurance" Text="Basic" runat="server"></asp:Label><br />
                      <span>
                          <asp:Label ID="lbPrixAssurance" Text="0.00" runat="server"></asp:Label>€
                      </span>

                  </div>
                  <div class="col-md-6">
                      <asp:Label ID="lbNombreOptions" Text="0" runat="server"></asp:Label>
                      Options
          <span>
              <asp:Label ID="lbTotalOptions" Text="0.00" runat="server"></asp:Label>€
          </span>

                  </div>
              </div>
            </div>
        </div>


        <div class="col-md-2">
            <div class="step_container">
                <span class="step">4</span>Résumé
            </div>
        </div>
    </div>


    <div class="row">
        <asp:Repeater ID="rptAssurances" ItemType="AppLocationVoiture.DAL.Assurance" runat="server">
            <ItemTemplate>
                <div class="col-md-4">
                    <div class="bloc_assurance">
                        <h3>
                            <%# Item.Libelle %>
                        </h3>

                        <div>
                            <strong>Franchise à 
                        <%# Item.Franchise %> € </strong>

                        </div>

                        <div>
                            <span style="font-weight: bold; font-size: 22px">
                                <%# Item.PrixTtc %> €
               </span>
                        </div>
                        <div style="text-align:left">
                        <ul>
                            <li>Protection contre les dommages résultant d'une collision</li>
                            <li>Protection contre le vol</li>
                            <li>Protection bris de glace, phares et pneumatiques</li>
                            <li>Protection personnelle accident (conducteur et passagers)</li>
                            <li>Protection des biens personnels</li>
                        </ul>
                            </div>
                        <asp:Button ID="btnSelectionner" runat="server" Text="Selectionner" CommandName="Selectionner" CommandArgument="<%# Item.IdAssurance %>" CssClass="btn btn-warning" />
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
