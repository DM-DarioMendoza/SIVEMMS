<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestro/IntroMaster.master"  AutoEventWireup="true" CodeFile="Principal.aspx.cs" Inherits="DirApp_SIVEMMS_Principal" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

<!-- Mapa -->
 <script src="../../js/HIGHCHARTS/HighMaps.js"></script>
 <script src="../../js/HIGHCHARTS/HighMaps_Mexico.js"></script>
<!-- Mapa -->

<!-- Odometr includes -->
<link rel="stylesheet" href="http://github.hubspot.com/odometer/themes/odometer-theme-default.css" />
<script src="http://github.hubspot.com/odometer/odometer.js"></script>
<!-- Odometr includes -->

<!-- iconos movimiento -->
        <link href="../../Scripts/BOOTSTRAP/fonts/font-awesome/css/font-awesome.css" rel="stylesheet" />
        <link href="../../Scripts/BOOTSTRAP/fonts/font-awesome/css/font-awesome.min.css" rel="stylesheet" />
        <link href="../../Scripts/BOOTSTRAP/fonts/font-awesome/css/font-awesome-animation.css" rel="stylesheet" />
        <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" />
     <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css" /> 

<!-- iconos movimiento -->
    <script src="../../js/bootstrap.bundle.min.js"></script>  
    <script src="../../js/miscelaneos.js"></script>
    <script src="../../js/graficas/pintarGraficas.js"></script>
    <script src="../../js/PrincipalRestringida.js"></script>
<!--    <script src="../../js/Principal.js"></script>-->


<!--Combos-->

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
                                 <label class="col-lg-4 col-md-5 col-form-label ">Institución:</label> <!--Institucion-->
                              <div class="col-lg-8 col-sm-7">
                                 <select class="form-control" id="cboInstitucion" onchange="cboInstitucionChange()"> <option value="-1">Todas</option> </select>
                              </div>
                             </div>
                         </div>
                     </div>
                 </div>
             </div>

<!--/.Combos-->   

<br />

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
            <!--Od͟o͟m͟e͟t͟r͟o͟-->
            <div class="form-group-sm">
               <br />
               <div id="Lblodometer" class="odometer">00000</div>
               <label class="mapa-txt"><b>&nbsp;&nbsp; Casos de Morbilidad Materna Severa (MMS)</b></label>
            </div>
            <!--Od͟o͟m͟e͟t͟r͟o͟-->
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
      <div class="col-12"></div>
   </div>
</div>
<!--/.Dónde estamos-->

</br>


<div class="container-fluid w98 mt-4">
	<div class="row">
		<div class="col-12"><hr></div>

 <!--Col-izq-->
		<div class="col-xl-6">
                    
                <div class="col-sm-12 text-center">
                        <p>
                            <a data-toggle="collapse" href="#footwear" aria-expanded="false" aria-controls="footwear" style="color:#2E2E2E; font-size:2.1rem; font-family:'Barlow Semi Condensed', sans-serif " >
                                                                       Vidas salvadas 
                                  <a style="color: #5a5a5a;"  class="fa fa-info-circle tooltips_RIGHT" href="" onclick="return false;">
                                      <span style="width:315px">
                                          <i class='far fa-hand-point-left faa-wrench animated fa-1x'></i>
                                          &nbsp;Hacer click para mayor información 
                                      </span>
                                   </a>
                             </a>
                        </p>
                              <div class="collapse" id="footwear">
                                   <!-- <div class="card card-body"-->
                                  <div class="p-3 mb-2 text-dark" style="background-color:#f2f7f9">    <!--Cards · Bootstrap-->
                                        <p>El indicador de vidas salvadas representa la proporción de mujeres que sobreviven a la ocurrencia de un evento cercano a la muerte durante la gestación. Un valor mayor refleja mejores resultados en la atención de las mujeres gestantes en este estado de gravedad.</p>
                                  </div>
                               </div>
                          <label style="font-size: 1.1rem; line-height: 125%; font-weight: 600;">Tasa de sobrevida en mujeres con MMS por entidad federativa</label>
                           <div class="row top20">
                              <div class="col-sm-12 text-center">
                                          <label class="texto2">Se salvaron </label>
                                          <label id="lblVidas" class="textoBold2">XXX,XXX</label> 
                                          <label class="texto2"> vidas</label>
                          <!--<label id="lblXXX" class="textoBold2">XXX,XXX (XX.X%)</label> <label class="texto2">productos nacieron vivos,</label>-->
                               </div>
                            </div>
                </div>


                <!--Ma͟p͟i͟t͟a͟-->
                <div class="container-fluid bott30" style="width:796px;height:600px;" >

                       <div class="row">      
                            <div class="col-sm-12">
                                <div  id="dvmapita" style="width:600px;height:500px; margin:auto;"></div>
                            </div>
                                <img class="Ins" id="img" src="../../images/logo_mexicopresidencia.SVG" alt="" style=" width: 220px;  height: 100px;"  />      <!--Instituciones-->
                        </div>
                                 <img class="desplazada" alt="" src="../../images/mapa2porcentaje.JPG" style = "height:300px;"/>      <!--porc imagen-->    
                </div>
                <!--Ma͟p͟i͟t͟a͟-->
        </div>


<!--Mapa-izq-->
<div class="col-xl-6 linea-centro">
<div class="col-sm-12 text-center">
   <label id="lblMorbilidadtitulo" style="color:#2E2E2E; font-size:2.1rem; font-family:'Barlow Semi Condensed', sans-serif " >
   Morbilidad
   </label>
   <label id="lblMorbilidad" style="font-size: 1.1rem;  line-height: 235%; font-weight: 600;" >
   Razón de MMS por entidad federativa
   </label>
   <label id="lblLetalidadtitulo" style="color:#2E2E2E; font-size:2.1rem; line-height: -220%; font-family:'Barlow Semi Condensed', sans-serif " >
   Letalidad
   </label>
   <label id="lblLetalidad" style="font-size: 1.1rem; line-height: 220%; font-weight: 600;" >
   Tasa de letalidad por MMS según entidad federativa
   </label>
</div>
   <div class="container-fluid bott30" style="width:796px;height:600px;" >
      <!--MapaOnOff-->
      <div class="row">
         <div class="col-sm-12">
            <div  id="dvMapaOnOff" style="width:600px;height:500px; margin:auto;">  </div>
         </div>
         <img class="Ins" id="img2" src="../../images/logo_mexicopresidencia.SVG" alt="" style=" width: 220px;  height: 100px;"  />      <!--Instituciones-->
         <!-- --Combos Letalidad e Mortalidad----> 
         <div class="row width95">
            <div class="col-sm-2">
               <div class="containerToggle" >
                  <label class="switch">
                  <input id="swMapaOnOff" type="checkbox" class="switch-input" onchange="optMapaOnOffChange()" />
                  <span class="switch-label" data-on="Letalidad" data-off="Morbilidad"></span>
                  <span class="switch-handle"></span>
                  </label>
               </div>
            </div>
         </div>
      </div>
      <img id="desplazadaMorbilidad" class="desplazadaMorbilidad" alt="" src="../../images/mapaporcMorbilidad.JPG" style = "height:300px;"/>     
      <img id="desplazadaLetalidad" class="desplazadaLetalidad" alt="" src="../../images/mapaporcLetalidad.JPG" style = "height:300px;"/>     
      <!--MapaOnOff-->
   </div>
</div>
<!--Mapa-izq-->

<div class="col-12"><hr></div>

		
<!--Col-Izq-->
<!--/.Indicadores nacionales-->
<div class="col-xl-6">
   <div class="row">
      <div class="col-12 mb-3 text-center">
          <label  class ="hvr-border-fade">Vidas salvadas</label>  
      </div>
   </div>
   <div class="row justify-content-end">
      <div class="col-10 mt-4">
         <div class="row justify-content-end bq-icono-p">
            <div class="col-md-1" >
               <a href="IndicadoresNacionales.aspx"><img src="../../images/ico_2.svg" alt="" class="ico-p" /></a> 
            </div>
            <div class="col-md-11"> <span class="speciallink"><a>Indicadores nacionales</a></span></div>
         </div>
      </div>
   </div>
   <!--Indicadores internacionales-->
   <div class="row justify-content-end">
      <div class="col-10 mt-4">
         <div class="row justify-content-end bq-icono-p">
            <div class="col-md-1" >
               <a href="Cesarias.aspx"><img src="../../images/ico_7.svg" alt="" class="ico-p" /></a> 
            </div>
            <div class="col-md-11"><span class="speciallink"><a>Indicadores internacionales</a></span></div>
         </div>
      </div>
   </div>
<!--   <div class="col-sm-6" style="right: -300px; top: 250px">
      <a class="button_animate" title="Ver nota metodológica" href="../../pdf/NOTA_Metodológica_SIVEMMS_240918.pdf">Nota metodológica</a>
   </div>-->
</div>
<!--Col-Izq-->


        <!--Col-Der-->
      <div class="col-xl-6">
         <!--Indicadores nacionales-->
         <div class="row">
            <div class="col-12 mb-3 text-center">
                    <label  class ="hvr-border-fade">Indicadores de daño</label>  
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
<!--         <div class="row justify-content-end">
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
         </div>-->
      </div>

<!--Col-Der-->
        

<!--Índice de evaluación-->
<div class="container-fluid width95 top20 bott50">
   <div class="row width95">
      <div class="col-sm-12 text-center" >
         <a href="IndiceDeEvaluacion.aspx"><img src="../../images/ico_8.svg" alt="" class="ico-p" /></a> 
         <span class="speciallink"><a>Índice de evaluación</a></span>
      </div>
   </div>
</div>

   <div class="col-sm-6" style="right: -1200px; top: -50px">
      <a class="button_animate" title="Ver nota metodológica" href="../../pdf/NOTA_Metodológica_SIVEMMS_240918.pdf">Nota metodológica</a>
   </div>


<div class="col-12 mb-3 text-center">
   <h1></h1>
</div>
<div class="row top20">
   <div class="col-sm-12 text-center">
      <label class="texto2">Los criterios para los indicadores de morbilidad materna severa fueron tomados del Plan de acción para acelerar la reducción de la mortalidad maternal y la morbilidad materna grave de la OMS/OPS.</label>
   </div>
</div>
<div class="col-12 mb-3 text-center">
   <h1></h1>
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
