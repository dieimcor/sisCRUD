using Datos;
using System;
using System.Collections.Generic;
using System.Data;

namespace Logica
{
    public class LLPro
    {
        private Conex Cn = new Conex();

        public int ValIdPro;
        public string ValNombre;
        public int ValIdReg;

        public int IdPro
        {
            get { return ValIdPro; }
            set { ValIdPro = value; }
        }
        public String Nombre
        {
            get { return ValNombre; }
            set { ValNombre = value; }
        }
        public int IdReg
        {
            get { return ValIdReg; }
            set { ValIdReg = value; }
        }
        public DataTable Lis_Provincia()
        {
            return Cn.Listado("LPro_lis", null);
        }
        public DataTable Bus_Provincia()
        {
            return Cn.Listado("LPro_Bus", null);
        }
        public DataTable Fil_Nom_Provincia()
        {
            DataTable dt = new DataTable();
            List<Parametros> lst = new List<Parametros>();
            try
            {
                lst.Add(new Parametros("@Buscar", Nombre));
                return dt = Cn.Listado("LPro_Fil_No", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable Fil_Id_Provincia(int IdReg)
        {
            DataTable dt = new DataTable();
            List<Parametros> lst = new List<Parametros>();
            try
            {
                lst.Add(new Parametros("@Id", IdReg));
                return dt = Cn.Listado("LPro_Fil_Id", lst);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String Ing_Provincia()
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@Nombre", Nombre));
                lst.Add(new Parametros("@IdReg", IdReg));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("LPro_Ing", ref lst);
                return Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String Act_Provincia()
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@IdPro", IdPro));
                lst.Add(new Parametros("@Nombre", Nombre));
                lst.Add(new Parametros("@IdReg", IdReg));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("LPro_Act", ref lst);
                return Mensaje = lst[3].Valor.ToString();
            }
            catch (Exception ex) { throw ex; }
        }
        public String Eli_Provincia()
        {
            List<Parametros> lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@IdPro", IdPro));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("LPro_Eli", ref lst);
                return Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
