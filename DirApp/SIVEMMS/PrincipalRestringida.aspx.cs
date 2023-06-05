using System;
using System.Data;
using System.Web.Services;
using System.Collections.Generic;

public partial class DirApp_SIVEMMS_PrincipalRestringida : System.Web.UI.Page
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

    //<%--MapaOnOff--%>
    [WebMethod]
    public static entMapas wmMapaOnOff(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entMapas LoGrafica = new entMapas();

        LoGrafica = LoSivemms.obtenerInfoMapaOnOff(PoFiltros.cveInstitucion, PoFiltros.cveEntidad);
        return LoGrafica;
    }

    //<%--MapaOnOff--%>

    //o͟d͟o͟m͟e͟t͟r͟o͟
    [WebMethod]
    public static List<string> wmodometro(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        List<string> LnsDatos = new List<string>();

        LnsDatos = LoSivemms.obtenerOdometro(PoFiltros.cveInstitucion, PoFiltros.cveEntidad, PoFiltros.cveJurisdiccion, PoFiltros.cveMunicipio);
        return LnsDatos;
    }
    //o͟d͟o͟m͟e͟t͟r͟o͟
}