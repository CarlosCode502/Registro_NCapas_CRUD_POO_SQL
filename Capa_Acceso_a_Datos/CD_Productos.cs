using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregamos las librerias correspondientes
using System.Data;
using System.Data.SqlClient;

namespace Capa_Acceso_a_Datos
{
    /// <summary>
    /// Clase responsable de realizar las consultas a la base de datos y/o ejecutar los 
    /// comandos correspondientes a las operaciones CRUD.
    /// </summary>
    public class CD_Productos
    {
        #region Objetos y variables
        /// <summary>
        /// Instancia de la clase CD_Conexion se asigna a la variable conexión
        /// </summary>
        private CD_Conexion conexion = new CD_Conexion();
        /// <summary>
        /// Contiene los datos leídos por SqlDataReader
        /// </summary>
        SqlDataReader leer;
        /// <summary>
        ///Contiene los datos de una tabla de la BD
        /// </summary>
        DataTable tabla = new DataTable();
        /// <summary>
        /// Contiene una intrucción de tipo T-SQL o StoreProcedure que se ejecuta en la base de datos
        /// </summary>
        SqlCommand comando = new SqlCommand();
        #endregion

        #region Métodos 
        /// <summary>
        /// Ejecuta el SP(mostrar_productos) en base a la cadena de conexión y lo almacena en una intancia 
        /// de tipo DataTable(tabla).
        /// </summary>
        /// <returns>Una tabla para el DataGridView.</returns>
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "mostrar_productos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        /// <summary>
        /// Asigna y agrega los nuevos campos a la bd, según el SP(insertar_usuarios), siempre 
        /// y cuando coincidan con los tipos de datos esperados.
        /// </summary>
        /// <param name="nombre">Se asigna al campo @nombre de la bd.</param>
        /// <param name="descripcion">Se asigna al campo @descripcion de la bd.</param>
        /// <param name="marca">Se asigna al campo @marca de la bd.</param>
        /// <param name="precio">Se asigna al campo @precio de la bd.</param>
        /// <param name="stock">Se asigna al campo @stock de la bd.</param>
        public void Insertar(String nombre, String descripcion, String marca, Decimal precio, int stock)
        {
            comando.Connection = conexion.AbrirConexion();

            comando.CommandText = "insertar_productos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        /// <summary>
        /// Permite modificar los datos ya existentes en la BD, a través de un SP(editar_productos)
        /// </summary>
        /// <param name="nombre">Se modifica y se asigna al campo @nombre de la bd.</param>
        /// <param name="descripcion">Se modifica y se asigna al campo @descripcion de la bd.</param>
        /// <param name="marca">Se modifica y se asigna al campo @marca de la bd.</param>
        /// <param name="precio">Se modifica y se asigna al campo @precio de la bd.</param>
        /// <param name="stock">Se modifica y se asigna al campo @stock de la bd.</param>
        /// <param name="id_producto">Se modifica y se asigna al campo @id_producto de la bd.</param>
        public void Editar(String nombre, String descripcion, String marca, Decimal precio, int stock, int id_producto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "editar_productos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@id_producto", id_producto);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        /// <summary>
        /// Permite eliminar un registro de la bd ejecutando el SP(eliminar_producto).
        /// </summary>
        /// <param name="id_producto">Se elimina el producto en base al id</param>
        public void Eliminar(int id_producto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminar_producto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_producto", id_producto);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
        #endregion
    }
}
