using System;
using System.Collections.Generic;
using System.Web.Services;
using System.Data;


public partial class DirApp_SIVEMMS_EmbarazosSinMorbilidad : System.Web.UI.Page
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

    //<%-- 𝔖𝔱𝔶𝔩𝔦𝔫𝔤 𝔞𝔵𝔢𝔰 𝔞𝔫𝔡 𝔠𝔬𝔩𝔲𝔪𝔫𝔰--%>
    [WebMethod]
    public static entGraficas wmStylingaxesandcolumns(entFiltros PoFiltros)
    {
        entGraficas LoGrafica = new entGraficas();
        return LoGrafica;
    }

    //<%-- 𝔖𝔱𝔶𝔩𝔦𝔫𝔤 𝔞𝔵𝔢𝔰 𝔞𝔫𝔡 𝔠𝔬𝔩𝔲𝔪𝔫𝔰--%>


    //<%--    𝑬𝒇𝒇𝒊𝒄𝒊𝒆𝒏𝒄𝒚𝑶𝒑𝒕𝒊𝒎𝒊𝒛𝒂𝒕𝒊𝒐𝒏 --%>

    [WebMethod]
    public static entGraficas wmEfficiencyOptimization(entFiltros PoFiltros)
    {
        entGraficas LoGrafica = new entGraficas();
        return LoGrafica;
    }
    //<%--    𝑬𝒇𝒇𝒊𝒄𝒊𝒆𝒏𝒄𝒚𝑶𝒑𝒕𝒊𝒎𝒊𝒛𝒂𝒕𝒊𝒐𝒏 --%>


}