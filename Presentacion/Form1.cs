using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;   //Llama la capa lógica
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        LLReg LReg = new LLReg();                                   //Se llama la clase correspondiente
        public Form1()
        {
            InitializeComponent();
        }

        public void CargarDatos()
        {
            DataTable dt=new DataTable();                                               //Llamar datos
            dt = LReg.Lis_Region();                                                     //Dirección de los datos a llamar
            try                                                                         //Señala bloque de instrucciones
            {
                dataGridView1.Rows.Clear();                                             //Limpiar dataGridView1
                for (int i= 0; i < dt.Rows.Count; i++)                                  //For para generar búsqueda
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);                              //Asignar parámetros para la búsqueda
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();    //Primera celda de la dataGridView1
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();    //Segunda celda de la dataGridView1
                }
            }
            catch ( Exception ex)                                                       //Excepción de las instrucciones dadas
            {
                MessageBox.Show(ex.Message);                                            //Mensaje de otro tipo de error(ejemplo conexión de base de datos)
            }
            dataGridView1.ClearSelection();                                             //Limpiar selección de la busqueda del dataGridView1
        }
        public void LleComReg() //Llenar comboBox
        {
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "IdReg";
            comboBox1.DataSource = LReg.Lis_Region();
        }
        private void Busqueda()
        {
            DataTable dt=new DataTable();                                               //Llamar datos
            try                                                                         //Señala bloque de instrucciones
            {
                LReg.Nombre = comboBox1.Text;                                           //Asignar valor a la variable de la clase llamada
                dt = LReg.Fil_Region(LReg.Nombre);                                      //Dirección de los datos con filtros
                dataGridView1.Rows.Clear();                                             //Limpiar dataGridView1
                for (int i= 0;i < dt.Rows.Count;i++)                                    //For para generar busqueda
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);                              //Asignar parametros para la busqueda
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();    //Primera celda de la dataGridView1
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();    //Segunda celda de la dataGridView1
                }
            }
            catch (Exception ex)                                                        //Excepcion de las instrucciones dadas
            { 
                MessageBox.Show(ex.Message);                                            //Mensaje de otro tipo de error ()
            }
            dataGridView1.ClearSelection();                                             //Eliminar seleccionado en dataGridView1
        }
        
        public void Validar()                                                           //Clase para validar botones
        {
            if (textBox2.Text.Trim()!="")                                               //textbox2 distinto de vacío
            {
                button1.Enabled=true;   //Boton button1 Habilitado
                button2.Enabled=true;   //Boton button2 habilitado
                button3.Enabled=true;   //Boton button3 habilitado
            }
            else                        //Contrario a la accion
            {
                button1.Enabled=false;  //Boton button1 inhabilitado
                button2.Enabled=false;  //Boton button2 inhabilitado
                button3.Enabled=false;  //Boton button3 inhabilitado
            }
        }
        public void Check_funciones()       //Clase para quitar check e inhabilitarlos
        {
            checkBox1.CheckState = CheckState.Unchecked;    //Quitar check a checkbox
            checkBox2.CheckState = CheckState.Unchecked;    //Quitar check a checkbox
            checkBox3.CheckState= CheckState.Unchecked;     //Quitar check a checkbox
            checkBox1.Enabled = true;                       //Habilitar check
            checkBox2.Enabled = false;                      //Inhabilitar check
            checkBox3.Enabled = false;                      //Inhabilitar check
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked)       //Condicion del check seleccionado
            {
                checkBox2.CheckState = CheckState.Unchecked;    //Quitar check a chechbox2
                checkBox3.CheckState = CheckState.Unchecked;    //Quitar check a checkbox3
                label3.Text = "Ingresar Región:";               //Dejar texto del label en "Ingresar Región:"
                textBox2.Enabled=true;                          //Dejar textbox2.Text habilitado
                textBox1.Clear();                               //Limpiar textbox1
                textBox2.Clear();                               //Limpiar textbox2
                button1.Visible=true;                           //Dejar boton de ingresar visible
            }
            else                                                //Contrario a la accion
            {
                label3.Text = "";                               //Dejar texto del label en blanco
                button1.Visible = false;                        //Dejar boton de ingresar invisible
            }
            Validar();                                          //Llamar clase para validar checkbox
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState==CheckState.Checked)       //Condicion del check seleccionado
            {
                checkBox1.CheckState = CheckState.Unchecked;    //Quitar check a checkbox1
                checkBox3.CheckState = CheckState.Unchecked;    //Quitar check a checkbox3
                label3.Text = "Actualizar Región";              //Dejar texto del label en "Actualizar Región:"
                textBox2.Enabled = true;                        //Dejar textbox2.Text habilitado
                button2.Visible=true;                           //Dejar boton de Modificar visible
            }
            else                                                //Contrario a la accion
            {
                label3.Text = "";                               //Dejar texto del label en blanco
                button2.Visible = false;                        //Dejar boton de modificar invisible
            }
            Validar();                                          //Llamar clase para validar Checkbox
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState==CheckState.Checked)       //Condicion del Check seleccionado
            {
                checkBox1.CheckState = CheckState.Unchecked;    //Quitar check a checkbox1
                checkBox2.CheckState = CheckState.Unchecked;    //Quitar check a checkbox2
                label3.Text = "Eliminar Región:";               //Dejar texto del label en "Eliminar Región:"
                textBox1.Enabled = false;                       //Dejar textbox1 inhabilitado
                button3.Visible=true;                           //Dejar boton de eliminar visible
            }
            else                                                //Contrario a la accion
            {
                label3.Text = "";                               //Dejar texto del label en blanco
                button3.Visible = false;                        //Dejar boton de eliminar invisible
            }
            Validar();                                          //Llamar clase para validar Checkbox
        }

        private void button5_Click(object sender, EventArgs e)  //Accion de Button click
        {
            textBox1.Clear();                                   //Limpiar textbox
            textBox2.Clear();                                   //Limpiar textbox
            textBox2.Enabled=false;                             //Inhabilitar textbox
            Check_funciones();                                  //Llamar función
            Validar();                                          //Llamar función
            LleComReg();                                        //Llenar combobox
            CargarDatos();                                      //Llamar función
        }

        private void button6_Click(object sender, EventArgs e)  //Accion de Button click
        {
            this.Close();                                       //Cerrar formulario
        }

        private void button7_Click(object sender, EventArgs e)  //Accion de Button click
        {
            Application.Exit();                                 //Cerrar la aplicación
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Está seguro de la acción a realizar?", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);    
            String Mensaje = "";                                                                                                                    //Variable de tipo String para mensaje
            try                                                                                                                                     //Señala bloque de instrucciones
            {
                if (res == DialogResult.Yes)                                                                                                        //Si el resultado del formulario es sí:
                    {
                    LReg.Nombre = textBox2.Text;                                                                                                    //Asignar valor a la variable de la clase llamada
                    Mensaje = LReg.Ing_Region();                                                                                                    //Llamar a función de la clase
                    if (Mensaje =="Los Datos ya Existen.")                                                                                          //Condición con mensaje de la base de datos
                    {
                        MessageBox.Show(Mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);                                            //Muestra ventana emergente con mensaje
                    }
                    else                                                                                                                             //Accion contraria a la condicion
                    {
                        MessageBox.Show(Mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);                                       //Muestra ventana emergente con mensaje
                        button5.PerformClick();                                                                                                      //Realiza un click del botón5(limpiar)
                    }
                }
                else if(res==DialogResult.No)               //Si el resultado de la consulta es no:
                {
                    button6.Focus();                        //Enfocar el botón6
                }
                else if (res == DialogResult.Cancel)        //Si el resultado de la consulta es cancelar:
                {
                    button7.Focus();                        //Enfocar el botón7(salir de la aplicación)
                }
            }
            catch (Exception ex)                            //Excepción de las instrucciones dadas
            {
                MessageBox.Show(ex.Message);                //Mensaje de otro tipo de error
            }
            CargarDatos();                                  //Llamar función
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))                    //Ciclo para bloquear numeros
            {
                e.Handled = true;                           //Permitir cualquier valor menos la condicion anterior
                MessageBox.Show("Solo se permiten letras", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);  //Mensaje de OK con error que dice que solo se permite letras
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textBox2.Text);        //Primera con mayúsculas
            textBox2.SelectionStart=textBox2.Text.Length;                                                               //Dejar el textbox para que tome la primera letra con mayuscula
            Validar();                                                                                                  //Llamar funcion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LleComReg();        //Llenar el combobox
            CargarDatos();      //Cargar datos en el dataGridView
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Está seguro de la acción a realizar", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            String Mensaje = "";                                                                                    //Variable de tipo String para mensaje
            try                                                                                                     //Señala bloque de instrucciones
            {
                if (res==DialogResult.Yes)
                {
                    LReg.IdReg = Convert.ToInt32(textBox1.Text);                                                    //Asignar valor a la variable de la clase llamada transformando el dato de varchar a int
                    LReg.Nombre = textBox2.Text;                                                                    //Asignar valor a la variable de la clase llamada
                    Mensaje =LReg.Act_Region();                                                                     //Llamar a funcion de la clase
                    if (Mensaje == "Región no Existe.")                                                             //Condicion con mensaje de la base de datos
                    {
                        MessageBox.Show(Mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else                                                                                            //Condicion con mensaje de la base de datos
                    {
                        MessageBox.Show(Mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else if(res==DialogResult.No)   //Si el resultado de la consulta es no:
                {
                    button6.Focus();            //Enfocar el boton de Volver
                    button2.Enabled = false;    //Deshabilita el boton de modificar

                }
                else if (res == DialogResult.Cancel)    //Si el resultado es cancelar:
                {
                    button7.Focus();                    //Enfoca el boton de salir
                    button2.Enabled = false;            //Deshabilita el boton de modificar
                }
            }
            catch (Exception ex)                        //Excepcion de las instrucciones dadas
            {
                MessageBox.Show(ex.Message);            //Mensaje de otro tipo de error
            }
            CargarDatos();                              //Llamar funcion
            button5.PerformClick();                     //Realizar click al boton de Limpiar

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Está seguro de la acción a realizar?", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            String Mensaje = "";                                                                                    //Variable de tipo String para mensaje
            try                                                                                                     //Señala bloque de instrucciones
            {
                if (res==DialogResult.Yes)
                {
                    LReg.IdReg = Convert.ToInt32(textBox1.Text);                                                    //Asignar valor a la variable de la clase llamada
                    Mensaje = LReg.Eli_Region();                                                                    //Llamar a funcion de la clase
                    if (Mensaje =="Región no Existe.")                                                              //Condicion con mensaje de la base de datos
                    {
                        MessageBox.Show(Mensaje,"Sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else                                                                                            //Condicion con mensaje de la base de datos
                    {
                        MessageBox.Show(Mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if(res==DialogResult.No)       //Si el resultado de la consulta es no:
                {
                    button6.Focus();                //Enfocar el boton de volver
                    button3.Enabled = false;        //Deshabilita el boton de eliminar
                }
                else if(res==DialogResult.Cancel)   //Si el resultado de la consulta es cancelar:
                {
                    button7.Focus();                //Enfocar el boton de salir
                    button3.Enabled = false;        //Deshabilita el boton de salir
                }
            }
            catch(Exception ex)                     //Excepcion de las instrucciones dadas
            {
                MessageBox.Show(ex.Message);        //Mensaje de otro tipo de error
            }
            CargarDatos();                          //Llamar funcion
            button5.PerformClick();                 //Realiza click boton de limpiar
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Clear();                                                           //Limpiar textbox1
            textBox2.Clear();                                                           //Limpiar textbox2
            checkBox2.Enabled = true;                                                   //Dejar checkbox2 habilitado
            checkBox3.Enabled = true;                                                   //Dejar checkbox3 habilitado
            checkBox1.CheckState = CheckState.Unchecked;                                //Quitar check a checkbox1
            checkBox1.Enabled = false;                                                  //Dejar checkbox 1 inhabilitado
            checkBox2.CheckState = CheckState.Unchecked;                                //Quitar check a checkbox2
            checkBox3.CheckState = CheckState.Unchecked;                                //Quitar check a checkbox3
            textBox1.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();    //Cargar textbox1 con valor del dataGridView1
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)     //si se cambia el campo en el combobox
        {
            Busqueda();     //llamar funcion
            Validar();      //llamar funcion
        }

        private void button4_Click(object sender, EventArgs e)      //accion de click al boton4
        {
            Pro ver=new Pro();      //seleccionar una ventana a la que saltar
            ver.Show();             //saltar a la ventana
        }
    }
}
