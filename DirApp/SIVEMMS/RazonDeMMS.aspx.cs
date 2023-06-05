using System;
using System.Collections.Generic;
using System.Web.Services;
using System.Data;


public partial class DirApp_SIVEMMS_RazonDeMMS : System.Web.UI.Page
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



    //<%-- R͟a͟z͟ó͟n͟ ͟d͟e͟ ͟M͟o͟r͟b͟i͟l͟i͟d͟a͟d͟ ͟M͟a͟t͟e͟r͟n͟a͟ ͟S͟e͟v͟e͟r͟a͟ --%>
    [WebMethod]
    public static entGraficas wmRazonMMS(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoGrafica = new entGraficas();

        LoGrafica = LoSivemms.obtenerMMSEntidad(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio, PoFiltros.clues);
        return LoGrafica;
    }
    //<%-- R͟a͟z͟ó͟n͟ ͟d͟e͟ ͟M͟o͟r͟b͟i͟l͟i͟d͟a͟d͟ ͟M͟a͟t͟e͟r͟n͟a͟ ͟S͟e͟v͟e͟r͟a͟ --%>

    //  <%--𝘊𝘢𝘴𝘰𝘴 𝘱𝘰𝘳 𝘨𝘳𝘶𝘱𝘰 𝘥𝘦 𝘦𝘥𝘢𝘥--%>
    [WebMethod]
    public static entGraficas wmGrupodeedad(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoGrafica = new entGraficas();

        LoGrafica = LoSivemms.obtenerGrupodeedad(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio, PoFiltros.clues);
        return LoGrafica;
    }

    //  <%--𝘊𝘢𝘴𝘰𝘴 𝘱𝘰𝘳 𝘨𝘳𝘶𝘱𝘰 𝘥𝘦 𝘦𝘥𝘢𝘥--%>

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