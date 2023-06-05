<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestro/IntroMaster.master"  AutoEventWireup="true" CodeFile="IndicadoresNacionales.aspx.cs" Inherits="DirApp_SIVEMMS_IndicadoresNacionales" %>

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
    <script src="../../js/IndicadoresNacionales.js"></script>



<!--Título-->
<div class="container-fluid pt-100 bg-10">
   <div class="container-fluid w98">
      <div class="row">
         <div class="col-11">
            <h1 class="hvr-underline-from-left">Indicadores Nacionales</h1>
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
<!--Combos-->


<!--Embarazos sin morbilidad materna-->  <!--class="percent-p tit-clr1">97.4% rojo para el porcentaje-->
<div class="container-fluid w98">
   <div class="row">
      <div class="col-11">
         <h1 >
            <a data-toggle="collapse" href="#footwear" aria-expanded="false" aria-controls="footwear" class="bq-icono-tit tit-clr1" >
            <img  src="../../images/ico_1.svg" alt="" class="ico-cab-int" />
            <label style= "font-size:130%">Embarazos sin morbilidad materna severa </label>            
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
            <div class="p-3 mb-2 text-dark" style="background-color:#f2f7f9">
               <!--Cards · Bootstrap-->
               <p>El indicador de Embarazos Sin Morbilidad Materna Severa representa la proporción de mujeres gestantes que se atienden por unidad médica (estimadas indirectamente por número de nacimientos registrados) que evolucionan sin morbilidad materna severa durante el embarazo, parto y puerperio. Un valor mayor refleja mejores resultados en la atención de las mujeres gestantes tanto en el control prenatal como en la atención intra parto y postparto.</p>
            </div>
         </div>
         <div class="col-12">
            <h2 class="mb-2">Proporción de nacimientos sin MMS por entidad federativa </h2>
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
               <label id="lblNacionalRN" class="textoBold2">XXX,XXX</label> 
               <label class="texto2">nacimientos registrados,</label>
               <label id="lblSinMorbiRN" class="textoBold2">XXX,XXX</label> 
               <label id="lblSinMorbiRNPorc" class="textoBold2">XXX%</label> 
               <label class="texto2">no presentaron morbilidad materna severa.</label>
            </div>
         </div>
      </div>
   </div>
   <div class="container-fluid bott30">
      <div class="row">
         <div id="dvSinMMS" style="width:1000px;height: 1000px; margin:auto;"></div>         <!--E͢m͢b͢a͢r͢a͢z͢o͢s͢ ͢S͢i͢n͢ ͢M͢o͢r͢b͢i͢l͢i͢d͢a͢d͢ ͢M͢a͢t͢e͢r͢n͢a͢ ͢ -->
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
<!--E͢m͢b͢a͢r͢a͢z͢o͢s͢ ͢S͢i͢n͢ ͢M͢o͢r͢b͢i͢l͢i͢d͢a͢d͢ ͢M͢a͢t͢e͢r͢n͢a͢ ͢ -->


   

<!--𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝!-->
<div class="container-fluid fondocolor">
   <br />   
   <div class="container-fluid w98 mt-3">
      <div class="row">
         <div class="container-fluid bott30">
            <div class="row top20">
      <div class="col-12">
         <h2 class="mb-2">Proporción de embarazos sin MMS por rango de edad </h2>
      </div>
            </div>
         </div>
      </div>
      <div class="container-fluid bott30">
         <div class="row">
            <div id="dvSinMMSGrupodeedad" style="width:1000px;height:600px;  margin:auto;"></div>       <!--𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝!-->
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


<!--Tasa de sobrevida en mujeres...-->  <!--class="percent-p tit-clr2">97.4% amarillo para el porcentaje-->
<div class="container-fluid fondocolor">
<div class="container-fluid w98">
   <div class="row">
      <div class="col-11">
         <h1 class="bq-icono-tit tit-clr2"><img src="../../images/ico_2.svg" alt="" class="ico-cab-int" />
            <label style= "font-size:130%">Embarazos con morbilidad materna severa</label>  
            &nbsp;&nbsp;&nbsp;&nbsp; 
            <img  id="img2" src="../../images/logo_mexicopresidencia.SVG" style=" width: 220px;  height: 100px;"/>
         </h1>
         <div class="col-12">
            <h2 class="mb-2">Tasa de sobrevida en mujeres con MMS por entidad federativa </h2>
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
                  <label id="lblTasauma" class="textoBold2">XXX,XXX</label> 
                  <label class="texto2"> casos con morbilidad materna severa hay </label>
                  <label id="lblTasaumacasos" class="textoBold2">XXX,XXX </label> 
                  <label class="texto2">casos con sobrevida con tasa de </label>
                  <label id="lbltaza" class="textoBold2">XXX,XXX </label> 
               </div>
            </div>
         </div>
      </div>
      <div class="container-fluid bott30">
         <div class="row">
            <div id="dvTasaSobrevida" style="width:1000px;height: 1000px;  margin:auto;"></div>            <!--Tasa de sobrevida en mujeres...--> 
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
</div>
<!--Tasa de sobrevida en mujeres...-->



<!-- 𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 𝗧𝗮𝘀𝗮𝗦𝗼𝗯𝗿𝗲𝘃𝗶𝗱𝗮𝗠𝗠𝗦 -->
<!-- <div class="container-fluid fondocolor"> FONDO GRIS-->
<br />   
<div class="container-fluid w98 mt-3">
   <div class="row">
      <div class="container-fluid bott30">
         <div class="row top20">
            <div class="col-12">
               <h2 class="mb-2">Rango de edad de tasa sobrevida MMS  </h2>
            </div>
         </div>
      </div>
   </div>
   <div class="container-fluid bott30">
      <div class="row">
         <div id="dvTasaSobrevidaMMSEdad" style="width:1000px;height:600px;  margin:auto;"></div>
         <!-- 𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 𝗧𝗮𝘀𝗮𝗦𝗼𝗯𝗿𝗲𝘃𝗶𝗱𝗮𝗠𝗠𝗦 -->
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
<!-- 𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 𝗧𝗮𝘀𝗮𝗦𝗼𝗯𝗿𝗲𝘃𝗶𝗱𝗮𝗠𝗠𝗦 -->






<!--Causas de morbilidad materna severa-->  <!--class="percent-p tit-clr3">97.4% amarillo para el porcentaje-->
<div class="container-fluid w98">
   <div class="row">
      <div class="col-11">
         <h1>
            <a data-toggle="collapse" href="#footwear1" aria-expanded="false" aria-controls="footwear" class="bq-icono-tit tit-clr3">
            <img src="../../images/ico_3.svg" alt="" class="ico-cab-int" />
            <label style= "font-size:130%">Causas de morbilidad materna severa </label>              
            <a style="color: #5a5a5a; font-size:18px"  class="fa fa-info-circle tooltips_RIGHT" href="" onclick="return false;">
            <span style="width:315px">
            <i style="font-size:18px"  class='far fa-hand-point-left faa-wrench animated fa-1x'></i>
            &nbsp;Hacer click para mayor información 
            </span>
            </a> 
            &nbsp;&nbsp;&nbsp;&nbsp;
            <img  id="img3" src="../../images/logo_mexicopresidencia.SVG" style=" width: 220px;  height: 100px;"/>
            </a> 
         </h1>
         <div class="collapse" id="footwear1">
            <div class="p-3 mb-2 text-dark" style="background-color:#f2f7f9">               <!--Cards · Bootstrap-->
               <p>Causas de Morbilidad Materna Severa, se refiere a la enfermedad o condición clínica que condiciona la presencia de morbilidad materna severa, y puede ser asignada a partir del diagnóstico de ingreso, de egreso, o a partir de los criterios de clasificación como morbilidad materna severa.</p>
            </div>
         </div>
      </div>
   </div>
</div>
<div class="container-fluid w98 mt-3">
   <div class="row">
      <div class="container-fluid bott30">
         <div class="row top20">
            <div class="col-sm-12 text-left">
               <label class="texto2">Se han reportado </label>
               <label id="lblCausassuma" class="textoBold2">XXX,XXX</label> 
               <label class="texto2"> casos con morbilidad materna severa cuyas principales causas son: </label> <br />
            </div>
         </div>
         <!-- <div class="col-sm-12 text-left">
            <label class="texto2">• Enfermedad hipertensiva del embarazo </label>
            <label id="lblEnfgerHipertetotal" class="textoBold2">XXX,XXX </label> 
            <label id="lblEnferHiperte" class="textoBold2">(XX.X%)</label> <br />
            <label class="texto2">• Hemorragia obstétrica </label>
            <label id="lblHemoobstretotal" class="textoBold2">XXX,XXX </label> 
            <label id="lblHemoobstre" class="textoBold2"> (XX.X%)</label> <br />
            <label class="texto2">• Embarazo adolescente</label>
            <label id="lblAdoletotal" class="textoBold2">XXX,XXX (XX.X%)</label> 
            <label id="lblAdole" class="textoBold2">(XX.X%)</label> 
            </div>-->
      </div>
   </div>
   <div class="container-fluid w98 mt-3">
      <div class="row">
         <div class="container-fluid bott30">
            <div class="row">
               <div class="col-sm-12">
                  <div id="dvCausasmorbilidad" style="width:1000px;height:500px;  margin:auto;"></div>                  <!-- Causasmorbilidad -->
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
                     <label id="lblObse4" class="SemanaEpidemioligica">XXX,XXX</label> 
                     <label class="texto-small" style= "font-size:75%">del 2018</label>

                  </div>
               </div>
            </div>
            <!--A͟c͟t͟u͟ d͟i͟a͟r͟i͟a͟-->
         </div>
      </div>
   </div>
</div>
<!-- Causasmorbilidad -->


<!--Estatus del feto y el recién nacido--> <!--class="percent-p tit-clr4">97.4% amarillo para el porcentaje-->
<div class="container-fluid fondocolor">
   <div class="container-fluid w98">
      <div class="row">
         <div class="col-11">
            <h1 class="bq-icono-tit tit-clr4"><img src="../../images/ico_4.svg" alt="" class="ico-cab-int" />
                  <label style= "font-size:130%">Estatus del producto </label>                  
                &nbsp;&nbsp;&nbsp;&nbsp;
                 <img  id="img4" src="../../images/logo_mexicopresidencia.SVG" style=" width: 220px;  height: 100px;"/>
            </h1>
         </div>
      </div>
   </div>
   <div class="container-fluid w98 mt-3">
      <div class="row">
         <div class="container-fluid bott30">
            <!--       <div class="row top30">
               <div class="col-sm-12">
                   <h2 class="primero">Estatus del producto al nacimiento</h2>
               </div>
               </div>
               <div class="row top20">
               <div class="col-sm-12 text-center">
                     <label class="texto2">De los </label>
                     <label id="lblNacsuma" class="textoBold2">XXX,XXX (XX.X%)</label> 
               </div>
               </div>-->
            <div class="row">
               <div class="col-lg-6 col-md-12 text-center bott30">
                  <div id="dvFeto" class="center-block"></div>                  <!--Estatus del feto y el recién nacido-->
               </div>
               <div class="col-lg-6 col-md-12">
                  <div class="col-lg-12 col-md-12">
                     <div class="row width98 tabladiv-th">
                        <div class="col-xs-1"><label></label></div>
                        <div class="col-xs-7"><label></label></div>
                        <div class="col-xs-2 text-center"><label>N</label></div>
                        <div class="col-xs-2 text-center"><label>%</label></div>
                     </div>
                     <div class="row width98 tabladiv-td">
                        <div class="col-xs-1" style="background-color: #587498"><label class="textoTabla" ></label></div>
                        <div class="col-xs-7"><label class="textoTabla">&nbsp;&nbsp;Recién nacidos / Vivos</label></div>
                        <div class="col-xs-2 text-center"><label id="lblNacVivo" class="textoTabla">XXX</label></div>
                        <div class="col-xs-2 text-center"><label id="lblNacVivoPorc" class="textoTabla">XXX%</label></div>
                     </div>
                     <div class="row width98 tabladiv-td">
                        <div class="col-xs-1" style="background-color: #E86850"><label class="textoTabla" ></label></div>
                        <div class="col-xs-7"><label class="textoTabla">&nbsp;&nbsp;Óbitos / Abortos</label></div>
                        <div class="col-xs-2 text-center"><label id="lblNacMuerto" class="textoTabla">XXX</label></div>
                        <div class="col-xs-2 text-center"><label id="lblNacMuertoPorc" class="textoTabla">XXX%</label></div>
                     </div>
                     <div class="row width98 tabladiv-td-ultima">
                        <div class="col-xs-1" style="background-color: #FFD800"><label class="textoTabla" ></label></div>
                        <div class="col-xs-7"><label class="textoTabla">&nbsp;&nbsp;No han nacido</label></div>
                        <div class="col-xs-2 text-center"><label id="lblNonace" class="textoTabla">XXX</label></div>
                        <div class="col-xs-2 text-center"><label id="lblNonacePorc" class="textoTabla">XXX%</label></div>
                     </div>
                     <div class="row width98 tabladiv-td">
                        <div class="col-xs-1" style="background-color: #F5F5F5"><label class="textoTabla" ></label></div>
                        <div class="col-xs-7"><label class="textoTabla">Total</label></div>
                        <div class="col-xs-2 text-center"><label id="lblNacsuma" class="textoTabla">XXX</label></div>
                        <div class="col-xs-2 text-center"><label id="set" class="textoTabla">100%</label></div>
                     </div>
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
                     <label id="lblObse5" class="SemanaEpidemioligica">XXX,XXX</label> 
                     <label class="texto-small" style= "font-size:75%">del 2018</label>

                  </div>
               </div>
            </div>
            <!--A͟c͟t͟u͟ d͟i͟a͟r͟i͟a͟-->
            </div>
         </div>
      </div>
   </div>
</div>
<!--Estatus del feto y el recién nacido-->



<!--𝑮𝒓𝒂𝒇𝒊𝒄𝒂 𝒑𝒐𝒓 𝒓𝒂𝒏𝒈𝒐 𝒅𝒆 𝒆𝒅𝒂𝒅 𝑬𝒔𝒕𝒂𝒕𝒖𝒔 𝒅𝒆𝒍 𝑷𝒓𝒐𝒅𝒖𝒄𝒕𝒐 𝑬𝒅𝒂𝒅 -->
<br />   
<div class="container-fluid w98 mt-3">
   <div class="row">
      <div class="container-fluid bott30">
         <div class="row top20">
      <div class="col-12">
         <h2 class="mb-2">Estatus del producto según grupo de edad de la madre</h2>
      </div>
         </div>
      </div>
   </div>
   <div class="container-fluid bott30">
      <div class="row">
         <div id="dvEstatusdelProductoEdad" style="width:1000px;height:600px;  margin:auto;"></div>         <!--𝑮𝒓𝒂𝒇𝒊𝒄𝒂 𝒑𝒐𝒓 𝒓𝒂𝒏𝒈𝒐 𝒅𝒆 𝒆𝒅𝒂𝒅 𝑬𝒔𝒕𝒂𝒕𝒖𝒔 𝒅𝒆𝒍 𝑷𝒓𝒐𝒅𝒖𝒄𝒕𝒐 𝑬𝒅𝒂𝒅 -->
      </div>
            <!--A͟c͟t͟u͟ d͟i͟a͟r͟i͟a͟-->
            <div class="container-fluid width95 bott50">
               <div class="row">
                  <div class=" col-md-6 col-xs-6 text-left">
                     <label class="texto-small" style= "font-size:75%">Actualización semanal</label>
                  </div>
                  <div class=" col-md-6 col-xs-6 text-right">
                     <label class="texto-small" style= "font-size:75%">Información hasta la semana epidemiológica</label>
                     <label id="lblObse6" class="SemanaEpidemioligica">XXX,XXX</label> 
                     <label class="texto-small" style= "font-size:75%">del 2018</label>

                  </div>
               </div>
            </div>
            <!--A͟c͟t͟u͟ d͟i͟a͟r͟i͟a͟-->
   </div>
</div>
<!--𝑮𝒓𝒂𝒇𝒊𝒄𝒂 𝒑𝒐𝒓 𝒓𝒂𝒏𝒈𝒐 𝒅𝒆 𝒆𝒅𝒂𝒅 𝑬𝒔𝒕𝒂𝒕𝒖𝒔 𝒅𝒆𝒍 𝑷𝒓𝒐𝒅𝒖𝒄𝒕𝒐 𝑬𝒅𝒂𝒅 -->


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