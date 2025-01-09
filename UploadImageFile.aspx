<%@ Page Title="" Language="C#" MasterPageFile="~/PatientMasterPage5.master" AutoEventWireup="true" CodeFile="UploadImageFile.aspx.cs" Inherits="UploadImageFile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="Width:1300px;text-align:left;padding-left: 50px;">
         <div class="form-w3agile form1">
           <asp:Label ID="Label8" runat="server" Font-Bold="True" ForeColor="Black" Font-Size = "X-Large"
            Text="Detection"></asp:Label>
             <br />
               <br />
         
         <asp:Label ID="Label18" runat="server" Text="Browse Image For Plant Disease  Detection:" 
                 ForeColor="Black" Font-Names="Arial" Font-Size="Large"></asp:Label>            
             <%--<div style="margin-top:-18px;margin-left:225px;"> --%>
          &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;<asp:FileUpload ID="FileUpload1" 
                 runat="server" Width="451px" Height="31px" onload="FileUpload1_Load"/> 
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" 
                 ControlToValidate="FileUpload1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator><%--</div>--%>
                 <br />
                  
                  <br />
              &nbsp;<asp:Button 
                 ID="Button1" runat="server" Height="47px" Text="Search"  
                  style="background-color:#31850b;border:1px Solid gray;color:white;" onclick="Button1_Click"  
        Width="448px" Font-Names="Arial" Font-Size="Medium"/>
             <br />
              <br />
  <asp:Label ID="Label1" runat="server" Text="Image:" 
             Font-Names="Arial" Font-Size="Medium"></asp:Label> 
                <br />
             <asp:Image ID="Image1" runat="server" Width="457px" Height="259px" />
                  <br />
                  
                  <br />
             <br />
                  <asp:ListBox ID="ListBox1" runat="server" Height="160px" Width="462px">
             </asp:ListBox>
                  <br />
                  <br />
                
         <asp:Label ID="Label13" runat="server" Text="Disease State:" 
             Font-Names="Arial" Font-Size="Medium"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox10" runat="server" Width="330px" ></asp:TextBox>
             <br />
             <br />
                
         <asp:Label ID="Label19" runat="server" Text="Disease Type:" 
             Font-Names="Arial" Font-Size="Medium"></asp:Label> &nbsp; &nbsp; &nbsp;
             <asp:TextBox ID="TextBox11" runat="server" Width="330px" ></asp:TextBox>
             <br />
             <br />
                
         <asp:Label ID="Label20" runat="server" Text="Disease Stage:" 
             Font-Names="Arial" Font-Size="Medium"></asp:Label> &nbsp; &nbsp; 
             <asp:TextBox ID="TextBox12" runat="server" Width="330px" ></asp:TextBox>
          <br />
           <br />
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp 
  <br />
           <br />
             &nbsp;&nbsp;&nbsp;</div>


</asp:Content>

