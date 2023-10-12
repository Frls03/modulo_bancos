
namespace CapaVistaBancos
{
    partial class Menu_inicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bancosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosBancariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTipoDeMovimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarTransaccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conciliaciónBancariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disponibilidadYTipoDeCambioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorizaciónDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procesosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(995, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bancosToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // bancosToolStripMenuItem
            // 
            this.bancosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimientosBancariosToolStripMenuItem,
            this.conciliaciónBancariaToolStripMenuItem,
            this.disponibilidadYTipoDeCambioToolStripMenuItem,
            this.autorizaciónDeToolStripMenuItem});
            this.bancosToolStripMenuItem.Name = "bancosToolStripMenuItem";
            this.bancosToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.bancosToolStripMenuItem.Text = "Bancos";
            // 
            // movimientosBancariosToolStripMenuItem
            // 
            this.movimientosBancariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCuentaToolStripMenuItem,
            this.agregarTipoDeMovimientoToolStripMenuItem,
            this.ingresarTransaccionToolStripMenuItem});
            this.movimientosBancariosToolStripMenuItem.Name = "movimientosBancariosToolStripMenuItem";
            this.movimientosBancariosToolStripMenuItem.Size = new System.Drawing.Size(330, 26);
            this.movimientosBancariosToolStripMenuItem.Text = "Movimientos Bancarios";
            this.movimientosBancariosToolStripMenuItem.Click += new System.EventHandler(this.movimientosBancariosToolStripMenuItem_Click);
            // 
            // agregarCuentaToolStripMenuItem
            // 
            this.agregarCuentaToolStripMenuItem.Name = "agregarCuentaToolStripMenuItem";
            this.agregarCuentaToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.agregarCuentaToolStripMenuItem.Text = "Agregar cuenta";
            this.agregarCuentaToolStripMenuItem.Click += new System.EventHandler(this.agregarCuentaToolStripMenuItem_Click);
            // 
            // agregarTipoDeMovimientoToolStripMenuItem
            // 
            this.agregarTipoDeMovimientoToolStripMenuItem.Name = "agregarTipoDeMovimientoToolStripMenuItem";
            this.agregarTipoDeMovimientoToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.agregarTipoDeMovimientoToolStripMenuItem.Text = "Agregar tipo de movimiento";
            this.agregarTipoDeMovimientoToolStripMenuItem.Click += new System.EventHandler(this.agregarTipoDeMovimientoToolStripMenuItem_Click);
            // 
            // ingresarTransaccionToolStripMenuItem
            // 
            this.ingresarTransaccionToolStripMenuItem.Name = "ingresarTransaccionToolStripMenuItem";
            this.ingresarTransaccionToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.ingresarTransaccionToolStripMenuItem.Text = "Ingresar transaccion";
            this.ingresarTransaccionToolStripMenuItem.Click += new System.EventHandler(this.ingresarTransaccionToolStripMenuItem_Click);
            // 
            // conciliaciónBancariaToolStripMenuItem
            // 
            this.conciliaciónBancariaToolStripMenuItem.Name = "conciliaciónBancariaToolStripMenuItem";
            this.conciliaciónBancariaToolStripMenuItem.Size = new System.Drawing.Size(330, 26);
            this.conciliaciónBancariaToolStripMenuItem.Text = "Conciliación Bancaria";
            this.conciliaciónBancariaToolStripMenuItem.Click += new System.EventHandler(this.conciliaciónBancariaToolStripMenuItem_Click);
            // 
            // disponibilidadYTipoDeCambioToolStripMenuItem
            // 
            this.disponibilidadYTipoDeCambioToolStripMenuItem.Name = "disponibilidadYTipoDeCambioToolStripMenuItem";
            this.disponibilidadYTipoDeCambioToolStripMenuItem.Size = new System.Drawing.Size(330, 26);
            this.disponibilidadYTipoDeCambioToolStripMenuItem.Text = "Disponibilidad y Tipo De Cambio";
            this.disponibilidadYTipoDeCambioToolStripMenuItem.Click += new System.EventHandler(this.disponibilidadYTipoDeCambioToolStripMenuItem_Click);
            // 
            // autorizaciónDeToolStripMenuItem
            // 
            this.autorizaciónDeToolStripMenuItem.Name = "autorizaciónDeToolStripMenuItem";
            this.autorizaciónDeToolStripMenuItem.Size = new System.Drawing.Size(330, 26);
            this.autorizaciónDeToolStripMenuItem.Text = "Autorización de ordenes de compra";
            this.autorizaciónDeToolStripMenuItem.Click += new System.EventHandler(this.autorizaciónDeToolStripMenuItem_Click);
            // 
            // Menu_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 607);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_inicial";
            this.Text = "Menu_inicial";
            this.Load += new System.EventHandler(this.Menu_inicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bancosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosBancariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conciliaciónBancariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disponibilidadYTipoDeCambioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorizaciónDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarTipoDeMovimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarTransaccionToolStripMenuItem;
    }
}