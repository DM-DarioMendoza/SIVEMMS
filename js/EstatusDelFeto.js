
function post(webMethod, succes) {
    $.filtro.cveInstitucion = obtenerValorCbo("#cboInstitucion");
    $.filtro.cveEntidad = obtenerValorCbo("#cboEntidad");
    $.filtro.cveJurisdiccion = obtenerValorCbo("#cboJurisdiccion");
    $.filtro.cveMunicipio = obtenerValorCbo("#cboMunicipio");
    $.filtro.clues = obtenerValorCbo("#cboUS");
    
    $.ajax({
        type: "POST",
        url: webMethod,
        contentType: "application/json; charset=utf-8",
        data: '{ "PoFiltros": ' + JSON.stringify($.filtro)+ ' }',
        success: succes,
        error: OnErrorCall1_
    });

    function OnErrorCall1_(response) {
        //alert("Ocurrió un Error!");
        console.log(response);
        return true;
    }
}


function postPoblarCboInstitucion(cbo) {
    var succes = function (response) {
        var aData = response.d;

        $(cbo)
            .find('option')
            .remove()
            .end();
            
        $.each(aData, function () {
            $(cbo).append($("<option/>").val(this.clave).text(this.descripcion));
        });

        $(cbo)
            .append('<option value="-1" selected="selected">Todas</option>')
            .val('-1');
    };

    post("EstatusDelFeto.aspx/wmCboInstitucion", succes);
}

function cargarCombos() {
    postPoblarCboInstitucion("#cboInstitucion");
    limpiarCombo("#cboEntidad", "Todas");
    limpiarCombo("#cboJurisdiccion", "Todas");
    limpiarCombo("#cboMunicipio", "Todos");
    limpiarCombo("#cboUS", "Todas");
    
}

function cboInstitucionChange() {
    limpiarCombo("#cboEntidad", "Todas");
    limpiarCombo("#cboJurisdiccion", "Todas");
    limpiarCombo("#cboMunicipio", "Todas");
    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboInstitucion", "#cboEntidad", "EmbarazosSinMorbilidad.aspx/wmCboEntidad");
    cargarEstatusDelFeto();
}

function cboEntidadChange() {
    limpiarCombo("#cboJurisdiccion", "Todas");
    limpiarCombo("#cboMunicipio", "Todos");
    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboEntidad", "#cboJurisdiccion", "EmbarazosSinMorbilidad.aspx/wmCboJurisdiccion");
    cargarEstatusDelFeto();
}

function cboJurisdiccionChange() {
    limpiarCombo("#cboMunicipio", "Todas");
    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboJurisdiccion", "#cboMunicipio", "EmbarazosSinMorbilidad.aspx/wmCboMunicipio");
    cargarEstatusDelFeto();
}

function cboMunicipioChange() {

    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboMunicipio", "#cboUS", "EmbarazosSinMorbilidad.aspx/wmCboUS");
    cargarEstatusDelFeto();
}

function cboUSChange() {
    cargarEstatusDelFeto();
}


//<%-- 𝘌𝘴𝘵𝘢𝘵𝘶𝘴 𝘥𝘦𝘭 𝘧𝘦𝘵𝘰 𝘺 𝘦𝘭 𝘳𝘦𝘤𝘪é𝘯 𝘯𝘢𝘤𝘪𝘥𝘰 --%>
function postGraficaPie(PoDiv, PoWM) {
    var succes = function (response) {
        $("#lblNacsuma").text(response.d.valores[0]);
        $("#lblNacVivo").text(response.d.valores[1]);
        $("#lblNacMuerto").text(response.d.valores[2]);
        $("#lblNonace").text(response.d.valores[3]);

        pintarGraficaDona(PoDiv, response.d);
    };
    post(PoWM, succes)
}

function cargarEstatusDelFeto() {
    postGraficaPie("#dvFeto", "EstatusDelFeto.aspx/wmFeto");
};

//<%-- 𝘌𝘴𝘵𝘢𝘵𝘶𝘴 𝘥𝘦𝘭 𝘧𝘦𝘵𝘰 𝘺 𝘦𝘭 𝘳𝘦𝘤𝘪é𝘯 𝘯𝘢𝘤𝘪𝘥𝘰 --%>

/*Page load*/
$(document).ready(function () {
    $.filtro = {
        cveInstitucion :-1,
        cveEntidad: -1,
        cveJurisdiccion: -1,
        cveMunicipio: -1,
        clues: -1
    };
    cargarCombos();
    cargarEstatusDelFeto();
});