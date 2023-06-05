<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestro/IntroMaster.master"  AutoEventWireup="true" CodeFile="RazonDeMMS.aspx.cs" Inherits="DirApp_SIVEMMS_RazonDeMMS" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

<!-- iconos movimiento -->
        <link href="../../Scripts/BOOTSTRAP/fonts/font-awesome/css/font-awesome.css" rel="stylesheet" />
        <link href="../../Scripts/BOOTSTRAP/fonts/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
        <link href="../../Scripts/BOOTSTRAP/fonts/font-awesome/css/font-awesome-animation.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" />
<!-- iconos movimiento -->


    <script src="https://code.highcharts.com/highcharts.js"></script>
    <script src="https://code.highcharts.com/highcharts-more.js"></script>
    <script src="../../js/miscelaneos.js"></script>
    <script src="../../js/bootstrap.bundle.min.js"></script>
    <script src="../../js/graficas/pintarGraficas.js"></script>
    <script src="../../js/RazonDeMMS.js"></script>



<!--Título-->
<div class="container-fluid pt-100 bg-10">
   <div class="container-fluid w98">
      <div class="row">
         <div class="col-11">
            <h1 class="hvr-underline-from-left">
               Razón de Morbilidad
            </h1>
         </div>
         <div class="col-1 text-right">
            <a href="Principal.aspx" class="btn btn-regreso">
            </a>
         </div>
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



<!-- R͟a͟z͟ó͟n͟ ͟d͟e͟ ͟M͟o͟r͟b͟i͟l͟i͟d͟a͟d͟ ͟M͟a͟t͟e͟r͟n͟a͟ ͟S͟e͟v͟e͟r͟a͟ -->
<div class="container-fluid w98">
<div class="row">
   <div class="col-11">
      <h1>
         <a data-toggle="collapse" href="#footwear" aria-expanded="false" aria-controls="footwear" class="tit-clr3" >
         <img src="../../images/ico_3.svg" alt="" class="ico-cab-int" />
         Razón de Morbilidad Materna Severa 
         <a style="color: #5a5a5a; font-size:18px"  class="fa fa-info-circle tooltips_RIGHT" href="" onclick="return false;">
         <span style="width:315px">
         <i style="font-size:18px"  class='far fa-hand-point-left faa-wrench animated fa-1x'></i>
         &nbsp;Hacer click para mayor información 
         </span>
         </a> 
         &nbsp;&nbsp;&nbsp;&nbsp; 
         <img  id="img" src="../../images/logo_mexicopresidencia.SVG" style=" width: 220px;  height: 100px;"/> 
         </a> 
      </h1>
      <div class="collapse" id="footwear">
         <div class="p-3 mb-2 text-dark" style="background-color:#f2f7f9">            <!--Cards · Bootstrap-->
            <p>El indicador de Razón de Morbilidad Materna Severa se construye mediante la razón entre el número de nacimientos atendidos por unidad médica y el número de mujeres gestantes que se atienden con Morbilidad Materna Severa en las mismas unidades médicas. Un valor menor refleja mejores resultados en la atención de las mujeres gestantes tanto en este estadío de gravedad.</p>
         </div>
      </div>
   </div>
</div>
<div class="container-fluid w98 mt-3">
   <div class="row">
      <div class="col-12">
         <h2 class="mb-2">Razón de Morbilidad Materna Severa por entidad federativa.</h2>
      </div>
      <div class="row top20">
         <div class="col-sm-12 text-center">
            <label class="texto2">De los</label>
            <label id="lblMorbiRN" class="textoBold2">XXX,XXX</label> 
            <label class="texto2">nacimientos registrados, en </label>
            <label id="lblMorbiTotal" class="textoBold2"> X,XXX</label> 
            <label class="texto2"> se presentó Morbilidad Materna Severa. Esto representa una razón de </label>
            <label id="lblRazon" class="textoBold2"> (XX.X%)</label> 
         </div>
      </div>
   </div>
      <div class="container-fluid bott30">
         <div class="row">
                    <div id="dvRazonMMS" style="width:1000px;height: 1000px;margin:auto;"></div>               <!-- R͟a͟z͟ó͟n͟ ͟d͟e͟ ͟M͟o͟r͟b͟i͟l͟i͟d͟a͟d͟ ͟M͟a͟t͟e͟r͟n͟a͟ ͟S͟e͟v͟e͟r͟a͟ -->
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
<!-- R͟a͟z͟ó͟n͟ ͟d͟e͟ ͟M͟o͟r͟b͟i͟l͟i͟d͟a͟d͟ ͟M͟a͟t͟e͟r͟n͟a͟ ͟S͟e͟v͟e͟r͟a͟ -->


<!--𝘊𝘢𝘴𝘰𝘴 𝘱𝘰𝘳 𝘨𝘳𝘶𝘱𝘰 𝘥𝘦 𝘦𝘥𝘢𝘥-->
<div class="container-fluid fondocolor">
   <div class="container-fluid w98 mt-3">
      <div class="row">
         <div class="col-12">
            <h3 class="primero">Morbilidad Materna Severa por Grupo de Edad</h3>
         </div>
      </div>
      <div class="row top20">
         <div class="col-sm-12 text-center">
            <label class="texto2">El grupo de edad con mayor número de casos  es el de 20 a 24 con una tasa de </label>
            <label id="lbledad" class="textoBold2"> (XX.X%)</label> 
         </div>
      </div>
      <div class="row">
         <div class="col-sm-12">
            <div id="dvGrupodeedad" style="width:auto;height: auto;margin:auto;"></div>
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
                     <label id="lblObse1" class="SemanaEpidemioligica">XXX,XXX</label> 
                     <label class="texto-small" style= "font-size:75%">del 2018</label>

                  </div>
               </div>
            </div>
            <!--A͟c͟t͟u͟ d͟i͟a͟r͟i͟a͟-->
   </div>
</div>
<!--𝘊𝘢𝘴𝘰𝘴 𝘱𝘰𝘳 𝘨𝘳𝘶𝘱𝘰 𝘥𝘦 𝘦𝘥𝘢𝘥-->


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