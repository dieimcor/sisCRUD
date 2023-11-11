using Datos;    //Llamar capa Datos
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LLCom
    {
        private Conex Cn=new Conex();   //Crea una instancia de la clase Conex para manejar la conexion a la base de datos

        public int ValIdCom;        //Variable publica para almacenar el valor del ID de la comuna
        public String ValNombre;    //Variable publica para almacenar el nombre de la comuna
        public int ValIdPro;        //Variable publica para almacenar el valor del id de la provincia
        public int ValIdReg;        //Variable publica para almacenar el valor de la id de la region
        public int IdCom                //Propiedad publica que proporciona acceso al id de la comuna
        {
            get {  return ValIdCom; } 
            set {  ValIdCom = value; } 
        }
        public String Nombre            //Propiedad publica que proporciona acceso al nombre de la comuna
        {
            get { return ValNombre; }
            set { ValNombre = value; }
        }
        public int IdPro        //Propiedad publica que proporciona acceso al id de la provincia
        {
            get { return ValIdPro; }
            set { ValIdPro = value; }
        }
        public int IdReg        //Propiedad publica que proporciona acceso al id de la region
        {
            get { return ValIdReg; }
            set { ValIdReg = value; }
        }
        public DataTable Lis_Comuna()       //Metodo publico que devuelve un datatable con la lista de comunas
        {
            return Cn.Listado("LCom_lis", null);
        }
        public DataTable Bus_Comuna()       //Metodo publico que devuelve un datatable para buscar comunas
        {
            return Cn.Listado("LCom_Bus", null);
        }
        public DataTable Fil_Nom_Comuna()   //Metodo publico que filtra comunas por nombre y devuelve un datatable
        {
            DataTable dt=new DataTable();
            List<Parametros>lst=new List<Parametros>();
            try
            {
                lst.Add(new Parametros("@Buscar", Nombre));
                return dt = Cn.Listado("LCom_Fil_No", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Fil_IdReg_Región(int IdReg)    //Metodo publico que filtra comunas por id de region y devuelve un datatable
        {
            DataTable dt=new DataTable();
            List<Parametros>lst=new List<Parametros>();
            try
            {
                lst.Add(new Parametros("@Id", IdReg));
                return dt = Cn.Listado("LCom_Fil_Id_Reg", lst);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Fil_IdReg_Provincia(int IdReg) //Metodo publico que filtra comunas por id de region y devuelve un datatable
        {
            DataTable dt=new DataTable();
            List<Parametros>lst=new List<Parametros>();
            try
            {
                lst.Add(new Parametros("@Id", IdReg));
                return dt = Cn.Listado("LCom_Fil_Id_Pro", lst);
            }
            catch( Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Fil_Id_Comuna(int IdCom)   //Metodo publico que filtra comunas por id y devuelve un datatable
        {
            DataTable dt=new DataTable();
            List<Parametros>lst=new List<Parametros>();
            try
            {
                lst.Add(new Parametros("@Id", IdPro));
                return dt = Cn.Listado("LCom_Fil_Id", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String Ing_Comuna()      //Metodo publico para ingresar una comuna
        {
            List<Parametros>lst= new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@Nombre", Nombre));
                lst.Add(new Parametros("@IdPro", IdPro));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("LCom_Ing", ref lst);
                return Mensaje = lst[2].Valor.ToString();
            }
            catch ( Exception ex)
            {
                throw ex;
            }
        }
        public String Act_Comuna()      //Metodo publico para actualizar una comuna
        {
            List<Parametros>lst=new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@IdCom", IdCom));
                lst.Add(new Parametros("@Nombre", Nombre));
                lst.Add(new Parametros("IdPro", IdPro));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                return Mensaje = lst[3].Valor.ToString();
            }
            catch ( Exception ex) 
            {
                throw ex; 
            }
        }
        public String Eli_Comuna()      //Metodo publico para eliminar una comuna
        {
            List<Parametros>lst=new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@IdCom", IdCom));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("LCom_Eli", ref lst);
                return Mensaje = lst[1].Valor.ToString();
            }
            catch ( Exception ex ) 
            {
            throw ex;
            }
        }

    }
}
