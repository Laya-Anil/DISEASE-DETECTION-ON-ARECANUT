<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="HomePage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- basic -->
      <meta charset="utf-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge">
      <!-- mobile metas -->
      <meta name="viewport" content="width=device-width, initial-scale=1">
      <meta name="viewport" content="initial-scale=1, maximum-scale=1">
      <!-- site metas -->
      <title>Greeno</title>
      <meta name="keywords" content="">
      <meta name="description" content="">
      <meta name="author" content="">
      <!-- bootstrap css -->
      <link rel="stylesheet" href="greeno/css/bootstrap.min.css">
      <!-- style css -->
      <link rel="stylesheet" href="greeno/css/style.css">
      <!-- Responsive-->
      <link rel="stylesheet" href="greeno/css/responsive.css">
      <!-- fevicon -->
      <link rel="icon" href="greeno/images/fevicon.png" type="image/gif" />
      <!-- Scrollbar Custom CSS -->
      <link rel="stylesheet" href="greeno/css/jquery.mCustomScrollbar.min.css">
      <!-- Tweaks for older IEs-->
      <link rel="stylesheet" href="https://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css">
      <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.css" media="screen">
      <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script><![endif]-->
</head>
 <body class="main-layout">
      <!-- loader  -->
      <div class="loader_bg">
         <div class="loader"><img src="greeno/images/loading.gif" alt="#" /></div>
      </div>
      <!-- end loader -->
      <!-- header -->
      <header>
         <!-- header inner -->
         <div class="header">
            <div class="container">
               <div class="row">
                  <div class="col-xl-3 col-lg-3 col-md-3 col-sm-3 col logo_section">
                     <div class="full">
                        <div class="center-desk">
                           <div class="logo"> <a href="HomePage.aspx"><img src="greeno/images/logo.png" alt="#"></a> </div>
                        </div>
                     </div>
                  </div>
                  <div class="col-xl-9 col-lg-9 col-md-9 col-sm-9">
                     <div class="menu-area">
                        <div class="limit-box">
                           <nav class="main-menu">
                              <ul class="menu-area-main">
                                 <li class="active"> <a href="HomePage.aspx">Home</a> </li>
                                 <li> <a href="#about">About</a> </li>
                                 <li><a href="UserRegistration.aspx">Register User</a></li>
                                 <li><a href="#contact">Contact Us</a></li>
                                 <li class="last"><a href="#"><img src="greeno/images/search_icon.png" alt="icon"/></a></li>
                              </ul>
                           </nav>
                        </div>
                     </div>
                  </div>
               </div>
            </div>
         </div>
         <!-- end header inner -->
      </header>
      <!-- end header -->
      <section >
         <div id="main_slider" class="carousel slide banner-main" data-ride="carousel">
            <ol class="carousel-indicators">
               <li data-target="#main_slider" data-slide-to="0" class="active"></li>
               <li data-target="#main_slider" data-slide-to="1"></li>
               <li data-target="#main_slider" data-slide-to="2"></li>
            </ol>
            <div class="carousel-inner">
               <div class="carousel-item active">
                  <div class="container">
                     <div class="row marginii">
                        <div class="col-xl-6 col-lg-6 col-md-6 col-sm-12">
                           <div class="carousel-caption ">
                              <h1>Welcome To The <strong class="color">Arecanut Disease Detection</strong></h1>
                              <p>Arecanut is a tropical crop, which is popularly known as betel nut. India ranks second in producing and consuming arecanut in the world.</p>
                          <%--    <a class="btn btn-lg btn-primary" href="#" role="button">About</a>
                              <a class="btn btn-lg btn-primary" href="#" role="button">Contact US</a>--%>
                           </div>
                        </div>
                        <div class="col-xl-6 col-lg-6 col-md-6 col-sm-12">
                           <div class="img-box">
                              <figure><img src="greeno/images/Palm_I_IMG_2108.png" alt="img"/></figure>
                           </div>
                        </div>
                     </div>
                  </div>
               </div>
               <div class="carousel-item">
                  <div class="container">
                     <div class="row marginii">
                        <div class="col-xl-6 col-lg-6 col-md-6 col-sm-12">
                           <div class="carousel-caption ">
                              <h1>Welcome To The <strong class="color">Arecanut Disease Detection</strong></h1>
                              <p>Arecanut is a tropical crop, which is popularly known as betel nut. India ranks second in producing and consuming arecanut in the world.</p>
                             <%-- <a class="btn btn-lg btn-primary" href="#" role="button">About</a>
                              <a class="btn btn-lg btn-primary" href="#" role="button">Contact US</a>--%>
                           </div>
                        </div>
                        <div class="col-xl-6 col-lg-6 col-md-6 col-sm-12">
                           <div class="img-box ">
                              <figure><img src="greeno/images/a5a.png" alt="img"/></figure>
                           </div>
                        </div>
                     </div>
                  </div>
               </div>
               <div class="carousel-item">
                  <div class="container">
                     <div class="row marginii">
                        <div class="col-xl-6 col-lg-6 col-md-6 col-sm-12">
                           <div class="carousel-caption ">
                              <h1>Welcome To The <strong class="color">Arecanut Disease Detection</strong></h1>
                              <p>Arecanut is a tropical crop, which is popularly known as betel nut. India ranks second in producing and consuming arecanut in the world.</p>
                              <%--<a class="btn btn-lg btn-primary" href="#" role="button">About</a>
                              <a class="btn btn-lg btn-primary" href="#" role="button">Contact US</a>--%>
                           </div>
                        </div>
                        <div class="col-xl-6 col-lg-6 col-md-6 col-sm-12">
                           <div class="img-box">
                              <figure><img src="greeno/images/a2a.png" alt="img"/></figure>
                           </div>
                        </div>
                     </div>
                  </div>
               </div>
            </div>
            <a class="carousel-control-prev" href="#main_slider" role="button" data-slide="prev">
            <i class='fa fa-angle-left'></i></a>
            <a class="carousel-control-next" href="#main_slider" role="button" data-slide="next">
            <i class='fa fa-angle-right'></i>
            </a>
         </div>
      </section>
      <!-- plant -->
      <div id="plant" class="plants">
         <div class="container">
            <div class="row">
               <div class="col-md-12 ">
                  <div class="titlepage">
                     <h2>Arecanut Disease Detection</h2>
                   <%--  <span>looking at its layout. The point of using Lorem Ipsumletters, as opposed to usingl</span>--%>
                  </div>
               </div>
            </div>
         </div>
         <div class="container">
            <div class="row">
               <div class="col-xl-4 col-lg-4 col-md-6 col-sm-12">
                  <div class="plants-box">
                     <figure><img src="greeno/images/plant1.jpg" alt="img"/></figure>
                     <h3> Leaf </h3>
                   <%--  <p>It is a long established fact that a reader will be distracted by the readable content of a page   when looking at its layout. The point of using Lorem Ipsumletters, as opposed to using</p>--%>
                  </div>
               </div>
               <div class="col-xl-4 col-lg-4 col-md-6 col-sm-12">
                  <div class="plants-box">
                     <figure><img src="greeno/images/plant2.jpg" alt="img"/></figure>
                     <h3> Fruit </h3>
                     <%--<p>It is a long established fact that a reader will be distracted by the readable content of a page   when looking at its layout. The point of using Lorem Ipsumletters, as opposed to using</p>--%>
                  </div>
               </div>
               <div class="col-xl-4 col-lg-4 col-md-6 col-sm-12">
                 <%-- <div class="plants-box">--%>
                      <form id="form2" runat="server"   style="background-color:White;" >
                       <%-- <div style="z-index: 102; left: 5px; width: 400px; position: absolute; top: 50px; height: 200px">--%>
                         <h1 style="font-family: 'Times New Roman', Times, serif; font-size: x-large; font-weight: bold; color: #000000"><span></span>Login Details</h1>  
      <asp:Label ID="Label13" runat="server" Text="Username:" Font-Bold="True" 
            Font-Names="Arial" Font-Size="Medium"></asp:Label>
        &nbsp;&nbsp;<asp:TextBox ID="TextBox8" runat="server" Height="28px" Width="225px" ></asp:TextBox>
             <br />        
          <asp:Label ID="Label15" runat="server" Text="Password:" Font-Bold="True" 
            Font-Names="Arial" Font-Size="Medium"></asp:Label>
        &nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox10" runat="server" Width="225px" Height="28px" 
                                 TextMode="Password" ></asp:TextBox>
             <br />
             <br />
     <asp:Button 
                 ID="Button1" runat="server" Height="40px" Text="Login"  
                 style="background-color:#31850b;border:1px Solid gray;color:white;" onclick="Button1_Click"  
        Width="105px"/> &nbsp;&nbsp;<asp:Button ID="Button2" 
                 runat="server" Height="40px"  Text="Cancel"  style="background-color:#31850b;border:1px Solid gray;color:white;"  
        Width="105px" onclick="Button2_Click"/>
    
        <br />
         <br />
                       
         <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    <%--</div>--%>
                        </form> 
                  </div>
               </div>
              <%-- <div class="col-xl-4 col-lg-4 col-md-6 col-sm-12">
                  <div class="plants-box">
                     <figure><img src="greeno/images/plant1.jpg" alt="img"/></figure>
                     <h3> Floral Vibrant</h3>
                     <p>It is a long established fact that a reader will be distracted by the readable content of a page   when looking at its layout. The point of using Lorem Ipsumletters, as opposed to using</p>
                  </div>
               </div>--%>
               <%--<div class="col-xl-4 col-lg-4 col-md-6 col-sm-12">
                  <div class="plants-box">
                     <figure><img src="greeno/images/plant2.jpg" alt="img"/></figure>
                     <h3> Floral Vibrant</h3>
                     <p>It is a long established fact that a reader will be distracted by the readable content of a page   when looking at its layout. The point of using Lorem Ipsumletters, as opposed to using</p>
                  </div>
               </div>--%>
               <%--<div class="col-xl-4 col-lg-4 col-md-6 col-sm-12">
                  <div class="plants-box">
                     <figure><img src="greeno/images/plant3.jpg" alt="img"/></figure>
                     <h3> Floral Vibrant</h3>
                     <p>It is a long established fact that a reader will be distracted by the readable content of a page   when looking at its layout. The point of using Lorem Ipsumletters, as opposed to using</p>
                  </div>
               </div>--%>
            </div>
         </div>
      </div>
      <!-- end plant -->
      <!-- about -->
      <div id="about" class="about">
         <div class="container">
            <div class="row">
               <div class="col-xl-6 col-lg-6 col-md-6 col-sm-12">
                  <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12">
                     <div class="about-box">
                        <%--<h2>50</h2>--%>
                        <div class="white-bg">
                           <span>Segmentation </span> 
                        </div>
                     </div>
                  </div>
                  <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12">
                     <div class="about-box">
                      <%--  <h2>50</h2>--%>
                        <div class="white-bg">
                           <span>Classification</span> 
                        </div>
                     </div>
                  </div>
                  <div class="col-xl-12 col-lg-12 col-md-12 col-sm-12">
                     <div class="about-box">
                      <%--  <h2>50</h2>--%>
                        <div class="white-bg">
                           <span>CNN Algorithm</span> 
                        </div>
                     </div>
                  </div>
               </div>
               <div class="col-xl-6 col-lg-6 col-md-6 col-sm-12">
                  <div class="about-box">
                     <div class="titlepage">
                        <h2>About US</h2>
                        <span style="text-align:justify;">Arecanut is a tropical crop, which is popularly
known as betel nut. India ranks second in producing and
consuming arecanut in the world. Throughout its life cycle, it
is affected by a variety of diseases, from root to fruit.  In this
paper, we proposed a system that helps in detecting the
diseases of arecanut, leaves using Convolutional
Neural Networks.</span> 
                        <div class="read-more">
                          <%-- <a  href="#">Read More</a>--%>
                        </div>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
     
      <!-- footer -->
      <footer>
         <div id="contact" class="footer">
            <div class="container">
               <div class="row pdn-top-30">
                  <div class="col-md-12 ">
                     <div class="footer-box">
                        <div class="headinga">
                           <h3>Address</h3>
                           <span>Trivandrum, Kerala</span>
                           <p>(+91 9847653481)</p>
                        </div>
                        <ul class="location_icon">
                           <li> <a href="#"><img src="greeno/icon/facebook.png"></a></li>
                           <li> <a href="#"><img src="greeno/icon/Twitter.png"></a></li>
                           <li> <a href="#"><img src="greeno/icon/linkedin.png"></a></li>
                           <li> <a href="#"><img src="greeno/icon/instagram.png"></a></li>
                        </ul>
                       <%-- <div class="menu-bottom">
                           <ul class="link">
                              <li> <a href="#">Home</a></li>
                              <li> <a href="#">About</a></li>
                              <li> <a href="#"> Plant</a></li>
                              <li> <a href="#">Gallery</a></li>
                              <li> <a href="#"> Contact us</a></li>
                           </ul>
                        </div>--%>
                     </div>
                  </div>
               </div>
            </div>
            <div class="copyright">
               <div class="container">
                 <%-- <p>Copyright 2019 All Rights Reserved Design By  <a href="https://html.design/">Free Html Templates</a></p>--%>
               </div>
            </div>
         </div>
      </footer>
      <!-- end footer -->
      <!-- Javascript files-->
      <script src="greeno/js/jquery.min.js"></script>
      <script src="greeno/js/popper.min.js"></script>
      <script src="greeno/js/bootstrap.bundle.min.js"></script>
      <script src="greeno/js/jquery-3.0.0.min.js"></script>
      <script src="greeno/js/plugin.js"></script>
      <!-- sidebar -->
      <script src="greeno/js/jquery.mCustomScrollbar.concat.min.js"></script>
      <script src="greeno/js/custom.js"></script>
      <!-- javascript --> 
      <script src="greeno/js/owl.carousel.js"></script>
      <script src="https:cdnjs.cloudflare.com/ajax/libs/fancybox/2.1.5/jquery.fancybox.min.js"></script>
      <script>
          $(document).ready(function () {
              $(".fancybox").fancybox({
                  openEffect: "none",
                  closeEffect: "none"
              });

              $(".zoom").hover(function () {

                  $(this).addClass('transition');
              }, function () {

                  $(this).removeClass('transition');
              });
          });
         
      </script> 
  
    
</body>
</html>
