<%@ Page Title="" Language="C#" MasterPageFile="~/PatientMasterPage5.master" AutoEventWireup="true" CodeFile="CPatientChangePwd.aspx.cs" Inherits="CPatientChangePwd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div class="box-header">
                                    <h3 class="box-title">Patient Details</h3>                                    
                                </div><!-- /.box-header -->
                                 
                                <div class="box-body table-responsive">
                                
                         <div style="Width:1000px;text-align:left;padding-left: 20px;">
     
         
                             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                              &nbsp;<br />
        <asp:Label ID="Label14" runat="server" Text="UserName:" Font-Names="Arial" 
             Font-Size="Medium"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox8" runat="server"  Height="26px" Width="225px" Enabled="False"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<%--<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                 ErrorMessage="*" ForeColor="#FF5050" ControlToValidate="TextBox10"></asp:RegularExpressionValidator>--%><br />
         <br />

        <asp:Label ID="Label4" runat="server" Text="Old Password:" Font-Names="Arial" 
             Font-Size="Medium"></asp:Label>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox2" runat="server"  Height="26px" Width="225px"></asp:TextBox>
         <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
         <br />
         
        <asp:Label ID="Label5" runat="server" Text="New Password:" Font-Names="Arial" 
             Font-Size="Medium"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox3" runat="server" Height="26px" Width="225px" ></asp:TextBox>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
         <br />
        <asp:Label ID="Label7" runat="server" Text="Confirm Password:" 
             Font-Names="Arial" Font-Size="Medium"></asp:Label>
       &nbsp;&nbsp;<asp:TextBox 
                                  ID="TextBox5" runat="server" Width="225px"  Height="26px"></asp:TextBox> 
       &nbsp;&nbsp;&nbsp;
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
         <br />      

          &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                 ID="Button3" runat="server" Height="32px" Text="Submit" onclick="Button1_Click"  
        Width="110px"/> &nbsp;&nbsp;<asp:Button ID="Button4" 
                 runat="server" Height="32px" Text="Cancel"   
        Width="112px" onclick="Button2_Click"/>
        
        <br />
        <br />
         <asp:Label ID="Label11" runat="server" Visible="False"></asp:Label>
          </div>
                                     
                                </div><!-- /.box-body -->
</asp:Content>

