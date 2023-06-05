
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

    post("PrincipalRestringida.aspx/wmCboInstitucion", succes);
}

function cargarCombos() {
    postPoblarCboInstitucion("#cboInstitucion");

}

function cboInstitucionChange() {
    limpiarCombo("#cboEntidad", "Todas");
    limpiarCombo("#cboJurisdiccion", "Todas");
    limpiarCombo("#cboMunicipio", "Todas");
    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboInstitucion", "#cboEntidad", "PrincipalRestringida.aspx/wmCboEntidad");
    cargarodometro();
    cambiarImg();
    optMapaOnOffChange();
    cargarMapa();
}

//<!--m͟a͟p͟i͟t͟a͟-->
function Graficamapita(PoDiv, PoWM) {
    var succes = function (response) {
        pintarMapaMexico(PoDiv, response.d)
    };
    post(PoWM, succes)
}

function cargarMapa() {
    Graficamapita("#dvmapita", "Principal.aspx/wmmapita");
};

//<!--m͟a͟p͟i͟t͟a͟-->


//MapaOnOff
function GraficamapitaLetalidad(PoDiv, PoWM) {
    var succes = function (response) {
        pintarMapaMexicoletalidad(PoDiv, response.d)
    };
    post(PoWM, succes)
}

function GraficamapitaL(PoDiv, PoWM) {
    var succes = function (response) {
        pintarMapaMexico2Series(PoDiv, response.d)
    };
    post(PoWM, succes)
}

function optMapaOnOffChange() {
    if ($('#swMapaOnOff').is(':checked')) {
        $("#lblMorbilidadtitulo").css('display', 'none');
        $("#lblMorbilidad").css('display', 'none');
        $("#desplazadaMorbilidad").css('display', 'none');
        $("#lblLetalidad").css('display', 'block');
        $("#lblLetalidadtitulo").css('display', 'block');
        $("#desplazadaLetalidad").css('display', 'block');
        GraficamapitaLetalidad("#dvMapaOnOff", "PrincipalRestringida.aspx/wmMapaOnOff");

    }
    else {
        $("#lblMorbilidadtitulo").css('display', 'block');
        $("#desplazadaLetalidad").css('display', 'none');
        $("#lblLetalidadtitulo").css('display', 'none');
        $("#lblLetalidad").css('display', 'none');
        $("#lblMorbilidad").css('display', 'block');
        $("#desplazadaMorbilidad").css('display', 'block');
   
        GraficamapitaL("#dvMapaOnOff", "PrincipalRestringida.aspx/wmMapaOnOff");

    }
}

//MapaOnOff

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

function cambiarImg() {

    var value = obtenerValorCbo("#cboInstitucion")

    if (value == -1) {

        $("#img").attr("src", "../../images/logo_mexicopresidencia.SVG"); // Todos -1
        $("#img2").attr("src", "../../images/logo_mexicopresidencia.SVG"); // Todos -1
    }
    else if (value == 1) {

        $("#img").attr("src", "../../images/mapa_logo_ss.svg"); // SSA  1 
        $("#img2").attr("src", "../../images/mapa_logo_ss.svg"); // SSA  1 
    }
    else if (value == 2) {

        $("#img").attr("src", "../../images/mapa_logo_imss.svg"); // IMMS 2
        $("#img2").attr("src", "../../images/mapa_logo_imss.svg"); // IMMS 2
    }
    else if (value == 3) {

        $("#img").attr("src", "../../images/mapa_logo_issste.svg"); // ISSTE 3
        $("#img2").attr("src", "../../images/mapa_logo_issste.svg"); // ISSTE 3
    }
    else if (value == 6) {

        $("#img").attr("src", "../../images/mapa_logo_imss-prospera.svg"); // IMSS PROSPERA 6
        $("#img2").attr("src", "../../images/mapa_logo_imss-prospera.svg"); // IMSS PROSPERA 6
    }
    else if (value == 11) {

        $("#img").attr("src", "../../images/queso.PNG"); // UNIVERSIDAD 11
        $("#img2").attr("src", "../../images/queso.PNG"); // UNIVERSIDAD 11
    }
    else if (value == 12) {

        $("#img").attr("src", "../../images/manzana.PNG"); // PRIVADA
        $("#img2").attr("src", "../../images/manzana.PNG"); // PRIVADA
    }
    else {

        $("#img").attr("src", "../../images/logo_mexicopresidencia.SVG"); // Todos -1
        $("#img2").attr("src", "../../images/_logo_mexicopresidencia.SVG"); // Todos -1
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

 
//o͟d͟o͟m͟e͟t͟r͟o͟

function postOdometro(PoWM) {
    var succes = function (response) {
        $("#Lblodometer").text(response.d[0]);
        $("#lblEntidades").text(response.d[2]);
        $("#lblJurisdicciones").text(response.d[3]);
        $("#lblMunicipios").text(response.d[4]);
        $("#lblHospitales").text(response.d[5]);
        $("#lblVidas").text(numberWithCommas(response.d[6]));

        setTimeout(function () {
            odometer.innerHTML = 41390;
        }, 1000);
    };
    post(PoWM, succes)
}

function cargarodometro() {
    postOdometro("PrincipalRestringida.aspx/wmodometro")
}
//o͟d͟o͟m͟e͟t͟r͟o͟

//A͟c͟t͟u͟a͟l͟i͟z͟a͟c͟i͟ó͟n͟ ͟d͟i͟a͟r͟i͟a͟>
function postFecha(PoWM) {
    var succes = function (response) {
        $("#lblFecAct").text(response.d[0]);  /*<label id="lblFecAct" class="textoBold2">XXX,XXX</label>*/
        $("#lblObse").text(response.d[1]);
        $("#lblObse1").text(response.d[1]);
    };
    post(PoWM, succes)
}
function cargarFecha() {
    postFecha("Principal.aspx/wmFecha")
}
//A͟c͟t͟u͟a͟l͟i͟z͟a͟c͟i͟ó͟n͟ ͟d͟i͟a͟r͟i͟a͟>



/*Page load*/
$(document).ready(function () {
    $.filtro = {
        cveInstitucion :-1,
        //cveEntidad: -1,
        //cveJurisdiccion: -1,
        //cveMunicipio: -1,
        //clues: -1
    };
    cargarCombos();
    cargarodometro();
    cambiarImg();
    optMapaOnOffChange();
    cargarMapa();
    cargarFecha();
    });