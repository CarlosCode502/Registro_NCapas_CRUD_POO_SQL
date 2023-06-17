using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//importamos las librerias correspondientes
using Capa_Acceso_a_Datos;
using System.Data;

namespace Capa_Logica_de_Negocio
{
    /// <summary>
    /// Clase que contiene toda la lógica de negocio, validaciones y seguridad. 
    /// Esta compuesta en su mayoria por métodos para poder invocar a los 
    /// métodos creados anteriormente en la capa Acceso a datos(CD_Productos).
    /// </summary>
    public class CLN_Productos
    {
        //EN VEZ DE UTILIZAR VARIABLES, PROPUEDADES Y CONSTRUCTORES (PE)
        //SE CREAN MÉTODOS, USO DE OBJETOS Y SE PASAN LOS PARAMETROS(POO)

        #region Objetos y variables
        /// <summary>
        /// Instancia de la clase CD_Productos que permitira acceder a sus métodos.
        /// </summary>
        private readonly CD_Productos cd_producto_Objeto = new CD_Productos();
        #endregion

        #region Métodos
        /// <summary>
        /// Método de tipo DataTable que al invorcarlo se podrá mostrar una tabla 
        /// en el contenedor correspondiente.
        /// </summary>
        /// <returns>Una tabla.</returns>
        public DataTable MostrarProducto()
        {
            _= new DataTable();
            DataTable tabla = cd_producto_Objeto.Mostrar();
            return tabla;
        }

        // HACE REFERENCIA A LAS PROPIEDADES GET Y SET, SOLO QUE EN ESTE CASO SE HACE USO 
        // DE UN MÉTODOS AL QUE SE LE PASAN LOS PARAMETROS O LAS CARACTERISTICAS DEL PRODUCTO.

        /// <summary>
        /// Método que permite insertar productos asignando el valor desde la onterfaz hacia la 
        /// bd según el tipo de dato correspondiente.
        /// </summary>
        /// <param name="nombre">Parametro que se recibe desde la interfaz hacia la bd "@nombre"</param>
        /// <param name="descripcion">Parametro que se recibe desde la itfz hacia la bd "@descripcion"</param>
        /// <param name="marca">Parametro que se recibe desde la interfaz hacia la bd "@marca"</param>
        /// <param name="precio">Parametro que se recibe desde la interfaz hacia la bd "@precio"</param>
        /// <param name="stock">Parametro que se recibe desde la interfaz hacia la bd "@stock"</param>
        public void InsertarProducto(String nombre, String descripcion, String marca, String precio,
            String stock)
        {
            //int valorNumerico;

            //bool esNumero = int.TryParse(precio, out valorNumerico);

            //if(esNumero == true)
            //{
            //    precio = precio + "{0:0.00}";
            //}

            //String percioAddCeros = precio + "{0:N2}";

            //Double d_Ceros = Convert.ToDouble(percioAddCeros);
            //d_Ceros = (Math.Truncate( d_Ceros * 10000) / 10000);
            cd_producto_Objeto.Insertar(nombre, descripcion, marca, Convert.ToDecimal(precio), Convert.ToInt32(stock));
        }

        /// <summary>
        /// Método que permite editar productos existentes que se encuentran el bd.
        /// </summary>
        /// <param name="nombre">igual a @nombre de la bd.</param>
        /// <param name="descripcion">igual a @descripcion de la bd.</param>
        /// <param name="marca">igual a @marca de la bd.</param>
        /// <param name="precio">igual a @precio de la bd.</param>
        /// <param name="stock">igual a @stock de la bd.</param>
        /// <param name="id_producto">igual a @id_producto de la bd.</param>
        public void EditarProducto(String nombre, String descripcion, String marca, String precio,
            String stock, String id_producto)
        {
            cd_producto_Objeto.Editar(nombre, descripcion, marca, Convert.ToDecimal(precio), Convert.ToInt32(stock),
                Convert.ToInt32(id_producto));
        }

        /// <summary>
        /// Método que permite eliminar registros de la bd según de la bd.
        /// </summary>
        /// <param name="id_Producto">igual a @id_producto de la bd.</param>
        public void EliminarProducto(String id_Producto)
        {
            cd_producto_Objeto.Eliminar(Convert.ToInt32(id_Producto));
        }
        #endregion
    }
}

