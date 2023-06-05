
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

    post("IndicadoresNacionales.aspx/wmCboInstitucion", succes);
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
    cargarEstatusDelFeto();
    cargarEstatusdelProductoEdad();
    cargarTasa();
    cargarTasaSobrevidaMMSEdad();
    RazonsinMMS();
    CargarSinMMSGrupodeedad();
    cambiarImg();

}

function cboEntidadChange() {
    limpiarCombo("#cboJurisdiccion", "Todas");
    limpiarCombo("#cboMunicipio", "Todos");
    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboEntidad", "#cboJurisdiccion", "EmbarazosSinMorbilidad.aspx/wmCboJurisdiccion");
    cargarCausasmorbilidad();
    cargarEstatusDelFeto();
    cargarEstatusdelProductoEdad();
    cargarTasa();
    cargarTasaSobrevidaMMSEdad();
    RazonsinMMS();
    CargarSinMMSGrupodeedad();

    }

function cboJurisdiccionChange() {
    limpiarCombo("#cboMunicipio", "Todas");
    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboJurisdiccion", "#cboMunicipio", "EmbarazosSinMorbilidad.aspx/wmCboMunicipio");
    cargarCausasmorbilidad();
    cargarEstatusDelFeto();
    cargarEstatusdelProductoEdad();
    cargarTasa();
    cargarTasaSobrevidaMMSEdad();
    RazonsinMMS();
    CargarSinMMSGrupodeedad();

}

function cboMunicipioChange() {

    limpiarCombo("#cboUS", "Todas");
    postPoblarComboDep("#cboMunicipio", "#cboUS", "EmbarazosSinMorbilidad.aspx/wmCboUS");
    cargarCausasmorbilidad();
    cargarEstatusDelFeto();
    cargarEstatusdelProductoEdad();
    cargarTasa();
    cargarTasaSobrevidaMMSEdad();
    RazonsinMMS();
    CargarSinMMSGrupodeedad();

}

function cboUSChange() {
    cargarCausasmorbilidad();
    cargarEstatusDelFeto();
    cargarEstatusdelProductoEdad();
    cargarTasa();
    cargarTasaSobrevidaMMSEdad();
    RazonsinMMS();
    CargarSinMMSGrupodeedad();

}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

function cambiarImg() {

    var value = obtenerValorCbo("#cboInstitucion")

    if (value == -1) {

        $("#img").attr("src", "../../images/logo_mexicopresidencia.SVG"); // Todos -1
        $("#img2").attr("src", "../../images/logo_mexicopresidencia.SVG"); // Todos -1
        $("#img3").attr("src", "../../images/logo_mexicopresidencia.SVG"); // Todos -1
        $("#img4").attr("src", "../../images/logo_mexicopresidencia.SVG"); // Todos -1
    }
    else if (value == 1) {

        $("#img").attr("src", "../../images/mapa_logo_ss.svg"); // SSA  1
        $("#img2").attr("src", "../../images/mapa_logo_ss.svg"); // SSA  1 
        $("#img3").attr("src", "../../images/mapa_logo_ss.svg"); // SSA  1 
        $("#img4").attr("src", "../../images/mapa_logo_ss.svg"); // SSA  1 
    }
    else if (value == 2) {

        $("#img").attr("src", "../../images/mapa_logo_imss.svg"); // IMMS 2
        $("#img2").attr("src", "../../images/mapa_logo_imss.svg"); // IMMS 2
        $("#img3").attr("src", "../../images/mapa_logo_imss.svg"); // IMMS 2
        $("#img4").attr("src", "../../images/mapa_logo_imss.svg"); // IMMS 2
    }
    else if (value == 3) {

        $("#img").attr("src", "../../images/mapa_logo_issste.svg"); // ISSTE 3
        $("#img2").attr("src", "../../images/mapa_logo_issste.svg"); // ISSTE 3
        $("#img3").attr("src", "../../images/mapa_logo_issste.svg"); // ISSTE 3
        $("#img4").attr("src", "../../images/mapa_logo_issste.svg"); // ISSTE 3
    }
    else if (value == 6) {

        $("#img").attr("src", "../../images/mapa_logo_imss-prospera.svg"); // IMSS PROSPERA 6
        $("#img2").attr("src", "../../images/mapa_logo_imss-prospera.svg"); // IMSS PROSPERA 6
        $("#img3").attr("src", "../../images/mapa_logo_imss-prospera.svg"); // IMSS PROSPERA 6
        $("#img4").attr("src", "../../images/mapa_logo_imss-prospera.svg"); // IMSS PROSPERA 6
    }
    else if (value == 11) {

        $("#img").attr("src", "../../images/queso.PNG"); // UNIVERSIDAD 11
        $("#img2").attr("src", "../../images/queso.PNG"); // UNIVERSIDAD 11
        $("#img3").attr("src", "../../images/queso.PNG"); // UNIVERSIDAD 11
        $("#img4").attr("src", "../../images/queso.PNG"); // UNIVERSIDAD 11
    }
    else if (value == 12) {

        $("#img").attr("src", "../../images/manzana.PNG"); // PRIVADA
        $("#img2").attr("src", "../../images/manzana.PNG"); // PRIVADA
        $("#img3").attr("src", "../../images/manzana.PNG"); // PRIVADA
        $("#img4").attr("src", "../../images/manzana.PNG"); // PRIVADA
    }
    else {

        $("#img").attr("src", "../../images/_logo_mexicopresidencia.SVG"); // Todos -1
        $("#img2").attr("src", "../../images/_logo_mexicopresidencia.SVG"); // Todos -1
        $("#img3").attr("src", "../../images/_logo_mexicopresidencia.SVG"); // Todos -1
        $("#img4").attr("src", "../../images/_logo_mexicopresidencia.SVG"); // Todos -1
    }
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




//<%--   ͢E͢m͢b͢a͢r͢a͢z͢o͢s͢ ͢S͢i͢n͢ ͢M͢o͢r͢b͢i͢l͢i͢d͢a͢d͢ ͢M͢a͢t͢e͢r͢n͢a͢ ͢ --%>
function postGraficaBarrasinMMS(PoDiv, PoWM) {
    var succes = function (response) {
        $("#lblNacionalRN").text(response.d.valores[0]);
        $("#lblSinMorbiRN").text(response.d.valores[1]);
        $("#lblSinMorbiRNPorc").text(response.d.valores[2]);

              
        //Tamaño de la grafica
        if (response !== undefined) {
            if (response.d.categorias.length > 0) {
                regresarTamanioDiv(PoDiv, 50, 25, response.d.categorias.length, 'Alto');
            }
        }
        pintarGraficaBarraplotLine(PoDiv, response.d) //✓
    };
    post(PoWM, succes)
}
function RazonsinMMS() {
    postGraficaBarrasinMMS("#dvSinMMS", "IndicadoresNacionales.aspx/wmSinMMS");
};

//<%--   ͢E͢m͢b͢a͢r͢a͢z͢o͢s͢ ͢S͢i͢n͢ ͢M͢o͢r͢b͢i͢l͢i͢d͢a͢d͢ ͢M͢a͢t͢e͢r͢n͢a͢ ͢ --%>


//𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝  

function postGraficaSinMMSGrupodeedad(PoDiv, PoWM) {
    var succes = function (response) {
        pintarGraficaColumna(PoDiv, response.d)
    };
    post(PoWM, succes)
}
function CargarSinMMSGrupodeedad() {
    postGraficaSinMMSGrupodeedad("#dvSinMMSGrupodeedad", "IndicadoresNacionales.aspx/wmSinMMSGrupodeedad");
};

//𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝  



//d̳v̳C̳a̳u̳s̳a̳s̳m̳o̳r̳b̳i̳l̳i̳d̳a̳d̳
function postGraficaBarra(PoDiv, PoWM) {
    var succes = function (response) {
        $("#lblCausassuma").text(response.d.valores[0]);
        $("#lblEnferHiperte").text(response.d.valores[1]);
        $("#lblHemoobstre").text(response.d.valores[2]);
        $("#lblAdole").text(response.d.valores[3]);
        $("#lblEnfgerHipertetotal").text(response.d.valores[4]);
        $("#lblHemoobstretotal").text(response.d.valores[5]);
        $("#lblAdoletotal").text(response.d.valores[6]);
        
        pintarGraficaBarra(PoDiv, response.d)
    };
    post(PoWM, succes)
}

function cargarCausasmorbilidad() {
    postGraficaBarra("#dvCausasmorbilidad", "IndicadoresNacionales.aspx/wmCausasmorbilidad");
};

//d̳v̳C̳a̳u̳s̳a̳s̳m̳o̳r̳b̳i̳l̳i̳d̳a̳d̳

//𝘌𝘴𝘵𝘢𝘵𝘶𝘴 𝘥𝘦𝘭 𝘧𝘦𝘵𝘰 𝘺 𝘦𝘭 𝘳𝘦𝘤𝘪é𝘯 𝘯𝘢𝘤𝘪𝘥𝘰 
function postGraficaPie(PoDiv, PoWM) {
    var succes = function (response) {
        $("#lblNacsuma").text(response.d.valores[0]);
        $("#lblNacVivo").text(response.d.valores[1]);
        $("#lblNacVivoPorc").text(response.d.valores[2]);
        $("#lblNacMuerto").text(response.d.valores[3]);
        $("#lblNacMuertoPorc").text(response.d.valores[4]);
        $("#lblNonace").text(response.d.valores[5]);
        $("#lblNonacePorc").text(response.d.valores[6]);

        pintarGraficaDona(PoDiv, response.d);
    };
    post(PoWM, succes)
}

function cargarEstatusDelFeto() {
    postGraficaPie("#dvFeto", "IndicadoresNacionales.aspx/wmFeto");
};
//𝘌𝘴𝘵𝘢𝘵𝘶𝘴 𝘥𝘦𝘭 𝘧𝘦𝘵𝘰 𝘺 𝘦𝘭 𝘳𝘦𝘤𝘪é𝘯 𝘯𝘢𝘤𝘪𝘥𝘰 


//𝑮𝒓𝒂𝒇𝒊𝒄𝒂 𝒑𝒐𝒓 𝒓𝒂𝒏𝒈𝒐 𝒅𝒆 𝒆𝒅𝒂𝒅 𝑬𝒔𝒕𝒂𝒕𝒖𝒔 𝒅𝒆𝒍 𝑷𝒓𝒐𝒅𝒖𝒄𝒕𝒐 𝑬𝒅𝒂𝒅 

function postGraficaEstatusdelProductoEdad(PoDiv, PoWM) {
    var succes = function (response) {
        pintarGraficaBarraApilada(PoDiv, response.d)
    };
    post(PoWM, succes)
}
function cargarEstatusdelProductoEdad() {
    postGraficaEstatusdelProductoEdad("#dvEstatusdelProductoEdad", "IndicadoresNacionales.aspx/wmEstatusdelProductoEdad");
};

//𝑮𝒓𝒂𝒇𝒊𝒄𝒂 𝒑𝒐𝒓 𝒓𝒂𝒏𝒈𝒐 𝒅𝒆 𝒆𝒅𝒂𝒅 𝑬𝒔𝒕𝒂𝒕𝒖𝒔 𝒅𝒆𝒍 𝑷𝒓𝒐𝒅𝒖𝒄𝒕𝒐 𝑬𝒅𝒂𝒅 



// Tasa de sobrevida en mujeres
function postGraficaBarratasa(PoDiv, PoWM) {
    var succes = function (response) {
        $("#lblTasauma").text(response.d.valores[0]);
        $("#lblTasaumacasos").text(response.d.valores[1]);
        $("#lbltaza").text(response.d.valores[2]);

          //Tamaño de la grafica
        if (response !== undefined) {
            if (response.d.categorias.length > 0) {
                regresarTamanioDiv(PoDiv, 50, 25, response.d.categorias.length, 'Alto');
            }
        }


        pintarGraficaBarraplotLine(PoDiv, response.d)  //✓
    };
    post(PoWM, succes)
}
function cargarTasa() {
    postGraficaBarratasa("#dvTasaSobrevida", "IndicadoresNacionales.aspx/wmTasaSobrevida");
};

// Tasa de sobrevida en mujeres


// 𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 TasaSobrevidaMMSEdad 

function postGraficaTasaSobrevidaMMSEdad(PoDiv, PoWM) {
    var succes = function (response) {
        pintarGraficaColumna(PoDiv, response.d)
    };
    post(PoWM, succes)
}
function cargarTasaSobrevidaMMSEdad() {
    postGraficaTasaSobrevidaMMSEdad("#dvTasaSobrevidaMMSEdad", "IndicadoresNacionales.aspx/wmTasaSobrevidaMMSEdad");
};

// 𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 TasaSobrevidaMMSEdad 

//A͟c͟t͟u͟a͟l͟i͟z͟a͟c͟i͟ó͟n͟ ͟d͟i͟a͟r͟i͟a͟>
function postFecha(PoWM) {
    var succes = function (response) {
        $("#lblFecAct").text(response.d[0]);
        $("#lblObse").text(response.d[1]);
        $("#lblObse1").text(response.d[1]);
        $("#lblObse2").text(response.d[1]);
        $("#lblObse3").text(response.d[1]);
        $("#lblObse4").text(response.d[1]);
        $("#lblObse5").text(response.d[1]);
        $("#lblObse6").text(response.d[1]);
    };
    post(PoWM, succes)
}
function cargarFecha() {
    postFecha("IndicadoresNacionales.aspx/wmFecha")
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
    RazonsinMMS();
    CargarSinMMSGrupodeedad();
    cargarTasa();
    cargarTasaSobrevidaMMSEdad();
    cargarCausasmorbilidad();
    cargarEstatusDelFeto();
    cargarEstatusdelProductoEdad();
    cargarFecha();

});