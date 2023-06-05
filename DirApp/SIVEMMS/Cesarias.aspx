<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestro/IntroMaster.master"  AutoEventWireup="true" CodeFile="Cesarias.aspx.cs" Inherits="DirApp_SIVEMMS_Cesarias" %>

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
    <script type="text/javascript" src="../../js/jquery-scrolltofixed-min.js"></script>
    <script src="../../js/bootstrap.bundle.min.js"></script>
    <script src="../../js/graficas/pintarGraficas.js"></script>
    <script src="../../js/Cesarias.js"></script>
    <script src="../../js/Prenatal.js"></script>


<!--Título-->
<div class="container-fluid pt-100 bg-10">
   <div class="container-fluid w98">
      <div class="row">
         <div class="col-11">
            <h1 class="hvr-underline-from-left">Indicadores Internacionales</h1>
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


<!--C̸e̸s̸á̸r̸e̸a̸s̸-->
<div class="container-fluid w98">
   <div class="row">
      <div class="col-11">
         <h1>
            <a data-toggle="collapse" href="#footwear" aria-expanded="false" aria-controls="footwear" class="tit-clr5" >
            <img src="../../images/ico_5.svg" alt="" class="ico-cab-int" />
            <label style= "font-size:115%">Casos con morbilidad materna severa resueltos por cesárea </label>              
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
            <div class="p-3 mb-2 text-dark" style="background-color:#f2f7f9">               <!--Cards · Bootstrap-->
               <p>El indicador de casos de MMS resueltos por cesárea, se refiere a la proporción de mujeres que cursaron con MMS en quienes se practicó cirugía cesárea de urgencia.</p>
            </div>
         </div>
      <div class="col-12">
         <h2 class="mb-2">Proporción de casos de MMS resueltos por cesárea</h2>
      </div>
      </div>
   </div>
</div>
<div class="container-fluid w98 mt-3">
   <div class="row">
      <div class="container-fluid bott30">
         <div class="row top20">
            <div class="col-sm-12 text-center">
               <label class="texto2">De los </label>
               <label id="lblCesariasTotal" class="textoBold2">XXX,XXX</label> 
               <label class="texto2"> casos con Morbilidad Materna Severa, </label>
               <label id="lblCesariassum" class="textoBold2"> X,XXX</label>
               <label id="lblCesariasTotalPorc" class="textoBold2"> (XX.X%)</label> 
               <label class="texto2">  se han resuelto por cesárea</label>
            </div>
         </div>
      </div>
      <div class="container-fluid bott30" >
         <div class="row">
            <div id="dvCesarias" style=" width: 1000px;  height: 1000px;  margin:auto;" ></div>            <!--C̸e̸s̸á̸r̸e̸a̸s̸-->
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
<!--C̸e̸s̸á̸r̸e̸a̸s̸-->


<!-- 𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Cesarias -->
<div class="container-fluid fondocolor">
   <br />   
   <div class="container-fluid w98 mt-3">
      <div class="row">
         <div class="container-fluid bott30">
      <div class="col-12">
         <h2 class="mb-2">Proporción de cesáreas realizadas en casos de MMS según grupo de edad</h2>
      </div>
         </div>
      </div>
      <div class="container-fluid bott30">
         <div class="row">
            <div id="dvCesariasGrupodeedad" style="width:1000px;height:600px;  margin:auto;"></div>            <!-- 𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Cesarias -->
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
<!-- 𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Cesarias -->


<!--Título2--> <!--T̴r̴a̴n̴s̴f̴u̴s̴i̴o̴n̴-->
<div class="container-fluid fondocolor">
   <div class="container-fluid w98">
      <div class="row">
         <div class="col-11">
            <h1 class="tit-clr6"><img src="../../images/ico_6.svg" alt="" class="ico-cab-int" />
                <label style= "font-size:105%">Casos con morbilidad materna severa con más de tres transfusiones </label>                  
                &nbsp;&nbsp;&nbsp;&nbsp; 
                <img  id="img2" src="../../images/logo_mexicopresidencia.SVG" style=" width: 220px;  height: 100px;"/> 

            </h1>
         </div>
      </div>
   </div>
   <div class="container-fluid w98 mt-3">
      <div class="row">
         <div class="col-12">
            <h2 class="mb-2">Comparativo</h2>
         </div>
         <div class="col-6 col-xl-2 col-lg-3 col-md-4">
            <div class="form-group-sm">
               <label for="" class="combos">Año de notificación:</label>
               <select class="form-control" id="cboComparativo" onchange="cboComparativoChange()">
                  <option value="1">Actual</option>
                  <option value="2">Año anterior</option>
                  <option value="3">Misma semana del año anterior</option>
               </select>
            </div>
         </div>
         <div class="container-fluid bott30">
            <div class="row top20">
               <div class="col-sm-12 text-center">
                  <label class="texto2">De los</label>
                  <label id="lblTransfusionTotal" class="textoBold2">XXX,XXX</label> 
                  <label class="texto2"> casos con Morbilidad Materna Severa a </label>
                  <label id="lblTransfusionsum" class="textoBold2"> X,XXX</label> 
                  <label id="lblTransfusionTotalPorc" class="textoBold2"> (XX.X%)</label> 
                  <label class="texto2"> se le aplicaron más de tres unidades de sangre o hemoderivados</label>
               </div>
            </div>
         </div>
      </div>
      <div class="container-fluid bott30">
         <div class="row">
            <div id="dvTransfusion" style="width:1000px;height: 1000px;   margin:auto;"></div>            <!--T̴r̴a̴n̴s̴f̴u̴s̴i̴o̴n̴-->
            <div id="dvCausasTransfusion"  style="width:350px;height: 350px;" ></div>            <!--T̴r̴a̴n̴s̴f̴u̴s̴i̴o̴n̴-->
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
                     <label id="lblObse2" class="SemanaEpidemioligica">XXX,XXX</label> 
                     <label class="texto-small" style= "font-size:75%">del 2018</label>

                  </div>
               </div>
            </div>
            <!--A͟c͟t͟u͟ d͟i͟a͟r͟i͟a͟-->
   </div>
</div>
<!--T̴r̴a̴n̴s̴f̴u̴s̴i̴o̴n̴-->


<!--Título3-->  <!--ℙ𝕣𝕖𝕟𝕒𝕥𝕒𝕝-->
<div class="container-fluid w98">
   <div class="row">
      <div class="col-11">
         <h1 class="tit-clr7"><img src="../../images/ico_7.svg" alt="" class="ico-cab-int" />Casos con morbilidad materna severa con control prenatal de más de cuatro consultas &nbsp;&nbsp;&nbsp;&nbsp; <img  id="img3" src="../../images/logo_mexicopresidencia.SVG" style=" width: 220px;  height: 100px;"/> </h1>
      </div>
   </div>
</div>
<div class="container-fluid w98 mt-3">
   <div class="row">
      <div class="container-fluid bott30">
         <div class="row top20">
      <div class="col-12">
         <h2 class="mb-2">Proporción de casos de MMS con más de cuatro consultas según entidad federativa </h2>
      </div>
            <div class="col-sm-12 text-center">
               <label class="texto2">De los</label>
               <label id="lblPrenatalTotal" class="textoBold2">XXX,XXX</label> 
               <label class="texto2">casos con morbilidad materna severa </label>
               <label id="lblPrenatalsum" class="textoBold2">XXX,XXX</label> 
               <label id="lblPrenatalTotalPorc" class="textoBold2"> (XX.X%)</label> 
               <label class="texto2"> han llevado control prenatal con más de 4 consultas</label>
            </div>
         </div>
      </div>
      <div class="container-fluid bott30">
         <div class="row">
            <div id="dvPrenatal" style="width:1000px;height: 1000px;margin:auto;"></div>            <!--ℙ𝕣𝕖𝕟𝕒𝕥𝕒𝕝-->
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
                     <label id="lblObse3" class="SemanaEpidemioligica">XXX,XXX</label> 
                     <label class="texto-small" style= "font-size:75%">del 2018</label>

                  </div>
               </div>
            </div>
            <!--A͟c͟t͟u͟ d͟i͟a͟r͟i͟a͟-->
   </div>
</div>
<!--ℙ𝕣𝕖𝕟𝕒𝕥𝕒𝕝-->


<!-- 𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Controlprenatal -->
<div class="container-fluid fondocolor">
   <br />   
   <div class="container-fluid w98 mt-3">
      <div class="row">
         <div class="container-fluid bott30">
            <div class="row top20">
      <div class="col-12">
         <h2 class="mb-2">Proporción de embarazos con MMS y más de cuatro consultas según grupo de edad </h2>
      </div>
            </div>
         </div>
      </div>
      <div class="container-fluid bott30">
         <div class="row">
            <div id="dvControlprenatalGrupodeedad" style="width:1000px;height:600px;  margin:auto;"></div>
         </div>
            <!--A͟c͟t͟u͟ d͟i͟a͟r͟i͟a͟-->
            <div class="container-fluid width95 bott50">
               <div class="row">
                  <div class=" col-md-6 col-xs-6 text-left">
                     <label class="texto-small" style= "font-size:75%">Actualización semanal</label>
                  </div>
                  <div class=" col-md-6 col-xs-6 text-right">
                     <label class="texto-small" style= "font-size:75%">Información hasta la semana epidemiológica</label>
                     <label id="lblObse4" class="SemanaEpidemioligica">XXX,XXX</label> 
                     <label class="texto-small" style= "font-size:75%">del 2018</label>

                  </div>
               </div>
            </div>
            <!--A͟c͟t͟u͟ d͟i͟a͟r͟i͟a͟-->
      </div>
   </div>
</div>
<!-- 𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Controlprenatal -->



<!-- Scroll to fixed -->
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