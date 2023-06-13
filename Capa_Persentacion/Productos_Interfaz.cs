using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Agregar librerias necesarias
using Capa_Logica_de_Negocio;
using System.Drawing;
using System.Runtime.InteropServices;


namespace Capa_Persentacion
{
    public partial class Productos_Interfaz : Form
    {
        #region Objetos y variables
        
        private CLN_Productos cln_producto_Objeto = new CLN_Productos();
        private String id_producto = null;
        private bool Editar = false;
        #endregion

        #region Métodos
        public Productos_Interfaz()
        {
            InitializeComponent();
        }

        private void RatonEnter(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            boton.FlatAppearance.BorderColor = Color.Orange;
            boton.FlatAppearance.BorderSize = 3;
            boton.BackColor = Color.White;
            boton.ForeColor = Color.Orange;
        }

        private void RatonLeave(object sender, EventArgs e)
        {
            //if(!pbx_Minimizar_Principal.Bounds.Contains(this.PointToClient(Cursor.Position)))
            //{
            //    lb_minimizar_Principal.Visible = false;
            //}
            //else { }

            var boton = (Button)sender;
            boton.FlatAppearance.BorderColor = Color.Black;
            boton.FlatAppearance.BorderSize = 2;
            boton.BackColor = Color.DeepSkyBlue;
            boton.ForeColor = Color.Black;
            
        }

        private void RatonEnterImage(object sender, EventArgs e)
        {
            var pBox = (PictureBox)sender;

            if (pBox == pbx_Minimizar_Principal)
            {
                lb_minimizar_Principal.Visible = true;
            }
            else
            {
                pbx_cerrar_Principal.Image = Image.FromFile(@"C:\Users\admin\source\repos\Registro_NCapas_CRUD_POO_SQL\Capa_Persentacion\Resources\x red.png");
                            lb_cerrar_Principal.Visible = true;
            }
            
        }

        private void RatonLeaveImage(object sender, EventArgs e)
        {
            var pBox = (PictureBox)sender;
            if (pBox == pbx_Minimizar_Principal)
            {
                lb_minimizar_Principal.Visible = false;
            } 
            else
                pbx_cerrar_Principal.Image = Image.FromFile(@"C:\Users\admin\source\repos\Registro_NCapas_CRUD_POO_SQL\Capa_Persentacion\Resources\cerrar.png");
                lb_cerrar_Principal.Visible = false;           
        }



        private void Productos_Interfaz_Load(object sender, EventArgs e)
        {
            MostrarProductosInterfaz();
        }

        private void MostrarProductosInterfaz()
        {           
            CLN_Productos cln_producto_Objeto = new CLN_Productos();
            dtgViewProductos.DataSource = cln_producto_Objeto.MostrarProducto();

            dtgViewProductos.Columns[2].HeaderText = "Id Producto";
            dtgViewProductos.Columns[3].HeaderText = "Nombre";
            dtgViewProductos.Columns[4].HeaderText = "Descripción";
            dtgViewProductos.Columns[5].HeaderText = "Marca";
            dtgViewProductos.Columns[6].HeaderText = "Precio";
            dtgViewProductos.Columns[7].HeaderText = "Stock";
            dtgViewProductos.ClearSelection();
        }
        #endregion

        private void btn_guardar_Principal_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if(Editar == false)
            {
                try
                {
                    cln_producto_Objeto.InsertarProducto(txt_nombre_Prin.Text, txt_descripcion_Prin.Text, txt_marca_Prin.Text, txt_precio_Prin.Text, txt_stock_Prin.Text);
                    //MessageBox.Show("\"Se agrego correctamente\"");
                    MostrarProductosInterfaz();
                    LimpiarCamposInterfaz();
                    
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("No se pudo agregar el producto por: " + ex);
                    MessageBox.Show(ex.Message);
                }
            }
            else if(Editar == true)
            {
                try
                {
                    cln_producto_Objeto.EditarProducto(txt_nombre_Prin.Text, txt_descripcion_Prin.Text, txt_marca_Prin.Text, txt_precio_Prin.Text, txt_stock_Prin.Text, id_producto);
                    MessageBox.Show("Se edito correctamente");
                    MostrarProductosInterfaz();
                    LimpiarCamposInterfaz();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar por: " +ex);
                }
            }
        }

        //private void btn_editar_Principal_Click(object sender, EventArgs e)
        //{
        //    if(dtgViewProductos.SelectedRows.Count > 0)
        //    {
        //        Editar = true;
        //        id_producto = dtgViewProductos.CurrentRow.Cells["id_producto"].Value.ToString();
        //        txt_nombre_Prin.Text = dtgViewProductos.CurrentRow.Cells["nombre"].Value.ToString();
        //        txt_descripcion_Prin.Text = dtgViewProductos.CurrentRow.Cells["descripcion"].Value.ToString();
        //        txt_marca_Prin.Text = dtgViewProductos.CurrentRow.Cells["marca"].Value.ToString();
        //        txt_precio_Prin.Text = dtgViewProductos.CurrentRow.Cells["precio"].Value.ToString();
        //        txt_stock_Prin.Text = dtgViewProductos.CurrentRow.Cells["stock"].Value.ToString();
        //    }
        //    else
        //    {
        //        MessageBox.Show("¡Debe seleccionar una fila!");
        //    }
        //}

        private void LimpiarCamposInterfaz()
        {
            txt_nombre_Prin.Clear();
            txt_descripcion_Prin.Clear();
            txt_marca_Prin.Clear();
            txt_precio_Prin.Clear();
            txt_stock_Prin.Clear();
        }

        private void btn_eliminar_Principal_Click(object sender, EventArgs e)
        {
            if(dtgViewProductos.SelectedRows.Count > 0)
            {
                id_producto = dtgViewProductos.CurrentRow.Cells["id_producto"].Value.ToString();
                cln_producto_Objeto.EliminarProducto(id_producto);
                MessageBox.Show("Eliminado correctamente!!!");

                MostrarProductosInterfaz();
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar una fila!");
            }
        }

        private void btn_salir_Principal_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pbx_Minimizar_Principal_Click(object sender, EventArgs e)
        {
            //pbx_Minimizar_Principal.Controls.Add(label6);
            //label6.Visible = true;
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbx_cerrar_Principal_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //[DllImport("user32")]
        //private static extern IntPtr GetWindowDC(IntPtr hwnd);
        //private const int WM_NCPAINT = 0x85;

        //protected override void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);

        //    if(m.Msg == WM_NCPAINT && this.Focused)
        //    {
        //        var dc = GetWindowDC(Handle);
        //        using (Graphics g = Graphics.FromHdc(dc))
        //        {
        //            g.DrawRectangle(Pens.Orange, 0, 0, Width - 1, Height - 1);
        //        }
        //    }
        //}

        private void txt_nombre_Prin_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void dtgViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgViewProductos.SelectedRows.Count > 0)
            {
                Editar = true;
                id_producto = dtgViewProductos.CurrentRow.Cells["id_producto"].Value.ToString();
                txt_nombre_Prin.Text = dtgViewProductos.CurrentRow.Cells["nombre"].Value.ToString();
                txt_descripcion_Prin.Text = dtgViewProductos.CurrentRow.Cells["descripcion"].Value.ToString();
                txt_marca_Prin.Text = dtgViewProductos.CurrentRow.Cells["marca"].Value.ToString();
                txt_precio_Prin.Text = dtgViewProductos.CurrentRow.Cells["precio"].Value.ToString();
                txt_stock_Prin.Text = dtgViewProductos.CurrentRow.Cells["stock"].Value.ToString();
            }
            else
            {
                MessageBox.Show("¡Debe seleccionar una fila!");
            }
        }
    }
}
