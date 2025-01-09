<%@ Page Title="" Language="C#" MasterPageFile="~/PatientMasterPage5.master" AutoEventWireup="true" CodeFile="CPatientMail.aspx.cs" Inherits="CPatientMail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<section class="content">
                    <!-- MAILBOX BEGIN -->
                    <div class="mailbox row">
                        <div class="col-xs-12">
                            <div class="box box-solid">
                                <div class="box-body">
                                    <div class="row">
                                        <div class="col-md-3 col-sm-4">
                                            <!-- BOXES are complex enough to move the .box-header around.
                                                 This is an example of having the box header within the box body -->
                                            <div class="box-header">
                                                <i class="fa fa-inbox"></i>
                                                <h3 class="box-title">INBOX</h3>
                                            </div>
                                            <!-- compose message btn -->
                                            <a class="btn btn-block btn-primary"  href="CPatientMailCompose.aspx"><i class="fa fa-pencil"></i> Compose Message</a>
                                            <!-- Navigation - folders-->
                                            <div style="margin-top: 15px;">
                                                <ul class="nav nav-pills nav-stacked">
                                                    <li class="header">Folders</li>
                                                    <li class="active"><a href="CPatientMail.aspx"><i class="fa fa-inbox"></i> Inbox </a></li>
                                                    <%--<li><a href="#"><i class="fa fa-pencil-square-o"></i> Drafts</a></li>
                                                    <li><a href="#"><i class="fa fa-mail-forward"></i> Sent</a></li>
                                                    <li><a href="#"><i class="fa fa-star"></i> Starred</a></li>
                                                    <li><a href="#"><i class="fa fa-folder"></i> Junk</a></li>--%>
                                                </ul>
                                            </div>
                                        </div><!-- /.col (LEFT) -->
                                        <div class="col-md-9 col-sm-8">
                                            
                                             <asp:DataList ID="DataList1" runat="server" DataKeyField="mid" Width="700px" 
                                                onselectedindexchanged="DataList1_SelectedIndexChanged" 
                                                onitemcommand="DataList1_ItemCommand" >
                                              <HeaderTemplate>
                                               <div class="table-responsive">
                                                <!-- THE MESSAGES -->
                                                <table class="table table-mailbox">
                                                    <tr class="unread">
                                                    <%--  <td class="small-col"><input type="checkbox" /></td>--%>
                                                        <td class="small-col"><i class="fa fa-star"></i></td>
                                                        <td class="name"><a href="#"> Username </a></td>
                                                        <td class="subject"><a href="#"> Subject</a></td>
                                                        <td class="time"> Date </td>
                                                    </tr> 
                                                   
                                                </table>
                                            </div>

                                               </HeaderTemplate>
                                            <ItemTemplate>
                                            <div class="table-responsive">
                                                <!-- THE MESSAGES -->
                                                <table class="table table-mailbox">
                                                    <tr class="unread">
                                                       <%-- <td class="small-col"><input type="checkbox" /></td>--%>
                                                        <td class="small-col"><i class="fa fa-star"></i></td>
                                                       <%-- <td class="name"><a href="#"> <%# Eval("mfrom")%></a></td>--%>

                                                        <td class="name"> <%# Eval("mfrom")%></td>
                                                       <%--  <td class="subject"><a href="#"> <%# Eval("subject")%></a></td>--%>
                                                        <td class="subject"><asp:LinkButton ID="LinkButton1" runat="server"> <%# Eval("subject")%></asp:LinkButton></td>
                                                        <td class="time"> <%# Eval("mdate")%></td>
                                                    </tr>
                                                   
                                                </table>
                                            </div><!-- /.table-responsive -->
                                            </ItemTemplate>
                                            </asp:DataList>
                                        </div><!-- /.col (RIGHT) -->
                                    </div><!-- /.row -->
                                </div><!-- /.box-body -->
                                <div class="box-footer clearfix">
                                 
                                </div><!-- box-footer -->
                            </div><!-- /.box -->
                        </div><!-- /.col (MAIN) -->
                    </div>
                    <!-- MAILBOX END -->

                </section><!-- /.content -->
</asp:Content>

