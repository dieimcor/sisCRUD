using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Parametros
    {
        private String Nomb;                    //Campo privado para almacenar nombre
        private Object Val;                     //Campo privado para almacenar valor
        private SqlDbType TDat;                 //Campo privado para almacenar tipo de dato
        private ParameterDirection Direc;       //Campo privado para almacenar la dirección
        private int Tam;                        //Campo privado para almacenar tamaño

        public String Nombre                    //Propiedad publica que proporciona acceso al nombre del parametro
        {
            get { return Nomb; }
            set { Nomb = value; }
        }
        public Object Valor                     //Propiedad publica que proporciona acceso al valor del parametro
        {
            get { return Val; }
            set { Val = value; }
        }
        public SqlDbType TipoDatos              //Propiedad publica que proporciona acceso al tipo de dato del parametro
        {
            get { return TDat; }
            set { TDat = value; }
        }
        public ParameterDirection Direccion     //Propiedad publica que proporciona acceso a la direccion del parametro
        {
            get { return Direc; }
            set { Direc = value; }
        }
        public int Tamaño                       //Propiedad publica que proporciona acceso al tamaño del parametro
        {
            get { return Tam; }
            set { Tam = value; }
        }
        public Parametros(String objNombre, Object objValor)                //Constructor que inicializa un parametro de entrada
        {
            
            Nomb = objNombre;
            Val = objValor;
            Direc = ParameterDirection.Input;
        }
        public Parametros(String objNombre, Object objValor, SqlDbType objTipoDato, ParameterDirection objDireccion, int objTamaño)     //Constructor que inicializa un parametro con opciones personalizadas
        {
            Nomb = objNombre;
            Val = objValor;
            TDat=objTipoDato;
            Direc=objDireccion;
            Tam = objTamaño;
        }
    }
}
