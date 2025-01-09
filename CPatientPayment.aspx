<%@ Page Title="" Language="C#" MasterPageFile="~/PatientMasterPage5.master" AutoEventWireup="true" CodeFile="CPatientPayment.aspx.cs" Inherits="CPatientPayment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div class="box-header">
                                    <h3 class="box-title">Payment Portal </h3>                                    
                                </div>
    <div class="box-body table-responsive">
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
         <br />
          <asp:Label ID="Label3" runat="server" Text="Date:" Font-Bold="False" 
             Font-Names="Arial" Font-Size="Medium"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox 
                                  ID="TextBox1" runat="server" Height="26px" Width="225px" Enabled="False"></asp:TextBox> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                              &nbsp;<br />
         <br />
        <asp:Label ID="Label14" runat="server" Text="Payment Amount:" Font-Names="Arial" 
             Font-Size="Medium"></asp:Label>&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox8" runat="server"  Height="26px" Width="225px" Enabled="False"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%--<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                 ErrorMessage="*" ForeColor="#FF5050" ControlToValidate="TextBox10"></asp:RegularExpressionValidator>--%><br />
         <br />

        <asp:Label ID="Label4" runat="server" Text="Card No:" Font-Names="Arial" 
             Font-Size="Medium"></asp:Label>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox 
                                    ID="TextBox9" runat="server"  
                                        Height="26px" Width="225px"></asp:TextBox> 
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
         <br />
         
        <asp:Label ID="Label5" runat="server" Text="Card Holder Name:" Font-Names="Arial" 
             Font-Size="Medium"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Height="26px" Width="225px" ></asp:TextBox>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                                <br />
         
        <asp:Label ID="Label15" runat="server" Text="Valid Up To:" Font-Names="Arial" 
             Font-Size="Medium"></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox10" runat="server" Height="26px" Width="225px" ></asp:TextBox>
                                <br />
                                <br />
         
        <asp:Label ID="Label16" runat="server" Text="CVV:" Font-Names="Arial" 
             Font-Size="Medium"></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox11" runat="server" Height="26px" Width="225px" ></asp:TextBox>
         <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
         <br />      

          &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                 ID="Button3" runat="server" Height="32px"  Text="Make Payment" onclick="Button1_Click"  
        Width="225px"/> &nbsp;&nbsp;<br />
        <br />
         <asp:Label ID="Label11" runat="server" Visible="False"></asp:Label>
          </div>
                         
                                </div><!-- /.box -->

</asp:Content>

