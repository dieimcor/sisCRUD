using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Datos                                                                                                                             // Espacio de trabajo donde pertenece
{
    public class Conex                                                                                                                      // Nombre de la Clase
    {
        public SqlConnection Cnn = new SqlConnection("server=DESKTOP-UFNE00K\\SQLEXPRESS;integrated security=true;database=SNet");                // Dirección de la base de datos
        public void Conectar()                                                                                                              // Función Conectar
        {
            if (Cnn.State == ConnectionState.Closed)                                                                                        // Condición para la conxción, si esta cerrada se abre.
                Cnn.Open();                                                                                                                 // Abrir conexión
        }
        public void Desconectar()                                                                                                           // Función Desconectar
        {
            if (Cnn.State == ConnectionState.Open)                                                                                          // Condición para la conxción, si esta cerrada se abre.
                Cnn.Close();                                                                                                                // Abrir conexión
        }
        public DataTable Listado(String NombreSP, List<Parametros> lst)                                                                     // Clase para interactuar de tipo de consultar
        {
            DataTable dt = new DataTable();                                                                                                 // Conectar con tablas
            SqlDataAdapter da;                                                                                                              // Leer Tablas
            try                                                                                                                             // Señala bloque de instrucciones
            {
                Conectar();                                                                                                                 // Función Conectar
                da = new SqlDataAdapter(NombreSP, Cnn);                                                                                     // Comando para establecer conexión
                da.SelectCommand.CommandType = CommandType.StoredProcedure;                                                                 // Comando para interactuar con procedimientos almacenados
                if (lst != null)                                                                                                            // Condición para interactuar con procedimientos
                {
                    for (int i = 0; i < lst.Count; i++)                                                                                     // For para ir interacctuando con los parametros y varible
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);                                              // Datos de la base de datos con sus valores
                    }
                }
                da.Fill(dt);                                                                                                                // Enviar filas de la tabla 
            }
            catch (Exception ex)                                                                                                            // Excepción de las intrucciones dadas
            {
                throw ex;                                                                                                                   // Excepción
            }
            Desconectar();                                                                                                                  // Función desconectar
            return dt;                                                                                                                      // Devolver filas de la tabla 
        }
        public void Ejecutar(String NombreSP, ref List<Parametros> lst)                                                                     // Clase para interactuar de tipo de ejecutar 
        {
            SqlCommand cmd;                                                                                                                 // Comando SQL 
            try                                                                                                                             // Señala bloque de instrucciones
            {
                Conectar();                                                                                                                 // Función Conectar
                cmd = new SqlCommand(NombreSP, Cnn);                                                                                        // Comando para establecer conexión
                cmd.CommandType = CommandType.StoredProcedure;                                                                              // Comando para interactuar con procedimientos almacenados
                if (lst != null)                                                                                                            // Condición para interactuar con procedimientos
                {
                    for (int i = 0; i < lst.Count; i++)                                                                                     // For para ir interacctuando con los parametros y varibles
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)                                                                   // Parametro de entrar datos
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);                                                       // Valores del Parametro
                        if (lst[i].Direccion == ParameterDirection.Output)                                                                  // Parametro para devolver datos
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDatos, lst[i].Tamaño).Direction = ParameterDirection.Output;       // Parametros con las variables
                    }
                    cmd.ExecuteNonQuery();                                                                                                  // Ejecución del comando
                    for (int i = 0; i < lst.Count; i++)                                                                                     // vFor para ir interacctuando con los parametros y varibles
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)                                                       // Parametro de salida de datos de la base de datos
                            lst[i].Valor = cmd.Parameters[i].Value;                                                                         // Listar parametros
                    }
                }
            }
            catch (Exception ex)                                                                                                            // Excepción de las intrucciones dadas
            {
                throw ex;                                                                                                                   // Excepción
            }
            Desconectar();                                                                                                                  // Función desconectar
        }
    }
}