<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestro/IntroMaster.master"  AutoEventWireup="true" CodeFile="Letalidad.aspx.cs" Inherits="DirApp_SIVEMMS_Letalidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script src="https://code.highcharts.com/highcharts.js"></script>
    <script src="https://code.highcharts.com/highcharts-more.js"></script>
    <script src="../../js/miscelaneos.js"></script>
    <script src="../../js/bootstrap.bundle.min.js"></script>
    <script src="../../js/graficas/pintarGraficas.js"></script>
    <script src="../../js/Letalidad.js"></script>



<!--Título-->
<div class="container-fluid pt-100 bg-10">
   <div class="container-fluid w98">
      <div class="row">
         <div class="col-11">
            <h1 class="hvr-underline-from-left">Letalidad</h1>
         </div>
         <div class="col-1 text-right"><a href="Principal.aspx" class="btn btn-regreso"></a></div>
      </div>
   </div>
</div>

	
<!--Combos-->
<div class="container-fluid bg-10 pt-3 pb-3" id="combos-sup">
   <div class="container-fluid w98">
      <div class="row">
         <div class="col-6 col-lg-2 col-md-4">
            <div class="form-group-sm">
               <label for="" class="combos">Institución:</label>
               <select class="form-control" id="cboInstitucion" onchange="cboInstitucionChange()">
                  <option value="-1">Todas</option>
               </select>
            </div>
         </div>
         <div class="col-6 col-lg-2 col-md-4">
            <div class="form-group-sm">
               <label for="" class="combos">Entidad:</label>
               <select class="form-control" id="cboEntidad" onchange ="cboEntidadChange()">
                  <option value="-1">Todas</option>
               </select>
            </div>
         </div>
         <div class="col-6 col-lg-2 col-md-4">
            <div class="form-group-sm">
               <label for="" class="combos">Jurisdicción:</label>
               <select class="form-control" id="cboJurisdiccion" onchange="cboJurisdiccionChange()">
                  <option value="-1">Todas</option>
               </select>
            </div>
         </div>
         <div class="col-6 col-lg-3 col-md-4">
            <div class="form-group-sm">
               <label for="" class="combos">Municipio:</label>
               <select class="form-control" id="cboMunicipio" onchange="cboMunicipioChange()" >
                  <option value="-1">Todas</option>
               </select>
            </div>
         </div>
         <div class="col-6 col-lg-3 col-md-4">
            <div class="form-group-sm">
               <label for="" class="combos">Hospital:</label>
               <select class="form-control" id="cboUS" onchange="cboUSChange()" >
                  <option value="-1">Todas</option>
               </select>
            </div>
         </div>
      </div>
   </div>
</div>
<!--/.Combos-->


<!-- 🄛⒠⒯⒜⒧⒤⒟⒜⒟🄔⒩⒯⒤⒟⒜⒟ -->
<div class="container-fluid w98">
   <div class="row">
      <div class="col-11">
         <h1 class="tit-clr9"><img src="../../images/ico_9.svg" alt="" class="ico-cab-int" />Letalidad &nbsp;&nbsp;&nbsp;&nbsp; <img  id="img" src="../../images/logo_mexicopresidencia.SVG" style=" width: 220px;  height: 100px;"/> </h1>
      </div>
   </div>
</div>
<div class="container-fluid w98 mt-3">
   <div class="row">
      <div class="col-12">
         <h2 class="mb-2">Letalidad en Morbilidad Materna Severa por Entidad federativa </h2>
      </div>
      <br />
      <br />
      <br />
      <div class="row top20">
         <div class="col-sm-12 text-center">
            <label class="texto2">De los </label>
            <label id="lblLetalidadTotal" class="textoBold2">XXX,XXX</label> 
            <label class="texto2"> casos registrados </label>
            <label id="lblLetalidadsum" class="textoBold2"> X,XXX</label>
            <label id="lblLetalidadTotalPorc" class="textoBold2">XXX,XXX (XX.X%)</label> 
            <label class="texto2"> fallecieron.</label>
         </div>
      </div>
      <div class="container-fluid bott30">
         <div class="row">
            <div id="dvLetalidadEntidad" style="width:1000px;height: 1000px;margin:auto;"></div>            <!-- 🄛⒠⒯⒜⒧⒤⒟⒜⒟🄔⒩⒯⒤⒟⒜⒟ -->
         </div>
      </div>
            <!--A͟c͟t͟u͟ d͟i͟a͟r͟i͟a͟-->
            <div class="container-fluid width95 bott50">
               <div class="row">
                  <div class=" col-md-6 col-xs-6 text-left">
                     <label class="texto-small" style= "font-size:75%">Actualización semanal</label>
                  </div>
                  <div class=" col-md-6 col-xs-6 text-right">
                     <label class="texto-small" style= "font-size:75%">Información hasta la semana epidemiológica</label>
                     <label id="lblObse" class="SemanaEpidemioligica">XXX,XXX</label> 
                     <label class="texto-small" style= "font-size:75%">del 2018</label>

                  </div>
               </div>
            </div>
            <!--A͟c͟t͟u͟ d͟i͟a͟r͟i͟a͟-->
   </div>
</div>
<!-- 🄛⒠⒯⒜⒧⒤⒟⒜⒟🄔⒩⒯⒤⒟⒜⒟ -->


<!--𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝!-->
<div class="container-fluid fondocolor">
   <br />   
   <div class="container-fluid w98 mt-3">
      <div class="row">
         <div class="container-fluid bott30">
            <div class="row top20">
      <div class="col-12">
         <h2 class="mb-2">Letalidad por grupo de edad  </h2>
      </div>
            </div>
         </div>
      </div>
      <div class="container-fluid bott30">
         <div class="row">
            <div id="dvLetalidadGrupodeedad" style="width:1000px;height:600px;  margin:auto;"></div>            <!--𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝!-->
         </div>
            <!--A͟c͟t͟u͟ d͟i͟a͟r͟i͟a͟-->
            <div class="container-fluid width95 bott50">
               <div class="row">
                  <div class=" col-md-6 col-xs-6 text-left">
                     <label class="texto-small" style= "font-size:75%">Actualización semanal</label>
                  </div>
                  <div class=" col-md-6 col-xs-6 text-right">
                     <label class="texto-small" style= "font-size:75%">Información hasta la semana epidemiológica</label>
                     <label id="lblObse1" class="SemanaEpidemioligica">XXX,XXX</label> 
                     <label class="texto-small" style= "font-size:75%">del 2018</label>

                  </div>
               </div>
            </div>
            <!--A͟c͟t͟u͟ d͟i͟a͟r͟i͟a͟-->
      </div>
   </div>
</div>
<!--𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝!-->


<!-- Scroll to fixed -->
<script type="text/javascript" src="../../js/jquery-scrolltofixed-min.js"></script>
<script type="text/javascript">
   $('#combos-sup').scrollToFixed({marginTop: 76});
</script>

<!-- Btn subir -->
<a id="back-to-top" href="#" class="back-to-top" role="button" title="Subir" data-toggle="tooltip" data-placement="left"></a>
<script type="text/javascript">
   $(document).ready(function(){
   	$(window).scroll(function () {
   		if ($(this).scrollTop() > 50) {
   			$('#back-to-top').fadeIn();
   		} else {
   			$('#back-to-top').fadeOut();
   		}
   	});
   	$('#back-to-top').click(function () {
   		$('#back-to-top').tooltip('hide');
   		$('body,html').animate({scrollTop: 0}, 800);
   		return false;
   	});
   	$('#back-to-top').tooltip('hide');
   });
</script>
</asp:Content>
