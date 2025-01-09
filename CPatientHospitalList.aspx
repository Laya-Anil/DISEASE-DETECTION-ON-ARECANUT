<%@ Page Title="" Language="C#" MasterPageFile="~/PatientMasterPage5.master" AutoEventWireup="true" CodeFile="CPatientHospitalList.aspx.cs" Inherits="CPatientHospitalList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div class="box-header">
                                    <h3 class="box-title">User Details </h3>                                    
                                </div><!-- /.box-header -->
                                 
                                <div class="box-body table-responsive">
                                
                       <asp:DataList ID="DataList1" runat="server"       
        OnCancelCommand="DataList1_CancelCommand" DataKeyField="uid" onselectedindexchanged="DataList1_SelectedIndexChanged" >
            <HeaderTemplate>
               <table class="table table-bordered table-striped">
                  <tr>
                    <th>
                      User ID
                     </th>
                     <th>
                        User Name
                     </th>
                     <th>
                        Name
                     </th>
                     <th>
                       Address
                     </th>
                     <th>
                       phone
                     </th>
                     <th>
                       Email
                     </th>
                    
                  </tr>
                 
            </HeaderTemplate>
            <ItemTemplate>
           
               <tr >
              <td>
                 <%# Eval("uid")%>
               </td>
               <td>
                <%# Eval("username")%>
               </td>
               <td>
                <%# Eval("name")%> 
               </td>
               <td>
                <%# Eval("address")%>
               </td>
                <td>
                <%# Eval("phone")%>
               </td>
               <td>
                <%# Eval("emailid")%>
               </td>
               
            </tr>
       
         </ItemTemplate>
       
</asp:DataList>
                         
                                </div><!-- /.box -->
</asp:Content>

