using System.Collections.Generic;

/// <summary>
/// Daots referentes a la gráfica
/// </summary>
public class entGraficas
{
    public string titulo;
    public double alto;
    public double ancho;
    public string tooltipFormater;
    public string dataLabelsFormater = "redondeaN(this.y, 1) + '%'";
    public string colorFondo;
    public string tituloEjeX;
    public double total;
    public double min;
    public double max;
    public double pointWidth;
    public double borderRadius;
    public List<entSerie> series;
    public List<entCategoria> categorias;

    public List<string> valores;

    public List<double> totales;
}