<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestro/IntroMaster.master"  AutoEventWireup="true" CodeFile="CausasDeMorbilidad.aspx.cs" Inherits="DirApp_SIVEMMS_CausasDeMorbilidad" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script src="https://code.highcharts.com/highcharts.js"></script>
    <script src="https://code.highcharts.com/highcharts-more.js"></script>
    <script src="../../js/miscelaneos.js"></script>
    <script src="../../js/graficas/pintarGraficas.js"></script>
    <script src="../../js/CausasDeMorbilidad.js"></script>



<!--Título-->
<div class="container-fluid pt-100 bg-10">
	<div class="container-fluid w98">
		<div class="row">
			<div class="col-11"><h1 class="tit-clr3"><img src="../../images/ico_3.svg" alt="" class="ico-cab-int" />Causas de morbilidad materna severa</h1></div>
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


<div class="container-fluid w98 mt-3">
	<div class="row">
		<div class="col-12">
			<h2 class="mb-2">Casos de Morbilidad Materna Severa  por causa y proporción que representan </h2>
		</div>
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

        <br />
        <br />
        <br />

<%-- Causasmorbilidad --%>
    <div class="container-fluid bott30">
       <div class="row top30">
          <div class="col-sm-12">
         <h3 class="primero">Causas de morbilidad materna severa</h3>
          </div>
        </div>
        <div class="row">
            <div class="col-sm-12">
                <div id="dvCausasmorbilidad" style="width:100%;margin:auto;"></div>
            </div>
        </div>
    </div>
<%-- Causasmorbilidad --%>

	</div>
</div>


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