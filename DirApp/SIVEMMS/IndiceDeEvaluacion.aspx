<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestro/IntroMaster.master"  AutoEventWireup="true" CodeFile="IndiceDeEvaluacion.aspx.cs" Inherits="DirApp_SIVEMMS_IndiceDeEvaluacion" %>

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
    <script src="../../js/IndiceDeEvaluacion.js"></script>



<!--Título-->
<div class="container-fluid pt-100 bg-10">
   <div class="container-fluid w98">
      <div class="row">
         <div class="col-11">
            <h1 class="hvr-underline-from-left">Índice de evaluación</h1>
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


<!--a͟t͟e͟n͟c͟i͟ó͟n͟ ͟p͟r͟e͟n͟a͟t͟a͟l͟-->
<div class="container-fluid pt-100 bg-5">
   <div class="container-fluid w98">
      <div class="row">
         <div class="col-11">
            <h1>
               <a data-toggle="collapse" href="#footwear" aria-expanded="false" aria-controls="footwear" class="tit-clr10" >
               <img src="../../images/ico_10.svg" alt="" class="ico-cab-int" />
               Índice de calidad en la atención prenatal por entidad federativa
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
               <div class="p-3 mb-2 text-dark" style="background-color:#f2f7f9">                  <!--Cards · Bootstrap-->
                  <p>El índice de Índice de calidad en atención prenatal se construye mediante promedios ponderados de la razón de MMS y el % de cumplimiento de al menos 4 consultas de control prenatal. Un índice menor refleja mejores resultados en la atención prenatal de las mujeres embarazadas.</p>
               </div>
            </div>
         </div>
      </div>
   </div>
</div>
<div class="container-fluid w98 mt-3">
   <div class="row">
      <!-- <div class="row top20">
         <div class="col-sm-12 text-center">
                     <label class="texto2">demo </label>
                     <label id="lblCesariasTotal" class="textoBold2">XXX,XXX</label> 
                     <label class="texto2"> demo </label>
                     <label id="lblCesariassum" class="textoBold2"> X,XXX</label>
                     <label id="lblCesariasTotalPorc" class="textoBold2"> (XX.X%)</label> 
                     <label class="texto2">  demo</label>
          </div>
         </div>-->
      <div class="container-fluid bott30">
         <div class="row">
            <div id="dvAtnprenatal" style=" width: 1000px;  height: 1000px;  margin:auto;" ></div>            <!--a͟t͟e͟n͟c͟i͟ó͟n͟ ͟p͟r͟e͟n͟a͟t͟a͟l͟-->
         </div>
      </div>
<!--      <div class="row top20">
         <div class="col-sm-12 text-center">
            <ul id="ejm2">
               <a>* El índice de Índice de calidad en atención prenatal se construye mediante promedios ponderados de la razón de MMS y el % de cumplimiento de al menos 4 consultas de control prenatal.</a> 
            </ul>
         </div>
      </div>-%>
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
<!--a͟t͟e͟n͟c͟i͟ó͟n͟ ͟p͟r͟e͟n͟a͟t͟a͟l͟-->


<!--Título2-->      <!--a͟͟͟t͟͟͟e͟͟͟n͟͟͟c͟͟͟i͟͟͟ó͟͟͟n͟͟͟ ͟o͟b͟s͟t͟é͟t͟r͟i͟c͟a͟-->

<%--<div class="container-fluid fondocolor">
   <div class="container-fluid pt-100 bg-5">
      <div class="container-fluid w98">
         <div class="row">
            <div class="col-11">
               <h1>
                  <a data-toggle="collapse" href="#footwear1" aria-expanded="false" aria-controls="footwear" class="tit-clr11" >
                  <img src="../../images/ico_11.svg" alt="" class="ico-cab-int" />
                  Índice de gravedad obstétrica por lugar de atención 
                  <a style="color: #5a5a5a; font-size:18px"  class="fa fa-info-circle tooltips_RIGHT" href="" onclick="return false;">
                  <span style="width:315px">
                  <i style="font-size:18px"  class='far fa-hand-point-left faa-wrench animated fa-1x'></i>
                  &nbsp;Hacer click para mayor información 
                  </span>
                  </a> 
                  &nbsp;&nbsp;&nbsp;&nbsp; 
                  <img  id="img2" src="../../images/logo_mexicopresidencia.SVG" style=" width: 220px;  height: 100px;"/>
                  </a> 
               </h1>
               <div class="collapse" id="footwear1">
                  <div class="p-3 mb-2 text-dark" style="background-color:#f2f7f9">                     <!--Cards · Bootstrap-->
                     <p>El índice de gravedad obstétrica se construye mediante promedios ponderados de los indicadores internacionales de para la atención de eventos obstétricos (% de cesáreas, % de mujeres con más de 3 transfusiones, % de mujeres que requieren una cirugía adicional) y la letalidad. Un índice menor refleja mejores resultados en la atención hospitalaria del evento de gravedad obstétrica.</p>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
   <div class="container-fluid w98 mt-3">
      <div class="row">
         <div class="row top20">
            <div class="col-sm-12 text-center">
               <label class="texto2">demo</label>
               <label id="lblTransfusionTotal" class="textoBold2">XXX,XXX</label> 
               <label class="texto2"> demo</label>
               <label id="lblTransfusionsum" class="textoBold2"> X,XXX</label> 
               <label id="lblTransfusionTotalPorc" class="textoBold2"> (XX.X%)</label> 
               <label class="texto2"> demo</label>
            </div>
         </div>
         <div class="container-fluid bott30">
            <div class="row">
               <div id="dvAtnobstetrica" style="width:1000px;height: 1000px;   margin:auto;"></div>               <!--a͟͟͟t͟͟͟e͟͟͟n͟͟͟c͟͟͟i͟͟͟ó͟͟͟n͟͟͟ ͟o͟b͟s͟t͟é͟t͟r͟i͟c͟a͟-->
            </div>
         </div>
         <!--A͟c͟t͟u͟a͟l͟i͟z͟a͟c͟i͟ó͟n͟ ͟d͟i͟a͟r͟i͟a͟-->
         <div class="container-fluid width95 bott50">
            <div class="row">
               <div class=" col-md-6 col-xs-6 text-left">
                  <label class="texto-small">Actualización semanal</label>
               </div>
               <div class=" col-md-6 col-xs-6 text-right">
                  <label class="texto-small">Información hasta la semana epidemiológica  44 del 2018</label>
               </div>
            </div>
         </div>
         <!--A͟c͟t͟u͟a͟l͟i͟z͟a͟c͟i͟ó͟n͟ ͟d͟i͟a͟r͟i͟a͟-->
      </div>
   </div>
</div>--%>
<!--a͟͟͟t͟͟͟e͟͟͟n͟͟͟c͟͟͟i͟͟͟ó͟͟͟n͟͟͟ ͟o͟b͟s͟t͟é͟t͟r͟i͟c͟a͟-->


 
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