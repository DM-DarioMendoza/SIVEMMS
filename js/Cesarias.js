
function post(webMethod, succes) {
    $.filtro.cveInstitucion = obtenerValorCbo("#cboInstitucion");
    $.filtro.cveEntidad = obtenerValorCbo("#cboEntidad");
    $.filtro.cveJurisdiccion = obtenerValorCbo("#cboJurisdiccion");
    $.filtro.cveMunicipio = obtenerValorCbo("#cboMunicipio");
    $.filtro.clues = obtenerValorCbo("#cboUS");
    $.filtro.parametros = obtenerValorCbo("#cboComparativo");

    
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

    post("Cesarias.aspx/wmCboInstitucion", succes);
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
    cargarCesareas();
    cargarCesariasGrupodeEdad();
    cargarPrenatal();
    cargarControlprenatalGrupodeEdad();
    cargarTransfusion();
    cambiarImg();
    cargarCausasTransfusion();
}

function cboEntidadChange() {
    limpiarCombo("#cboJurisdiccion", "Todas");
    limpiarCombo("#cboMunicipio", "Todos");
    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboEntidad", "#cboJurisdiccion", "EmbarazosSinMorbilidad.aspx/wmCboJurisdiccion");
    cargarCesareas();
    cargarCesariasGrupodeEdad();
    cargarPrenatal();
    cargarControlprenatalGrupodeEdad();
    cargarTransfusion();
    cargarCausasTransfusion();
}

function cboJurisdiccionChange() {
    limpiarCombo("#cboMunicipio", "Todas");
    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboJurisdiccion", "#cboMunicipio", "EmbarazosSinMorbilidad.aspx/wmCboMunicipio");
    cargarCesareas();
    cargarCesariasGrupodeEdad();
    cargarPrenatal();
    cargarControlprenatalGrupodeEdad();
    cargarTransfusion();
    cargarCausasTransfusion();
}

function cboMunicipioChange() {

    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboMunicipio", "#cboUS", "EmbarazosSinMorbilidad.aspx/wmCboUS");
    cargarCesareas();
    cargarCesariasGrupodeEdad();
    cargarPrenatal();
    cargarControlprenatalGrupodeEdad();
    cargarTransfusion();
    cargarCausasTransfusion();
}

function cboUSChange() {
    cargarCesareas();
    cargarCesariasGrupodeEdad();
    cargarPrenatal();
    cargarControlprenatalGrupodeEdad();
    cargarTransfusion();
    cargarCausasTransfusion();
}

function cboComparativoChange() {

    postPoblarComboDep("#cboComparativo", "EmbarazosSinMorbilidad.aspx/wmTransfusion");
    cargarTransfusion();
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

function cambiarImg() {

    var value = obtenerValorCbo("#cboInstitucion")

    if (value == -1) {

        $("#img").attr("src", "../../images/logo_mexicopresidencia.SVG"); // Todos -1
        $("#img2").attr("src", "../../images/logo_mexicopresidencia.SVG"); // Todos -1
        $("#img3").attr("src", "../../images/logo_mexicopresidencia.SVG"); // Todos -1
    }
    else if (value == 1) {

        $("#img").attr("src", "../../images/mapa_logo_ss.svg"); // SSA  1
        $("#img2").attr("src", "../../images/mapa_logo_ss.svg"); // SSA  1 
        $("#img3").attr("src", "../../images/mapa_logo_ss.svg"); // SSA  1 
    }
    else if (value == 2) {

        $("#img").attr("src", "../../images/mapa_logo_imss.svg"); // IMMS 2
        $("#img2").attr("src", "../../images/mapa_logo_imss.svg"); // IMMS 2
        $("#img3").attr("src", "../../images/mapa_logo_imss.svg"); // IMMS 2
    }
    else if (value == 3) {

        $("#img").attr("src", "../../images/mapa_logo_issste.svg"); // ISSTE 3
        $("#img2").attr("src", "../../images/mapa_logo_issste.svg"); // ISSTE 3
        $("#img3").attr("src", "../../images/mapa_logo_issste.svg"); // ISSTE 3
    }
    else if (value == 6) {

        $("#img").attr("src", "../../images/mapa_logo_imss-prospera.svg"); // IMSS PROSPERA 6
        $("#img2").attr("src", "../../images/mapa_logo_imss-prospera.svg"); // IMSS PROSPERA 6
        $("#img3").attr("src", "../../images/mapa_logo_imss-prospera.svg"); // IMSS PROSPERA 6
    }
    else if (value == 11) {

        $("#img").attr("src", "../../images/queso.PNG"); // UNIVERSIDAD 11
        $("#img2").attr("src", "../../images/queso.PNG"); // UNIVERSIDAD 11
        $("#img3").attr("src", "../../images/queso.PNG"); // UNIVERSIDAD 11
    }
    else if (value == 12) {

        $("#img").attr("src", "../../images/manzana.PNG"); // PRIVADA
        $("#img2").attr("src", "../../images/manzana.PNG"); // PRIVADA
        $("#img3").attr("src", "../../images/manzana.PNG"); // PRIVADA
    }
    else {

        $("#img").attr("src", "../../images/_logo_mexicopresidencia.SVG"); // Todos -1
        $("#img2").attr("src", "../../images/_logo_mexicopresidencia.SVG"); // Todos -1
        $("#img3").attr("src", "../../images/_logo_mexicopresidencia.SVG"); // Todos -1
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//<%--C̸e̸s̸á̸r̸e̸a̸s̸--%> 
function postGraficaBarra(PoDiv, PoWM) {
    var succes = function (response) {

        //Tamaño de la grafica


        if (response !== undefined) {
            if (response.d.categorias.length > 0) {
                regresarTamanioDiv(PoDiv, 50, 25, response.d.categorias.length, 'Alto');
            }
        }
        $("#lblCesariasTotal").text(response.d.valores[0]);
        $("#lblCesariassum").text(response.d.valores[1]);
        $("#lblCesariasTotalPorc").text(response.d.valores[2]);
        pintarGraficaBarraplotLine(PoDiv, response.d) //✓
    };
    post(PoWM, succes)
}
function cargarCesareas() {
    postGraficaBarra("#dvCesarias", "Cesarias.aspx/wmCesarias");
};
//<%--C̸e̸s̸á̸r̸e̸a̸s̸--%>

//𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Cesarias

function postGraficaCesariasGrupodeEdad(PoDiv, PoWM) {
    var succes = function (response) {
        pintarGraficaColumna(PoDiv, response.d)
    };
    post(PoWM, succes)
}
function cargarCesariasGrupodeEdad() {
    postGraficaCesariasGrupodeEdad("#dvCesariasGrupodeedad", "Cesarias.aspx/wmCesariasGrupodeedad");
};

//𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Cesarias

//ℙ𝕣𝕖𝕟𝕒𝕥𝕒𝕝
function postGraficaBarraPrenatal(PoDiv, PoWM) {
    var succes = function (response) {

        //Tamaño de la grafica
        if (response !== undefined) {
            if (response.d.categorias.length > 0) {
                regresarTamanioDiv(PoDiv, 50, 25, response.d.categorias.length, 'Alto');
            }
        }

        $("#lblPrenatalTotal").text(response.d.valores[0]);
        $("#lblPrenatalsum").text(response.d.valores[1]);
        $("#lblPrenatalTotalPorc").text(response.d.valores[2]);
        pintarGraficaBarraplotLine(PoDiv, response.d) //✓
    };
    post(PoWM, succes)
}
function cargarPrenatal() {
    postGraficaBarraPrenatal("#dvPrenatal", "Cesarias.aspx/wmPrenatal");
};

//ℙ𝕣𝕖𝕟𝕒𝕥𝕒𝕝

//𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Controlprenatal

function postGraficaControlprenatalGrupodeEdad(PoDiv, PoWM) {
    var succes = function (response) {
        pintarGraficaColumna(PoDiv, response.d)
    };
    post(PoWM, succes)
}
function cargarControlprenatalGrupodeEdad() {
    postGraficaControlprenatalGrupodeEdad("#dvControlprenatalGrupodeedad", "Cesarias.aspx/wmControlprenatalGrupodeedad");
};

//𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Controlprenatal

//T̴r̴a̴n̴s̴f̴u̴s̴i̴o̴n̴
function postGraficaBarraTransfusion(PoDiv, PoWM) {
    var succes = function (response) {


        if ($("#cboComparativo").val() == "1")
        {
            //Tamaño de la grafica
            if (response !== undefined) {
                if (response.d.categorias.length > 0) {
                    regresarTamanioDiv(PoDiv, 50, 25, response.d.categorias.length, 'Alto');
                }
            }
            pintarGraficaBarraplotLine1Serie(PoDiv, response.d)//✓✓

        }

        if ($("#cboComparativo").val() != "1")
        {
            //Tamaño de la grafica
            if (response !== undefined) {
                if (response.d.categorias.length > 0) {
                    regresarTamanioDiv(PoDiv, 50, 60, response.d.categorias.length, 'Alto');
                
                }
            }
            pintarGraficaBarraplotLine(PoDiv, response.d)//✓
        }

        $("#lblTransfusionTotal").text(response.d.valores[0]);
        $("#lblTransfusionsum").text(response.d.valores[1]);
        $("#lblTransfusionTotalPorc").text(response.d.valores[2]);

    };
    post(PoWM, succes)
}
function cargarTransfusion() {
    postGraficaBarraTransfusion("#dvTransfusion", "Cesarias.aspx/wmTransfusion");
};

//T̴r̴a̴n̴s̴f̴u̴s̴i̴o̴n̴


//C̶a̶u̶s̶a̶s̶T̶r̶a̶n̶s̶f̶u̶s̶i̶o̶n̶
function postGraficaPie(PoDiv, PoWM) {
    var succes = function (response) {
     //   $("#lblNacsuma").text(response.d.valores[0]);

        pintarGraficaDona(PoDiv, response.d);
    };
    post(PoWM, succes)
}

function cargarCausasTransfusion() {
    postGraficaPie("#dvCausasTransfusion", "Cesarias.aspx/wmCausasTransfusion");
};


//C̶a̶u̶s̶a̶s̶T̶r̶a̶n̶s̶f̶u̶s̶i̶o̶n̶

//A͟c͟t͟u͟a͟l͟i͟z͟a͟c͟i͟ó͟n͟ ͟d͟i͟a͟r͟i͟a͟>
function postFecha(PoWM) {
    var succes = function (response) {
        $("#lblFecAct").text(response.d[0]);
        $("#lblObse").text(response.d[1]);
        $("#lblObse1").text(response.d[1]);
        $("#lblObse2").text(response.d[1]);
        $("#lblObse3").text(response.d[1]);
        $("#lblObse4").text(response.d[1]);
    };
    post(PoWM, succes)
}
function cargarFecha() {
    postFecha("Cesarias.aspx/wmFecha")
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
    cargarCesareas();
    cargarCesariasGrupodeEdad();
    cargarPrenatal();
    cargarControlprenatalGrupodeEdad();
    cargarTransfusion();
    cambiarImg();
    cargarCausasTransfusion();
    cargarFecha();
});