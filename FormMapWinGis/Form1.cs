using MapWinGIS;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FormMapWinGis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetMap();
        }

        public void GetMap()
        {
            AxMapi.Projection = tkMapProjection.PROJECTION_GOOGLE_MERCATOR;
            AxMapi.TileProvider = tkTileProvider.GoogleMaps;
            AxMapi.KnownExtents = tkKnownExtents.keMexico;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFD.ShowDialog();
        }

        private void openFD_FileOk(object sender, CancelEventArgs e)
        {
            foreach (var item in openFD.FileNames)
            {
                AxMapi.Projection = tkMapProjection.PROJECTION_NONE;
                var fm = new FileManager();
                var obj = fm.Open(item, tkFileOpenStrategy.fosAutoDetect, null);
                if (obj != null && fm.LastOpenIsSuccess)
                {
                    int handle = AxMapi.AddLayer(obj, true);
                    if (handle != -1)
                        MessageBox.Show("Se ha agregado " + fm.LastOpenFilename);
                    else
                        MessageBox.Show("No se pudo abrir " + fm.LastOpenFilename);
                }
                else
                    MessageBox.Show("No se pudo abrir " + fm.LastOpenFilename);
            }
        }
    }
}
