using System;
using System.Collections.Generic;
using System.Web.Services;
using System.Data;


public partial class DirApp_SIVEMMS_EstatusDelFeto : System.Web.UI.Page
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


    //<%-- 𝘌𝘴𝘵𝘢𝘵𝘶𝘴 𝘥𝘦𝘭 𝘧𝘦𝘵𝘰 𝘺 𝘦𝘭 𝘳𝘦𝘤𝘪é𝘯 𝘯𝘢𝘤𝘪𝘥𝘰 --%>

    [WebMethod]
    public static entGraficas wmFeto(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoPuntos = new entGraficas();

        LoPuntos = LoSivemms.obtenerEstatusdelProducto(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio);

        return LoPuntos;
    }
    //<%-- 𝘌𝘴𝘵𝘢𝘵𝘶𝘴 𝘥𝘦𝘭 𝘧𝘦𝘵𝘰 𝘺 𝘦𝘭 𝘳𝘦𝘤𝘪é𝘯 𝘯𝘢𝘤𝘪𝘥𝘰 --%>




}