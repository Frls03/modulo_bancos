
namespace CapaVistaBancos
{
    partial class Con_bancaria
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
            this.txt_saldoinicial = new System.Windows.Forms.TextBox();
            this.lbl_saldoinicial = new System.Windows.Forms.Label();
            this.lbl_valbanco = new System.Windows.Forms.Label();
            this.lbl_titulobanco = new System.Windows.Forms.Label();
            this.lbl_vallibro = new System.Windows.Forms.Label();
            this.lbl_titulolibbanco = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rb_incorrecta = new System.Windows.Forms.RadioButton();
            this.rb_correcta = new System.Windows.Forms.RadioButton();
            this.btn_conciliar = new System.Windows.Forms.Button();
            this.lbl_tipopago = new System.Windows.Forms.Label();
            this.cbTipoPago = new System.Windows.Forms.ComboBox();
            this.txt_banco = new System.Windows.Forms.TextBox();
            this.lbl_banco = new System.Windows.Forms.Label();
            this.txt_cuenta = new System.Windows.Forms.ComboBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.txt_transaccion = new System.Windows.Forms.TextBox();
            this.lbl_cuenta = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.lbl_notransaccion = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_saldoinicial
            // 
            this.txt_saldoinicial.Location = new System.Drawing.Point(140, 55);
            this.txt_saldoinicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_saldoinicial.Name = "txt_saldoinicial";
            this.txt_saldoinicial.Size = new System.Drawing.Size(249, 22);
            this.txt_saldoinicial.TabIndex = 58;
            // 
            // lbl_saldoinicial
            // 
            this.lbl_saldoinicial.AutoSize = true;
            this.lbl_saldoinicial.Location = new System.Drawing.Point(20, 59);
            this.lbl_saldoinicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_saldoinicial.Name = "lbl_saldoinicial";
            this.lbl_saldoinicial.Size = new System.Drawing.Size(112, 17);
            this.lbl_saldoinicial.TabIndex = 57;
            this.lbl_saldoinicial.Text = "Saldo Inicial (Q.)";
            // 
            // lbl_valbanco
            // 
            this.lbl_valbanco.AutoSize = true;
            this.lbl_valbanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valbanco.Location = new System.Drawing.Point(884, 686);
            this.lbl_valbanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_valbanco.Name = "lbl_valbanco";
            this.lbl_valbanco.Size = new System.Drawing.Size(66, 29);
            this.lbl_valbanco.TabIndex = 56;
            this.lbl_valbanco.Text = "0.00";
            // 
            // lbl_titulobanco
            // 
            this.lbl_titulobanco.AutoSize = true;
            this.lbl_titulobanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulobanco.Location = new System.Drawing.Point(604, 686);
            this.lbl_titulobanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulobanco.Name = "lbl_titulobanco";
            this.lbl_titulobanco.Size = new System.Drawing.Size(255, 29);
            this.lbl_titulobanco.TabIndex = 55;
            this.lbl_titulobanco.Text = "Saldo Total(Banco):";
            // 
            // lbl_vallibro
            // 
            this.lbl_vallibro.AutoSize = true;
            this.lbl_vallibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vallibro.Location = new System.Drawing.Point(372, 686);
            this.lbl_vallibro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vallibro.Name = "lbl_vallibro";
            this.lbl_vallibro.Size = new System.Drawing.Size(66, 29);
            this.lbl_vallibro.TabIndex = 54;
            this.lbl_vallibro.Text = "0.00";
            // 
            // lbl_titulolibbanco
            // 
            this.lbl_titulolibbanco.AutoSize = true;
            this.lbl_titulolibbanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulolibbanco.Location = new System.Drawing.Point(19, 686);
            this.lbl_titulolibbanco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulolibbanco.Name = "lbl_titulolibbanco";
            this.lbl_titulolibbanco.Size = new System.Drawing.Size(335, 29);
            this.lbl_titulolibbanco.TabIndex = 53;
            this.lbl_titulolibbanco.Text = "Saldo Total(Libro bancos):";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(19, 459);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(937, 223);
            this.dataGridView2.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 240);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(940, 212);
            this.dataGridView1.TabIndex = 51;
            // 
            // rb_incorrecta
            // 
            this.rb_incorrecta.AutoSize = true;
            this.rb_incorrecta.Location = new System.Drawing.Point(661, 114);
            this.rb_incorrecta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_incorrecta.Name = "rb_incorrecta";
            this.rb_incorrecta.Size = new System.Drawing.Size(141, 21);
            this.rb_incorrecta.TabIndex = 50;
            this.rb_incorrecta.TabStop = true;
            this.rb_incorrecta.Text = "Cuenta Incorrecta";
            this.rb_incorrecta.UseVisualStyleBackColor = true;
            // 
            // rb_correcta
            // 
            this.rb_correcta.AutoSize = true;
            this.rb_correcta.Location = new System.Drawing.Point(485, 114);
            this.rb_correcta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rb_correcta.Name = "rb_correcta";
            this.rb_correcta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_correcta.Size = new System.Drawing.Size(130, 21);
            this.rb_correcta.TabIndex = 49;
            this.rb_correcta.TabStop = true;
            this.rb_correcta.Text = "Cuenta correcta";
            this.rb_correcta.UseVisualStyleBackColor = true;
            // 
            // btn_conciliar
            // 
            this.btn_conciliar.Location = new System.Drawing.Point(485, 143);
            this.btn_conciliar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_conciliar.Name = "btn_conciliar";
            this.btn_conciliar.Size = new System.Drawing.Size(323, 43);
            this.btn_conciliar.TabIndex = 48;
            this.btn_conciliar.Text = "Conciliar";
            this.btn_conciliar.UseVisualStyleBackColor = true;
            // 
            // lbl_tipopago
            // 
            this.lbl_tipopago.AutoSize = true;
            this.lbl_tipopago.Location = new System.Drawing.Point(481, 71);
            this.lbl_tipopago.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tipopago.Name = "lbl_tipopago";
            this.lbl_tipopago.Size = new System.Drawing.Size(72, 17);
            this.lbl_tipopago.TabIndex = 47;
            this.lbl_tipopago.Text = "Tipo pago";
            // 
            // cbTipoPago
            // 
            this.cbTipoPago.FormattingEnabled = true;
            this.cbTipoPago.Location = new System.Drawing.Point(563, 68);
            this.cbTipoPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTipoPago.Name = "cbTipoPago";
            this.cbTipoPago.Size = new System.Drawing.Size(244, 24);
            this.cbTipoPago.TabIndex = 46;
            // 
            // txt_banco
            // 
            this.txt_banco.Location = new System.Drawing.Point(140, 190);
            this.txt_banco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_banco.Name = "txt_banco";
            this.txt_banco.Size = new System.Drawing.Size(249, 22);
            this.txt_banco.TabIndex = 45;
            // 
            // lbl_banco
            // 
            this.lbl_banco.AutoSize = true;
            this.lbl_banco.Location = new System.Drawing.Point(25, 190);
            this.lbl_banco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_banco.Name = "lbl_banco";
            this.lbl_banco.Size = new System.Drawing.Size(48, 17);
            this.lbl_banco.TabIndex = 44;
            this.lbl_banco.Text = "Banco";
            // 
            // txt_cuenta
            // 
            this.txt_cuenta.FormattingEnabled = true;
            this.txt_cuenta.Location = new System.Drawing.Point(140, 153);
            this.txt_cuenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cuenta.Name = "txt_cuenta";
            this.txt_cuenta.Size = new System.Drawing.Size(249, 24);
            this.txt_cuenta.TabIndex = 43;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(140, 121);
            this.txt_valor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(249, 22);
            this.txt_valor.TabIndex = 42;
            // 
            // txt_transaccion
            // 
            this.txt_transaccion.Location = new System.Drawing.Point(140, 87);
            this.txt_transaccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_transaccion.Name = "txt_transaccion";
            this.txt_transaccion.Size = new System.Drawing.Size(249, 22);
            this.txt_transaccion.TabIndex = 41;
            this.txt_transaccion.Tag = "noTransaccion";
            // 
            // lbl_cuenta
            // 
            this.lbl_cuenta.AutoSize = true;
            this.lbl_cuenta.Location = new System.Drawing.Point(25, 156);
            this.lbl_cuenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cuenta.Name = "lbl_cuenta";
            this.lbl_cuenta.Size = new System.Drawing.Size(53, 17);
            this.lbl_cuenta.TabIndex = 40;
            this.lbl_cuenta.Text = "Cuenta";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(25, 124);
            this.lbl_valor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(41, 17);
            this.lbl_valor.TabIndex = 39;
            this.lbl_valor.Text = "Valor";
            // 
            // lbl_notransaccion
            // 
            this.lbl_notransaccion.AutoSize = true;
            this.lbl_notransaccion.Location = new System.Drawing.Point(25, 91);
            this.lbl_notransaccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_notransaccion.Name = "lbl_notransaccion";
            this.lbl_notransaccion.Size = new System.Drawing.Size(104, 17);
            this.lbl_notransaccion.TabIndex = 38;
            this.lbl_notransaccion.Text = "NoTransaccion";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.Location = new System.Drawing.Point(0, 2);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(977, 44);
            this.lbl_titulo.TabIndex = 37;
            this.lbl_titulo.Text = "Conciliacion Bancaria";
            this.lbl_titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Con_bancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(161)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(979, 727);
            this.Controls.Add(this.txt_saldoinicial);
            this.Controls.Add(this.lbl_saldoinicial);
            this.Controls.Add(this.lbl_valbanco);
            this.Controls.Add(this.lbl_titulobanco);
            this.Controls.Add(this.lbl_vallibro);
            this.Controls.Add(this.lbl_titulolibbanco);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rb_incorrecta);
            this.Controls.Add(this.rb_correcta);
            this.Controls.Add(this.btn_conciliar);
            this.Controls.Add(this.lbl_tipopago);
            this.Controls.Add(this.cbTipoPago);
            this.Controls.Add(this.txt_banco);
            this.Controls.Add(this.lbl_banco);
            this.Controls.Add(this.txt_cuenta);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_transaccion);
            this.Controls.Add(this.lbl_cuenta);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_notransaccion);
            this.Controls.Add(this.lbl_titulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Con_bancaria";
            this.Text = "Con_bancaria";
            this.Load += new System.EventHandler(this.Con_bancaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_saldoinicial;
        private System.Windows.Forms.Label lbl_saldoinicial;
        private System.Windows.Forms.Label lbl_valbanco;
        private System.Windows.Forms.Label lbl_titulobanco;
        private System.Windows.Forms.Label lbl_vallibro;
        private System.Windows.Forms.Label lbl_titulolibbanco;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rb_incorrecta;
        private System.Windows.Forms.RadioButton rb_correcta;
        private System.Windows.Forms.Button btn_conciliar;
        private System.Windows.Forms.Label lbl_tipopago;
        private System.Windows.Forms.ComboBox cbTipoPago;
        private System.Windows.Forms.TextBox txt_banco;
        private System.Windows.Forms.Label lbl_banco;
        private System.Windows.Forms.ComboBox txt_cuenta;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox txt_transaccion;
        private System.Windows.Forms.Label lbl_cuenta;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Label lbl_notransaccion;
        private System.Windows.Forms.Label lbl_titulo;
    }
}