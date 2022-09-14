namespace Navegator
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnAtras = new System.Windows.Forms.ToolStripButton();
            this.btnDelanten = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.texBuscador = new System.Windows.Forms.ToolStripTextBox();
            this.btnGo = new System.Windows.Forms.ToolStripButton();
            this.combfavoritos = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAtras,
            this.btnDelanten,
            this.toolStripButton1,
            this.toolStripButton2,
            this.texBuscador,
            this.btnGo,
            this.combfavoritos,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(901, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(901, 413);
            this.webBrowser1.TabIndex = 1;
            // 
            // btnAtras
            // 
            this.btnAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(23, 22);
            this.btnAtras.Text = "toolStripButton1";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnDelanten
            // 
            this.btnDelanten.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelanten.Image = ((System.Drawing.Image)(resources.GetObject("btnDelanten.Image")));
            this.btnDelanten.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelanten.Name = "btnDelanten";
            this.btnDelanten.Size = new System.Drawing.Size(23, 22);
            this.btnDelanten.Text = "toolStripButton2";
            this.btnDelanten.Click += new System.EventHandler(this.btnDelanten_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "btnActualizar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "btnHome";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // texBuscador
            // 
            this.texBuscador.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.texBuscador.Name = "texBuscador";
            this.texBuscador.Size = new System.Drawing.Size(600, 25);
            // 
            // btnGo
            // 
            this.btnGo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGo.Image = ((System.Drawing.Image)(resources.GetObject("btnGo.Image")));
            this.btnGo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(23, 22);
            this.btnGo.Text = "toolStripButton3";
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // combfavoritos
            // 
            this.combfavoritos.Name = "combfavoritos";
            this.combfavoritos.Size = new System.Drawing.Size(121, 25);
            this.combfavoritos.SelectedIndexChanged += new System.EventHandler(this.combfavoritos_SelectedIndexChanged);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "btnFavoritos";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 438);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "EL FINAL";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAtras;
        private System.Windows.Forms.ToolStripButton btnDelanten;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripTextBox texBuscador;
        private System.Windows.Forms.ToolStripButton btnGo;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripComboBox combfavoritos;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}

