using System;
using System.Collections.Generic;
using System.Web.Services;
using System.Data;


public partial class DirApp_SIVEMMS_Cesarias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    [WebMethod]
    public static List<entElementoCombo> wmCboInstitucion()
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        List<entElementoCombo> LaoValores = new List<entElementoCombo>();

        LaoValores = LoSivemms.obtenerCboInstitucion();
        return LaoValores;
    }

    [WebMethod]
    public static List<entElementoCombo> wmCboEntidad()
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        List<entElementoCombo> LaoValores = new List<entElementoCombo>();

        LaoValores = LoSivemms.obtenerCboEntidad();
        return LaoValores;
    }


    [WebMethod]
    public static List<entElementoCombo> wmCboJurisdiccion(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        List<entElementoCombo> LaoValores = new List<entElementoCombo>();

        LaoValores = LoSivemms.obtenerCboJurisdiccion(PoFiltros.cveInstitucion,PoFiltros.cveEntidad);
        return LaoValores;
    }

    [WebMethod]
    public static List<entElementoCombo> wmCboMunicipio(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        List<entElementoCombo> LaoValores = new List<entElementoCombo>();

        LaoValores = LoSivemms.obtenerCboMunicipio(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion);
        return LaoValores;
    }

    [WebMethod]
    public static List<entElementoCombo> wmCboUS(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        List<entElementoCombo> LaoValores = new List<entElementoCombo>();

        LaoValores = LoSivemms.obtenerCboUS(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio);
        return LaoValores;
    }

    //<%--C̸e̸s̸á̸r̸e̸a̸s̸--%>
    [WebMethod]
    public static entGraficas wmCesarias(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoGrafica = new entGraficas();

        LoGrafica = LoSivemms.obtenerCesareas(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio, PoFiltros.clues);
        return LoGrafica;
    }
    //<%--C̸e̸s̸á̸r̸e̸a̸s̸--%>


    //𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Cesarias

    [WebMethod]
    public static entGraficas wmCesariasGrupodeedad(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoGrafica = new entGraficas();

        LoGrafica = LoSivemms.obtenerCesareasGrupodeEdad(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio, PoFiltros.clues);
        return LoGrafica;
    }

    //𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Cesarias


    //<%--ℙ𝕣𝕖𝕟𝕒𝕥𝕒𝕝--%>
    [WebMethod]
    public static entGraficas wmPrenatal(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoGrafica = new entGraficas();

        LoGrafica = LoSivemms.obtenerControlprenatal(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio, PoFiltros.clues);
        return LoGrafica;
    }
    //<%--ℙ𝕣𝕖𝕟𝕒𝕥𝕒𝕝--%>


    //𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Controlprenatal

    [WebMethod]
    public static entGraficas wmControlprenatalGrupodeedad(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoGrafica = new entGraficas();

        LoGrafica = LoSivemms.obtenerControlprenatalGrupodeEdad(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio, PoFiltros.clues);
        return LoGrafica;
    }

    //𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Controlprenatal

    //T̴r̴a̴n̴s̴f̴u̴s̴i̴o̴n̴
    [WebMethod]
    public static entGraficas wmTransfusion(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoGrafica = new entGraficas();

        LoGrafica = LoSivemms.obtenerTransfusion(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio, PoFiltros.clues, PoFiltros.parametros);
        return LoGrafica;
    }
    //T̴r̴a̴n̴s̴f̴u̴s̴i̴o̴n̴

    //C̶a̶u̶s̶a̶s̶T̶r̶a̶n̶s̶f̶u̶s̶i̶o̶n̶
    [WebMethod]
    public static entGraficas wmCausasTransfusion(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoPuntos = new entGraficas();

        LoPuntos = LoSivemms.obtenerCausasTransfusion(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio);

        return LoPuntos;
    }
    //C̶a̶u̶s̶a̶s̶T̶r̶a̶n̶s̶f̶u̶s̶i̶o̶n̶


    //A͟c͟t͟u͟a͟l͟i͟z͟a͟c͟i͟ó͟n͟ ͟d͟i͟a͟r͟i͟a͟>

    [WebMethod]
    public static List<string> wmFecha(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        List<string> LnsDatos = new List<string>();

        LnsDatos = LoSivemms.obtenerfecha(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio);
        return LnsDatos;
    }
    //A͟c͟t͟u͟a͟l͟i͟z͟a͟c͟i͟ó͟n͟ ͟d͟i͟a͟r͟i͟a͟>

}