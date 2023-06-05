<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestro/IntroMaster.master"  AutoEventWireup="true" CodeFile="PrincipalRestringida.aspx.cs" Inherits="DirApp_SIVEMMS_PrincipalRestringida" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

<!-- Mapa -->
 <script src="../../js/HIGHCHARTS/HighMaps.js"></script>
 <script src="../../js/HIGHCHARTS/HighMaps_Mexico.js"></script>
<!-- Mapa -->

<!-- Odometr includes -->
<link rel="stylesheet" href="http://github.hubspot.com/odometer/themes/odometer-theme-default.css" />
<script src="http://github.hubspot.com/odometer/odometer.js"></script>
<!-- Odometr includes -->

    <script src="../../js/miscelaneos.js"></script>
    <script src="../../js/bootstrap.bundle.min.js"></script>
    <script src="../../js/graficas/pintarGraficas.js"></script>
    <script src="../../js/PrincipalRestringida.js"></script>

<!--Institucion-->
<br />
<div class="container-fluid bg-10 pt-5 pb-1" id="combos-sup" style="padding-top:10px">
   <div class="container-fluid w98">
      <div class="row">
         <div class="row top20">
            <div class="col-sm-12 text-center">
               <a class="tooltips">¿Qué es el SIVEMMS? 
               <span>Sistema de Vigilancia Epidemiológica de Morbilidad Materna Severa es operado por el Sistema Nacional de Vigilancia Epidemiológica (SINAVE) con la participación de unidades monitoras distribuidas en las 32 Entidades Federativas, capta embarazos atendidos que llegan a presentar eventos que pueden poner en riesgo la vida de la mujer gestante.</span></a>
            </div>
         </div>
         <div class="col-lg-3 col-md-4"></div>
         <div class="col-lg-3 col-md-4"></div>
         <div class="col-lg-3 col-md-4">
            <div class="form-group row">
               <label class="col-lg-4 col-md-5 col-form-label ">Institución:</label>
               <div class="col-lg-8 col-sm-7">
                  <select class="form-control" id="cboInstitucion" onchange="cboInstitucionChange()">
                     <option value="-1">Todas</option>
                  </select>
               </div>
            </div>
         </div>
      </div>
   </div>
</div>
<!--Institucion-->

<!--Dónde estamos-->
<div class="container-fluid w98 mt-3">
   <div class="row justify-content-center">
      <div class="col-12">
         <hr>
      </div>
      <div class="col-lg-8">
         <div class="row justify-content-center">
            <div class="col-12 text-center">
               <h1 class="donde">Dónde estamos</h1>
            </div>
            <div class="col-6 col-lg-3 col-md-4 p-2">
               <div class="row justify-content-center">
                  <div class="col-12">
                     <p class="bqs">Entidades</p>
                  </div>
                  <div class="col-12 text-center">
                     <label id="lblEntidades"  class="bq-datos bq-clr1">XXX</label>
                  </div>
               </div>
            </div>
            <div class="col-6 col-lg-3 col-md-4 p-2">
               <div class="row justify-content-center">
                  <div class="col-12">
                     <p class="bqs">Jurisdicciones</p>
                  </div>
                  <div class="col-12 text-center">
                     <label id="lblJurisdicciones"  class="bq-datos bq-clr2">XXX</label>
                  </div>
               </div>
            </div>
            <div class="col-6 col-lg-3 col-md-4 p-2">
               <div class="row justify-content-center">
                  <div class="col-12">
                     <p class="bqs">Municipios</p>
                  </div>
                  <div class="col-12 text-center">
                     <label id="lblMunicipios"  class="bq-datos bq-clr3">XXX</label>
                  </div>
               </div>
            </div>
            <div class="col-6 col-lg-3 col-md-4 p-2">
               <div class="row justify-content-center">
                  <div class="col-12">
                     <p class="bqs">Hospitales</p>
                  </div>
                  <div class="col-12 text-center">
                     <label id="lblHospitales"  class="bq-datos bq-clr4">XXX</label>
                  </div>
               </div>
            </div>
            <!--o͟d͟o͟m͟e͟t͟r͟o͟-->
            <div class="form-group-sm">
               <br />
               <div id="Lblodometer" class="odometer">00000</div>
               <label class="mapa-txt"><b>&nbsp;&nbsp; Casos de Morbilidad Materna Severa</b></label>
            </div>
            <!--o͟d͟o͟m͟e͟t͟r͟o͟-->
         </div>
      </div>
      <div class="col-12"></div>
   </div>
</div>
<!--/.Dónde estamos-->


<div class="row top20">
   <div class="col-sm-12 text-center">
      <ul id="ejm2">
         <a>Información hasta la semana epidemiológica  44 del 2018</a> 
      </ul>
   </div>
</div>


<!--Col-izq-->          <!----Letalidad y Morbilidad-->
<div class="container-fluid w98 mt-4">
   <div class="row">
      <div class="col-12">
         <hr>
      </div>
      <!--Col-izq-->
      <div class="col-xl-7">
         <div class="col-sm-12 text-center">
            <label id="lblMorbilidad" style="font-size: 1.1rem; line-height: 125%; font-weight: 600;" >
               <h1>Morbilidad</h1>
               Los criterios para los indicadores en Morbilidad Materna Severa, fueron tomados del Plan de acción para acelerar la reducción de la mortalidad materna y la morbilidad materna grave de la OMS/OP
            </label>
         </div>
         <div class="col-sm-12 text-center">
            <label id="lblLetalidad" style="font-size: 1.1rem; line-height: 125%; font-weight: 600;" >
               <h1>Letalidad </h1>
               Estados con mayor letalidad
            </label>
         </div>
         <div class="container-fluid bott30" style="width:796px;height:600px;" >
            <!--MapaOnOff-->
            <div class="row">
               <div class="col-sm-12">
                  <div  id="dvMapaOnOff" style="width:600px;height:500px; margin:auto;">  </div>
               </div>
               <img class="Ins" id="img" src="../../images/logo_mexicopresidencia.SVG" alt="" style=" width: 220px;  height: 100px;"  />      <!--Instituciones-->
               <!-- --Combos Letalidad e Mortalidad----> 
               <div class="row width95">
                  <div class="col-sm-2">
                     <div class="containerToggle" >
                        <label class="switch">
                        <input id="swMapaOnOff" type="checkbox" class="switch-input" onchange="optMapaOnOffChange()" />
                        <span class="switch-label" data-on="Morbilidad" data-off="Letalidad"></span>
                        <span class="switch-handle"></span>
                        </label>
                     </div>
                  </div>
               </div>
               <!-- --Combos Letalidad e Mortalidad----> 
               <!--A͟c͟t͟u͟a͟l͟i͟z͟a͟c͟i͟ó͟n͟ ͟d͟i͟a͟r͟i͟a͟-->
               <div class="container-fluid width95 bott50">
                  <div class="row">
                     <div class=" col-md-6 col-xs-6 text-left">
                        <label class="texto-small">Actualización semanal</label>
                     </div>
                     <div class=" col-md-6 col-xs-6 text-right">
                        <label class="texto-small">Información hasta la semana 44 del 2018</label>
                     </div>
                  </div>
               </div>
               <!--A͟c͟t͟u͟a͟l͟i͟z͟a͟c͟i͟ó͟n͟ ͟d͟i͟a͟r͟i͟a͟-->
            </div>
            <img class="desplazada" alt="" src="../../images/X.png" <%--style = "height:250px;--%>"/>      <!--porc imagen-->    
            <!--MapaOnOff-->
         </div>
      </div>
      <!--Col-der-->
      <div class="col-xl-5 linea-izq">
         <!--Indicadores nacionales-->
         <div class="row">
            <div class="col-12 mb-3 text-center">
               <h1></h1>
            </div>
         </div>
         <!--/.Indicadores nacionales-->
         <div class="row justify-content-end">
            <div class="col-10 mt-4">
               <!--Razón de morbilidad materna severa-->
               <div class="row justify-content-end bq-icono-p">
                  <div class="col-md-1" >
                     <a href="RazonDeMMS.aspx"><img src="../../images/ico_3.svg" alt="" class="ico-p" /></a> 
                  </div>
                  <div class="col-md-11">
                     <span class="speciallink"><a>Razón de morbilidad materna severa</a></span>
                  </div>
               </div>
            </div>
         </div>
         <!--Letalidad-->
         <div class="row justify-content-end">
            <div class="col-10 mt-4">
               <div class="row justify-content-end bq-icono-p">
                  <div class="col-md-1" >
                     <a href="Letalidad.aspx"><img src="../../images/ico_9.svg" alt="" class="ico-p" /></a> 
                  </div>
                  <div class="col-md-11">
                     <span class="speciallink"><a>Letalidad</a></span>
                  </div>
               </div>
            </div>
         </div>
         <!--Índice de evaluación-->
         <div class="row justify-content-end">
            <div class="col-10 mt-4">
               <div class="row justify-content-end bq-icono-p">
                  <div class="col-md-1" >
                     <a href="IndiceDeEvaluacion.aspx"><img src="../../images/ico_8.svg" alt="" class="ico-p" /></a> 
                  </div>
                  <div class="col-md-11">
                     <span class="speciallink"><a>Índice de evaluación</a></span>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
</div>
<!----Letalidad y Morbilidad-->

 

 
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
