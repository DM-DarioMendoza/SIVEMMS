using System;
using System.Data;
using System.Web.Services;
using System.Collections.Generic;



public partial class DirApp_SIVEMMS_Principal : System.Web.UI.Page
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


    //<%--m͟a͟p͟i͟t͟a͟--%>
    [WebMethod]
    public static entMapas wmmapita(entFiltros PoFiltros)
    {
        bsnIntroSIVEMMS LoSivemms = new bsnIntroSIVEMMS();
        entMapas LoGrafica = new entMapas();

        LoGrafica = LoSivemms.obtenerInfoMapa(PoFiltros.cveInstitucion, PoFiltros.cveEntidad);
        return LoGrafica;
    }

    //<%--m͟a͟p͟i͟t͟a͟--%>



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