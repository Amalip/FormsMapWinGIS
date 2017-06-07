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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 439);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AxMapi);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AxMapi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxMapWinGIS.AxMap AxMapi;
        private System.Windows.Forms.OpenFileDialog openFD;
        private System.Windows.Forms.Button button1;
    }
}

