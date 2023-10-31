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
using System.IO;

namespace Capa_Persentacion
{
    public partial class Productos_Interfaz : Form
    {
        #region Objetos y variables
        /// <summary>
        /// Variable que contiene la instancia de la clase CLN_Productos
        /// </summary>
        private readonly CLN_Productos cln_producto_Objeto = new CLN_Productos();
        /// <summary>
        /// Variable que se le asigna el valor del id_producto al momento de ejecutar un
        /// SP(editar_producto, eliminar_producto), ya que estos dependen del id.
        /// </summary>
        private String id_producto = null;
        /// <summary>
        /// Variable que permitirá decidir si al momento de hacer click en el botón se va a
        /// agregar un nuevo registro o a actualizar un registro ya existente.
        /// (Si Editar == false entonces INSERT) (sino si Editar == true entonces EDIT).
        /// </summary>
        private bool Editar = false;
        #endregion

        #region Métodos
        /// <summary>
        /// Metodo que sera encargado de cargar o mostrar los registros de la bd y los mostrará
        /// en el DataGridView a través de la clase CLN_Productos y su nétodo MostrarProducto().
        /// También se establece el nombre de las columnas según su posición correspondiente.
        /// </summary>
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
            dtgViewProductos.ClearSelection();//ningún registro se mostrara seleccionado.
        }

        /// <summary>
        /// Método que detecta cuando el puntero esta sobre algún componente que tenga 
        /// configurado el evento MouseEnter, además recibe como parametros proviedades
        /// de los eventos.
        /// </summary>
        /// <param name="sender">recibe el tipo de control</param>
        /// <param name="e">recibe el tipo de evento</param>
        private void RatonEnter(object sender, EventArgs e)
        {
            var boton = (Button)sender;//Recibe el control especifíco de tipo botón
            boton.FlatAppearance.BorderColor = Color.Orange;//Cambia el color del borde del control (debe ser de tipo Flat).
            boton.FlatAppearance.BorderSize = 3;//Cambia el tamaño del borde del control (debe ser de tipo Flat).
            boton.BackColor = Color.White;//Cambia el color del control.
            boton.ForeColor = Color.Orange;//Cambia el color de la letra del control.
        }

        /// <summary>
        /// Se ejecuta cuando el puntero sale del control(Siempre que contenga este Evento).
        /// </summary>
        /// <param name="sender">recibe el tipo de control</param>
        /// <param name="e">recive las propiedades para el tipo de evento</param>
        private void RatonLeave(object sender, EventArgs e)
        {
            //Obtiene la posición del cursor si este se encuentra cerca del control que contiene el evento.
            /*if (!pbx_Minimizar_Principal.Bounds.Contains(this.PointToClient(Cursor.Position))){
                lb_minimizar_Principal.Visible = false;}
            else { }*/

            var boton = (Button)sender;//Recibe el control especifico.
            boton.FlatAppearance.BorderColor = Color.Black;//Cambia del color anterior el borde del control.
            boton.FlatAppearance.BorderSize = 2;//Cambia de tamaño anterior el borde del control.
            boton.BackColor = Color.DeepSkyBlue;//Cambia el color del control.
            boton.ForeColor = Color.Black;//Cambia el color de la letra del control
        }

        /// <summary>
        /// Se ejecuta cuando el puntero entra en la parte visible del PictureBox y muestra
        /// un label luego de ejecutar cierta condición.
        /// </summary>
        /// <param name="sender">Obtiene el tipo de control</param>
        /// <param name="e">Obtiene las propiedades según el evento</param>
        private void RatonEnterImage(object sender, EventArgs e)
        {
            var pBox = (PictureBox)sender;//recibe el control especifico.

            //Evalua si el control especifico corresponde a algúna condición
            if (pBox == pbx_Minimizar_Principal)
            {
                //si cumple se ejecutara una acción
                lb_minimizar_Principal.Visible = true;
            }
            else
            {
                //si no se cumple se ejecutara la opción por defecto
                //si se ejecuta esta opción se cambiará la imagen que se muestra en el control
                pbx_cerrar_Principal.Image = Image.FromFile(@"D:\CARLOS H\Documents\Visual Studio 2019\ProjectsPortafolio_CH\Registro_NCapas_CRUD_POO_SQL\Capa_Persentacion\Resources\x red.png");
                lb_cerrar_Principal.Visible = true;
            }
        }

        /// <summary>
        /// Se ejecuta cuando el puntero sale de la parte visible del Control.
        /// </summary>
        /// <param name="sender">Recibe el tipo de control</param>
        /// <param name="e">Recive la propiedades según el evento</param>
        private void RatonLeaveImage(object sender, EventArgs e)
        {
            var pBox = (PictureBox)sender;
            if (pBox == pbx_Minimizar_Principal)
            {
                lb_minimizar_Principal.Visible = false;
            }
            else
            { 
                pbx_cerrar_Principal.Image = Image.FromFile(@"D:\CARLOS H\Documents\Visual Studio 2019\ProjectsPortafolio_CH\Registro_NCapas_CRUD_POO_SQL\Capa_Persentacion\Resources\cerrar.png");
                lb_cerrar_Principal.Visible = false;
            }
        }

        /// <summary>
        /// Borra el contenido de los textbox.
        /// </summary>
        private void LimpiarCamposInterfaz()
        {
            txt_nombre_Prin.Clear();
            txt_descripcion_Prin.Clear();
            txt_marca_Prin.Clear();
            txt_precio_Prin.Clear();
            txt_stock_Prin.Clear();
        }

        /// <summary>
        /// Cierra o finaliza el programa luego de solicitar una confirmación en donde el resultado 
        /// debe ser "Si", de lo contrario se mantendrá abierto.
        /// </summary>
        private void BotonSalir_Cerrar()
        {
            var result = MessageBox.Show("¿Esta segur@ de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
        #endregion

        #region Métodos, eventos y constructores
        /// <summary>
        /// Se inicializa el formulario principal
        /// </summary>
        public Productos_Interfaz()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra la tabla en el DataGridView al cargar o iniciar el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Productos_Interfaz_Load(object sender, EventArgs e)
        {
            MostrarProductosInterfaz();
        }

        /// <summary>
        /// Minimiza la ventana al hacer clic sobre este.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_Minimizar_Principal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Cierra o finaliza la ejecución del programa a través del método BotonSalir_Cerrar();
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbx_cerrar_Principal_Click(object sender, EventArgs e)
        {
            BotonSalir_Cerrar();
        }

        /// <summary>
        /// Ejecuta las opciónes de guardar o editar (dependiendo del estado de la variable
        /// Editar ? true : false).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_guardar_Principal_Click(object sender, EventArgs e)
        {
            //INSERTAR
            //Si editar es igual a falso se ejecuta lo que esta dentro de la condición
            if (Editar == false)
            {
                try
                {
                    //obtiene los datos de los controles y los envia según los parametros del método InsertarProducto 
                    //de la clase CLN_Productos
                    cln_producto_Objeto.InsertarProducto(txt_nombre_Prin.Text, txt_descripcion_Prin.Text, txt_marca_Prin.Text, txt_precio_Prin.Text, txt_stock_Prin.Text);
                    MessageBox.Show("Se agregó correctamente", "Nuevo producto",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    MostrarProductosInterfaz();
                    LimpiarCamposInterfaz();
                }
                catch (Exception ex)
                {
                    if (String.IsNullOrWhiteSpace(txt_nombre_Prin.Text) || String.IsNullOrWhiteSpace(txt_descripcion_Prin.Text) ||
                        String.IsNullOrWhiteSpace(txt_marca_Prin.Text) || String.IsNullOrWhiteSpace(txt_precio_Prin.Text)
                        || String.IsNullOrWhiteSpace(txt_stock_Prin.Text))
                    {
                        MessageBox.Show("¡Todos los campos son obligatorios!", "No se agregó", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message,"¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else if (Editar == true)//Si editar == true se ejecuta esta condición
            {
                try
                {
                    cln_producto_Objeto.EditarProducto(txt_nombre_Prin.Text, txt_descripcion_Prin.Text, txt_marca_Prin.Text, txt_precio_Prin.Text, txt_stock_Prin.Text, id_producto);
                    MessageBox.Show("Se edito correctamente", "El producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarProductosInterfaz();
                    LimpiarCamposInterfaz();
                    Editar = false;
                    btn_guardar_Principal.Text = "Guardar";
                }
                catch (Exception ex)
                {
                    if (String.IsNullOrWhiteSpace(txt_nombre_Prin.Text) || String.IsNullOrWhiteSpace(txt_descripcion_Prin.Text) ||
                        String.IsNullOrWhiteSpace(txt_marca_Prin.Text) || String.IsNullOrWhiteSpace(txt_precio_Prin.Text)
                        || String.IsNullOrWhiteSpace(txt_stock_Prin.Text))
                    {
                        //MessageBox.Show("¡Todos los campos son obligatorios!", "No se agregó", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Editar = false;
                        btn_guardar_Principal.Text = "Guardar";
                    }
                    else
                        MessageBox.Show(ex.Message, "¡Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btn_guardar_Principal.Text = "Guardar";
                    //Editar = false;
                }
            }
        }

        /// <summary>
        /// Se ejecuta cuando se hace click en una celda o columna especificada del DataGridView.
        /// </summary>
        /// <param name="sender">Obtiene el tipo de control</param>
        /// <param name="e">Obtiene los eventos para el DataGridView</param>
        private void dtgViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //validación descartada 
            //int id = dtgViewProductos.CurrentCell.RowIndex;
            //if (dtgViewProductos.SelectedRows.Count > 0)

            //Obtiene el evento de la columna especificada en "e", luego obtiene el ídice para 
            //ver si existe dentro de la estructura de selección múltiple.
            switch (e.ColumnIndex)
            {
                //Si la condición coincide con algún caso, se ejecuta el frágmento de código que se encuentra 
                //dentro de este.

                //CASO 1
                case 0:
                    if (Convert.ToInt32(id_producto) == 0)
                    {
                        //Si la variable id es == a 0 entonces se le asignarán los siguientes valores a los campos 
                        //vacíos.
                        btn_guardar_Principal.Text = "Editar";
                        Editar = true;
                        id_producto = dtgViewProductos.CurrentRow.Cells["id_producto"].Value.ToString();
                        txt_nombre_Prin.Text = dtgViewProductos.CurrentRow.Cells["nombre"].Value.ToString();
                        txt_descripcion_Prin.Text = dtgViewProductos.CurrentRow.Cells["descripcion"].Value.ToString();
                        txt_marca_Prin.Text = dtgViewProductos.CurrentRow.Cells["marca"].Value.ToString();
                        txt_precio_Prin.Text = dtgViewProductos.CurrentRow.Cells["precio"].Value.ToString();
                        txt_stock_Prin.Text = dtgViewProductos.CurrentRow.Cells["stock"].Value.ToString();
                        break;
                    }
                    else if (Convert.ToInt32(id_producto) >= 0)
                    {
                        //Si la variable id es >= 0 entonces se limpiaran todos los campos
                        //esto evitara que se actualice un producto con el valor anterior1
                        LimpiarCamposInterfaz();
                        btn_guardar_Principal.Text = "Editar";
                        Editar = true;
                        id_producto = dtgViewProductos.CurrentRow.Cells["id_producto"].Value.ToString();
                        txt_nombre_Prin.Text = dtgViewProductos.CurrentRow.Cells["nombre"].Value.ToString();
                        txt_descripcion_Prin.Text = dtgViewProductos.CurrentRow.Cells["descripcion"].Value.ToString();
                        txt_marca_Prin.Text = dtgViewProductos.CurrentRow.Cells["marca"].Value.ToString();
                        txt_precio_Prin.Text = dtgViewProductos.CurrentRow.Cells["precio"].Value.ToString();
                        txt_stock_Prin.Text = dtgViewProductos.CurrentRow.Cells["stock"].Value.ToString();
                        break;
                    }
                    break;

                //CASO 2
                case 1:
                    //Si la variable id es == a 0 entonces se ejecutará la siguiente condición para eliminar 
                    //el registro segun el id
                    if (Convert.ToInt32(id_producto) == 0)
                    {
                        //Pregunta al usuario si desea eliminar el registro
                        var result = MessageBox.Show("¿Segur@ que desea eliminar este producto?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                        //Si el resultado de la confirmación es igual a "Si"
                        if (result == DialogResult.Yes)
                        {
                            //Se procede a eliminar el producto 
                            id_producto = dtgViewProductos.CurrentRow.Cells["id_producto"].Value.ToString();
                            cln_producto_Objeto.EliminarProducto(id_producto);
                            MessageBox.Show("Se ha eliminado correctamente", "El producto:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarProductosInterfaz();
                            return;
                        }
                    }
                    else if (Convert.ToInt32(id_producto) >= 0)
                    {
                        //Si los campos no estan vacíos se ejecutara el siguiente fragmento de código
                        LimpiarCamposInterfaz();//borra el contenido de los campos 

                        //Mensaje al usuario si desea eliminar los siguientes registros
                        var result = MessageBox.Show("¿Seguro que desea eliminar este producto?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                        //Si la confirmación es igual a "SI"
                        if (result == DialogResult.Yes)
                        {
                            //se procede a eliminar el registro
                            id_producto = dtgViewProductos.CurrentRow.Cells["id_producto"].Value.ToString();
                            cln_producto_Objeto.EliminarProducto(id_producto);
                            MessageBox.Show("Se ha eliminado correctamente", "El producto:", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MostrarProductosInterfaz();
                            return;
                        }
                    }
                    break;

                //default:
                //    break;
            }
        }

        /// <summary>
        /// Vuelve a cargar/mostrar nuevamente la tabla y limpias los campos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_recargartabla_Principal_Click(object sender, EventArgs e)
        {
            MostrarProductosInterfaz();
            LimpiarCamposInterfaz();
        }

        /// <summary>
        /// Borra los campos y vuelve a cargar la tabla.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancelar_Principal_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se limpiaron correctamente.","Los campos:", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCamposInterfaz();
            MostrarProductosInterfaz();
        }

        /// <summary>
        /// Cierra o finaliza la ejecución del programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_salir_Principal_Click(object sender, EventArgs e)
        {
            BotonSalir_Cerrar();
        }
        #endregion


        //DESCARTADO
        #region Editar o eliminar al seleccionar una celda(se modifico por Switch)
        //ESTRUCTURA CONCICIONAL IF ELSE ANIDADO
        //VALIDA SI SE HACE CLICK SOBRE ALGUNA CELDA DE LA TABLA 
        //0 PARA EDITAR PRODUCTO
        //1 PARA ELIMIAR PRODUCTO
        //if (e.ColumnIndex == 0)
        //{
        //    if (Convert.ToInt32(id_producto) == 0)
        //    {
        //        Editar = true;
        //        id_producto = dtgViewProductos.CurrentRow.Cells["id_producto"].Value.ToString();
        //        txt_nombre_Prin.Text = dtgViewProductos.CurrentRow.Cells["nombre"].Value.ToString();
        //        txt_descripcion_Prin.Text = dtgViewProductos.CurrentRow.Cells["descripcion"].Value.ToString();
        //        txt_marca_Prin.Text = dtgViewProductos.CurrentRow.Cells["marca"].Value.ToString();
        //        txt_precio_Prin.Text = dtgViewProductos.CurrentRow.Cells["precio"].Value.ToString();
        //        txt_stock_Prin.Text = dtgViewProductos.CurrentRow.Cells["stock"].Value.ToString();
        //    }
        //    else if (Convert.ToInt32(id_producto) >= 0)
        //    {
        //        LimpiarCamposInterfaz();
        //        Editar = true;
        //        id_producto = dtgViewProductos.CurrentRow.Cells["id_producto"].Value.ToString();
        //        txt_nombre_Prin.Text = dtgViewProductos.CurrentRow.Cells["nombre"].Value.ToString();
        //        txt_descripcion_Prin.Text = dtgViewProductos.CurrentRow.Cells["descripcion"].Value.ToString();
        //        txt_marca_Prin.Text = dtgViewProductos.CurrentRow.Cells["marca"].Value.ToString();
        //        txt_precio_Prin.Text = dtgViewProductos.CurrentRow.Cells["precio"].Value.ToString();
        //        txt_stock_Prin.Text = dtgViewProductos.CurrentRow.Cells["stock"].Value.ToString();
        //    }
        //}
        //else if (e.ColumnIndex == 1)
        //{
        //    if (Convert.ToInt32(id_producto) == 0)
        //    {
        //        var result = MessageBox.Show("¿Segur@ que desea eliminar este producto?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

        //        if (result == DialogResult.Yes)
        //        {
        //            id_producto = dtgViewProductos.CurrentRow.Cells["id_producto"].Value.ToString();
        //            cln_producto_Objeto.EliminarProducto(id_producto);
        //            MessageBox.Show("Se ha eliminado correctamente");
        //            MostrarProductosInterfaz();
        //        }
        //    }
        //    else if (Convert.ToInt32(id_producto) >= 0)
        //    {
        //        LimpiarCamposInterfaz();

        //        var result = MessageBox.Show("¿Seguro que desea eliminar este producto?", "Eliminar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

        //        if(result == DialogResult.Yes)
        //        {
        //            id_producto = dtgViewProductos.CurrentRow.Cells["id_producto"].Value.ToString();
        //            cln_producto_Objeto.EliminarProducto(id_producto);
        //            MessageBox.Show("Se ha eliminado correctamente");
        //            MostrarProductosInterfaz();
        //        }                                        
        //    }
        //}
        ////else
        ////{
        ////    MessageBox.Show("¡Debe seleccionar una fila!");
        ////}
        #endregion

        #region Se quito el btn editar
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
        #endregion

        #region Código para detectar si un control esta vacio 
        //foreach (Control c in this.Controls)
        //{
        //    if(c is TextBox)
        //    {
        //        TextBox txt = c as TextBox;
        //        if(txt.Text == string.Empty)
        //        {
        //            MessageBox.Show("¡No se ha podido agregar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //} 
        #endregion

        #region Dibujar bordes al TextBox(No se uso)
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
        #endregion        
    }
}
