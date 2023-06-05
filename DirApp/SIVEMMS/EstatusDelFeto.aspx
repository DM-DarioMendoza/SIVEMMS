<%@ Page Title="" Language="C#" MasterPageFile="~/PaginasMaestro/IntroMaster.master"  AutoEventWireup="true" CodeFile="EstatusDelFeto.aspx.cs" Inherits="DirApp_SIVEMMS_EstatusDelFeto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script src="https://code.highcharts.com/highcharts.js"></script>
    <script src="https://code.highcharts.com/highcharts-more.js"></script>
    <script src="../../js/miscelaneos.js"></script>
    <script src="../../js/graficas/pintarGraficas.js"></script>
    <script src="../../js/EstatusDelFeto.js"></script>



<!--Título-->
<div class="container-fluid pt-100 bg-10">
	<div class="container-fluid w98">
		<div class="row">
			<div class="col-11"><h1 class="tit-clr4"><img src="../../images/ico_4.svg" alt="" class="ico-cab-int" />Estatus del feto y el recién nacido</h1></div>
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
			<h2 class="mb-2">Estatus del producto al nacimiento, México 2017. </h2>
		</div>

        <br />
        <br />
        <br />


 <div class="row top20">
    <div class="col-sm-12 text-center">
                <label class="texto2">De los </label>
                <label id="lblNacsuma" class="textoBold2">XXX,XXX (XX.X%)</label> 
                <label class="texto2"> casos con Morbilidad Materna Severa;</label>
                <label id="lblNacVivo" class="textoBold2">XXX,XXX (XX.X%)</label> 
                <label class="texto2">productos nacieron vivos,</label>
                <label id="lblNacMuerto" class="textoBold2">XXX,XXX (XX.X%)</label> 
                <label class="texto2">nacieron muertos y</label>
                <label id="lblNonace" class="textoBold2">XXX,XXX (XX.X%)</label> 
                <label class="texto2">no han nacido</label>
     </div>
  </div>

<%-- 𝘌𝘴𝘵𝘢𝘵𝘶𝘴 𝘥𝘦𝘭 𝘧𝘦𝘵𝘰 𝘺 𝘦𝘭 𝘳𝘦𝘤𝘪é𝘯 𝘯𝘢𝘤𝘪𝘥𝘰 --%>
    <div class="container-fluid bott30">
        <div class="row">
            <div class="col-sm-12">
                <div id="dvFeto" style="width:100%;margin:auto;"></div>
            </div>
        </div>
    </div>
<%-- 𝘌𝘴𝘵𝘢𝘵𝘶𝘴 𝘥𝘦𝘭 𝘧𝘦𝘵𝘰 𝘺 𝘦𝘭 𝘳𝘦𝘤𝘪é𝘯 𝘯𝘢𝘤𝘪𝘥𝘰 --%>

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