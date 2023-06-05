<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestro/IntroMaster.master"  AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="DirApp_SIVEMMS_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

   <script src="https://code.highcharts.com/highcharts.js"></script>
   <script src="https://code.highcharts.com/highcharts-more.js"></script>
   <script src="../../js/miscelaneos.js"></script>
   <script src="../../js/bootstrap.bundle.min.js"></script>


   <br />
   <br />
   <br />
   <br />
   <div class="container-fluid pb-5 bg-10" >
      <div class="container p-0">
         <div class="row justify-content-center">
            <div class="col-lg-8 col-md-10">
               <!-- box wrapper -->
               <div class="blmd-wrapp">
                  <div class="row">
                     <div class="col-12 text-center pt-3"><img src="../../images/logo_sivemms.svg" alt="SIVEMMS" class="logo-sivemms-ini" /></div>
                     <div class="col-12">
                        <h1>Tablero de control</h1>
                     </div>
                  </div>
                  <div class="row blmd-container">
                     <div class="col-md-12">
                        <div class="input-group blmd-form">
                           <div class="blmd-line">
                              <input type="text" name="username" autocomplete="off" id="" class="form-control">
                              <label class="blmd-label">Usuario</label>
                           </div>
                        </div>
                        <div class="input-group blmd-form">
                           <div class="blmd-line">
                              <input type="password" name="password" autocomplete="off" id="" class="form-control">
                              <label class="blmd-label">Contraseña</label>
                           </div>
                        </div>
                     </div>
                     <div class="col-sm-12 text-center">
                        <%--	<a href="PrincipalRestringida.aspx" class="btn btn-info text-uppercase">Ingresar</a>--%>
                        <%--  <button formaction="PrincipalRestringida.aspx" class="button_Login">Ingresar</button>--%>
                        <a href="PrincipalRestringida.aspx" class="btn btn-lg blue">Ingresar</a>
                        <%--<div class="container">
                           <div class="loader"></div>
                           </div>
                           <script type="text/javascript">
                           $(window).load(function() {
                             $(".loader").fadeOut("slow");
                           });
                           </script>--%>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>

   <div class="container-fluid w95 mt-2 mb-3">
      <div class="row">
         <div class="col-12 text-center">
            <p class="pt-4" style="font-size: .8rem">2018 &reg; Derechos reservados | Datos de contacto, web institucional, etc. </p>
         </div>
      </div>
   </div>
</asp:Content>
