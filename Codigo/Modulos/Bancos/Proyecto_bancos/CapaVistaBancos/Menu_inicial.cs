using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaBancos
{
    public partial class Menu_inicial : Form
    {
        public Menu_inicial()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void disponibilidadYTipoDeCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            Tipo_cambio ndispo = new Tipo_cambio();
            ndispo.MdiParent = this;
            ndispo.Show();
>>>>>>> 85db71d3da07734bc6d4d3e087a3545e54f45462
        }

        private void movimientosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void conciliaciónBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void autorizaciónDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_inicial_Load(object sender, EventArgs e)
        {

        }
        private void customizeDesign()
        {
            pnl_subMenu_mantenimientos.Visible = false;
            pnl_subMenu_movBancarios.Visible = false;
        }
        private void hideSubMenu1()
        {
            if (pnl_subMenu_mantenimientos.Visible == true)
            {
                pnl_subMenu_mantenimientos.Visible = false;
            }

        }
        private void hideSubMenu2()
        {
            if (pnl_subMenu_movBancarios.Visible == true)
            {
                pnl_subMenu_movBancarios.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible ==false)
            {
                hideSubMenu1();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        private void showsubMenu2(Panel subMenu2)
        {
            if (subMenu2.Visible == false)
            {
                hideSubMenu2();
                subMenu2.Visible = true;
            }
            else
            {
                subMenu2.Visible = false;
            }
        }
        private void agregarCuentaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarTipoDeMovimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresarTransaccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_MovBancarios_Click(object sender, EventArgs e)
        {
            Mov_bancarios nmov = new Mov_bancarios();
            nmov.MdiParent = this;
            nmov.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_mant_movbancarios_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_mantenimientos_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_subMenu_mantenimientos);
        }

        private void btn_mant_movbancarios_Click_1(object sender, EventArgs e)
        {
            showsubMenu2(pnl_subMenu_movBancarios);
        }

        private void btn_dispoycambio_Click(object sender, EventArgs e)
        {
            Dispo_tcambio ndispo = new Dispo_tcambio();
            ndispo.MdiParent = this;
            ndispo.Show();
        }

        private void btn_ConciliacionBancaria_Click(object sender, EventArgs e)
        {
            Con_bancaria ncon = new Con_bancaria();
            ncon.MdiParent = this;
            ncon.Show();
        }

        private void btn_ordCompras_Click(object sender, EventArgs e)
        {
            Ordenes_compra nordenes = new Ordenes_compra();
            nordenes.MdiParent = this;
            nordenes.Show();
        }

        private void btn_agregarBancos_Click(object sender, EventArgs e)
        {
            Mantenimiento_Agregar_Bancos nbanco = new Mantenimiento_Agregar_Bancos();
            nbanco.MdiParent = this;
            nbanco.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mantenimiento_tipoMov ntipo = new Mantenimiento_tipoMov();
            ntipo.MdiParent = this;
            ntipo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mantenimiento_agregar_cuenta ncuenta = new Mantenimiento_agregar_cuenta();
            ncuenta.MdiParent = this;
            ncuenta.Show();
        }

        private void btn_mant_ordencompras_Click(object sender, EventArgs e)
        {
            Mantenimiento_OrdenesdeCompra nordenc = new Mantenimiento_OrdenesdeCompra();
            nordenc.MdiParent = this;
            nordenc.Show();
        }
    }
}
