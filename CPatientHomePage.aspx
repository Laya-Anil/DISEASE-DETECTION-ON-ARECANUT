<%@ Page Title="" Language="C#" MasterPageFile="~/PatientMasterPage5.master" AutoEventWireup="true" CodeFile="CPatientHomePage.aspx.cs" Inherits="CPatientHomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div class="box-header">
                                    <h3 class="box-title">User Details</h3>                                    
                                </div><!-- /.box-header -->
                                 
                                <div class="box-body table-responsive">
                                
                          <div>

        <asp:DataList ID="DataList1" runat="server" Font-Names="Verdana" Font-Size="Small" GridLines="Both"  Width="600px">

           <%-- <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />--%>

            <%--<HeaderStyle BackColor="#333333" Font-Bold="True" Font-Size="Large" ForeColor="White"

                HorizontalAlign="Center" VerticalAlign="Middle" />--%>

          <%--  <HeaderTemplate>

                Hospital Details</HeaderTemplate>
--%>
            <ItemStyle BackColor="White" ForeColor="Black"  Font-Names="Verdana" Font-Size="Small" />

            <ItemTemplate>
           
               
                <b>User Name:</b>

                <asp:Label ID="lblCName" runat="server" Text='<%# Bind("username") %>' ></asp:Label>  

                <br />
                 <br />
                <b>Name:</b>

                <asp:Label ID="lblName" runat="server" Text='<%# Bind("name") %>'></asp:Label>

                <br />
                 <br />
              
                  <b>Address:</b>

                <asp:Label ID="Label4" runat="server" Text='<%# Bind("address") %>'></asp:Label>

                <br />
                 <br />

                <b>Mobile No:</b>

                <asp:Label ID="lblCountry" runat="server" Text='<%# Bind("phone") %>'></asp:Label>

                <br />
                 <br />
                 <b>Email:</b>

                <asp:Label ID="Label2" runat="server" Text='<%# Bind("emailid") %>'></asp:Label>

                <br />
                 <br />
                  
            </ItemTemplate>

        </asp:DataList>

    </div>
                                     
                                </div><!-- /.box-body -->
                               
</asp:Content>

