using System;
using System.Collections.Generic;
using System.Web.Services;
using System.Data;


public partial class DirApp_SIVEMMS_IndiceDeEvaluacion : System.Web.UI.Page
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

    //<%--a͟t͟e͟n͟c͟i͟ó͟n͟ ͟p͟r͟e͟n͟a͟t͟a͟l͟--%>
    [WebMethod]
    public static entGraficas wmAtnprenatal(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entGraficas LoGrafica = new entGraficas();

        LoGrafica = LoSivemms.obtenerIndGravedad();
    //    LoGrafica = LoSivemms.obtenerIndGravedad(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio, PoFiltros.clues);

        return LoGrafica;
    }

    //<%--a͟t͟e͟n͟c͟i͟ó͟n͟ ͟p͟r͟e͟n͟a͟t͟a͟l͟--%>


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