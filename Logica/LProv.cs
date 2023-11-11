using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Datos;

namespace Logica
{
    public class LProv
    {
        private Conex Cn = new Conex();

        public int ValIdProv;
        public String ValNombre;
        public String ValRut;
        public int ValIdCom;
        public String ValDireccion;
        public String ValTel;
        public String ValEmail;
        public String ValGiro;
        public String ValDescr;
        public int IdProv
        {
            get { return ValIdProv; }
            set { ValIdProv = value; }
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

        public String Descr
        {
            get { return ValDescr; }
            set { ValDescr = value; }
        }
        public DataTable Lis_Proveedor()
        {
            return Cn.Listado("Prov_lis", null);
        }

        public DataTable Bus_Proveedor()
        {
            return Cn.Listado("Prov_Bus", null);
        }

        public DataTable Fil_Proveedor_Nombre()
        {
            DataTable dt = new DataTable();
            List<Parametros> lst = new List<Parametros>();
            try
            {
                lst.Add(new Parametros("@Buscar", Nombre));
                return dt = Cn.Listado("Prov_Fil_No", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Fil_Proveedor_Rut()
        {
            DataTable dt = new DataTable();
            List<Parametros> lst = new List<Parametros>();
            try
            {
                lst.Add(new Parametros("@Buscar", Rut));
                return dt = Cn.Listado("Prov_Fil_Rut", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Fil_Proveedor_Giro()
        {
            DataTable dt = new DataTable();
            List<Parametros> lst = new List<Parametros>();
            try
            {
                lst.Add(new Parametros("@Buscar", Giro));
                return dt = Cn.Listado("Prov_Fil", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Fil_Proveedor_Total()
        {
            DataTable dt = new DataTable();
            List<Parametros> lst = new List<Parametros>();
            try
            {
                lst.Add(new Parametros("@Buscar", Nombre));
                lst.Add(new Parametros("@Buscar", Rut));
                lst.Add(new Parametros("@Buscar", Giro));
                return dt = Cn.Listado("Prov_Fil", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String Bus_Prov_Rut()
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@Rut", Rut));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("Prov_Rut_Regis", ref lst);
                return Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String Ing_Proveedor()
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
                lst.Add(new Parametros("@Descr", Descr));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("Prov_Ing", ref lst);
                return Mensaje = lst[8].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String Act_Proveedor()
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@IdProv", IdProv));
                lst.Add(new Parametros("@Nombre", Nombre));
                lst.Add(new Parametros("@Rut", Rut));
                lst.Add(new Parametros("@IdCom", IdCom));
                lst.Add(new Parametros("@Direccion", Direccion));
                lst.Add(new Parametros("@Tel", Tel));
                lst.Add(new Parametros("@Email", Email));
                lst.Add(new Parametros("@Giro", Giro));
                lst.Add(new Parametros("@Descr", Descr));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("Prov_Act", ref lst);
                return Mensaje = lst[9].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String Eli_Proveedor()
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@IdProv", IdProv));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("Prov_Eli", ref lst);
                return Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
