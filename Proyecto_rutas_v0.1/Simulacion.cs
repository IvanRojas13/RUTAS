using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Proyecto_rutas_v0._1
{
    public partial class Simulacion : Form
    {
        Bitmap bmpMarker = (Bitmap)Image.FromFile("img/camion.png");
        List<PointLatLng> punto;
        Ruta ruta2 = new Ruta();
        public Simulacion()
        {
            InitializeComponent();
            punto = new List<PointLatLng>();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();

            menu.Show();
            this.Close();
        }

        private void Simulacion_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyA5dEbbeqn3GkB4V0B9S-3n8Yy0kQXQwkM";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapSimula.CacheLocation = @"cache";
            gMapSimula.MapProvider = GMapProviders.GoogleMap;
            gMapSimula.Position = new PointLatLng(22.150528, -100.991706); //Tequisquiapan
            gMapSimula.MinZoom = 5;
            gMapSimula.MaxZoom = 100;
            gMapSimula.Zoom = 14;
            gMapSimula.ShowCenter = false;

            cargaPng();
            tTiempo.Start();

            punto.Add(new PointLatLng(22.151042, -100.982690));
            punto.Add(new PointLatLng(22.150822, -100.985149));
        }

        public void cargaPng()
        {
            //PointLatLng punto = new PointLatLng(22.151042, -100.982690);
           /* punto.Add(new PointLatLng(22.151042, -100.982690));

            GMapMarker marcador = new GMarkerGoogle(punto[0], bmpMarker);

            GMapOverlay marcadores = new GMapOverlay("marcadores");
            marcadores.Markers.Add(marcador);
            gMapSimula.Overlays.Add(marcadores);

            gMapSimula.Zoom = gMapSimula.Zoom + 1; //Actualiza mapa
            gMapSimula.Zoom = gMapSimula.Zoom - 1;*/
        }

        private void tTiempo_Tick(object sender, EventArgs e)
        {
            //for (int i=0; i<1;i++)
            //{

            GMapMarker marcador = new GMarkerGoogle(punto[0], bmpMarker);
            GMapMarker marcador1 = new GMarkerGoogle(punto[1], bmpMarker);
            //i +=1;
            GMapOverlay marcadores = new GMapOverlay("marcadores");

            marcadores.Markers.Add(marcador);
            marcadores.Markers.Add(marcador1);
            gMapSimula.Overlays.Add(marcadores);

            //}
            gMapSimula.Zoom = gMapSimula.Zoom + 1; //Actualiza mapa
            gMapSimula.Zoom = gMapSimula.Zoom - 1;
        }

        private void Simulacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            tTiempo.Stop();
        }
    }
}
