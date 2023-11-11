using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;
using System.Security.Cryptography;

namespace Logica
{
    public class CCli
    {
        private Conex Cn = new Conex();

        public int ValIdP_Cli;
        public String ValNombre;
        public String ValRut;
        public int ValIdCom;
        public String ValDireccion;
        public String ValTel;
        public String ValEmail;
        public String ValGiro;

        public int IdP_Cli
        {
            get { return ValIdP_Cli; }
            set { ValIdP_Cli = value; }
        }
        public String Nombre
        {
            get { return ValNombre; }
            set { ValNombre = value; }
        }
        public String Rut
        {
            get { return ValRut; }
            set { ValRut = value; }
        }
        public int IdCom
        {
            get { return ValIdCom; }
            set { ValIdCom = value; }
        }
        public String Direccion
        {
            get { return ValDireccion; }
            set { ValDireccion = value; }
        }
        public String Tel
        {
            get { return ValTel; }
            set { ValTel = value; }
        }
        public String Email
        {
            get { return ValEmail; }
            set { ValEmail = value; }
        }
        public String Giro
        {
            get { return ValGiro; }
            set { ValGiro = value; }
        }
        public DataTable Lis_Cliente()
        {
            return Cn.Listado("Cliente_lis", null);
        }
        public DataTable Bus_Cliente()
        {
            return Cn.Listado("Cliente_Bus", null);
        }
        public DataTable Fil_Cliente_Nombre()
        {
            DataTable dt = new DataTable();
            List<Parametros> lst = new List<Parametros>();
            try
            {
                lst.Add(new Parametros("@Buscar", Nombre));
                return dt = Cn.Listado("Cliente_Fil_No", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Fil_Cliente_Rut()
        {
            DataTable dt = new DataTable();
            List<Parametros> lst = new List<Parametros>();
            try
            {
                lst.Add(new Parametros("@Buscar", Rut));
                return dt = Cn.Listado("Cliente_Fil_Rut", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String Bus_Cliente_Rut()
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@Rut", Rut));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("Cliente_Rut_Regis", ref lst);
                return Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String Ing_Cliente()
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@Nombre", Nombre));
                lst.Add(new Parametros("@Rut", Rut));
                lst.Add(new Parametros("@IdCom", IdCom));
                lst.Add(new Parametros("@Direccion", Direccion));
                lst.Add(new Parametros("@Tel", Tel));
                lst.Add(new Parametros("@Email", Email));
                lst.Add(new Parametros("@Giro", Giro));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("Cliente_Ing", ref lst);
                return Mensaje = lst[7].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String Act_Cliente()
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@IdP_Cli", IdP_Cli));
                lst.Add(new Parametros("@Nombre", Nombre));
                lst.Add(new Parametros("@Rut", Rut));
                lst.Add(new Parametros("@IdCom", IdCom));
                lst.Add(new Parametros("@Direccion", Direccion));
                lst.Add(new Parametros("@Tel", Tel));
                lst.Add(new Parametros("@Email", Email));
                lst.Add(new Parametros("@Giro", Giro));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("Cliente_Act", ref lst);
                return Mensaje = lst[8].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String Eli_Cliente()
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@IdP_Cli", IdP_Cli));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("Cliente_Eli", ref lst);
                return Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}