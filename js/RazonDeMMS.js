
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

    post("RazonDeMMS.aspx/wmCboInstitucion", succes);
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
    RazonMMS();
    CargarRazonMMS2();
    cambiarImg();
}

function cboEntidadChange() {
    limpiarCombo("#cboJurisdiccion", "Todas");
    limpiarCombo("#cboMunicipio", "Todos");
    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboEntidad", "#cboJurisdiccion", "EmbarazosSinMorbilidad.aspx/wmCboJurisdiccion");
    RazonMMS();
    CargarRazonMMS2();
}

function cboJurisdiccionChange() {
    limpiarCombo("#cboMunicipio", "Todas");
    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboJurisdiccion", "#cboMunicipio", "EmbarazosSinMorbilidad.aspx/wmCboMunicipio");
    RazonMMS();
    CargarRazonMMS2();
}

function cboMunicipioChange() {

    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboMunicipio", "#cboUS", "EmbarazosSinMorbilidad.aspx/wmCboUS");
    RazonMMS();
    CargarRazonMMS2();
}

function cboUSChange() {
    RazonMMS();
    CargarRazonMMS2();
}
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

function cambiarImg() {

    var value = obtenerValorCbo("#cboInstitucion")

    if (value == -1) {

        $("#img").attr("src", "../../images/logo_mexicopresidencia.SVG"); // Todos -1
      //  $("#img2").attr("src", "../../images/logo_mexicopresidencia.SVG"); // Todos -1
        //$("#img3").attr("src", "../../images/logo_mexicopresidencia.SVG"); // Todos -1
    }
    else if (value == 1) {

        $("#img").attr("src", "../../images/mapa_logo_ss.svg"); // SSA  1
       // $("#img2").attr("src", "../../images/mapa_logo_ss.svg"); // SSA  1 
       // $("#img3").attr("src", "../../images/mapa_logo_ss.svg"); // SSA  1 
    }
    else if (value == 2) {

        $("#img").attr("src", "../../images/mapa_logo_imss.svg"); // IMMS 2
       // $("#img2").attr("src", "../../images/mapa_logo_imss.svg"); // IMMS 2
       // $("#img3").attr("src", "../../images/mapa_logo_imss.svg"); // IMMS 2
    }
    else if (value == 3) {

        $("#img").attr("src", "../../images/mapa_logo_issste.svg"); // ISSTE 3
       // $("#img2").attr("src", "../../images/mapa_logo_issste.svg"); // ISSTE 3
       // $("#img3").attr("src", "../../images/mapa_logo_issste.svg"); // ISSTE 3
    }
    else if (value == 6) {

        $("#img").attr("src", "../../images/mapa_logo_imss-prospera.svg"); // IMSS PROSPERA 6
       // $("#img2").attr("src", "../../images/mapa_logo_imss-prospera.svg"); // IMSS PROSPERA 6
       // $("#img3").attr("src", "../../images/mapa_logo_imss-prospera.svg"); // IMSS PROSPERA 6
    }
    else if (value == 11) {

        $("#img").attr("src", "../../images/queso.PNG"); // UNIVERSIDAD 11
       // $("#img2").attr("src", "../../images/queso.PNG"); // UNIVERSIDAD 11
       // $("#img3").attr("src", "../../images/queso.PNG"); // UNIVERSIDAD 11
    }
    else if (value == 12) {

        $("#img").attr("src", "../../images/manzana.PNG"); // PRIVADA
       // $("#img2").attr("src", "../../images/manzana.PNG"); // PRIVADA
       // $("#img3").attr("src", "../../images/manzana.PNG"); // PRIVADA
    }
    else {

        $("#img").attr("src", "../../images/_logo_mexicopresidencia.SVG"); // Todos -1
       // $("#img2").attr("src", "../../images/_logo_mexicopresidencia.SVG"); // Todos -1
       // $("#img3").attr("src", "../../images/_logo_mexicopresidencia.SVG"); // Todos -1
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//<%-- R͟a͟z͟ó͟n͟ ͟d͟e͟ ͟M͟o͟r͟b͟i͟l͟i͟d͟a͟d͟ ͟M͟a͟t͟e͟r͟n͟a͟ ͟S͟e͟v͟e͟r͟a͟ --%>
function postGraficaBarraMMS(PoDiv, PoWM) {
    var succes = function (response) {

        //Tamaño de la grafica
        if (response !== undefined) {
            if (response.d.categorias.length > 0) {
                regresarTamanioDiv(PoDiv, 50, 25, response.d.categorias.length, 'Alto');
            }
        }

        $("#lblMorbiTotal").text(response.d.valores[0]);
        $("#lblMorbiRN").text(response.d.valores[1]);
        $("#lblRazon").text(response.d.valores[2]);
        pintarGraficaBarraplotLine(PoDiv, response.d) //✓
    };
    post(PoWM, succes)
}
function RazonMMS() {
    postGraficaBarraMMS("#dvRazonMMS", "RazonDeMMS.aspx/wmRazonMMS");
};

//<%-- R͟a͟z͟ó͟n͟ ͟d͟e͟ ͟M͟o͟r͟b͟i͟l͟i͟d͟a͟d͟ ͟M͟a͟t͟e͟r͟n͟a͟ ͟S͟e͟v͟e͟r͟a͟ --%>



//  <%--𝘊𝘢𝘴𝘰𝘴 𝘱𝘰𝘳 𝘨𝘳𝘶𝘱𝘰 𝘥𝘦 𝘦𝘥𝘢𝘥--%>

function postGraficaColumna(PoDiv, PoWM) {
    var succes = function (response) {
        $("#lbledad").text(response.d.valores[0]);
        pintarGraficaColumna2series(PoDiv, response.d)
    };
    post(PoWM, succes)
}
function CargarRazonMMS2() {
    postGraficaColumna("#dvGrupodeedad", "RazonDeMMS.aspx/wmGrupodeedad");
};

//  <%--𝘊𝘢𝘴𝘰𝘴 𝘱𝘰𝘳 𝘨𝘳𝘶𝘱𝘰 𝘥𝘦 𝘦𝘥𝘢𝘥--%>


//A͟c͟t͟u͟a͟l͟i͟z͟a͟c͟i͟ó͟n͟ ͟d͟i͟a͟r͟i͟a͟>
function postFecha(PoWM) {
    var succes = function (response) {
        $("#lblFecAct").text(response.d[0]);
        $("#lblObse").text(response.d[1]);
        $("#lblObse1").text(response.d[1]);
    };
    post(PoWM, succes)
}
function cargarFecha() {
    postFecha("RazonDeMMS.aspx/wmFecha")
}
//A͟c͟t͟u͟a͟l͟i͟z͟a͟c͟i͟ó͟n͟ ͟d͟i͟a͟r͟i͟a͟>

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
    cambiarImg();
    RazonMMS();
    CargarRazonMMS2();
    cargarFecha();
});