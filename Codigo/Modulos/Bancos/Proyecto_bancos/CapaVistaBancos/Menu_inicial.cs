using System;
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
            if (subMenu.Visible == false)
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


        private void btn_MovBancarios_Click(object sender, EventArgs e)
        {
            Mov_bancarios nmov = new Mov_bancarios();
            nmov.MdiParent = this;
            nmov.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void btn_mantenimientos_Click(object sender, EventArgs e)
        {
            Ordenes_compra norden = new Ordenes_compra();
            norden.MdiParent = this;
            norden.Show();
        }



        private void btn_dispoycambio_Click(object sender, EventArgs e)
        {
            Tipo_cambio ntipoc = new Tipo_cambio();
            ntipoc.MdiParent = this;
            ntipoc.Show();
        }

        private void btn_ConciliacionBancaria_Click(object sender, EventArgs e)
        {
            Con_bancaria ncon = new Con_bancaria();
            ncon.MdiParent = this;
            ncon.Show();
        }

        private void btn_ordCompras_Click(object sender, EventArgs e)
        {
            Dispo_diaria ndispo = new Dispo_diaria();
            ndispo.MdiParent = this;
            ndispo.Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(pnl_subMenu_mantenimientos);
        }

        private void btn_mant_movBancarios_Click_2(object sender, EventArgs e)
        {
            showsubMenu2(pnl_subMenu_movBancarios);
        }

        private void btn_agregarBanco_Click(object sender, EventArgs e)
        {
            Mantenimiento_Agregar_Bancos nbanco = new Mantenimiento_Agregar_Bancos();
            nbanco.MdiParent = this;
            nbanco.Show();
        }

        private void btn_agregarCuenta_Click(object sender, EventArgs e)
        {
            Mantenimiento_agregar_cuenta ncuenta = new Mantenimiento_agregar_cuenta();
            ncuenta.MdiParent = this;
            ncuenta.Show();
        }

        private void btn_agregaMov_Click(object sender, EventArgs e)
        {
            Mantenimiento_tipoMov ntipo = new Mantenimiento_tipoMov();
            ntipo.MdiParent = this;
            ntipo.Show();
        }

        private void btn_mant_compras_Click(object sender, EventArgs e)
        {
            Mantenimiento_OrdenesdeCompra nordenc = new Mantenimiento_OrdenesdeCompra();
            nordenc.MdiParent = this;
            nordenc.Show();
        }
    }
}
