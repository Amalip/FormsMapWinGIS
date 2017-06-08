namespace FormMapWinGis
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AxMapi = new AxMapWinGIS.AxMap();
            this.openFD = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.chkLstBoxCapas = new System.Windows.Forms.CheckedListBox();
            this.cmbCursosrMode = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AxMapi)).BeginInit();
            this.SuspendLayout();
            // 
            // AxMapi
            // 
            this.AxMapi.Enabled = true;
            this.AxMapi.Location = new System.Drawing.Point(150, 12);
            this.AxMapi.Name = "AxMapi";
            this.AxMapi.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AxMapi.OcxState")));
            this.AxMapi.Size = new System.Drawing.Size(622, 415);
            this.AxMapi.TabIndex = 0;
            this.AxMapi.MouseDownEvent += new AxMapWinGIS._DMapEvents_MouseDownEventHandler(this.AxMapi_MouseDownEvent_1);
            // 
            // openFD
            // 
            this.openFD.Filter = "DBF |*.dbf|SHP|*.shp|SHX|*.shx";
            this.openFD.Multiselect = true;
            this.openFD.FileOk += new System.ComponentModel.CancelEventHandler(this.openFD_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkLstBoxCapas
            // 
            this.chkLstBoxCapas.CheckOnClick = true;
            this.chkLstBoxCapas.FormattingEnabled = true;
            this.chkLstBoxCapas.Location = new System.Drawing.Point(12, 123);
            this.chkLstBoxCapas.Name = "chkLstBoxCapas";
            this.chkLstBoxCapas.Size = new System.Drawing.Size(120, 214);
            this.chkLstBoxCapas.TabIndex = 2;
            this.chkLstBoxCapas.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkLstBoxCapas_ItemCheck);
            // 
            // cmbCursosrMode
            // 
            this.cmbCursosrMode.FormattingEnabled = true;
            this.cmbCursosrMode.Items.AddRange(new object[] {
            "Pan",
            "ZoomIn",
            "ZoomOut",
            "Identify"});
            this.cmbCursosrMode.Location = new System.Drawing.Point(11, 96);
            this.cmbCursosrMode.Name = "cmbCursosrMode";
            this.cmbCursosrMode.Size = new System.Drawing.Size(121, 21);
            this.cmbCursosrMode.TabIndex = 4;
            this.cmbCursosrMode.SelectedIndexChanged += new System.EventHandler(this.cmbCursosrMode_SelectedIndexChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "DBF |*.dbf|SHP|*.shp|SHX|*.shx";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(33, 42);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cursor Mode";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbCursosrMode);
            this.Controls.Add(this.chkLstBoxCapas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AxMapi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AxMapi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxMapWinGIS.AxMap AxMapi;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox chkLstBoxCapas;
        private System.Windows.Forms.ComboBox cmbCursosrMode;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
    }
}

