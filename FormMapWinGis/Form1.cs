using AxMapWinGIS;
using MapWinGIS;
using System;
using System.ComponentModel;
using System.IO;
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
        private int m_layerHandle = -1;
        void GetMap()
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
            int i;
            for (i = 0; i < openFD.FileNames.Length; i++)
            {
                bool canAdd = true;
                for (int j = 0; j < chkLstBoxCapas.Items.Count; j++)
                {
                    if (openFD.SafeFileNames[i].Equals(chkLstBoxCapas.Items[j].ToString()))
                    {
                        canAdd = false;
                        break;
                    }
                }
                if (canAdd) AddLayer(i);
            }
        }

        public void AddLayer(int i)
        {
            AxMapi.Projection = tkMapProjection.PROJECTION_NONE;
            var fm = new FileManager();
            var obj = fm.Open(openFD.FileNames[i], tkFileOpenStrategy.fosAutoDetect, null);
            if (obj != null && fm.LastOpenIsSuccess)
            {
                int handle = AxMapi.AddLayer(obj, true);
                m_layerHandle = AxMapi.AddLayer(obj, true);
                if (handle != -1)
                {
                    chkLstBoxCapas.Items.Add(openFD.SafeFileNames[i]);
                    chkLstBoxCapas.SetItemCheckState(chkLstBoxCapas.Items.Count - 1, CheckState.Checked);
                }
                else
                    MessageBox.Show("No se pudo abrir " + openFD.SafeFileNames[i]);
            }
            else
                MessageBox.Show("No se pudo abrir " + openFD.SafeFileNames[i]);
        }



        private void chkLstBoxCapas_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Unchecked)
                AxMapi.set_LayerVisible(e.Index, false);
            else
                AxMapi.set_LayerVisible(e.Index, true);
        }

        private void cmbCursosrMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbCursosrMode.SelectedIndex)
            {
                case 0:
                    AxMapi.CursorMode = tkCursorMode.cmPan;
                    break;
                case 1:
                    AxMapi.CursorMode = tkCursorMode.cmZoomIn;
                    break;
                case 2:
                    AxMapi.CursorMode = tkCursorMode.cmZoomOut;
                    break;
                case 3:
                    AxMapi.CursorMode = tkCursorMode.cmIdentify;
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            AxMapi.SaveLayerOptions(0, saveFileDialog1.FileName, true, "Test");
            //AxMapi.SaveMapState(saveFileDialog1.FileName, false, false);
        }
        private void AxMapi_MouseDownEvent_1(object sender, _DMapEvents_MouseDownEvent e)
        {
           
        }



    }
}