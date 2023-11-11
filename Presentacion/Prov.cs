using Logica;       //Llama la capa lógica
using Presentacion.AAClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Presentacion
{
    public partial class Prov : Form
    {
        public Prov()
        {
            InitializeComponent();
        }
        ValidaRut Rut = new ValidaRut();            //Se llaman las clases correspondientes
        LLReg LReg = new LLReg();
        LLPro LPro = new LLPro();
        LLCom LCom = new LLCom();
        LProv LProv = new LProv();

        private void Prov_Load(object sender, EventArgs e)
        {

        }
        public void LleComReg()     //Llenar combobox region
        {
            CBReg.DisplayMember = "Nombre";
            CBReg.ValueMember = "IdReg";
            CBReg.DataSource = LReg.Lis_Region();
        }
        private void cargaCBPro()       //Llenar combobox provincia
        {
            LPro.IdReg = Convert.ToInt32(CBReg.SelectedValue);
            CBPro.DisplayMember = "Nombre";
            CBPro.ValueMember = "IdPro";
            CBPro.DataSource = LPro.Fil_Id_Provincia(LPro.IdReg);
        }
        private void cargaCBCom()       //Llenar combobox comuna
        {
            LCom.IdPro=Convert.ToInt32(CBPro.SelectedValue);
            CBCom.DisplayMember = "Nombre";
            CBCom.ValueMember = "IdCom";
            CBCom.DataSource=LCom.Fil_Id_Comuna(LCom.IdPro);
        }
        public void HabBotIng() //Habilitar boyon de ingreso
        {
            if ((textTel.Text.Trim() != "") && (textNom.Text.Trim() != "") && (CBReg.Text.Trim() != "") && (CBPro.Text.Trim() != "") && (CBCom.Text.Trim() != "") && (textDire.Text.Trim() != "") && (textTel.Text.Trim() != "") && (textEma.Text.Trim() != "") && (textGir.Text.Trim() != ""))
            {
                butIng.Enabled = true;
            }
            else
            {
                butIng.Enabled = false;
            }
        }
        public void HabBotLim()             //Habilita boton de limpiar
        {
            if ((textRut.Text.Trim() != "") || (textNom.Text.Trim() != "") || (CBReg.Text.Trim() != "") || (CBPro.Text.Trim() != "") || (CBCom.Text.Trim() != "") || (textDire.Text.Trim() != "") || (textTel.Text.Trim() != "") || (textEma.Text.Trim() != "") || (textGir.Text.Trim() != "")) // "O" Distinto a vacio
            {
                butLim.Enabled = true;
            }
            else
            {
                butLim.Enabled = false;
            }
        }   

        private void textRut_Leave(object sender, EventArgs e)      //Accion de abandonar el textbot de rut
        {
            bool respuesta = false;                         //define booleano respuesta como falso
            respuesta=Rut.validarRut(textRut.Text);         //entrega lo ingresado en textrut para validarse

            if (respuesta == false)         //Si el rut es invalido
            {
                textRut.Clear();            //vaciar el textbox
                MessageBox.Show("Rut Malo","Sistema.",MessageBoxButtons.OK,MessageBoxIcon.Error);       //mostrar ventana emergente con error
            }
            else
            {
                MessageBox.Show("Rut Bueno", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);     //mostrar ventana emergente con confirmacion
                textRut.Text=Rut.formatoRut(textRut.Text);          //se formatea el rut
                String Mensaje = "";        //se crea un string con nombre Mensaje
                try                         //comienza bloque de instrucciones
                {
                    if (textRut.Text.Trim() != "")          //si el textbox esta vacio
                    {
                        LProv.Rut = textRut.Text;               //Asignar valor a la variable de la clase llamada
                        Mensaje = LProv.Bus_Prov_Rut();         //Definir mensaje desde la base de datos
                        if (Mensaje =="Rut ya existe.")         //Si el mensaje dice:"Rut ya existe."
                        {
                            MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);       //mostrar una ventana emergente con error
                            textRut.Clear();                //limpiar el textboc¿x
                            textNom.TabStop = false;        //inhabilitar el pare de tab en textnom
                            textRut.TabStop = true;         //habilitar el pare de tab en textrut
                        }
                        else
                        {
                            MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textNom.TabStop = true;         //habilitar el pare de tab en en textnom
                            textRut.TabStop = false;        //inhabilitar el pare de tab en textrut
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por Favor Ingrese Cliente a Registrar", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);       //mostrar una ventana emergente pidiendo que se llene el campo
                        textRut.Clear();            //vaciar el textbox
                    }
                }
                catch (Exception ex)                //si no se cumple con ninguna
                {
                    MessageBox.Show(ex.Message);    //mostrar otro tipo de error
                }
                HabBotLim();        //llamar funcion
                HabBotIng();        //llamar funcion
            }
        }

        private void textNom_KeyPress(object sender, KeyPressEventArgs e)       //Limitar a texto el contenido a ingresar
        {
            if (char.IsNumber(e.KeyChar))               //ciclo para bloquear numeros
            {
                e.Handled = true;               //Permitir cualquier valor menos la condicion anterior
                MessageBox.Show("Solo se permiten letras");     //Mensaje de OK con error que dice que solo se permite letras
            }
        }

        private void textNom_TextChanged(object sender, EventArgs e)
        {
            textNom.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textNom.Text);      //primera con mayusculas
            textNom.SelectionStart=textNom.Text.Length;                                     //Dejar el textbox para que tome la primera letra con mayuscula
            if (textNom.Text.Trim() != "")  //si textnom esta vacio
            {
                CBReg.TabStop = true;       //habilitar el pare de tab en combobox region
                textNom.TabStop=false;      //inhabilitar el pare de tab en textnom
                LleComReg();                //llamar funcion
            }
            else
            {
                CBReg.TabStop=false;        //inhabilitar el pare de tab en combobox region
                textNom.TabStop = true;     //habilita el pare de tab en textnom
            }
            HabBotIng();                    //llamar funcion
        }

        private void CBReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBReg.Text.Trim() != "")    //si el combobox esta vacii
            {
                CBPro.TabStop = true;   //habilitar el pare de tab en combobox provincia
                CBReg.TabStop = false;  //inhabilitar el pare de tab en combobox region
                cargaCBPro();           //llamar funcion
            }
            else
            {
                CBReg.TabStop = false;  //inhabilitar el pare de tab en combobox region
                CBPro.TabStop = true;   //habilitar el pare de tab en combobox provincia
            }
            HabBotLim();                //llamar funcion
            HabBotIng();                //llamar funcion
        }

        private void CBPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBPro.Text.Trim() != "")
            {
                CBCom.TabStop = true;       //habilitar el pare de tab en combobox comuna
                CBPro.TabStop = false;      //inhabilitar el pare de tab en combobox provincia
                cargaCBCom();               //llamar funcion
            }
            else
            {
                CBPro.TabStop = false;     //inhabilitar el pare de tab en combobox provincia
                CBCom.TabStop = true;      //habilitar el pare de tab en combobox comuna
            }
            HabBotLim();                    //llamar funcion
            HabBotIng();                    //llamar funcion
        }

        private void CBCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCom.Text.Trim() != "")        //si el combobox esta vacio
            {
                textDire.TabStop = true;        //habilitar el pare de tab en textdire
                CBCom.TabStop= false;           //inhabilitar el pare de tab en combobox comuna
            }
            else
            {
                textDire.TabStop= false;        //inhabilitar el pare de tab en textdire
                CBCom.TabStop = true;           //habilitar el pare de tab en combobox comuna
            }
            HabBotIng();        //llamar funcion
            HabBotLim();        //llamar funcion
        }

        private void textDire_TextChanged(object sender, EventArgs e)
        {
            if (textDire.Text.Trim() != "") //si esta vacio el textbox
            {
                textTel.TabStop = true;     //habilitar el pare de tab en textel
                textDire.TabStop = false;   //inhabilitar el pare de tab en textdire
            }
            else
            {
                textTel.TabStop= false;     //inhabilitar el pare de tab en textel
                textDire.TabStop= true;     //habilitar el pare de tab en textdire
            }
            HabBotLim();
            HabBotIng();
        }

        private void textTel_TextChanged(object sender, EventArgs e)
        {
            if (textTel.Text.Trim() != "")  //si esta vacio el textbox
            {
                textEma.TabStop=true;       //habilitar el pare de tab en textema
                textTel.TabStop = false;    //inhabilitar el pare de tab en textel
            }
            else
            {
                textEma.TabStop = false;    //inhabilitar el pare de tab en textema
                textTel.TabStop= true;      //habilitar el pare de tab en textel
            }
            HabBotLim();            //llamar funcion
            HabBotIng();            //llamar funcion
        }

        private void textEma_TextChanged(object sender, EventArgs e)
        {
            if (textEma.Text.Trim() != "")      //si esta vacio el textbox
            {
                textGir.TabStop=true;       //habilitar el pare de tab en textgir
                textEma.TabStop=false;      //inhabilitar el pare de tab en textema
            }
            else
            {
                textGir.TabStop = false;    //inhabilitar el pare de tab en textgir
                textEma.TabStop= true;      //habilitar el pare de tab en textema
            }
            HabBotLim();        //llamar funcion
            HabBotIng();        //llamar funcion
        }

        private void textGir_TextChanged(object sender, EventArgs e)
        {
            if (textGir.Text.Trim() != "")  //si esta vacio el textbox
            {
                textDescr.TabStop=true;     //habilitar el pare de tab en textdescr
                textGir.TabStop=false;      //inhabilitar el pare de tab en textgir
            }
            else
            {
                textDescr.TabStop = false;  //inhabilitar el pare de tab en textdescr
                textGir.TabStop = true;     //habilitar el pare de tab en textgir
            }
            HabBotLim();                    //llamar funcion
            HabBotIng();                    //llamar funcion
        }

        private void textDescr_TextChanged(object sender, EventArgs e)
        {
            if (textDescr.Text.Trim() != "")    //si esta vacio el textbox
            {
                butIng.TabStop=true;            //habilitar el pare de tab buting
                textDescr.TabStop=false;        //inhabilitar el pare de tab en textdescr
            }
            else
            {
                butIng.TabStop = false;         //inhabilitar el pare de tab en buting
                textDescr.TabStop = true;       //habilitar el pare de tab en textdescr
            }
            HabBotLim();                        //llamar funcion
            HabBotIng();                        //llamar funcion
        }

        private void butLim_Click(object sender, EventArgs e)
        {
            textRut.Clear();                //Vaciar textrut
            textNom.Clear();                //vaciar textnom
            textDire.Clear();               //vaciar textdire
            textTel.Clear();                //vaciar texttel
            textEma.Clear();                //vaciar textema
            textGir.Clear();                //vaciar textgir
            textDescr.Clear();              //vaciar textdescr
            CBReg.DataSource = null;        //dejar combobox en null
            CBPro.DataSource = null;        //dejar combobox en null
            CBCom.DataSource = null;        //dejar combobox en null
            HabBotIng();                    //llamar funcion
        }

        private void butIng_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            String Mensaje = "";                                            //Variable de tipo string para mensaje
            try                                                             //Señala bloque de instrucciones
            {
                if (res == DialogResult.Yes)                                //Si el resultado de la consulta es sí:
                {
                    LProv.Nombre = textNom.Text;                            //Asignar valor a la variable de la clase llamada
                    LProv.Rut = textRut.Text;                               //Asignar valor a la variable de la clase llamada
                    LProv.IdCom = Convert.ToInt32(CBCom.SelectedValue);     //Asignar valor al combobox
                    LProv.Direccion = textDire.Text;                        //Asignar valor a la variable de la clase llamada
                    LProv.Tel = textTel.Text;                               //Asignar valor a la variable de la clase llamada
                    LProv.Email = textEma.Text;                             //Asignar valor a la variable de la clase llamada
                    LProv.Giro = textGir.Text;                              //Asignar valor a la variable de la clase llamada
                    LProv.Descr = textDescr.Text;                           //Asignar valor a la variable de la clase llamada
                    Mensaje = LProv.Ing_Proveedor();                        //Asignar desde la clase a mensaje
                    if (Mensaje == "Proveedor ya Existen.")                 //Si el mensaje de la base de datos es:"Proveedor ya Existen."
                    {
                        MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);  //Mostrar mensaje de error desde la base de datos
                    }
                    else
                    {
                        MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information); //Mostrar mensaje desde la base de datos
                        butLim.PerformClick();      //Realizar un click al boton limpiar
                    }
                }
                else if (res == DialogResult.No)    //Si el resultado de la consulta es No:
                {
                    butVol.Focus();                 //Enfocar boton Volvver
                }
                else if (res == DialogResult.Cancel)    //Si el resultado de la consulta es Cancel:
                {
                    butSal.Focus();                     //Enfocar boton de Salir
                }
            }
            catch (Exception ex)        //Si no se cumple con ninguna
            {
                MessageBox.Show(ex.Message);        //Mostrar otro mensaje de error
            }
            HabBotIng();            //Llama la funcion
        }

        private void butVol_Click(object sender, EventArgs e)       //Boton de volver en la aplicacion
        {
            this.Close();
        }

        private void butSal_Click(object sender, EventArgs e)       //Boton de cerrar la aplicacion
        {
            Application.Exit();
        }
    }
}
