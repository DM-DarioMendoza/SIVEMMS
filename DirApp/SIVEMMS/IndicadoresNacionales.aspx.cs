using System;
using System.Collections.Generic;
using System.Web.Services;
using System.Data;


public partial class DirApp_SIVEMMS_IndicadoresNacionales : System.Web.UI.Page
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

    //<%--   ͢E͢m͢b͢a͢r͢a͢z͢o͢s͢ ͢S͢i͢n͢ ͢M͢o͢r͢b͢i͢l͢i͢d͢a͢d͢ ͢M͢a͢t͢e͢r͢n͢a͢ ͢ --%>
    [WebMethod]
    public static entGraficas wmSinMMS(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoGrafica = new entGraficas();

        LoGrafica = LoSivemms.obtenerSinMMSEntidad(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio, PoFiltros.clues);
        return LoGrafica;
    }


    //<%--   ͢E͢m͢b͢a͢r͢a͢z͢o͢s͢ ͢S͢i͢n͢ ͢M͢o͢r͢b͢i͢l͢i͢d͢a͢d͢ ͢M͢a͢t͢e͢r͢n͢a͢ ͢ --%>


    //𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 

    [WebMethod]
    public static entGraficas wmSinMMSGrupodeedad(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoGrafica = new entGraficas();

        LoGrafica = LoSivemms.obtenerSinMMSGrupodeedad(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio, PoFiltros.clues);
        return LoGrafica;
    }

    //𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 


    //<%-- Tasa de sobrevida en mujeres --%>

    [WebMethod]
    public static entGraficas wmTasaSobrevida(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoGrafica = new entGraficas();

        LoGrafica = LoSivemms.obtenerTasaSobrevidaMMS(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio, PoFiltros.clues);
        return LoGrafica;
    }
    //<%-- Tasa de sobrevida en mujeres --%>

    // 𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 TasaSobrevidaMMS 

    [WebMethod]
    public static entGraficas wmTasaSobrevidaMMSEdad(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoGrafica = new entGraficas();

        LoGrafica = LoSivemms.obtenerTasaSobrevidaMMSEdad(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio, PoFiltros.clues);
        return LoGrafica;
    }

    // 𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 TasaSobrevidaMMS 


    //d̳v̳C̳a̳u̳s̳a̳s̳m̳o̳r̳b̳i̳l̳i̳d̳a̳d̳
    [WebMethod]
    public static entGraficas wmCausasmorbilidad(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoPuntos = new entGraficas();

        LoPuntos = LoSivemms.obtenerCausasmorbilidad(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio);
        return LoPuntos;
    }
    //d̳v̳C̳a̳u̳s̳a̳s̳m̳o̳r̳b̳i̳l̳i̳d̳a̳d̳

    // 𝘌𝘴𝘵𝘢𝘵𝘶𝘴 𝘥𝘦𝘭 𝘧𝘦𝘵𝘰 𝘺 𝘦𝘭 𝘳𝘦𝘤𝘪é𝘯 𝘯𝘢𝘤𝘪𝘥𝘰 

    [WebMethod]
    public static entGraficas wmFeto(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoPuntos = new entGraficas();

        LoPuntos = LoSivemms.obtenerEstatusdelProducto(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio);

        return LoPuntos;
    }

    // 𝘌𝘴𝘵𝘢𝘵𝘶𝘴 𝘥𝘦𝘭 𝘧𝘦𝘵𝘰 𝘺 𝘦𝘭 𝘳𝘦𝘤𝘪é𝘯 𝘯𝘢𝘤𝘪𝘥𝘰 

    //𝑮𝒓𝒂𝒇𝒊𝒄𝒂 𝒑𝒐𝒓 𝒓𝒂𝒏𝒈𝒐 𝒅𝒆 𝒆𝒅𝒂𝒅 𝑬𝒔𝒕𝒂𝒕𝒖𝒔 𝒅𝒆𝒍 𝑷𝒓𝒐𝒅𝒖𝒄𝒕𝒐 𝑬𝒅𝒂𝒅 

    [WebMethod]
    public static entGraficas wmEstatusdelProductoEdad(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoPuntos = new entGraficas();

        LoPuntos = LoSivemms.obtenerEstatusdelProductoEdad(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio, PoFiltros.clues);
        return LoPuntos;
    }

    //𝑮𝒓𝒂𝒇𝒊𝒄𝒂 𝒑𝒐𝒓 𝒓𝒂𝒏𝒈𝒐 𝒅𝒆 𝒆𝒅𝒂𝒅 𝑬𝒔𝒕𝒂𝒕𝒖𝒔 𝒅𝒆𝒍 𝑷𝒓𝒐𝒅𝒖𝒄𝒕𝒐 𝑬𝒅𝒂𝒅 

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