<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reservation.aspx.cs" Inherits="AppLocationVoiture.PageReservation" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-4">
            <asp:DropDownList ID="dlAgences" runat="server" CssClass="form-control">
            </asp:DropDownList>
        </div>
        <div class="col-md-3">
            <!-- Date Picker -->
            <div class="form-group mb-4">
                <div class="datepicker date input-group">
                    <asp:TextBox ID="tbDateDepart" placeholder="Date de départ " class="form-control" runat="server"></asp:TextBox>
                    <div class="input-group-append">
                        <span class="input-group-text"><i class="fa fa-calendar"></i></span>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-1 pad0">
            <!-- // Date Picker -->
            <asp:DropDownList ID="dlHeureDepart" runat="server" CssClass="form-control heure_select">
                <asp:ListItem Value="7h30" Text="7h30"> </asp:ListItem>
                <asp:ListItem Value="8h00" Text="8h00"> </asp:ListItem>
                <asp:ListItem Value="8h30" Text="8h30"> </asp:ListItem>
                <asp:ListItem Value="9h00" Text="9h00"> </asp:ListItem>
                <asp:ListItem Value="9h30" Text="9h30"> </asp:ListItem>
                <asp:ListItem Value="10h00" Text="10h00"> </asp:ListItem>
                <asp:ListItem Value="10h30" Text="10h30"> </asp:ListItem>
                <asp:ListItem Value="11h00" Text="11h00"> </asp:ListItem>
                <asp:ListItem Value="11h30" Text="11h30"> </asp:ListItem>
                <asp:ListItem Value="12h00" Text="12h00"> </asp:ListItem>
                <asp:ListItem Value="12h30" Text="12h30"> </asp:ListItem>
                <asp:ListItem Value="13h00" Text="13h00"> </asp:ListItem>
                <asp:ListItem Value="13h30" Text="13h30"> </asp:ListItem>
                <asp:ListItem Value="14h00" Text="14h00"> </asp:ListItem>
                <asp:ListItem Value="14h30" Text="14h30"> </asp:ListItem>
                <asp:ListItem Value="15h00" Text="15h00"> </asp:ListItem>
                <asp:ListItem Value="15h30" Text="15h30"> </asp:ListItem>
                <asp:ListItem Value="16h00" Text="16h00"> </asp:ListItem>
                <asp:ListItem Value="16h30" Text="16h30"> </asp:ListItem>
                <asp:ListItem Value="17h00" Text="17h00"> </asp:ListItem>
                <asp:ListItem Value="17h30" Text="17h30"> </asp:ListItem>
                <asp:ListItem Value="18h00" Text="18h00"> </asp:ListItem>
                <asp:ListItem Value="18h30" Text="18h30"> </asp:ListItem>
                <asp:ListItem Value="19h00" Text="19h00"> </asp:ListItem>
                <asp:ListItem Value="19h30" Text="19h30"> </asp:ListItem>
                <asp:ListItem Value="20h00" Text="20h00"> </asp:ListItem>
                <asp:ListItem Value="20h30" Text="20h30"> </asp:ListItem>
                <asp:ListItem Value="21h00" Text="21h00"> </asp:ListItem>
                <asp:ListItem Value="21h30" Text="21h30"> </asp:ListItem>
                <asp:ListItem Value="22h00" Text="22h30"> </asp:ListItem>
                <asp:ListItem Value="22h30" Text="22h30"> </asp:ListItem>
                <asp:ListItem Value="23h00" Text="23h00"> </asp:ListItem>
                <asp:ListItem Value="23h30" Text="23h30"> </asp:ListItem>
                <asp:ListItem Value="00h00" Text="00h00"> </asp:ListItem>



            </asp:DropDownList>

        </div>
        <div class="col-md-3">
            <!-- Date Picker -->
            <div class="form-group mb-4">
                <div class="datepicker date input-group">
                    <asp:TextBox ID="tbDateRetour" placeholder="Date de retour" class="form-control" runat="server"></asp:TextBox>

                    <div class="input-group-append">
                        <span class="input-group-text"><i class="fa fa-calendar"></i></span>
                    </div>
                </div>
            </div>

            <!-- // Date Picker -->
        </div>
        <div class="col-md-1 pad0">
            <asp:DropDownList ID="dlHeureRetour" runat="server" CssClass="form-control heure_select">
                <asp:ListItem Value="7h30" Text="7h30"> </asp:ListItem>
                <asp:ListItem Value="8h00" Text="8h00"> </asp:ListItem>
                <asp:ListItem Value="8h30" Text="8h30"> </asp:ListItem>
                <asp:ListItem Value="9h00" Text="9h00"> </asp:ListItem>
                <asp:ListItem Value="9h30" Text="9h30"> </asp:ListItem>
                <asp:ListItem Value="10h00" Text="10h00"> </asp:ListItem>
                <asp:ListItem Value="10h30" Text="10h30"> </asp:ListItem>
                <asp:ListItem Value="11h00" Text="11h00"> </asp:ListItem>
                <asp:ListItem Value="11h30" Text="11h30"> </asp:ListItem>
                <asp:ListItem Value="12h00" Text="12h00"> </asp:ListItem>
                <asp:ListItem Value="12h30" Text="12h30"> </asp:ListItem>
                <asp:ListItem Value="13h00" Text="13h00"> </asp:ListItem>
                <asp:ListItem Value="13h30" Text="13h30"> </asp:ListItem>
                <asp:ListItem Value="14h00" Text="14h00"> </asp:ListItem>
                <asp:ListItem Value="14h30" Text="14h30"> </asp:ListItem>
                <asp:ListItem Value="15h00" Text="15h00"> </asp:ListItem>
                <asp:ListItem Value="15h30" Text="15h30"> </asp:ListItem>
                <asp:ListItem Value="16h00" Text="16h00"> </asp:ListItem>
                <asp:ListItem Value="16h30" Text="16h30"> </asp:ListItem>
                <asp:ListItem Value="17h00" Text="17h00"> </asp:ListItem>
                <asp:ListItem Value="17h30" Text="17h30"> </asp:ListItem>
                <asp:ListItem Value="18h00" Text="18h00"> </asp:ListItem>
                <asp:ListItem Value="18h30" Text="18h30"> </asp:ListItem>
                <asp:ListItem Value="19h00" Text="19h00"> </asp:ListItem>
                <asp:ListItem Value="19h30" Text="19h30"> </asp:ListItem>
                <asp:ListItem Value="20h00" Text="20h00"> </asp:ListItem>
                <asp:ListItem Value="20h30" Text="20h30"> </asp:ListItem>
                <asp:ListItem Value="21h00" Text="21h00"> </asp:ListItem>
                <asp:ListItem Value="21h30" Text="21h30"> </asp:ListItem>
                <asp:ListItem Value="22h00" Text="22h30"> </asp:ListItem>
                <asp:ListItem Value="22h30" Text="22h30"> </asp:ListItem>
                <asp:ListItem Value="23h00" Text="23h00"> </asp:ListItem>
                <asp:ListItem Value="23h30" Text="23h30"> </asp:ListItem>
                <asp:ListItem Value="00h00" Text="00h00"> </asp:ListItem>
            </asp:DropDownList>

        </div>

    </div>




    <div class="text-right">
        <asp:Button ID="btnValider" runat="server" Text="Rechercher" OnClick="btnValider_Click" CssClass="btn btn-primary" />
    </div>
    <asp:Label ID="lbErreur" runat="server" CssClass="alert"></asp:Label>

    <asp:Repeater ID="rptVoitures" runat="server" ItemType="AppLocationVoiture.BLL.Offre" OnItemCommand="rptVoitures_ItemCommand">
        <ItemTemplate>
            <div class="row">
                <div class="col-md-4">
                    <img src="<%#"./Img/"+ Item.Voiture.ImageURL %>" style="max-height: 180px;">
                </div>
                <div class="col-md-5">
                    <div style="font-size: 28px; font-weight: bold">
                    <%# Item.Voiture.NomCommercial %>  </div>
                    <br />
                    <div class="caracteristique">
                        <img src="./Img/picto/places.svg" style="width: 18px; height: 18px; min-width: 18px; min-height: 18px;">
                        <%# Item.Voiture.NombrePlaces %>
                    </div>

                    <div class="caracteristique">
                        <img src="./Img/picto/portes.svg" style="width: 18px; height: 18px; min-width: 18px; min-height: 18px;">
                        <%# Item.Voiture.NombrePortes %>
                    </div>
                     <div class="caracteristique">
     <img src="./Img/picto/valises.svg" style="width: 18px; height: 18px; min-width: 18px; min-height: 18px;">
     <%# Item.Voiture.CapaciteCoffre %>
 </div>
                                        <div class="caracteristique">
    <img src="./Img/picto/autonomie.svg" style="width: 18px; height: 18px; min-width: 18px; min-height: 18px;">
    <%# Item.Voiture.Autonomie %>
</div>
                                        <div class="caracteristique">

    <img src="./Img/picto/climatisation.svg" style="width: 18px; height: 18px; min-width: 18px; min-height: 18px;">
<h10> climatisation </h10>
</div>
                </div>

                <div class="col-md-3">
                    <div style="font-size: 24px">
                        <span style="font-size: 28px; font-weight: bold">
                            <%# Item.PrixJourTtc %>€ </span>/jour
                        <br />
                        Total <%# Item.PrixTotalTtc %>€
                        <br />
                    </div>
                    <asp:Button ID="btnSelectionner" runat="server" Text="Selectionner" CommandName="Selectionner" CommandArgument="<%# Item.Voiture.IdVoiture %>" CssClass="btn btn-warning" />
                </div>
            </div>

        </ItemTemplate>
    </asp:Repeater>


</asp:Content>
