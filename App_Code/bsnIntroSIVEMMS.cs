using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Descripción breve de bsnIntroSIVEMMS
/// </summary>
public class bsnIntroSIVEMMS
{
    public bsnIntroSIVEMMS()
    {
    }
    #region "Propiedades"
    //Cadena de Conexión
    SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString);
    #endregion

    public List<entElementoCombo> obtenerCboInstitucion()
    {
        List<entElementoCombo> LaoValores = new List<entElementoCombo>();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.CommandText = "spObtenerInstitucion";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();

            if (LdtIntro != null)
            {
                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entElementoCombo LoValor = new entElementoCombo();
                    LoValor.clave = dr["clave"].ToString();
                    LoValor.descripcion = dr["descripcion"].ToString();

                    LaoValores.Add(LoValor);
                }
            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LaoValores;
    }

    public List<entElementoCombo> obtenerCboEntidad()
    {
        List<entElementoCombo> LaoValores = new List<entElementoCombo>();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.CommandText = "spObtenerEntidad";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();

            if (LdtIntro != null)
            {
                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entElementoCombo LoValor = new entElementoCombo();
                    LoValor.clave = dr["clave"].ToString();
                    LoValor.descripcion = dr["descripcion"].ToString();

                    LaoValores.Add(LoValor);
                }
            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LaoValores;
    }

    public List<entElementoCombo> obtenerCboJurisdiccion(string PnCveInstitucion, string PnCveEntidad )
    {
        List<entElementoCombo> LaoValores = new List<entElementoCombo>();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.CommandText = "spObtenerJurisdiccion";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();

            if (LdtIntro != null)
            {
                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entElementoCombo LoValor = new entElementoCombo();
                    LoValor.clave = dr["clave"].ToString();
                    LoValor.descripcion = dr["descripcion"].ToString();
                    LaoValores.Add(LoValor);
                }
            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LaoValores;
    }

    public List<entElementoCombo> obtenerCboMunicipio(string PnCveInstitucion, string PnCveEntidad, string PnCveJurisdiccion )
    {
        List<entElementoCombo> LaoValores = new List<entElementoCombo>();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJurisdiccion);
            sqlCmd.CommandText = "spObtenerMunicipio";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();

            if (LdtIntro != null)
            {
                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entElementoCombo LoValor = new entElementoCombo();
                    LoValor.clave = dr["clave"].ToString();
                    LoValor.descripcion = dr["descripcion"].ToString();
                    LaoValores.Add(LoValor);
                }
            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LaoValores;
    }
    public List<entElementoCombo> obtenerCboUS(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio) 
    {
        List<entElementoCombo> LaoValores = new List<entElementoCombo>();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.CommandText = "spObtenerUS";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();

            if (LdtIntro != null)
            {
                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entElementoCombo LoValor = new entElementoCombo();
                    LoValor.clave = dr["clave"].ToString(); // Convert.ToInt16(dr["clave"].ToString());
                    LoValor.descripcion = dr["descripcion"].ToString();
                    LaoValores.Add(LoValor);
                }
            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LaoValores;
    }

    //A͟c͟t͟u͟a͟l͟i͟z͟a͟c͟i͟ó͟n͟ ͟d͟i͟a͟r͟i͟a͟>
    public List<string> obtenerfecha(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio)
    {
        List<string> LaoValores = new List<string>();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.CommandText = "spObtenerfecha";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();

            if (LdtIntro != null)
            {

               LaoValores.Add(LdtIntro.Rows[0]["fechaProc"].ToString());
               LaoValores.Add(LdtIntro.Rows[0]["observaciones"].ToString());


            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LaoValores;
    }
    //A͟c͟t͟u͟a͟l͟i͟z͟a͟c͟i͟ó͟n͟ ͟d͟i͟a͟r͟i͟a͟>

    //<--m͟a͟p͟i͟t͟a͟-->
    public entMapas obtenerInfoMapa(string PnCveInstitucion, string PnCveEntidad)
    {
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();
        entMapas LoGraficas = new entMapas();

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.CommandText = "spObtenerInfoMapa";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();

            //

            if (LdtIntro.Rows.Count > 0)
            {

                List<entSerieMapa> LaoSeries = new List<entSerieMapa>();
                entSerieMapa LoSerie = new entSerieMapa();
                LoSerie.name = "Vidas salvadas";
                LoSerie.data = new List<entPuntoMapa>();
                LaoSeries.Add(LoSerie);

                foreach (DataRow dr in LdtIntro.Rows)
                {

                    entPuntoMapa LoPunto = new entPuntoMapa();
                    LoPunto.hc_key = dr["hc-key"].ToString();  // Valor en 100%
                    LoPunto.value = Convert.ToDouble(dr["value"].ToString());
                    LoPunto.color = dr["color"].ToString();
                    LaoSeries[0].data.Add(LoPunto);
                }
                LoGraficas.series = LaoSeries;
             
            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }

    //<--m͟a͟p͟i͟t͟a͟-->

    //<--MapaOnOff-->
    public entMapas obtenerInfoMapaOnOff(string PnCveInstitucion, string PnCveEntidad)
    {
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();
        entMapas LoGraficas = new entMapas();

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.CommandText = "spObtenerInfoMapaOnOff";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();

            //

            if (LdtIntro.Rows.Count > 0)
            {

                List<entSerieMapa> LaoSeries = new List<entSerieMapa>();

                entSerieMapa LoSerie = new entSerieMapa();
                LoSerie.name = "Letalidad";
                LoSerie.data = new List<entPuntoMapa>();
                LaoSeries.Add(LoSerie);

                // Serie 2 Morbilidad
                entSerieMapa LoSerie1 = new entSerieMapa();
                LoSerie1.name = "Morbilidad";
                LoSerie1.data = new List<entPuntoMapa>();
                LaoSeries.Add(LoSerie1);

                foreach (DataRow dr in LdtIntro.Rows)
                {

                    entPuntoMapa LoPunto = new entPuntoMapa();
                    LoPunto.hc_key = dr["hc-key"].ToString();  // Valor en 100%
                    LoPunto.value = Convert.ToDouble(dr["value"].ToString());
                    LoPunto.color = dr["color"].ToString();
                    LaoSeries[0].data.Add(LoPunto);

                    // Serie 2 Morbilidad
                    entPuntoMapa LoPunto2 = new entPuntoMapa();
                    LoPunto2.hc_key = dr["hc-key"].ToString();
                    LoPunto2.value = Convert.ToDouble(dr["Morbilidad"].ToString());
                    LoPunto2.color = dr["color2"].ToString();
                    LaoSeries[1].data.Add(LoPunto2);
                }
                LoGraficas.series = LaoSeries;

            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }
    
    //<--MapaOnOff-->


    //<--  o͟d͟o͟m͟e͟t͟r͟o͟-->
    public List<string> obtenerOdometro(string PnCveInstitucion, string PnCveEntidad, string @PnCveJurisdiccion, string PnCveMunicipio)
    {
        List<string> LaoValores = new List<string>();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();
        entGraficas LoGraficas = new entGraficas();
        
        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", @PnCveJurisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.CommandText = "spObtenerOdometro";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();

            if (LdtIntro != null)
            {

                LaoValores.Add(LdtIntro.Rows[0]["odometro"].ToString());
                LaoValores.Add(LdtIntro.Rows[0]["TotalInstitucion"].ToString());
                LaoValores.Add(LdtIntro.Rows[0]["TotalEntidad"].ToString());
                LaoValores.Add(LdtIntro.Rows[0]["TotalJurisdiccion"].ToString());
                LaoValores.Add(LdtIntro.Rows[0]["TotalMunicipio"].ToString());
                LaoValores.Add(LdtIntro.Rows[0]["Totalclues"].ToString());
                LaoValores.Add(LdtIntro.Rows[0]["VidasSalvadas"].ToString());

            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LaoValores;
    }

    //<--  o͟d͟o͟m͟e͟t͟r͟o͟-->



    //d̳v̳C̳a̳u̳s̳a̳s̳m̳o̳r̳b̳i̳l̳i̳d̳a̳d̳
    public entGraficas obtenerCausasmorbilidad(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio)
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();
        double TotalCasosSMM, EnfermedadHipertensiva , EnfermedadHipertensivaTotal, HemorragiaObstetrica, HemorragiaObstetricatotal, EmbarazoAdolescente, EmbarazoAdolescentetotal;

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.CommandText = "spObtenerCausasMorbilidad";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();

            if (LdtIntro != null)
            {
                LoGraficas.titulo = "";
                List<entSerie> LaoSeries = new List<entSerie>();

                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "mediciones";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);

                List<entCategoria> LasCategorias = new List<entCategoria>();

                TotalCasosSMM = Convert.ToDouble(LdtIntro.Rows[0]["TotalCasosSMM"].ToString());
                EnfermedadHipertensiva = Convert.ToDouble(LdtIntro.Rows[0]["Y"].ToString());
                HemorragiaObstetrica = Convert.ToDouble(LdtIntro.Rows[1]["Y"].ToString());
                EmbarazoAdolescente = Convert.ToDouble(LdtIntro.Rows[2]["Y"].ToString());
                EnfermedadHipertensivaTotal = Convert.ToDouble(LdtIntro.Rows[0]["valorY"].ToString());
                HemorragiaObstetricatotal = Convert.ToDouble(LdtIntro.Rows[1]["valorY"].ToString());
                EmbarazoAdolescentetotal = Convert.ToDouble(LdtIntro.Rows[2]["valorY"].ToString());

                LoGraficas.valores.Add(TotalCasosSMM.ToString("###,##0")); // Posición 0
                LoGraficas.valores.Add(EnfermedadHipertensiva.ToString("(##0.0") + "%)"); // Posición 1
                LoGraficas.valores.Add(HemorragiaObstetrica.ToString("(##0.0") + "%)"); // Posición 2
                LoGraficas.valores.Add(EmbarazoAdolescente.ToString("(##0.0") + "%)"); // Posición 3
                LoGraficas.valores.Add(EnfermedadHipertensivaTotal.ToString("###,##0")); // Posición 4
                LoGraficas.valores.Add(HemorragiaObstetricatotal.ToString("###,##0")); // Posición 5
                LoGraficas.valores.Add(EmbarazoAdolescentetotal.ToString("###,##0")); // Posición 6


                LoGraficas.valores.Add(LdtIntro.Rows[0]["mediciones"].ToString());


                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.y = Convert.ToDouble(dr["y"].ToString());
                    LoPunto.valorY = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.color = dr["color"].ToString();
                    LaoSeries[0].data.Add(LoPunto);
                }
                LoGraficas.tooltipFormater = "this.x + ': ' + numberWithCommas(PoPuntos.series[0].data[this.point.index].valorY);";
                LoGraficas.series = LaoSeries;
                LoGraficas.categorias = LasCategorias;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }
    //d̳v̳C̳a̳u̳s̳a̳s̳m̳o̳r̳b̳i̳l̳i̳d̳a̳d̳


    //𝘌𝘴𝘵𝘢𝘵𝘶𝘴 𝘥𝘦𝘭 𝘧𝘦𝘵𝘰 𝘺 𝘦𝘭 𝘳𝘦𝘤𝘪é𝘯 𝘯𝘢𝘤𝘪𝘥𝘰 
    public entGraficas obtenerEstatusdelProducto(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio)
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();
        double LnVivos, LnVivosPorc, LnMuertos, LnMuertosPorc, LnNosabe , LnNosabePorc, LnTotal2, total;

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.CommandText = "spObtenerEstatusdelProducto";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();

            if (LdtIntro != null)
            {
                LoGraficas.titulo = "";
                LoGraficas.colorFondo = "#F5F5F5";

                List<entSerie> LaoSeries = new List<entSerie>();

                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "mediciones";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);
                double LnTotal = 0;

                List<entCategoria> LasCategorias = new List<entCategoria>();

                LnVivos = Convert.ToDouble(LdtIntro.Rows[0]["y"].ToString());
                LnVivosPorc = Convert.ToDouble(LdtIntro.Rows[0]["Porc"].ToString());
                LnMuertos = Convert.ToDouble(LdtIntro.Rows[1]["y"].ToString());
                LnMuertosPorc = Convert.ToDouble(LdtIntro.Rows[1]["Porc"].ToString());
                LnNosabe = Convert.ToDouble(LdtIntro.Rows[2]["y"].ToString());
                LnNosabePorc = Convert.ToDouble(LdtIntro.Rows[2]["Porc"].ToString());

                total = Convert.ToDouble(LdtIntro.Rows[0]["total"].ToString());


                LoGraficas.valores.Add(total.ToString("###,##0")); // lblNacsuma [0]
                LoGraficas.valores.Add(LnVivos.ToString("###,##0")); // lblNacVivo [1]
                LoGraficas.valores.Add(LnVivosPorc.ToString("(##0.0") + "%)"); //lblNacVivoPorc [2]
                LoGraficas.valores.Add(LnMuertos.ToString("###,##0")); //lblNacMuerto [3]
                LoGraficas.valores.Add(LnMuertosPorc.ToString("(##0.0") + "%)"); //lblNacVivoPorc [4]
                LoGraficas.valores.Add(LnNosabe.ToString("###,##0")); // lblNonace [5]
                LoGraficas.valores.Add(LnNosabePorc.ToString("(##0.0") + "%)"); //lblNonacePorc [6]

                //LnTotal2 = (LnVivos + LnMuertos + LnNosabe);

                //l͟b͟l͟N͟a͟c͟V͟i͟v͟o͟
                //if (LnVivos == 0)
                //{
                //    LoGraficas.valores.Add(LnVivos.ToString("###,##0") + " (0%)");
                //}
                //else
                //{
                //  LoGraficas.valores.Add(LnVivos.ToString("###,##0") + " (" + (LnVivos / LnTotal2 * 100).ToString("##0.0") + "%)");
                //}

                //l͟b͟l͟N͟a͟c͟V͟i͟v͟o͟

                //l͟b͟l͟N͟a͟c͟M͟u͟e͟r͟t͟o͟
                //if (LnMuertos == 0)
                //{
                //    LoGraficas.valores.Add(LnMuertos.ToString("###,##0") + " (0%)");
                //}
                //else
                //{
                //    LoGraficas.valores.Add(LnMuertos.ToString("###,##0") + " (" + (LnMuertos / LnTotal2 * 100).ToString("##0.0") + "%)");
                //}
                //l͟b͟l͟N͟a͟c͟M͟u͟e͟r͟t͟o͟

                //l͟b͟l͟N͟o͟n͟a͟c͟e͟
                //if (LnNosabe == 0)
                //{
                //    LoGraficas.valores.Add(LnNosabe.ToString("###,##0") + " (0%)");
                //}
                //else
                //{
                //    LoGraficas.valores.Add(LnNosabe.ToString("###,##0") + " (" + (LnNosabe / LnTotal2 * 100).ToString("##0.0") + "%)");
                //}
                //l͟b͟l͟N͟o͟n͟a͟c͟e͟




                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.y = Convert.ToDouble(dr["y"].ToString());
                    LnTotal += LoPunto.y;
                    LoPunto.name = dr["etiquetaX"].ToString();
                    LoPunto.color = dr["color"].ToString();
                    LaoSeries[0].data.Add(LoPunto);
                }
                LoGraficas.tooltipFormater = "this.key + ': ' + numberWithCommas(this.y) + ' (' + redondeaN(this.percentage, 1) + '%)';";
                LoGraficas.total = LnTotal;
                LoGraficas.series = LaoSeries;
                LoGraficas.categorias = LasCategorias;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }
    //𝘌𝘴𝘵𝘢𝘵𝘶𝘴 𝘥𝘦𝘭 𝘧𝘦𝘵𝘰 𝘺 𝘦𝘭 𝘳𝘦𝘤𝘪é𝘯 𝘯𝘢𝘤𝘪𝘥𝘰 

    //𝑮𝒓𝒂𝒇𝒊𝒄𝒂 𝒑𝒐𝒓 𝒓𝒂𝒏𝒈𝒐 𝒅𝒆 𝒆𝒅𝒂𝒅 𝑬𝒔𝒕𝒂𝒕𝒖𝒔 𝒅𝒆𝒍 𝑷𝒓𝒐𝒅𝒖𝒄𝒕𝒐 𝑬𝒅𝒂𝒅 
    public entGraficas obtenerEstatusdelProductoEdad(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio, string @PnClues)
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.Parameters.AddWithValue("@PnClues", PnClues);
            sqlCmd.CommandText = "spObtenerEstatusdelProductoEdad";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();

            if (LdtIntro != null)
            {
                LoGraficas.titulo = "";
                LoGraficas.tituloEjeX = "Edad";


                List<entSerie> LaoSeries = new List<entSerie>();
                List<entCategoria> LasCategorias = new List<entCategoria>();
                List<double> LanTotales = new List<double>();  // La suma del final de la barra apilada 
                LanTotales.Add(0);

                for (int i = 13; i >= 3; i--)             // Los nombres de las categorias  de la columna 13 (55 y mas ) hasta la columna 3 (menores de 10 años)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = (LdtIntro.Columns[i].Caption.ToString());
                    LasCategorias.Add(LoCategoria);
                }

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entSerie LoSerie = new entSerie();
                    LoSerie.name = dr["etiquetaX"].ToString(); 
                    LoSerie.color = dr["color"].ToString();
                    LoSerie.showInLegend = true;
                    LoSerie.data = new List<entPunto>();

                    for (int i = 13; i >= 3; i--)
                    {
                        entPunto LoPunto = new entPunto();
                        LoPunto.y = Convert.ToDouble(dr[i].ToString());  // Va por el Resultset del SQL y trae el ROWS de la Fila
                        LoPunto.color = dr["color"].ToString();
                        LoPunto.id = dr["etiquetaX"].ToString();
                        LoSerie.data.Add(LoPunto);
                        LanTotales[0] = LanTotales[0] + LoPunto.y;
                    }
                    LaoSeries.Add(LoSerie);
                }
                LoGraficas.tooltipFormater = "'Rango de edad de  ' + '<b>' + this.point.category + '</b>' + ' ' + this.series.name  + ': ' + '<b>' + numberWithCommas(this.point.y) + '</b>'  +' (' + redondeaN(this.point.percentage, 1) + '%)';";
                LoGraficas.series = LaoSeries;
                LoGraficas.totales = LanTotales;
                LoGraficas.categorias = LasCategorias;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }

    //𝑮𝒓𝒂𝒇𝒊𝒄𝒂 𝒑𝒐𝒓 𝒓𝒂𝒏𝒈𝒐 𝒅𝒆 𝒆𝒅𝒂𝒅 𝑬𝒔𝒕𝒂𝒕𝒖𝒔 𝒅𝒆𝒍 𝑷𝒓𝒐𝒅𝒖𝒄𝒕𝒐 𝑬𝒅𝒂𝒅 


    //<-- L̳e̳t̳a̳l̳i̳d̳a̳d̳E̳n̳t̳i̳d̳a̳d̳ -->
    public entGraficas obtenerLetalidadEntidad(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio, string @PnClues)
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();
        double TotalCasosSMM, LetalidadNacional, TotalLetalidad; 

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.Parameters.AddWithValue("@PnClues", PnClues);
            sqlCmd.CommandText = "spObtenerLetalidadEntidad";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();
            

            if (LdtIntro != null)
            {
                LoGraficas.min = 0;
                LoGraficas.max = 10;
                LoGraficas.pointWidth = 20;

                List<double> LanPromedio = new List<double>();
                LetalidadNacional = Convert.ToDouble(LdtIntro.Rows[0]["LetalidadNacional"].ToString());
                LanPromedio.Add(LetalidadNacional);

                List<entSerie> LaoSeries = new List<entSerie>();

                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "Porcentaje";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);

                // Segunda serie sin información solo para que pinte la grafica
                entSerie LoSerie1 = new entSerie();
                LoSerie1.name = "XX";
                LoSerie1.data = new List<entPunto>();
                LaoSeries.Add(LoSerie1);
                // Segunda serie sin información solo para que pinte la grafica

                List<entCategoria> LasCategorias = new List<entCategoria>();
                TotalCasosSMM = Convert.ToDouble(LdtIntro.Rows[0]["TotalCasosSMM"].ToString());
                TotalLetalidad = Convert.ToDouble(LdtIntro.Rows[0]["TotalLetalidad"].ToString());
                LetalidadNacional = Convert.ToDouble(LdtIntro.Rows[0]["LetalidadNacional"].ToString());
                LoGraficas.valores.Add(TotalCasosSMM.ToString("###,##0"));
                LoGraficas.valores.Add(TotalLetalidad.ToString("###,##0"));
                LoGraficas.valores.Add(LetalidadNacional.ToString("(##0.0") + "%)");

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.y = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.valorY = Convert.ToDouble(dr["y"].ToString());
                    LoPunto.color = dr["color"].ToString();
                    LoPunto.id = dr["Defuncion"].ToString();
                    LanPromedio[0] = LanPromedio[0];
                    LaoSeries[0].data.Add(LoPunto);
                }
                LoGraficas.tooltipFormater = " '<b>' +PoPuntos.series[0].data[this.point.index].valorY +  '</b>'+ ' casos de los cuales '+'<b>'+ + PoPuntos.series[0].data[this.point.index].id + '</b>'+ ' fallecieron ' +'<b>'+this.x + '</b>' ;";
                LoGraficas.series = LaoSeries;
                LoGraficas.totales = LanPromedio;
                LoGraficas.categorias = LasCategorias;

            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }
    //<-- L̳e̳t̳a̳l̳i̳d̳a̳d̳E̳n̳t̳i̳d̳a̳d̳ -->

    //𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Letalidad

    public entGraficas obtenerLetalidadGrupodeEdad(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio, string @PnClues)
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.Parameters.AddWithValue("@PnClues", PnClues);
            sqlCmd.CommandText = "spObtenerLetalidadGrupodeEdad";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();


            if (LdtIntro.Rows.Count > 0)
                LoGraficas.colorFondo = "#F5F5F5";
                LoGraficas.pointWidth = 30;
                LoGraficas.borderRadius = 10;

            {

                List<entSerie> LaoSeries = new List<entSerie>();
                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);

                List<entCategoria> LasCategorias = new List<entCategoria>();

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.valorY = Convert.ToDouble(dr["y"].ToString());
                    LoPunto.y = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.z = Convert.ToDouble(dr["z"].ToString());
                    LoPunto.color = dr["color"].ToString();
                   
                    LaoSeries[0].data.Add(LoPunto);


                }
                LoGraficas.tooltipFormater = " 'En el rango de edad de '+'<b>'+this.x + '</b>' + ' hay ' +'<b>'+ numberWithCommas(PoPuntos.series[0].data[this.point.index].z) + '</b>'+ ' casos con MMS de los cuales ' +'<b>' + numberWithCommas(PoPuntos.series[0].data[this.point.index].valorY) +  '</b>'+ ' fallecieron' ";
                LoGraficas.series = LaoSeries;
                LoGraficas.categorias = LasCategorias;

            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }

    //𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Letalidad

    //<--C̸e̸s̸á̸r̸e̸a̸s̸-->
    public entGraficas obtenerCesareas(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio , string @PnClues)
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();
        double TotalCasosSMM, LetalidadCesarias , TotalCesareas;

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.Parameters.AddWithValue("@PnClues", PnClues);
            sqlCmd.CommandText = "spObtenerCesareas";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();


            if (LdtIntro.Rows.Count > 0)
            {
                LoGraficas.min = 0;
                LoGraficas.max = 100;
                LoGraficas.pointWidth = 20;


                List<double> LanPromedio = new List<double>();
                LetalidadCesarias = Convert.ToDouble(LdtIntro.Rows[0]["LetalidadCesarias"].ToString());
                LanPromedio.Add(LetalidadCesarias);

                List<entSerie> LaoSeries = new List<entSerie>();

                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "Porc";
                LoSerie.data = new List<entPunto>(); 
                LaoSeries.Add(LoSerie);

                // Segunda serie sin información solo para que pinte la grafica
                entSerie LoSerie1 = new entSerie();
                LoSerie1.name = "XX";
                LoSerie1.data = new List<entPunto>();
                LaoSeries.Add(LoSerie1);
                // Segunda serie sin información solo para que pinte la grafica

                List<entCategoria> LasCategorias = new List<entCategoria>();
                TotalCasosSMM = Convert.ToDouble(LdtIntro.Rows[0]["TotalCasosSMM"].ToString());
                TotalCesareas = Convert.ToDouble(LdtIntro.Rows[0]["TotalCesareas"].ToString());
                LetalidadCesarias = Convert.ToDouble(LdtIntro.Rows[0]["LetalidadCesarias"].ToString());
                LoGraficas.valores.Add(TotalCasosSMM.ToString("###,##0"));
                LoGraficas.valores.Add(TotalCesareas.ToString("###,##0"));
                LoGraficas.valores.Add(LetalidadCesarias.ToString("(##0.0") + "%)");

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.y = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.valorY = Convert.ToDouble(dr["y"].ToString());
                    LoPunto.color = dr["color"].ToString();
                    LoPunto.id = dr["Cesareas"].ToString();
                    LanPromedio[0] = LanPromedio[0];
                    LaoSeries[0].data.Add(LoPunto);
                }
                LoGraficas.tooltipFormater = " '<b>' +PoPuntos.series[0].data[this.point.index].valorY +  '</b>'+ ' casos de los cuales '+'<b>'+ + PoPuntos.series[0].data[this.point.index].id + '</b>'+ ' se han resuleto por cesárea en ' +'<b>'+this.x + '</b>' ;";
                LoGraficas.series = LaoSeries;
                LoGraficas.totales = LanPromedio;
                LoGraficas.categorias = LasCategorias;

            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }

    //<--C̸e̸s̸á̸r̸e̸a̸s̸-->

    //𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Cesarias

    public entGraficas obtenerCesareasGrupodeEdad(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio, string @PnClues)
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.Parameters.AddWithValue("@PnClues", PnClues);
            sqlCmd.CommandText = "spObtenerCesareasGrupodeEdad";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();


            if (LdtIntro.Rows.Count > 0)
                LoGraficas.colorFondo = "#F5F5F5";
                LoGraficas.pointWidth = 40;
                LoGraficas.borderRadius = 9;

            {

                List<entSerie> LaoSeries = new List<entSerie>();
                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);

                List<entCategoria> LasCategorias = new List<entCategoria>();

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.valorY = Convert.ToDouble(dr["y"].ToString());
                    LoPunto.y = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.z = Convert.ToDouble(dr["z"].ToString());
                    LoPunto.color = dr["color"].ToString();

                    LaoSeries[0].data.Add(LoPunto);


                }
                LoGraficas.tooltipFormater = " 'En el rango de edad de '+'<b>'+this.x + '</b>' + ' hay ' +'<b>'+ numberWithCommas(PoPuntos.series[0].data[this.point.index].z) + '</b>'+ ' casos con MMS de los cuales ' +'<b>' + numberWithCommas(PoPuntos.series[0].data[this.point.index].valorY) +  '</b>'+ ' se han resuleto por cesárea' ";
                LoGraficas.series = LaoSeries;
                LoGraficas.categorias = LasCategorias;

            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }

    //𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Cesarias

    //<--ℙ𝕣𝕖𝕟𝕒𝕥𝕒𝕝-->
    public entGraficas obtenerControlprenatal(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio, string @PnClues)
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();
        double PrenatalNacional, TotalCasosSMM , TotalPrenatal;

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.Parameters.AddWithValue("@PnClues", PnClues);
            sqlCmd.CommandText = "spObtenerControlprenatal";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();


            if (LdtIntro.Rows.Count > 0)
            {
                LoGraficas.min = 0;
                LoGraficas.max = 100;
                LoGraficas.pointWidth = 20;


                List<double> LanPromedio = new List<double>();
                PrenatalNacional = Convert.ToDouble(LdtIntro.Rows[0]["PrenatalNacional"].ToString());
                LanPromedio.Add(PrenatalNacional);


                List<entSerie> LaoSeries = new List<entSerie>();

                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "Porc";
                LoSerie.data = new List<entPunto>(); 
                LaoSeries.Add(LoSerie);

                // Segunda serie sin información solo para que pinte la grafica
                entSerie LoSerie1 = new entSerie();
                LoSerie1.name = "XX";
                LoSerie1.data = new List<entPunto>();
                LaoSeries.Add(LoSerie1);
                // Segunda serie sin información solo para que pinte la grafica

                List<entCategoria> LasCategorias = new List<entCategoria>();
                TotalCasosSMM = Convert.ToDouble(LdtIntro.Rows[0]["TotalCasosSMM"].ToString());
                TotalPrenatal = Convert.ToDouble(LdtIntro.Rows[0]["TotalPrenatal"].ToString());
                PrenatalNacional = Convert.ToDouble(LdtIntro.Rows[0]["PrenatalNacional"].ToString());
                LoGraficas.valores.Add(TotalCasosSMM.ToString("###,##0"));
                LoGraficas.valores.Add(TotalPrenatal.ToString("###,##0"));
                LoGraficas.valores.Add(PrenatalNacional.ToString("(##0.0") + "%)");

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.y = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.valorY = Convert.ToDouble(dr["y"].ToString());
                    LoPunto.color = dr["color"].ToString();
                    LoPunto.id = dr["Prenatal"].ToString();
                    LanPromedio[0] = LanPromedio[0];
                    LaoSeries[0].data.Add(LoPunto);
                }
                LoGraficas.tooltipFormater = " '<b>' +PoPuntos.series[0].data[this.point.index].valorY +  '</b>'+ ' casos de los cuales '+'<b>'+ + PoPuntos.series[0].data[this.point.index].id + '</b>'+ '  cuentan con más de cuatro consultas en ' +'<b>'+this.x + '</b>' ;";
                LoGraficas.series = LaoSeries;
                LoGraficas.totales = LanPromedio;
                LoGraficas.categorias = LasCategorias;

            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }

    //<--ℙ𝕣𝕖𝕟𝕒𝕥𝕒𝕝-->

    //𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Controlprenatal

    public entGraficas obtenerControlprenatalGrupodeEdad(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio, string @PnClues)
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.Parameters.AddWithValue("@PnClues", PnClues);
            sqlCmd.CommandText = "spObtenerControlprenatalGrupodeEdad";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();


            if (LdtIntro.Rows.Count > 0)
                LoGraficas.colorFondo = "#F5F5F5";
            LoGraficas.pointWidth = 40;
            LoGraficas.borderRadius = 9;

            {

                List<entSerie> LaoSeries = new List<entSerie>();
                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);

                List<entCategoria> LasCategorias = new List<entCategoria>();

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.valorY = Convert.ToDouble(dr["y"].ToString());
                    LoPunto.y = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.z = Convert.ToDouble(dr["z"].ToString());
                    LoPunto.color = dr["color"].ToString();

                    LaoSeries[0].data.Add(LoPunto);


                }
                LoGraficas.tooltipFormater = " 'En el rango de edad de '+'<b>'+this.x + '</b>' + ' hay ' +'<b>'+ numberWithCommas(PoPuntos.series[0].data[this.point.index].z) + '</b>'+ ' casos con MMS de los cuales ' +'<b>' + numberWithCommas(PoPuntos.series[0].data[this.point.index].valorY) +  '</b>'+ ' cuentan con más de cuatro consultas' ";
                LoGraficas.series = LaoSeries;
                LoGraficas.categorias = LasCategorias;

            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }

    //𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 Controlprenatal

    //T̴r̴a̴n̴s̴f̴u̴s̴i̴o̴n̴
    public entGraficas obtenerTransfusion(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio, string @PnClues, string @PnParametros)
    {

        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();
        double TransfusionNacional, TotalCasosSMM, TotalTransfusion;

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.Parameters.AddWithValue("@PnClues", PnClues);
            sqlCmd.Parameters.AddWithValue("@PnParametros", PnParametros);
            sqlCmd.CommandText = "spObtenerTransfusion";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();

           
            if (LdtIntro != null)
            {
                LoGraficas.colorFondo = "#F5F5F5";
                LoGraficas.min = 0;
                LoGraficas.max = 30;
                LoGraficas.pointWidth = 20;

            if (PnParametros != "1")
             {
                LoGraficas.colorFondo = "#F5F5F5";
                LoGraficas.min = 0;
                LoGraficas.max = 30;
                LoGraficas.pointWidth = 15;
             }


                List<double> LanPromedio = new List<double>();
                TransfusionNacional = Convert.ToDouble(LdtIntro.Rows[0]["TransfusionNacional"].ToString());
                LanPromedio.Add(TransfusionNacional);

                List<entSerie> LaoSeries = new List<entSerie>();

                    entSerie LoSerie = new entSerie();
                    LoGraficas.valores = new List<string>();
                    LoSerie.name = "Porc";
                    LoSerie.data = new List<entPunto>();
                    LaoSeries.Add(LoSerie);

                if (PnParametros != "1")
               {
                    entSerie LoSerie1 = new entSerie();
                    LoSerie1.name = "Porc2";
                    LoSerie1.data = new List<entPunto>();
                    LaoSeries.Add(LoSerie1);
               }

                List<entCategoria> LasCategorias = new List<entCategoria>();
                TotalCasosSMM = Convert.ToDouble(LdtIntro.Rows[0]["TotalCasosSMM"].ToString());
                TotalTransfusion = Convert.ToDouble(LdtIntro.Rows[0]["TotalTransfusion"].ToString());
                TransfusionNacional = Convert.ToDouble(LdtIntro.Rows[0]["TransfusionNacional"].ToString());
                LoGraficas.valores.Add(TotalCasosSMM.ToString("###,##0"));
                LoGraficas.valores.Add(TotalTransfusion.ToString("###,##0"));
                LoGraficas.valores.Add(TransfusionNacional.ToString("(##0.0") + "%)");
                                

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.y = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.valorY = Convert.ToDouble(dr["y"].ToString());
                    LoPunto.color = dr["color"].ToString();
                    LoPunto.id = dr["Transfusion"].ToString();
                    LanPromedio[0] = LanPromedio[0];
                    LaoSeries[0].data.Add(LoPunto);

                    if (PnParametros != "1")
                    {
                        entPunto LoPunto2 = new entPunto();
                        LoPunto2.y = Convert.ToDouble(dr["Porc2"].ToString());
                        LoPunto2.valorY = Convert.ToDouble(dr["Totalgeneral2"].ToString());
                        LoPunto2.color = dr["color2"].ToString();
                        LoPunto2.id = dr["Transfusion2"].ToString();
                        LaoSeries[1].data.Add(LoPunto2);
                    }
                }
                //          LoGraficas.tooltipFormater = " '<b>' +this.point.valorY +  '</b>'+ ' casos de los cuales '+'<b>'+ + this.point.id + '</b>'+ '  se aplicaron más de tres transfusiones en ' +'<b>'+this.x + '</b>' ;";
                LoGraficas.tooltipFormater = " 'De los '  +'<b>' +this.point.valorY +  '</b>'+ ' casos con MMS en ' + '<b>'+this.x + '</b>'  + ' a '+'<b>'+ + this.point.id + '</b>'+ ' se aplicaron más de tres transfusiones ' ;";
                LoGraficas.series = LaoSeries;
                LoGraficas.totales = LanPromedio;
                LoGraficas.categorias = LasCategorias;

            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }
    //T̴r̴a̴n̴s̴f̴u̴s̴i̴o̴n̴

    //C̶a̶u̶s̶a̶s̶T̶r̶a̶n̶s̶f̶u̶s̶i̶o̶n̶
    public entGraficas obtenerCausasTransfusion(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio)
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.CommandText = "spObtenerCausasTransfusion";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();

            if (LdtIntro != null)
            {
                LoGraficas.titulo = "";
                LoGraficas.colorFondo = "#F5F5F5";

                List<entSerie> LaoSeries = new List<entSerie>();

                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "Causas";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);
                double LnTotal = 0;

                List<entCategoria> LasCategorias = new List<entCategoria>();


                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.y = Convert.ToDouble(dr["y"].ToString());
                    LnTotal += LoPunto.y;
                    LoPunto.name = dr["etiquetaX"].ToString();
                    LoPunto.color = dr["color"].ToString();
                    LaoSeries[0].data.Add(LoPunto);
                }
                LoGraficas.tooltipFormater = "this.key + ': ' + numberWithCommas(this.y) + ' (' + redondeaN(this.percentage, 1) + '%)';";
                LoGraficas.total = LnTotal;
                LoGraficas.series = LaoSeries;
                LoGraficas.categorias = LasCategorias;
            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }
    //C̶a̶u̶s̶a̶s̶T̶r̶a̶n̶s̶f̶u̶s̶i̶o̶n̶

    //<-- R͟a͟z͟ó͟n͟ ͟d͟e͟ ͟M͟o͟r͟b͟i͟l͟i͟d͟a͟d͟ ͟M͟a͟t͟e͟r͟n͟a͟ ͟S͟e͟v͟e͟r͟a͟ -->
    public entGraficas obtenerMMSEntidad(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio, string @PnClues)
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();
        double RazonNacional, TotalCasosSMM, TotalRNGlobal;

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.Parameters.AddWithValue("@PnClues", PnClues);
            sqlCmd.CommandText = "spObtenerMMSEntidad";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();


            if (LdtIntro.Rows.Count > 0)
            {
                LoGraficas.min = 0;
                LoGraficas.max = 30;
                LoGraficas.pointWidth = 20;

                List<double> LanPromedio = new List<double>();
                RazonNacional = Convert.ToDouble(LdtIntro.Rows[0]["RazonNacional"].ToString());
                LanPromedio.Add(RazonNacional);

                List<entSerie> LaoSeries = new List<entSerie>();
                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "Porc";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);

                // Segunda serie sin información solo para que pinte la grafica
                entSerie LoSerie1 = new entSerie();
                LoSerie1.name = "XX";
                LoSerie1.data = new List<entPunto>();
                LaoSeries.Add(LoSerie1);
                // Segunda serie sin información solo para que pinte la grafica

                List<entCategoria> LasCategorias = new List<entCategoria>();
                TotalCasosSMM = Convert.ToDouble(LdtIntro.Rows[0]["TotalCasosSMM"].ToString()); 
                TotalRNGlobal = Convert.ToDouble(LdtIntro.Rows[0]["TotalRNGlobal"].ToString()); 
                RazonNacional = Convert.ToDouble(LdtIntro.Rows[0]["RazonNacional"].ToString());

                LoGraficas.valores.Add(TotalCasosSMM.ToString("###,##0")); // Pos 0
                LoGraficas.valores.Add(TotalRNGlobal.ToString("###,##0")); // Pos 1
                LoGraficas.valores.Add(RazonNacional.ToString("##0.0") + "%");// Pos 2

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.y = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.valorY = Convert.ToDouble(dr["y"].ToString());
                    LoPunto.color = dr["color"].ToString();
                    LoPunto.id = dr["TotalRN"].ToString();
                    LanPromedio[0] = LanPromedio[0];
                    LaoSeries[0].data.Add(LoPunto);


                }
                //LoGraficas.tooltipFormater = " '<b>' +PoPuntos.series[0].data[this.point.index].valorY +  '</b>'+ ' casos de los cuales '+'<b>'+ numberWithCommas(PoPuntos.series[0].data[this.point.index].id) + '</b>'+ '  es el total de recién nacidos en  ' +'<b>'+this.x + '</b>' ;";
                LoGraficas.tooltipFormater = " 'En '+'<b>'+this.x + '</b>' + ' hay ' +'<b>'+ numberWithCommas(PoPuntos.series[0].data[this.point.index].id) + '</b>'+ ' recién nacidos y ' +'<b>' +PoPuntos.series[0].data[this.point.index].valorY +  '</b>'+ ' casos CON Morbilidad Materna Severa' ";
                LoGraficas.dataLabelsFormater = "redondeaN(this.y, 2) + '%' ";
                LoGraficas.series = LaoSeries;
                LoGraficas.totales = LanPromedio;
                LoGraficas.categorias = LasCategorias;

            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }

    //<-- R͟a͟z͟ó͟n͟ ͟d͟e͟ ͟M͟o͟r͟b͟i͟l͟i͟d͟a͟d͟ ͟M͟a͟t͟e͟r͟n͟a͟ ͟S͟e͟v͟e͟r͟a͟ -->

    //  <--𝘊𝘢𝘴𝘰𝘴 𝘱𝘰𝘳 𝘨𝘳𝘶𝘱𝘰 𝘥𝘦 𝘦𝘥𝘢𝘥-->
    public entGraficas obtenerGrupodeedad (string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio, string @PnClues)
    { 
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();
        double LnEdad;

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.Parameters.AddWithValue("@PnClues", PnClues);
            sqlCmd.CommandText = "spObtenerGrupodeedad";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();

            if (LdtIntro != null)
            {
                LoGraficas.titulo = "";
                LoGraficas.colorFondo = "#F5F5F5";

                List<entSerie> LaoSeries = new List<entSerie>();

                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "mediciones";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);

                entSerie LoSerie1 = new entSerie();
                LoSerie1.name = "Razon";
                LoSerie1.data = new List<entPunto>();
                LaoSeries.Add(LoSerie1);


                List<entCategoria> LasCategorias = new List<entCategoria>();
                LnEdad = Convert.ToDouble(LdtIntro.Rows[3]["razon"].ToString());
                LoGraficas.valores.Add(LnEdad.ToString("##0.0") + "%");

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.y = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.valorY = Convert.ToDouble(dr["y"].ToString());
                    LoPunto.color = dr["color"].ToString();
                    LaoSeries[0].data.Add(LoPunto);

                    entPunto LoPunto2 = new entPunto();
                    LoPunto2.y = Convert.ToDouble(dr["razon"].ToString());
                    LaoSeries[1].data.Add(LoPunto2);
                }
                LoGraficas.tooltipFormater = "'Para el grupo de edad ' + this.x + ' años la razón de casos por cada 100NV es ' + '<b>'+ redondeaN(PoPuntos.series[1].data[this.point.index].y,1) + ' %' + '</b>' + ' con un numero de casos de ' +  '<b>'  + PoPuntos.series[0].data[this.point.index].y + '</b>' ";
                LoGraficas.series = LaoSeries;
                LoGraficas.categorias = LasCategorias;
               }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }
    //  <--𝘊𝘢𝘴𝘰𝘴 𝘱𝘰𝘳 𝘨𝘳𝘶𝘱𝘰 𝘥𝘦 𝘦𝘥𝘢𝘥-->

    //<-- Tasa de sobrevida en mujeres -->
    public entGraficas obtenerTasaSobrevidaMMS(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio, string @PnClues)
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();
        double  TotalCasosSMM, VivosTotal, Taza;

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.Parameters.AddWithValue("@PnClues", PnClues);
            sqlCmd.CommandText = "spObtenerTasaSobrevidaMMS";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();


            if (LdtIntro != null)
            {
                LoGraficas.min = 40;
                LoGraficas.max = 110;
                LoGraficas.pointWidth = 20;

                List<entSerie> LaoSeries = new List<entSerie>();

                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "Porcentaje";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);

                // Segunda serie sin información solo para que pinte la grafica
                entSerie LoSerie1 = new entSerie();
                LoSerie1.name = "XX";
                LoSerie1.data = new List<entPunto>();
                LaoSeries.Add(LoSerie1);
                // Segunda serie sin información solo para que pinte la grafica

                List<entCategoria> LasCategorias = new List<entCategoria>();
                TotalCasosSMM = Convert.ToDouble(LdtIntro.Rows[0]["TotalCasosSMM"].ToString());
                VivosTotal = Convert.ToDouble(LdtIntro.Rows[0]["VivosTotal"].ToString());
                Taza = Convert.ToDouble(LdtIntro.Rows[0]["Taza"].ToString());

                LoGraficas.valores.Add(TotalCasosSMM.ToString("###,##0")); //lblTasauma
                LoGraficas.valores.Add(VivosTotal.ToString("###,##0")); //lblTasaumacasos
                LoGraficas.valores.Add(Taza.ToString("##0.0") + "%");//lbltaza

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.y = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.valorY = Convert.ToDouble(dr["y"].ToString());
                    LoPunto.color = dr["color"].ToString();
                    LoPunto.id = dr["vivos"].ToString();
                    LaoSeries[0].data.Add(LoPunto);
                }
                LoGraficas.tooltipFormater = " '<b>' +PoPuntos.series[0].data[this.point.index].valorY +  '</b>'+ ' casos notificados y  '+'<b>'+ + PoPuntos.series[0].data[this.point.index].id + '</b>'+ ' casos con sobrevida en ' +'<b>'+this.x + '</b>' ;";
                LoGraficas.series = LaoSeries;
                LoGraficas.categorias = LasCategorias;

            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }

    //<-- Tasa de sobrevida en mujeres -->

    // 𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 TasaSobrevidaMMS 

    public entGraficas obtenerTasaSobrevidaMMSEdad(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio, string @PnClues)
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.Parameters.AddWithValue("@PnClues", PnClues);
            sqlCmd.CommandText = "spObtenerTasaSobrevidaMMSEdad";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();


            if (LdtIntro.Rows.Count > 0)
                //  LoGraficas.colorFondo = "#F5F5F5";
                LoGraficas.pointWidth = 40;
                LoGraficas.borderRadius = 4;

            {

                List<entSerie> LaoSeries = new List<entSerie>();
                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);

                List<entCategoria> LasCategorias = new List<entCategoria>();

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.valorY = Convert.ToDouble(dr["y"].ToString());
                    LoPunto.y = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.z = Convert.ToDouble(dr["z"].ToString());
                    LoPunto.color = dr["color"].ToString();

                    LaoSeries[0].data.Add(LoPunto);


                }
                LoGraficas.tooltipFormater = " 'En el rango de edad de '+'<b>'+this.x + '</b>' + ' hay ' +'<b>'+ numberWithCommas(PoPuntos.series[0].data[this.point.index].z) + '</b>'+ ' casos con MMS de los cuales ' +'<b>' + numberWithCommas(PoPuntos.series[0].data[this.point.index].z) +  '</b>'+ ' casos con sobrevida' ";
                LoGraficas.series = LaoSeries;
                LoGraficas.categorias = LasCategorias;

            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }

    // 𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 TasaSobrevidaMMS 

    //<--E͢m͢b͢a͢r͢a͢z͢o͢s͢ ͢S͢i͢n͢ ͢M͢o͢r͢b͢i͢l͢i͢d͢a͢d͢ ͢M͢a͢t͢e͢r͢n͢a͢ ͢ -->
    public entGraficas obtenerSinMMSEntidad(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio, string @PnClues)
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();
        double NacionalRN, SinMorbiRN, SinMorbiRNPorc;

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.Parameters.AddWithValue("@PnClues", PnClues);
            sqlCmd.CommandText = "spObtenerSinMMSEntidad";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();


            if (LdtIntro.Rows.Count > 0)

                LoGraficas.min = 40;
                LoGraficas.max = 110;
                LoGraficas.pointWidth = 20;
            
            {

                List<entSerie> LaoSeries = new List<entSerie>();
                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "Porc";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);

                // Segunda serie sin información solo para que pinte la grafica
                entSerie LoSerie1 = new entSerie();
                LoSerie1.name = "XX";
                LoSerie1.data = new List<entPunto>();
                LaoSeries.Add(LoSerie1);
                // Segunda serie sin información solo para que pinte la grafica

                List<entCategoria> LasCategorias = new List<entCategoria>();
                NacionalRN = Convert.ToDouble(LdtIntro.Rows[0]["NacionalRN"].ToString());
                SinMorbiRN = Convert.ToDouble(LdtIntro.Rows[0]["SinMorbiRN"].ToString());
                SinMorbiRNPorc = Convert.ToDouble(LdtIntro.Rows[0]["SinMorbiRNPorc"].ToString());


                LoGraficas.valores.Add(NacionalRN.ToString("###,##0"));//lblNacionalRN [0] 
                LoGraficas.valores.Add(SinMorbiRN.ToString("###,##0"));//lblSinMorbiRN  [1]
                LoGraficas.valores.Add(SinMorbiRNPorc.ToString("(##0.0") + "%)");//lblSinMorbiRNPorc [2]

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.y = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.valorY = Convert.ToDouble(dr["y"].ToString());
                    LoPunto.color = dr["color"].ToString();
                    LoPunto.id = dr["TotalRN"].ToString();
                    LoPunto.id2 = dr["SinMorbi"].ToString();

                    LaoSeries[0].data.Add(LoPunto);


                }
                //LoGraficas.tooltipFormater = " '<b>' +PoPuntos.series[0].data[this.point.index].valorY +  '</b>'+ ' casos de los cuales '+'<b>'+ numberWithCommas(PoPuntos.series[0].data[this.point.index].id) + '</b>'+ '  es el total de recién nacidos en  ' +'<b>'+this.x + '</b>' ;";
                LoGraficas.tooltipFormater = " 'En '+'<b>'+this.x + '</b>' + ' hay ' +'<b>'+ numberWithCommas(PoPuntos.series[0].data[this.point.index].id) + '</b>'+ ' recién nacidos y ' +'<b>' + numberWithCommas(PoPuntos.series[0].data[this.point.index].id2) +  '</b>'+ ' casos SIN Morbilidad Materna Severa' ";
                LoGraficas.series = LaoSeries;
                LoGraficas.categorias = LasCategorias;

            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }

    //<--E͢m͢b͢a͢r͢a͢z͢o͢s͢ ͢S͢i͢n͢ ͢M͢o͢r͢b͢i͢l͢i͢d͢a͢d͢ ͢M͢a͢t͢e͢r͢n͢a͢ ͢ -->

    //𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝  

    public entGraficas obtenerSinMMSGrupodeedad(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio, string @PnClues)
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();

        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
            sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
            sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
            sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
            sqlCmd.Parameters.AddWithValue("@PnClues", PnClues);
            sqlCmd.CommandText = "spObtenerSinMMSGrupodeedad";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();


            if (LdtIntro.Rows.Count > 0)
            LoGraficas.colorFondo = "#F5F5F5";
            LoGraficas.pointWidth = 40;
            LoGraficas.borderRadius = 4;

            {

                List<entSerie> LaoSeries = new List<entSerie>();
                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);

                List<entCategoria> LasCategorias = new List<entCategoria>();

                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.valorY = Convert.ToDouble(dr["y"].ToString());
                    LoPunto.y = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.color = dr["color"].ToString();
                    LoPunto.id = dr["RN"].ToString();

                    LaoSeries[0].data.Add(LoPunto);


                }
                LoGraficas.tooltipFormater = " 'En el rango de edad de '+'<b>'+this.x + '</b>' + ' hay ' +'<b>'+ numberWithCommas(PoPuntos.series[0].data[this.point.index].id) + '</b>'+ ' recién nacidos y ' +'<b>' + numberWithCommas(PoPuntos.series[0].data[this.point.index].valorY) +  '</b>'+ ' casos SIN Morbilidad Materna Severa' ";
                LoGraficas.series = LaoSeries;
                LoGraficas.categorias = LasCategorias;

            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }

    //𝐆𝐫á𝐟𝐢𝐜𝐚 𝐩𝐨𝐫 𝐫𝐚𝐧𝐠𝐨 𝐝𝐞 𝐞𝐝𝐚𝐝 


    //<--calidad en la atención prenatal-->
    public entGraficas obtenerIndGravedad()
    {
        entGraficas LoGraficas = new entGraficas();
        DataTable LdtIntro = new DataTable();
        SqlCommand sqlCmd = new SqlCommand();
       
        try
        {
            sqlCon.Open();
            sqlCmd.Connection = sqlCon;
            sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCmd.CommandTimeout = 0;
            sqlCmd.CommandText = "spObtenerIndGravedad";
            LdtIntro.Load(sqlCmd.ExecuteReader());
            sqlCon.Close();


            if (LdtIntro.Rows.Count > 0)
            {
                LoGraficas.min = 0;
                LoGraficas.max = 10;
                LoGraficas.pointWidth = 20;

                List<entSerie> LaoSeries = new List<entSerie>();
                entSerie LoSerie = new entSerie();
                LoGraficas.valores = new List<string>();
                LoSerie.name = "Porc";
                LoSerie.data = new List<entPunto>();
                LaoSeries.Add(LoSerie);

                // Segunda serie sin información solo para que pinte la grafica
                entSerie LoSerie1 = new entSerie();
                LoSerie1.name = "XX";
                LoSerie1.data = new List<entPunto>();
                LaoSeries.Add(LoSerie1);
                // Segunda serie sin información solo para que pinte la grafica

                List<entCategoria> LasCategorias = new List<entCategoria>();


                foreach (DataRow dr in LdtIntro.Rows)
                {
                    entCategoria LoCategoria = new entCategoria();
                    LoCategoria.nombre = dr["etiquetaX"].ToString();
                    LasCategorias.Add(LoCategoria);

                    entPunto LoPunto = new entPunto();
                    LoPunto.y = Convert.ToDouble(dr["valorY"].ToString());
                    LoPunto.valorY = Convert.ToDouble(dr["y"].ToString());
                    LoPunto.color = dr["color"].ToString();

                    LaoSeries[0].data.Add(LoPunto);


                }
                LoGraficas.tooltipFormater = " 'Para la Entidad '+'<b>'+this.x + '</b>' + ' su Índice de calidad en atención prenatal es ' + '<b>'+ redondeaN(PoPuntos.series[0].data[this.point.index].y,1) + '</b>' ";
                LoGraficas.dataLabelsFormater = "redondeaN(this.y, 1) ";
                LoGraficas.series = LaoSeries;
                LoGraficas.categorias = LasCategorias;

            }
        }
        catch (SqlException ex)
        {
            throw new Exception(ex.Message.ToString());
        }
        finally
        {
            //closeQuietly();
        }
        return LoGraficas;
    }

    //<--calidad en la atención prenatal-->



    //<--calidad en la atención prenatal-->
    //public entGraficas obtenerIndGravedad(string PnCveInstitucion, string PnCveEntidad, string PnCveJruisdiccion, string PnCveMunicipio, string @PnClues)
    //{
    //    entGraficas LoGraficas = new entGraficas();
    //    DataTable LdtIntro = new DataTable();
    //    SqlCommand sqlCmd = new SqlCommand();

    //    try
    //    {
    //        sqlCon.Open();
    //        sqlCmd.Connection = sqlCon;
    //        sqlCmd.CommandType = System.Data.CommandType.StoredProcedure;
    //        sqlCmd.CommandTimeout = 0;
    //        sqlCmd.Parameters.AddWithValue("@PnCveInstitucion", PnCveInstitucion);
    //        sqlCmd.Parameters.AddWithValue("@PnCveEntidad", PnCveEntidad);
    //        sqlCmd.Parameters.AddWithValue("@PnCveJurisdiccion", PnCveJruisdiccion);
    //        sqlCmd.Parameters.AddWithValue("@PnCveMunicipio", PnCveMunicipio);
    //        sqlCmd.Parameters.AddWithValue("@PnClues", PnClues);
    //        sqlCmd.CommandText = "spObtenerIndGravedadPrenatal";
    //        LdtIntro.Load(sqlCmd.ExecuteReader());
    //        sqlCon.Close();


    //        if (LdtIntro.Rows.Count > 0)
    //        {
    //            LoGraficas.min = 0;
    //            LoGraficas.max = 20;
    //            LoGraficas.pointWidth = 20;

    //            List<entSerie> LaoSeries = new List<entSerie>();
    //            entSerie LoSerie = new entSerie();
    //            LoGraficas.valores = new List<string>();
    //            LoSerie.name = "Porc";
    //            LoSerie.data = new List<entPunto>();
    //            LaoSeries.Add(LoSerie);

    //            // Segunda serie sin información solo para que pinte la grafica
    //            entSerie LoSerie1 = new entSerie();
    //            LoSerie1.name = "XX";
    //            LoSerie1.data = new List<entPunto>();
    //            LaoSeries.Add(LoSerie1);
    //            // Segunda serie sin información solo para que pinte la grafica

    //            List<entCategoria> LasCategorias = new List<entCategoria>();


    //            foreach (DataRow dr in LdtIntro.Rows)
    //            {
    //                entCategoria LoCategoria = new entCategoria();
    //                LoCategoria.nombre = dr["etiquetaX"].ToString();
    //                LasCategorias.Add(LoCategoria);

    //                entPunto LoPunto = new entPunto();
    //                LoPunto.y = Convert.ToDouble(dr["valorY"].ToString());
    //                LoPunto.valorY = Convert.ToDouble(dr["y"].ToString());
    //                LoPunto.color = dr["color"].ToString();

    //                LaoSeries[0].data.Add(LoPunto);


    //            }
    //            LoGraficas.tooltipFormater = " 'Para la Entidad '+'<b>'+this.x + '</b>' + ' su Índice de calidad en atención prenatal es ' + '<b>'+ redondeaN(PoPuntos.series[0].data[this.point.index].y,1) + '</b>' ";
    //            LoGraficas.dataLabelsFormater = "redondeaN(this.y, 1) ";
    //            LoGraficas.series = LaoSeries;
    //            LoGraficas.categorias = LasCategorias;

    //        }
    //    }
    //    catch (SqlException ex)
    //    {
    //        throw new Exception(ex.Message.ToString());
    //    }
    //    finally
    //    {
    //        //closeQuietly();
    //    }
    //    return LoGraficas;
    //}

    //<--calidad en la atención prenatal-->
}