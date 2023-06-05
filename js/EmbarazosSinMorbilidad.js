
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

function postGraficaBarra(PoDiv, PoWM) {
    var succes = function (response) {
        pintarGraficaBarra(PoDiv, response.d)
    };
    post(PoWM, succes)
}


function cargarIntroSivemms() {
    postGraficaBarra("#dvStylingaxesandcolumns", "EmbarazosSinMorbilidad.aspx/wmStylingaxesandcolumns")
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

    post("EmbarazosSinMorbilidad.aspx/wmCboInstitucion", succes);
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
    cargarIntroSivemms();
}



function cboEntidadChange() {
    limpiarCombo("#cboJurisdiccion", "Todas");
    limpiarCombo("#cboMunicipio", "Todos");
    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboEntidad", "#cboJurisdiccion", "EmbarazosSinMorbilidad.aspx/wmCboJurisdiccion");
    cargarIntroSivemms();
}

function cboJurisdiccionChange() {
    limpiarCombo("#cboMunicipio", "Todas");
    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboJurisdiccion", "#cboMunicipio", "EmbarazosSinMorbilidad.aspx/wmCboMunicipio");
    cargarIntroSivemms();
}

function cboMunicipioChange() {

    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboMunicipio", "#cboUS", "EmbarazosSinMorbilidad.aspx/wmCboUS");
    cargarIntroSivemms();
}

function cboUSChange() {
    cargarIntroSivemms();
}

//<%-- 𝔖𝔱𝔶𝔩𝔦𝔫𝔤 𝔞𝔵𝔢𝔰 𝔞𝔫𝔡 𝔠𝔬𝔩𝔲𝔪𝔫𝔰--%>
function GraficaStylingaxesandcolumns(PoDiv, PoWM) {
    var succes = function (response) {
        pintarStylingaxesandcolumns(PoDiv, response.d)
    };
    post(PoWM, succes)
}

function cargarPruebaGraficas5() {
    GraficaStylingaxesandcolumns("#dvStylingaxesandcolumns", "EmbarazosSinMorbilidad.aspx/wmStylingaxesandcolumns");
};
//<%-- 𝔖𝔱𝔶𝔩𝔦𝔫𝔤 𝔞𝔵𝔢𝔰 𝔞𝔫𝔡 𝔠𝔬𝔩𝔲𝔪𝔫𝔰--%>

//<%--    𝑬𝒇𝒇𝒊𝒄𝒊𝒆𝒏𝒄𝒚𝑶𝒑𝒕𝒊𝒎𝒊𝒛𝒂𝒕𝒊𝒐𝒏 --%>

function GraficaEfficiencyOptimization(PoDiv, PoWM) {
    var succes = function (response) {
        pintarEfficiencyOptimization(PoDiv, response.d)
    };
    post(PoWM, succes)
}


function cargarPruebaGraficas3() {
    GraficaEfficiencyOptimization("#dvEfficiencyOptimization", "EmbarazosSinMorbilidad.aspx/wmEfficiencyOptimization");
};

//<%--    𝑬𝒇𝒇𝒊𝒄𝒊𝒆𝒏𝒄𝒚𝑶𝒑𝒕𝒊𝒎𝒊𝒛𝒂𝒕𝒊𝒐𝒏 --%>

/*Page load*/
$(document).ready(function () {
    $.filtro = {
        cveInstitucion :-1,
        cveEntidad: -1,
        cveJurisdiccion: -1,
        cveMunicipio: -1,
        clues: -1
        //cveGrado: -1
    };
    cargarCombos();
    cargarIntroSivemms();
    cargarPruebaGraficas5();
    cargarPruebaGraficas3();
});