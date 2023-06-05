// input.map "No funciona en IE con vista de compatilidad, requiere >= IE 9"
function obtenerCampos(input, field) {
    return input.map(function (o) {
        return o[field];
    });
}

function redondeaN(num, places) {
    return parseFloat(Math.round(num * 100) / 100).toFixed(places);
}

function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}

function obtenerValorCbo(cbo) {
    var value = $(cbo).val();
    if (value == null || value == undefined) {
        value = -1;
    }
    return value;
}

function limpiarCombo(cbo, texto) {
    $(cbo)
        .find('option')
        .remove()
        .end()
        .append('<option value="-1" selected="selected">' + texto + '</option>')
        .val('-1');
}

//Quien llame a esta función deberá definir el método post(<webMethodObtenerValoresCombo>, <callback success (definida en esta función)>)
function postPoblarComboDep(cboIndep, cboDep, wmCombo) {
    var succes = function (response) {
        var aData = response.d;

        $(cboDep)
            .find('option')
            .remove()
            .end();

        $.each(aData, function () {
            $(cboDep).append($("<option/>").val(this.clave).text(this.descripcion));
        });

        $(cboDep)
            .append('<option value="-1" selected="selected">Todas</option>')
            .val('-1');
    };

    var value = $(cboIndep + ' option:selected').val();
    if (value == null || value == undefined) {
        value = -1;
    }

    if (value == -1) {
        $(cboDep)
            .find('option')
            .remove()
            .end()
            .append('<option value="-1" selected="selected">Todas</option>')
            .val('-1');
    }
    else {
        post(wmCombo, succes);
    }
}

function regresarTamanioDiv(nombreDiv, tamanioBase, tamanioFila, numeroFilas, tipoCrecimiento) {
    var tamanioDiv = tamanioBase;
    var numeroFilas = numeroFilas;
    var tamanioFila = tamanioFila;
    tamanioDiv = tamanioDiv + (numeroFilas * tamanioFila);

    if (tipoCrecimiento == 'Alto') {
        $(nombreDiv).height(tamanioDiv);
    }
    else if (tipoCrecimiento == 'Ancho') {
        $(nombreDiv).width(tamanioDiv);
    }
}

