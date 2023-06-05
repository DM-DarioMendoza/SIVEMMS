function pintarGraficaBarra(PoDiv, PoPuntos) { //Causas de morbilidad materna severa
    var chart = $(PoDiv).highcharts({
        chart: {
            plotBackgroundColor: null,  //Color del fondo
            type: 'bar'
        },
        title: {
            text: ''
        },
        tooltip: {
            formatter: function () { return eval(PoPuntos.tooltipFormater); }
        },
        xAxis: {
            categories: obtenerCampos(PoPuntos.categorias, 'nombre'),
            labels: {
                style: {
                    fontSize: '14px',
                    fontFamily: 'Open Sans'
                }
            }
        },
        yAxis: {
            labels: false,
            gridLineWidth: 0,
            min: 0,
            title: {
                text: ''
            }
        },
        credits: false,
        legend: {
            enabled: false
        },
        plotOptions: {
                bar: {
                    pointWidth: 20,
                    dataLabels: {
                        enabled: true,
                        formatter: function () {
                            return redondeaN(this.y, 1) + '%';
                        }
                    }
                }
        },
        series: [{
            name: '',
            colorByPoint: true,
            data: PoPuntos.series[0].data,
            maxPointWidth: 30
        }],
        responsive: {
            rules: [{
                condition: {
                    maxWidth: 200
                }
            }]
        }
    })
};

///
function pintarGraficaBarraplotLine1Serie(PoDiv, PoPuntos) { //transfusiones     
    var chart = $(PoDiv).highcharts({
        chart: {
            backgroundColor: PoPuntos.colorFondo,
            type: 'bar'
        },
        title: {
            text: ''
        },
        tooltip: {
            formatter: function () { return eval(PoPuntos.tooltipFormater); }
        },
        xAxis: {
            categories: obtenerCampos(PoPuntos.categorias, 'nombre'),
            labels: {
                style: {
                    fontSize: '14px',
                    fontFamily: 'Open Sans'
                }
            }
        },
        yAxis: {
            labels: {
                overflow: 'justify'
            },
            lineWidth: 1,  // Linea de las y
            tickInterval: 10,
            gridLineWidth: 0,
            min: PoPuntos.min,
            max: PoPuntos.max,

            plotLines: [{
                color: '#336699',
                width: 5,
                value: PoPuntos.totales,
                zIndex: 10,  //Linea flotando

                //label: {
                //     text: 'Promedio  ' + redondeaN(PoPuntos.totales,1),
                //    //verticalAlign: 'middle',
                //    y: 270,
                //    x: 20,
                //    style: {
                //        color: '#3a404e',
                //        fontWeight: 'bold',
                //        fontSize: '25px',
                //    }
                //}
            }],
            title: {
                text: ''
            }
        },
        credits: false,
        legend: {
            enabled: false
        },
        plotOptions: {
            bar: {
                //  stacking: 'normal',   | Para poner los porcentajes dentro de la grafica|
                pointWidth: PoPuntos.pointWidth,   // tamaño de grueso de la barra 
                dataLabels: {
                    enabled: true,
                    //  align: 'right', |Para poner los porcentajes dentro de la grafica del lado derecho|
                    formatter: function () {
                        return redondeaN(this.y, 1) + '%';
                    }
                }
            }
        },
        series: [{
            name: PoPuntos.series[0].name,
            colorByPoint: true,
            data: PoPuntos.series[0].data,

            // para poner el tamaño y color de el porcentaje dentro de la grafica
            dataLabels: {
                //       format: '{point.y:.1f} % - {point.valorY} casos ',
                style: {
                    enabled: true,
                    color: 'contrast',
                    fontSize: '12px',
                    textOutline: '1px 1px contrast',
                }
            },
            // para poner el tamaño y color de el porcentaje dentro de la grafica
        }, 
        ],
        responsive: {
            rules: [{
                condition: {
                    maxWidth: 200
                }
            }]
        }
    })
};
///

function pintarGraficaBarraplotLine(PoDiv, PoPuntos) { //todas
    var chart = $(PoDiv).highcharts({
        chart: {
            backgroundColor: PoPuntos.colorFondo,
            type: 'bar'
        },
        title: {
            text: ''
        },
        tooltip: {
            formatter: function () { return eval(PoPuntos.tooltipFormater); }
        },
        xAxis: {
            categories: obtenerCampos(PoPuntos.categorias, 'nombre'),
            labels: {
                style: {
                    fontSize: '14px',
                    fontFamily: 'Open Sans'
                }
            }
        },
        yAxis: {
            labels: {
                overflow: 'justify'
            },
            lineWidth: 1,  // Linea de las y
            tickInterval: 10,
            gridLineWidth: 0,
            min: PoPuntos.min,
            max: PoPuntos.max,

            plotLines: [{
                color: '#336699',
                width: 5,
                value: PoPuntos.totales,
                zIndex: 10,  //Linea flotando

                //label: {
                //     text: 'Promedio  ' + redondeaN(PoPuntos.totales,1),
                //    //verticalAlign: 'middle',
                //    y: 270,
                //    x: 20,
                //    style: {
                //        color: '#3a404e',
                //        fontWeight: 'bold',
                //        fontSize: '25px',
                //    }
                //}
            }],
            title: {
                text: ''
            }
        },
        credits: false,
        legend: {
            enabled: false
        },
        plotOptions: {
            bar: {
              //  stacking: 'normal',   | Para poner los porcentajes dentro de la grafica|
                pointWidth: PoPuntos.pointWidth,   // tamaño de grueso de la barra 

                dataLabels: {
                    enabled:true,
                    formatter: function () { return eval(PoPuntos.dataLabelsFormater); }
                }


            }
        },
        series: [{
            name: PoPuntos.series[0].name,
            colorByPoint: true,
            data: PoPuntos.series[0].data,

            // para poner el tamaño y color de el porcentaje dentro de la grafica
            dataLabels: {
            //       format: '{point.y:.1f} % - {point.valorY} casos ',
                style: {
                    enabled: true,
                    color: 'contrast',
                    fontSize: '12px',
                    textOutline: '1px 1px contrast',
                }
            },
            // para poner el tamaño y color de el porcentaje dentro de la grafica
        }, // Serie 2
            {
            name: PoPuntos.series[1].name,  // nombre de la segunda serie
            data: PoPuntos.series[1].data,  // datos de la segunda serie 
            dataLabels: {
                //format: '{point.y:.1f} % - {point.valorY} casos ',
                style: {
                    enabled: true,
                    color: 'contrast',
                    fontSize: '12px',
                    textOutline: '1px 1px contrast',
                }
            },
        },


        ],
        responsive: {
            rules: [{
                condition: {
                    maxWidth: 200
                }
            }]
        }
    })
};

function pintarGraficaDona(PoDiv, PoPuntos) { // Estatus del producto
    var chart = $(PoDiv).highcharts({
        chart: {
            backgroundColor: PoPuntos.colorFondo,
            type: 'pie',
            events: {
                load: function (event) {
                    var total = numberWithCommas(this.series[0].data[0].total);
                    var x = (this.plotLeft + this.plotWidth) / 2 - 20;
                    var y = (this.plotTop + this.plotHeight) / 2 + 15;
                    x = x + ((3 - total.toString().length) * 10);
                    chart.customText = this.renderer.text(
                        total,
                        x,
                        y
                    ).attr({
                        zIndex: 50
                    }).css({
                        color: '#727272',
                        fontWeight: '600',
                        fontSize: '1.8rem'
                    }).add()
                }
            }
        },
        title: {
            text: ''
        },
        legend: {
            enabled: false,
            x: 32,
            margin: 0,
            itemMarginTop: 1,
            itemMarginBottom: 1,
            width: 500,
            itemWidth: 230,
        },
        tooltip: {
            formatter: function () { return eval(PoPuntos.tooltipFormater); }
        },
        plotOptions: {
            pie: {
                allowPointSelect: true,
                cursor: 'pointer',
                dataLabels: {
                    enabled: true,
                    distance: -50,
                    formatter: function () {
                        return '<span style="font-family:\'Open Sans\'; font-size:16px; font-weight:normal; color:#FFFFFF; text-shadow: 1px 1px 2px rgba(0, 0, 0, 0.3); text-rendering:geometricPrecision;">' + redondeaN(this.percentage, 1) + '%</span> ';
                    },
                },
                showInLegend: true
            }
        },
        series: [{
            name: '',
            colorByPoint: true,
            size: '100%',
            innerSize: '40%',
            data: PoPuntos.series[0].data
        }],
        credits: false,
        responsive: {
            rules: [{
                condition: {
                    maxWidth: 200
                }
            }]
        }
    })
};

function pintarGraficaColumna(PoDiv, PoPuntos) { //Gráfica por rango de edad sin morbilidad materna severa
    var chart = $(PoDiv).highcharts({
        chart: {
            backgroundColor: PoPuntos.colorFondo, //Color del fondo
            type: 'column',
        },
        title: {
            text: PoPuntos.titulo,
        },
        tooltip: {
            formatter: function () { return eval(PoPuntos.tooltipFormater); }
        },
        xAxis: {
            categories: obtenerCampos(PoPuntos.categorias, 'nombre'),
            labels: {
                style: {
                    fontSize: '14px',
                    fontFamily: 'Open Sans'
                }
            }
        },
        yAxis: {
            labels: false,
            gridLineWidth: 0,
            title: {
                text: ''
            }
        },
        credits: false,
        legend: {
            enabled: false
        },
        plotOptions: {
            column: {
                borderRadius: PoPuntos.borderRadius,  // el radio de la grafica
              //  pointWidth: 40, // tamaño de grueso de la barra 
                pointWidth: PoPuntos.pointWidth, // tamaño de grueso de la barra 
                dataLabels: {
                    enabled: true,
                    formatter: function () { return redondeaN(this.y, 1) + '%'; }
                }
            }
        },
        series: [{
            name: '',
            colorByPoint: true,
            data: PoPuntos.series[0].data
        }],
        responsive: {
            rules: [{
                condition: {
                    maxWidth: 200
                }
            }]
        }
    })
};

function pintarGraficaColumna2series(PoDiv, PoPuntos) { //Casos de Morbilidad Materna Severa por Grupo de Edad
    var chart = $(PoDiv).highcharts({
        chart: {
            backgroundColor: PoPuntos.colorFondo,
            type: 'column'
        },
        title: {
            text: PoPuntos.titulo,
        },
        tooltip: {
            formatter: function ()
            { 
                return eval(PoPuntos.tooltipFormater);
            }
        },
        xAxis: {
            categories: obtenerCampos(PoPuntos.categorias, 'nombre'),
            labels: {
                style: {
                    fontSize: '14px',
                    fontFamily: 'Open Sans'
                }
            }
        },
        yAxis:[ {
            labels: {
                overflow: 'justify'
                //format: '{value} %'
            },
            lineWidth: 1,  // grosor de Linea de las y
           // tickInterval: 100, //para que crezca la barra segun lo que quieras  
            gridLineWidth: 0, // Lineas atras de la grafica
            title: {
                text: 'Casos',
                    style: {
                        color: '#8E8F94',
                        fontWeight: 'bold',
                        fontSize: '15px',
                    }
            }
        }, { // Secondary yAxis
            labels: {
                overflow: 'justify',
                format: '{value} %'
            },
            lineWidth: 1,  // grosor de Linea de las y
            gridLineWidth: 0, // Lineas atras de la grafica
            opposite: true,
            title: {
                text: 'Razón',
                style: {
                    color: '#8E8F94',
                    fontWeight: 'bold',
                    fontSize: '15px',
                }
            },
        }],
        credits: false,
        legend: {
            enabled: false
        },
        plotOptions: {
            column: {
                dataLabels: {
                    enabled: true,
                    formatter: function () { return numberWithCommas(this.y) ; }
                }
            }
        },
        series: [{
            name: 'Casos',
            type: 'column',
            //colorByPoint: true,
            color: '#E6AC1C',
           data: PoPuntos.series[0].data
        }, {
            name: 'Razón',
            type: 'spline',
            color: '#028482',
            yAxis: 1,
            data: PoPuntos.series[1].data,
            marker: {
                lineWidth: 2,
                lineColor: '#028482',  // o se le puede poder el color de la barra | lineColor: '#E6AC1C' |
                fillColor: 'white',
            }
            //,dashStyle: 'shortdot', // para linea de puntos ................
        }],
        legend: {
            layout: 'horizontal',
            align: 'right',
            verticalAlign: 'top',
            x: -80,
            y: 80,
            floating: true,
            borderWidth: 1,
            backgroundColor: ((Highcharts.theme && Highcharts.theme.legendBackgroundColor) || '#FFFFFF'),
            shadow: true
        },

        responsive: {
            rules: [{
                condition: {
                    maxWidth: 200
                }
            }]
        }
    })
};

function pintarGraficaBarraApilada(PoDiv, PoPuntos) {
    var chart = $(PoDiv).highcharts({
        chart: {
            type: 'bar',
            marginRight: 100
        },
        title: {
            text: PoPuntos.titulo
        },
        xAxis: {
            categories: obtenerCampos(PoPuntos.categorias, 'nombre'),
            reversed: true,
            title: {
                text: PoPuntos.tituloEjeX,
            }
        },
        yAxis: {
            min: 0,
            max: 110,
            allowDecimals: false,
            showLastLabel: false,
            title: {
                text: ''
            },
            stackLabels: {
                enabled: true,
                allowOverlap: true,
                textAlign: 'left',
                x: 15,
                color: '#009688',
                formatter: function () {
                    return numberWithCommas(this.total);
                }
            }
        },
        tooltip: {
            formatter: function () {
                return eval(PoPuntos.tooltipFormater);
            }
        },
        credits: false,
        legend: {
            reversed: true,
            enabled: true,
            margin: 2,
            itemMarginTop: 1,
            itemMarginBottom: 1,
            width: 500,
            itemWidth: 250,
            itemStyle: {
                width: 230
            }
        },
        plotOptions: {
            series: {
                stacking: 'percent',
                dataLabels: {
                    enabled: true,
                    formatter: function () {
                        var LsEtiqueta = '<span style="font-family:\'Open Sans\'; font-size:11px; font-weight:normal; color:#FFFFFF; text-shadow: 1px 1px 2px rgba(0, 0, 0, 0.3); text-rendering:geometricPrecision;">';
                        if (this.percentage == 0) {
                            LsEtiqueta += '0';
                        }
                        else {
                            if (this.percentage == 100) {
                                LsEtiqueta += '100';
                            }
                            else {
                                LsEtiqueta += redondeaN(this.percentage, 1);
                            }
                        }
                        LsEtiqueta += '%</span> '
                        return LsEtiqueta;
                    },

                },
            }
        },
        series: PoPuntos.series,
    })
}


function pintarMapaMexico(PoDiv, PoPuntos) {

    //var dataMap = [
    //    {
    //        "hc_key": "mx-3622",
    //        "value": 0
    //    },
    //    {
    //        "hc_key": "mx-bc",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-bs",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-so",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-cl",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-na",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-cm",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-qr",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-mx",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-mo",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-df",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-qt",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-tb",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-cs",
    //        "value": 98,
    //        "color": '#FFC000'
    //    },
    //    {
    //        "hc_key": "mx-nl",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-si",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-ch",
    //        "value": 98,
    //        "color": '#FFC000'
    //    },
    //    {
    //        "hc_key": "mx-ve",
    //        "value": 99,
    //        "color": '#FED966'
    //    },
    //    {
    //        "hc_key": "mx-za",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-ag",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-ja",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-mi",
    //        "value": 99,
    //        "color": '#FED966'
    //    },
    //    {
    //        "hc_key": "mx-oa",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-pu",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-gr",
    //        "value": 99,
    //        "color": '#FED966'
    //    },
    //    {
    //        "hc_key": "mx-tl",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-gj",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-tm",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-co",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-dg",
    //        "value": 86,
    //        "color": ' 	#EE8943'
    //    },
    //    {
    //        "hc_key": "mx-yu",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-sl",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-hg",
    //        "value": 99,
    //        "color": '#FED966'
    //    }
    //];
    var dataPoint = [
        {
        }
    ]

    var data = $(PoDiv).highcharts('Map', {

        title: {
            text: ''
        },

        subtitle: {
            text: ''
        },

        legend: {

            enabled: false,  //cuadro de los colores
            //borderRadius: 5,
            //borderWidth: 1
            symbolRadius: 64,
            symbolHeight: 15
        },

        colorAxis: {
            min: 50,
            max: 100,
            minColor: '#DEEAF6',
            maxColor: '#DEEAF6',
            stops: [
                [0, '#DEEAF6'],
                [86, '#e98a46'],
                [98, '#ffc000'],
                [99, '#fed966'],
                [100, '#009899']
            ]
        },

        tooltip: {
            pointFormat: '{point.name}: <b>{point.value:.1f}%</b>',
          //  valueSuffix: ' %'
        },
            
        //mapNavigation: {
        //    enabled: true,
        //    buttonOptions: {
        //        verticalAlign: 'bottom'                // botom de zoom
        //    }
        //},

        series: [{
            data: PoPuntos.series[0].data,
            enabled: false,
            mapData: Highcharts.maps['countries/mx/mx-all'],
            joinBy: 'hc_key',
            name: PoPuntos.series[0].name,
            states: {
                hover: {
                    color: '#757575'
                }
            },
            dataLabels: {
                enabled: false,
                format: '{point.name}'
            }
        },
        //{
        //    type: 'mappoint',
        //    name: 'Points',
        //    data: dataPoint,
        //    dataLabels: {
        //        enabled: false,
        //        format: '{point.name}'
        //    }
        //}
        ],
        credits: false,
    });

}


function pintarMapaMexicoletalidad(PoDiv, PoPuntos) {

    var dataPoint = [
        {
        }
    ]

    var data = $(PoDiv).highcharts('Map', {

        title: {
            text: ''
        },

        subtitle: {
            text: ''
        },

        legend: {

            enabled: false,  //cuadro de los colores
            //borderRadius: 5,
            //borderWidth: 1
            symbolRadius: 64,
            symbolHeight: 15
        },

        colorAxis: {
            min: 50,
            max: 100,
            minColor: '#DEEAF6',
            maxColor: '#DEEAF6',
            stops: [
                [0, '#DEEAF6'],
                [86, '#e98a46'],
                [98, '#ffc000'],
                [99, '#fed966'],
                [100, '#009899']
            ]
        },

        tooltip: {
            pointFormat: '{point.name}: <b>{point.value:.2f}%</b>',
            //  valueSuffix: ' %'
        },

        //mapNavigation: {
        //    enabled: true,
        //    buttonOptions: {
        //        verticalAlign: 'bottom'                // botom de zoom
        //    }
        //},

        series: [{
            data: PoPuntos.series[0].data,
            enabled: false,
            mapData: Highcharts.maps['countries/mx/mx-all'],
            joinBy: 'hc_key',
            name: PoPuntos.series[0].name,
            states: {
                hover: {
                    color: '#757575'
                }
            },
            dataLabels: {
                enabled: false,
                format: '{point.name}'
            }
        },
        //{
        //    type: 'mappoint',
        //    name: 'Points',
        //    data: dataPoint,
        //    dataLabels: {
        //        enabled: false,
        //        format: '{point.name}'
        //    }
        //}
        ],
        credits: false,
    });

}

function pintarMapaMexico2Series(PoDiv, PoPuntos) {

    //var dataMap = [
    //    {
    //        "hc_key": "mx-3622",
    //        "value": 0
    //    },
    //    {
    //        "hc_key": "mx-bc",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-bs",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-so",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-cl",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-na",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-cm",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-qr",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-mx",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-mo",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-df",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-qt",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-tb",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-cs",
    //        "value": 98,
    //        "color": '#FFC000'
    //    },
    //    {
    //        "hc_key": "mx-nl",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-si",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-ch",
    //        "value": 98,
    //        "color": '#FFC000'
    //    },
    //    {
    //        "hc_key": "mx-ve",
    //        "value": 99,
    //        "color": '#FED966'
    //    },
    //    {
    //        "hc_key": "mx-za",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-ag",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-ja",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-mi",
    //        "value": 99,
    //        "color": '#FED966'
    //    },
    //    {
    //        "hc_key": "mx-oa",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-pu",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-gr",
    //        "value": 99,
    //        "color": '#FED966'
    //    },
    //    {
    //        "hc_key": "mx-tl",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-gj",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-tm",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-co",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-dg",
    //        "value": 86,
    //        "color": ' 	#EE8943'
    //    },
    //    {
    //        "hc_key": "mx-yu",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-sl",
    //        "value": 100,
    //        "color": '#029899'
    //    },
    //    {
    //        "hc_key": "mx-hg",
    //        "value": 99,
    //        "color": '#FED966'
    //    }
    //];
    var dataPoint = [
        {
        }
    ]

    var data = $(PoDiv).highcharts('Map', {

        title: {
            text: ''
        },

        subtitle: {
            text: ''
        },

        legend: {

            enabled: false,  //cuadro de los colores
            //borderRadius: 5,
            //borderWidth: 1
            symbolRadius: 64,
            symbolHeight: 15
        },

        colorAxis: {
            min: 50,
            max: 100,
            minColor: '#DEEAF6',
            maxColor: '#DEEAF6',
            stops: [
                [0, '#DEEAF6'],
                [86, '#e98a46'],
                [98, '#ffc000'],
                [99, '#fed966'],
                [100, '#009899']
            ]
        },

        tooltip: {
            pointFormat: '{point.name}: <b>{point.value:.2f}%</b>',
            //  valueSuffix: ' %'
        },

        //mapNavigation: {
        //    enabled: true,
        //    buttonOptions: {
        //        verticalAlign: 'bottom'                // botom de zoom
        //    }
        //},

        series: [{
            data: PoPuntos.series[0].data,
            enabled: false,
            mapData: Highcharts.maps['countries/mx/mx-all'],
            joinBy: 'hc_key',
            name: PoPuntos.series[0].name,
            states: {
                hover: {
                    color: '#757575'
                }
            },
            dataLabels: {
                enabled: false,
                format: '{point.name}'
            }
        },// Serie 2
        {
            data: PoPuntos.series[1].data,
            enabled: false,
            mapData: Highcharts.maps['countries/mx/mx-all'],
            joinBy: 'hc_key',
            name: PoPuntos.series[1].name,
            states: {
                hover: {
                    color: '#757575'
                }
            },
            dataLabels: {
                enabled: false,
                format: '{point.name}'
            }

        }
        //{
        //    type: 'mappoint',
        //    name: 'Points',
        //    data: dataPoint,
        //    dataLabels: {
        //        enabled: false,
        //        format: '{point.name}'
        //    }
        //}
        ],
        credits: false,
    });

}