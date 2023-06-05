
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


                                                                                                                                //𝑒𝑗𝑒𝑚𝑝𝑙𝑜 𝑑𝑒 𝑙𝑙𝑒𝑛𝑎𝑟 𝑏𝑎𝑟𝑟𝑎 𝑦 𝑑𝑜𝑛𝑎 
//function postGraficaBarra(PoDiv, PoWM) {
//    var succes = function (response) {
//        pintarGraficaBarra(PoDiv, response.d)
//    };
//    post(PoWM, succes)
//}

//function postGraficaPie(PoDiv, PoWM) {
//    var succes = function (response) {
//        pintarGraficaDona(PoDiv, response.d)
//    };
//    post(PoWM, succes)
//}

//function cargarIntroSivemms() {
//    postGraficaBarra("#dvStylingaxesandcolumns", "EmbarazosSinMorbilidad.aspx/wmStylingaxesandcolumns")
//    postGraficaPie("#dvDona111", "EmbarazosSinMorbilidad.aspx/wmDona111");
//}


//<%--    𝑬𝒇𝒇𝒊𝒄𝒊𝒆𝒏𝒄𝒚𝑶𝒑𝒕𝒊𝒎𝒊𝒛𝒂𝒕𝒊𝒐𝒏 --%>

//function GraficaEfficiencyOptimization(PoDiv, PoWM) {
//    var succes = function (response) {
//        pintarEfficiencyOptimization(PoDiv, response.d)
//    };
//    post(PoWM, succes)
//}


//function cargarPruebaGraficas3() {
//    GraficaEfficiencyOptimization("#dvEfficiencyOptimization", "EmbarazosSinMorbilidad.aspx/wmEfficiencyOptimization");
//};

//<%--    𝑬𝒇𝒇𝒊𝒄𝒊𝒆𝒏𝒄𝒚𝑶𝒑𝒕𝒊𝒎𝒊𝒛𝒂𝒕𝒊𝒐𝒏 --%>
                                                                                                                                //𝑒𝑗𝑒𝑚𝑝𝑙𝑜 𝑑𝑒 𝑙𝑙𝑒𝑛𝑎𝑟 𝑏𝑎𝑟𝑟𝑎 𝑦 𝑑𝑜𝑛𝑎 

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

    post("CausasDeMorbilidad.aspx/wmCboInstitucion", succes);
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
    cargarCausasmorbilidad();
}


function cboEntidadChange() {
    limpiarCombo("#cboJurisdiccion", "Todas");
    limpiarCombo("#cboMunicipio", "Todos");
    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboEntidad", "#cboJurisdiccion", "EmbarazosSinMorbilidad.aspx/wmCboJurisdiccion");
    cargarCausasmorbilidad();
}

function cboJurisdiccionChange() {
    limpiarCombo("#cboMunicipio", "Todas");
    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboJurisdiccion", "#cboMunicipio", "EmbarazosSinMorbilidad.aspx/wmCboMunicipio");
    cargarCausasmorbilidad();
}

function cboMunicipioChange() {

    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboMunicipio", "#cboUS", "EmbarazosSinMorbilidad.aspx/wmCboUS");
    cargarCausasmorbilidad();
}

function cboUSChange() {
    cargarCausasmorbilidad();
}

//d̳v̳C̳a̳u̳s̳a̳s̳m̳o̳r̳b̳i̳l̳i̳d̳a̳d̳
function postGraficaBarra(PoDiv, PoWM) {
    var succes = function (response) {
        pintarGraficaBarra(PoDiv, response.d)
    };
    post(PoWM, succes)
}

function cargarCausasmorbilidad() {
    postGraficaBarra("#dvCausasmorbilidad", "CausasDeMorbilidad.aspx/wmCausasmorbilidad");
};

//d̳v̳C̳a̳u̳s̳a̳s̳m̳o̳r̳b̳i̳l̳i̳d̳a̳d̳


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
    cargarCausasmorbilidad();
});