using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Luego de agregar las regerencias importamos las librerias
using System.Data;
using System.Data.SqlClient;

namespace Capa_Acceso_a_Datos
{    
    /// <summary>
    /// Clase que contiene la cadena de conexión y los métodos para abrir o cerrar la conexión.
    /// </summary>
    public class CD_Conexion
    {
        #region Variables
        /// <summary>
        /// Contiene la cadena de conexión al servidor y la base de datos.
        /// </summary>
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-QGVNI28; DataBase=Registro_NCapas_BD; Integrated Security=true");
        #endregion

        #region Métodos
        /// <summary>
        /// Método que evalua si la conexión esta cerrada y pasará a abrirla.
        /// </summary>
        /// <returns>Que la conexión ha sido abierta.</returns>
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                Conexion.Open();                
            }
            return Conexion;
        }

        /// <summary>
        /// Método que evalua si la conexión esta abierta y pasará a cerrarla.
        /// </summary>
        /// <returns>Que la conexión ha sido cerrada.</returns>
        public SqlConnection CerrarConexion()
        {
            if(Conexion.State == ConnectionState.Open)
            {
                Conexion.Close();
            }
            return Conexion;
        }
        #endregion
    }
}
