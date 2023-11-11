using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data.SqlClient;
using System.Security.Policy;

namespace Logica
{
    public class LLReg              
    {
        private Conex Cn = new Conex();

        public int ValIdReg{get; set;}

        public String ValNombre { get; set;}

        public int IdReg
        {
            get { return ValIdReg; }
            set { ValIdReg = value; }
        }
        public String Nombre
        {
            get { return ValNombre; }
            set { ValNombre = value; }
        }
        public DataTable Lis_Region()
        {
            return Cn.Listado("LReg_lis", null);
        }
        public DataTable Fil_Region(String Buscar)
        {
            DataTable dt = new DataTable();
            List<Parametros>lst=new List<Parametros>();
            try
            {
                lst.Add(new Parametros("@Buscar",Buscar));
                return dt = Cn.Listado("LReg_Fil", lst);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public String Ing_Region()
        {
            List<Parametros>lst=new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@Nombre", Nombre));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("LReg_Ing", ref lst);
                return Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String Act_Region()
        {
            List <Parametros>lst=new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@IdReg", IdReg));
                lst.Add(new Parametros("@Nombre", Nombre));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("LReg_Act", ref lst);
                return Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public String Eli_Region()
        {
            List<Parametros>lst=new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@IdReg", IdReg));
                lst.Add(new Parametros("@Mensaje", "", SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("LReg_Eli", ref lst);
                return Mensaje = lst[1].Valor.ToString();
            }
            catch (Exception ex) { throw ex; }
        }
    }
}
