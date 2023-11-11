using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LLogin
    {
        private Conex Cn = new Conex();

        public String ValNombre;

        public String ValPass;
        public String Nombre
        {
            get { return ValNombre; }
            set { ValNombre = value; }
        }
        public String Pass
        {
            get { return ValPass; }
            set { ValPass = value; }
        }
        public String IniciarSesion()
        {
            List<Parametros>lst = new List<Parametros>();
            String Mensaje = "";
            try
            {
                lst.Add(new Parametros("@Nombre", Nombre));
                lst.Add(new Parametros("@Pass", Pass));
                lst.Add(new Parametros("@Mensaje", "", System.Data.SqlDbType.VarChar, ParameterDirection.Output, 50));
                Cn.Ejecutar("IngSig", ref lst);
                return Mensaje = lst[2].Valor.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}