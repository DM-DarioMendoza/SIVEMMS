<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestro/IntroMaster.master"  AutoEventWireup="true" CodeFile="EmbarazosSinMorbilidad.aspx.cs" Inherits="DirApp_SIVEMMS_EmbarazosSinMorbilidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script src="https://code.highcharts.com/highcharts.js"></script>
    <script src="https://code.highcharts.com/highcharts-more.js"></script>
    <script src="../../js/miscelaneos.js"></script>
    <script src="../../js/graficas/pintarGraficas.js"></script>
    <script src="../../js/EmbarazosSinMorbilidad.js"></script>



<!--Título-->
<div class="container-fluid pt-100 bg-10">
	<div class="container-fluid w98">
		<div class="row">
			<div class="col-11"><h1 class="tit-clr1"><img src="../../images/ico_1.svg" alt="" class="ico-cab-int" />Embarazos sin morbilidad materna</h1></div>
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
					<label for="" class="combos">Unidad médica:</label>
					<select class="form-control" id="cboUS" onchange="cboUSChange()" >
                 <option value="-1">Todas</option>
					</select>
				</div>
			</div>
	</div>
	</div>
		
</div>
<!--/.Combos-->


<hr class="mt-5">
<div class="container-fluid w98 mt-3">
	<div class="row">
		<div class="col-12">
			<h2 class="mb-2"> Embarazos Sin Morbilidad Materna Severa </h2>
		</div>

        <%--combo de años--%>

<%--		<div class="col-6 col-xl-2 col-lg-3 col-md-4">
			<div class="form-group-sm">
					<label for="" class="combos">Año de notificación:</label>
					<select class="form-control" id="">
						<option>-Todos-</option>
						<option>2017</option>
						<option>2018</option>
					</select>
				</div>
		</div>--%>

<%--d͟v͟S͟t͟y͟l͟i͟n͟g͟a͟x͟e͟s͟a͟n͟d͟c͟o͟l͟u͟m͟n͟s͟--%>
   <div class="container-fluid bott30">
        <div class="row top30">
            <div class="col-sm-12">
                <h2 class="primero">MMS por semana</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <div id="dvStylingaxesandcolumns" style="width:80%;margin:auto;"></div>
            </div>
        </div>
    </div>
<%--d͟v͟S͟t͟y͟l͟i͟n͟g͟a͟x͟e͟s͟a͟n͟d͟c͟o͟l͟u͟m͟n͟s͟--%>


        <%--    𝑬𝒇𝒇𝒊𝒄𝒊𝒆𝒏𝒄𝒚𝑶𝒑𝒕𝒊𝒎𝒊𝒛𝒂𝒕𝒊𝒐𝒏 --%>

          <div class="container-fluid bott30">
        <div class="row top30">
            <div class="col-sm-12">
                <h2 class="primero">MMS por mes</h2>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <div id="dvEfficiencyOptimization" style="width:80%;margin:auto;"></div>
            </div>
        </div>
    </div>

<%--    𝑬𝒇𝒇𝒊𝒄𝒊𝒆𝒏𝒄𝒚𝑶𝒑𝒕𝒊𝒎𝒊𝒛𝒂𝒕𝒊𝒐𝒏 --%>

	</div>
</div>

<%--<div class="container-fluid w98 mt-4">
	<div class="row">
		<div class="col-12">
			<h2 class="mb-2">Embarazos por grupo de edad Sin Morbilidad Materna Severa, México 2017 </h2>
		</div>
		<div class="col-xl-2 col-lg-3">
			<div class="form-group-sm">
					<label for="" class="combos">Año de notificación:</label>
					<select class="form-control" id="">
						<option>-Todos-</option>
						<option>2017</option>
						<option>2018</option>
					</select>
				</div>
		</div>
		<div class="col-12 text-center">
			<img src="../../images/graficas_tmp/grafica2.svg" alt="" style="width: 100%; max-width: 850px; margin-top: 1rem; margin-bottom: 2rem" /> 
		</div>
	</div>
</div>--%>


<!--Btn subir-->
<a id="back-to-top" href="#" class="back-to-top" role="button" title="Subir" data-toggle="tooltip" data-placement="left"></a>

<script src="js/jquery.min.js"></script>
<script src="js/bootstrap.bundle.min.js"></script>

<!-- Scroll to fixed -->
	<script type="text/javascript" src="js/jquery-scrolltofixed-min.js"></script>
	
	<script type="text/javascript">
		$('#combos-sup').scrollToFixed({marginTop: 76});
	</script>

<!-- Btn subir -->
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

<%--</body>--%>
<%--</html>--%>
</asp:Content>