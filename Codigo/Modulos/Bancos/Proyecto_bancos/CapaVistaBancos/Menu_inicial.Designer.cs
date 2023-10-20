
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_inicial));
            this.pnl_principal = new System.Windows.Forms.Panel();
            this.btn_ordCompras = new System.Windows.Forms.Button();
            this.btn_dispo = new System.Windows.Forms.Button();
            this.btn_cambio = new System.Windows.Forms.Button();
            this.btn_ConciliacionBancaria = new System.Windows.Forms.Button();
            this.btn_MovBancarios = new System.Windows.Forms.Button();
            this.pnl_logo = new System.Windows.Forms.Panel();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.btn_mantenimientos = new System.Windows.Forms.Button();
            this.pnl_subMenu_mantenimientos = new System.Windows.Forms.Panel();
            this.pnl_subMenu_movBancarios = new System.Windows.Forms.Panel();
            this.btn_mant_movBancarios = new System.Windows.Forms.Button();
            this.btn_agregarBanco = new System.Windows.Forms.Button();
            this.btn_agregarCuenta = new System.Windows.Forms.Button();
            this.btn_agregaMov = new System.Windows.Forms.Button();
            this.btn_mant_compras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_principal.SuspendLayout();
            this.pnl_logo.SuspendLayout();
            this.pnl_subMenu_mantenimientos.SuspendLayout();
            this.pnl_subMenu_movBancarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_principal
            // 
            this.pnl_principal.AutoScroll = true;
            this.pnl_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.pnl_principal.Controls.Add(this.pnl_subMenu_mantenimientos);
            this.pnl_principal.Controls.Add(this.btn_mantenimientos);
            this.pnl_principal.Controls.Add(this.btn_ordCompras);
            this.pnl_principal.Controls.Add(this.btn_dispo);
            this.pnl_principal.Controls.Add(this.btn_cambio);
            this.pnl_principal.Controls.Add(this.btn_ConciliacionBancaria);
            this.pnl_principal.Controls.Add(this.btn_MovBancarios);
            this.pnl_principal.Controls.Add(this.pnl_logo);
            this.pnl_principal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_principal.Location = new System.Drawing.Point(0, 0);
            this.pnl_principal.Name = "pnl_principal";
            this.pnl_principal.Size = new System.Drawing.Size(250, 1003);
            this.pnl_principal.TabIndex = 2;
            // 
            // btn_ordCompras
            // 
            this.btn_ordCompras.AutoSize = true;
            this.btn_ordCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_ordCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ordCompras.FlatAppearance.BorderSize = 0;
            this.btn_ordCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ordCompras.Image = global::CapaVistaBancos.Properties.Resources.purchase_order_48_45448;
            this.btn_ordCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ordCompras.Location = new System.Drawing.Point(0, 324);
            this.btn_ordCompras.Name = "btn_ordCompras";
            this.btn_ordCompras.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_ordCompras.Size = new System.Drawing.Size(250, 62);
            this.btn_ordCompras.TabIndex = 5;
            this.btn_ordCompras.Text = "        Autorización de ordenes de compras";
            this.btn_ordCompras.UseVisualStyleBackColor = false;
            this.btn_ordCompras.Click += new System.EventHandler(this.btn_mantenimientos_Click);
            // 
            // btn_dispo
            // 
            this.btn_dispo.AutoSize = true;
            this.btn_dispo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_dispo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dispo.FlatAppearance.BorderSize = 0;
            this.btn_dispo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dispo.Image = global::CapaVistaBancos.Properties.Resources.coin_currency_dollar_finance_money_payment_wallet_icon_123189;
            this.btn_dispo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dispo.Location = new System.Drawing.Point(0, 262);
            this.btn_dispo.Name = "btn_dispo";
            this.btn_dispo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_dispo.Size = new System.Drawing.Size(250, 62);
            this.btn_dispo.TabIndex = 4;
            this.btn_dispo.Text = "     Disponibilidad Diaria";
            this.btn_dispo.UseVisualStyleBackColor = false;
            this.btn_dispo.Click += new System.EventHandler(this.btn_ordCompras_Click);
            // 
            // btn_cambio
            // 
            this.btn_cambio.AutoSize = true;
            this.btn_cambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_cambio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cambio.FlatAppearance.BorderSize = 0;
            this.btn_cambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cambio.Image = global::CapaVistaBancos.Properties.Resources.bank_bill_finance_invoice_money_payment_receipt_icon_123239;
            this.btn_cambio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cambio.Location = new System.Drawing.Point(0, 200);
            this.btn_cambio.Name = "btn_cambio";
            this.btn_cambio.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_cambio.Size = new System.Drawing.Size(250, 62);
            this.btn_cambio.TabIndex = 3;
            this.btn_cambio.Text = "     Tipo de cambio";
            this.btn_cambio.UseVisualStyleBackColor = false;
            this.btn_cambio.Click += new System.EventHandler(this.btn_dispoycambio_Click);
            // 
            // btn_ConciliacionBancaria
            // 
            this.btn_ConciliacionBancaria.AutoSize = true;
            this.btn_ConciliacionBancaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_ConciliacionBancaria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ConciliacionBancaria.FlatAppearance.BorderSize = 0;
            this.btn_ConciliacionBancaria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConciliacionBancaria.Image = ((System.Drawing.Image)(resources.GetObject("btn_ConciliacionBancaria.Image")));
            this.btn_ConciliacionBancaria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ConciliacionBancaria.Location = new System.Drawing.Point(0, 150);
            this.btn_ConciliacionBancaria.Name = "btn_ConciliacionBancaria";
            this.btn_ConciliacionBancaria.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_ConciliacionBancaria.Size = new System.Drawing.Size(250, 50);
            this.btn_ConciliacionBancaria.TabIndex = 2;
            this.btn_ConciliacionBancaria.Text = "       Conciliación Bancaria";
            this.btn_ConciliacionBancaria.UseVisualStyleBackColor = false;
            this.btn_ConciliacionBancaria.Click += new System.EventHandler(this.btn_ConciliacionBancaria_Click);
            // 
            // btn_MovBancarios
            // 
            this.btn_MovBancarios.AutoSize = true;
            this.btn_MovBancarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_MovBancarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MovBancarios.FlatAppearance.BorderSize = 0;
            this.btn_MovBancarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MovBancarios.Image = ((System.Drawing.Image)(resources.GetObject("btn_MovBancarios.Image")));
            this.btn_MovBancarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MovBancarios.Location = new System.Drawing.Point(0, 100);
            this.btn_MovBancarios.Name = "btn_MovBancarios";
            this.btn_MovBancarios.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_MovBancarios.Size = new System.Drawing.Size(250, 50);
            this.btn_MovBancarios.TabIndex = 1;
            this.btn_MovBancarios.Text = "      Movimientos Bancarios";
            this.btn_MovBancarios.UseVisualStyleBackColor = false;
            this.btn_MovBancarios.Click += new System.EventHandler(this.btn_MovBancarios_Click);
            // 
            // pnl_logo
            // 
            this.pnl_logo.Controls.Add(this.label1);
            this.pnl_logo.Controls.Add(this.pictureBox1);
            this.pnl_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_logo.Location = new System.Drawing.Point(0, 0);
            this.pnl_logo.Name = "pnl_logo";
            this.pnl_logo.Size = new System.Drawing.Size(250, 100);
            this.pnl_logo.TabIndex = 0;
            // 
            // btn_mantenimientos
            // 
            this.btn_mantenimientos.AutoSize = true;
            this.btn_mantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btn_mantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_mantenimientos.FlatAppearance.BorderSize = 0;
            this.btn_mantenimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mantenimientos.Image = ((System.Drawing.Image)(resources.GetObject("btn_mantenimientos.Image")));
            this.btn_mantenimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mantenimientos.Location = new System.Drawing.Point(0, 386);
            this.btn_mantenimientos.Name = "btn_mantenimientos";
            this.btn_mantenimientos.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_mantenimientos.Size = new System.Drawing.Size(250, 62);
            this.btn_mantenimientos.TabIndex = 6;
            this.btn_mantenimientos.Text = "  Mantenimientos";
            this.btn_mantenimientos.UseVisualStyleBackColor = false;
            this.btn_mantenimientos.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_subMenu_mantenimientos
            // 
            this.pnl_subMenu_mantenimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(219)))), ((int)(((byte)(200)))));
            this.pnl_subMenu_mantenimientos.Controls.Add(this.btn_mant_compras);
            this.pnl_subMenu_mantenimientos.Controls.Add(this.pnl_subMenu_movBancarios);
            this.pnl_subMenu_mantenimientos.Controls.Add(this.btn_mant_movBancarios);
            this.pnl_subMenu_mantenimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_subMenu_mantenimientos.Location = new System.Drawing.Point(0, 448);
            this.pnl_subMenu_mantenimientos.Name = "pnl_subMenu_mantenimientos";
            this.pnl_subMenu_mantenimientos.Size = new System.Drawing.Size(250, 266);
            this.pnl_subMenu_mantenimientos.TabIndex = 7;
            // 
            // pnl_subMenu_movBancarios
            // 
            this.pnl_subMenu_movBancarios.Controls.Add(this.btn_agregaMov);
            this.pnl_subMenu_movBancarios.Controls.Add(this.btn_agregarCuenta);
            this.pnl_subMenu_movBancarios.Controls.Add(this.btn_agregarBanco);
            this.pnl_subMenu_movBancarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_subMenu_movBancarios.Location = new System.Drawing.Point(0, 50);
            this.pnl_subMenu_movBancarios.Name = "pnl_subMenu_movBancarios";
            this.pnl_subMenu_movBancarios.Size = new System.Drawing.Size(250, 149);
            this.pnl_subMenu_movBancarios.TabIndex = 0;
            // 
            // btn_mant_movBancarios
            // 
            this.btn_mant_movBancarios.AutoSize = true;
            this.btn_mant_movBancarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(236)))));
            this.btn_mant_movBancarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_mant_movBancarios.FlatAppearance.BorderSize = 0;
            this.btn_mant_movBancarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mant_movBancarios.Image = ((System.Drawing.Image)(resources.GetObject("btn_mant_movBancarios.Image")));
            this.btn_mant_movBancarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mant_movBancarios.Location = new System.Drawing.Point(0, 0);
            this.btn_mant_movBancarios.Name = "btn_mant_movBancarios";
            this.btn_mant_movBancarios.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_mant_movBancarios.Size = new System.Drawing.Size(250, 50);
            this.btn_mant_movBancarios.TabIndex = 2;
            this.btn_mant_movBancarios.Text = "      Movimientos Bancarios";
            this.btn_mant_movBancarios.UseVisualStyleBackColor = false;
            this.btn_mant_movBancarios.Click += new System.EventHandler(this.btn_mant_movBancarios_Click_2);
            // 
            // btn_agregarBanco
            // 
            this.btn_agregarBanco.AutoSize = true;
            this.btn_agregarBanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.btn_agregarBanco.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_agregarBanco.FlatAppearance.BorderSize = 0;
            this.btn_agregarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarBanco.Image = global::CapaVistaBancos.Properties.Resources.building_icon_255880;
            this.btn_agregarBanco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregarBanco.Location = new System.Drawing.Point(0, 0);
            this.btn_agregarBanco.Name = "btn_agregarBanco";
            this.btn_agregarBanco.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_agregarBanco.Size = new System.Drawing.Size(250, 50);
            this.btn_agregarBanco.TabIndex = 3;
            this.btn_agregarBanco.Text = "      Agregar Bancos";
            this.btn_agregarBanco.UseVisualStyleBackColor = false;
            this.btn_agregarBanco.Click += new System.EventHandler(this.btn_agregarBanco_Click);
            // 
            // btn_agregarCuenta
            // 
            this.btn_agregarCuenta.AutoSize = true;
            this.btn_agregarCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.btn_agregarCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_agregarCuenta.FlatAppearance.BorderSize = 0;
            this.btn_agregarCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarCuenta.Image = global::CapaVistaBancos.Properties.Resources.piggy_bank_icon_icons_com_65003;
            this.btn_agregarCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregarCuenta.Location = new System.Drawing.Point(0, 50);
            this.btn_agregarCuenta.Name = "btn_agregarCuenta";
            this.btn_agregarCuenta.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_agregarCuenta.Size = new System.Drawing.Size(250, 50);
            this.btn_agregarCuenta.TabIndex = 4;
            this.btn_agregarCuenta.Text = "      Agregar Cuenta";
            this.btn_agregarCuenta.UseVisualStyleBackColor = false;
            this.btn_agregarCuenta.Click += new System.EventHandler(this.btn_agregarCuenta_Click);
            // 
            // btn_agregaMov
            // 
            this.btn_agregaMov.AutoSize = true;
            this.btn_agregaMov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(243)))), ((int)(((byte)(242)))));
            this.btn_agregaMov.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_agregaMov.FlatAppearance.BorderSize = 0;
            this.btn_agregaMov.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregaMov.Image = global::CapaVistaBancos.Properties.Resources.transfer_icon_icons_com_64677;
            this.btn_agregaMov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregaMov.Location = new System.Drawing.Point(0, 100);
            this.btn_agregaMov.Name = "btn_agregaMov";
            this.btn_agregaMov.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_agregaMov.Size = new System.Drawing.Size(250, 50);
            this.btn_agregaMov.TabIndex = 5;
            this.btn_agregaMov.Text = "      Agregar Movimiento";
            this.btn_agregaMov.UseVisualStyleBackColor = false;
            this.btn_agregaMov.Click += new System.EventHandler(this.btn_agregaMov_Click);
            // 
            // btn_mant_compras
            // 
            this.btn_mant_compras.AutoSize = true;
            this.btn_mant_compras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(236)))));
            this.btn_mant_compras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_mant_compras.FlatAppearance.BorderSize = 0;
            this.btn_mant_compras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mant_compras.Image = global::CapaVistaBancos.Properties.Resources.purchase_order_48_45448;
            this.btn_mant_compras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mant_compras.Location = new System.Drawing.Point(0, 199);
            this.btn_mant_compras.Name = "btn_mant_compras";
            this.btn_mant_compras.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_mant_compras.Size = new System.Drawing.Size(250, 62);
            this.btn_mant_compras.TabIndex = 6;
            this.btn_mant_compras.Text = "        Autorización de ordenes de compras";
            this.btn_mant_compras.UseVisualStyleBackColor = false;
            this.btn_mant_compras.Click += new System.EventHandler(this.btn_mant_compras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bancos";
            // 
            // Menu_inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.ClientSize = new System.Drawing.Size(1182, 1003);
            this.Controls.Add(this.pnl_principal);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu_inicial";
            this.Text = "Menu_inicial";
            this.Load += new System.EventHandler(this.Menu_inicial_Load);
            this.pnl_principal.ResumeLayout(false);
            this.pnl_principal.PerformLayout();
            this.pnl_logo.ResumeLayout(false);
            this.pnl_logo.PerformLayout();
            this.pnl_subMenu_mantenimientos.ResumeLayout(false);
            this.pnl_subMenu_mantenimientos.PerformLayout();
            this.pnl_subMenu_movBancarios.ResumeLayout(false);
            this.pnl_subMenu_movBancarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_principal;
        private System.Windows.Forms.Panel pnl_logo;
        private System.Windows.Forms.Button btn_MovBancarios;
        private System.Windows.Forms.Button btn_ordCompras;
        private System.Windows.Forms.Button btn_dispo;
        private System.Windows.Forms.Button btn_cambio;
        private System.Windows.Forms.Button btn_ConciliacionBancaria;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button btn_mantenimientos;
        private System.Windows.Forms.Panel pnl_subMenu_mantenimientos;
        private System.Windows.Forms.Button btn_mant_compras;
        private System.Windows.Forms.Panel pnl_subMenu_movBancarios;
        private System.Windows.Forms.Button btn_agregaMov;
        private System.Windows.Forms.Button btn_agregarCuenta;
        private System.Windows.Forms.Button btn_agregarBanco;
        private System.Windows.Forms.Button btn_mant_movBancarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}