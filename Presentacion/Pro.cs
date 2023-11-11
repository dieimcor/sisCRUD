using Logica;           //Llama la capa lógica
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Pro : Form
    {
        LLPro LPro = new LLPro();                   //Se llaman las clases correspondientes
        LLReg LReg = new LLReg();

        public Pro()
        {
            InitializeComponent();
        }

        private void Pro_Load(object sender, EventArgs e)
        {
            LleComReg();        //Llenar el combobox region
            LleComPro();        //Llenar combobox provincia
            CargarDatos();      //Cargar datos en dataGridView1
        }
        private void CargarDatos()
        {
            DataTable dt = new DataTable();     //Llamar datos
            dt=LPro.Bus_Provincia();            //Direccion de los datos a llamar
            try                                 //Señala bloque de instrucciones
            {
                dataGridView1.Rows.Clear();     //Limpiar dataGridView1
                for (int i = 0; i < dt.Rows.Count; i++)     //For para generar la busqueda
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);      //Asignar parametros para la busqueda
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();        //Primerca celda del dataGridView1
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();        //Segunda celda del dataGridView1
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();        //Tercera celda del dataGridView1
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();        //Cuarta celda del dataGridView1
                }
            }
            catch(Exception ex)             //Excepcion de las instrucciones dadas
            {
                MessageBox.Show(ex.Message);        //Mensaje de otro tipo de error(ejemplo conexion de base de datos)
            }
            dataGridView1.ClearSelection();         //Limpiar seleccion de busqueda del dataGridView1
        }
        private void BusPro()           //Llenar la grilla con provincia
        {
            try
            {
                DataTable dt = new DataTable();
                LPro.Nombre = comboBusPro.Text;
                dt = LPro.Fil_Nom_Provincia();
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
        }
        private void BusReg()               //Llenar la grilla con region
        {
            try
            {
                DataTable dt = new DataTable();
                LPro.IdReg = Convert.ToInt32(comboBusReg.SelectedValue);
                dt = LPro.Fil_Id_Provincia(LPro.IdReg);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
        }
        public void LleComReg()             //Llenar combobox
        {
            comboBusReg.DisplayMember = "Nombre";
            comboBusReg.ValueMember = "IdReg";
            comboBusReg.DataSource = LReg.Lis_Region();
            comboReg.DisplayMember = "Nombre";
            comboReg.ValueMember = "IdReg";
            comboReg.DataSource = LReg.Lis_Region();
        }
        public void LleComPro()
        {
            comboBusPro.DisplayMember = "Nombre";
            comboBusPro.ValueMember = "IdPro";
            comboBusPro.DataSource = LPro.Lis_Provincia();
        }
        public void Validar()           //Clase para validar botones
        {
            try
            {
                if (textIngMod.Text.Trim() != "")       //textbox distinto de vacio
                {
                    if ((textIngMod.Text == textBox1.Text) && (comboReg.Text == textBox2.Text))
                    {
                        butMod.Enabled = false;
                        butIng.Enabled = false;
                    }
                    else
                    {
                        butMod.Enabled = true;
                        butIng.Enabled = true;
                    }
                }
                else
                {
                    butIng.Enabled = false;
                    butMod.Enabled = false;
                    butEli.Enabled = false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void checkIng_CheckedChanged(object sender, EventArgs e)
        {
            if (checkIng.CheckState==CheckState.Checked)        //Condicion del check seleccionado
            {
                checkMod.CheckState = CheckState.Unchecked;     //quitar check a checkMod
                checkEli.CheckState = CheckState.Unchecked;     //quitar check a checkEli
                labVac.Text = "Ingresar Provincia:";            //Dejar texto del label en "Ingresar Provincia:"
                textIngMod.Enabled = true;                      //Habilita el textbox
                comboReg.Enabled = true;                        //habilita el combobox
                textIngMod.Clear();                             //vacía el textbox textIngMod
                textId.Clear();                                 //vacía el textbox textId
                butIng.Visible = true;                          //Deja visible el boton butIng
            }
            else                    //Contrario a la accion
            {
                labVac.Text = "";       //deja el label vacio
                butIng.Visible= false;  //deja invisible el boton butIng
            }
            Validar();
        }

        private void checkMod_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMod.CheckState==CheckState.Checked)        //Condicion del check seleccionado
            {
                checkIng.CheckState = CheckState.Unchecked;     //quitar check a checkIng
                checkEli.CheckState = CheckState.Unchecked;     //quitar check a checkEli
                labVac.Text = "Actualizar Provincia:";          //Dejar texto del label en "Actualizar Region:"
                comboReg.Enabled= true;                         //habilita el combobox
                textIngMod.Enabled = true;                      //habilita textIngMod
                butMod.Visible = true;                          //boton butMod visible
            }
            else                                                //contrario a la accion
            {
                labVac.Text = "";               //deja el label vacio
                butMod.Visible= false;          //boton butMod invisible
            }
            Validar();          //Llama la funcion
        }

        private void checkEli_CheckedChanged(object sender, EventArgs e)
        {
            if(checkEli.CheckState==CheckState.Checked)         //Condicion del check seleccionado
            {
                checkIng.CheckState = CheckState.Unchecked;     //quitar check a checkIng
                checkMod.CheckState = CheckState.Unchecked;     //quitar check a checkMod
                labVac.Text = "Eliminar Provincia:";            //Dejar texto del label en "Elimiar Provincia:"
                textIngMod.Enabled = false;                     //Deshabillita textIngMod
                butEli.Enabled = true;                          //habilita el combobox
                butEli.Visible = true;                          //Deja boton butEli visible
            }
            else                //Contrario a la accion
            {
                labVac.Text = "";           //Deja el label vacio
                butEli.Visible = false;     //Boton butEli invisible
                butEli.Enabled= false;      //deja el boton butEli deshabilitado
            }
        }

        private void butIng_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            String Mensaje = "";            //Variable de tipo String para Mensaje
            try                             //Señala bloque de instrucciones
            {
                if (res == DialogResult.Yes)        //Si el resultado del formulario es sí:
                {
                    LPro.Nombre = textIngMod.Text;      //Asignar valor a la variable de la clase llamada
                    LPro.IdReg = Convert.ToInt32(comboReg.SelectedValue);   //Transforma en entero la id del registro recibido
                    Mensaje = LPro.Ing_Provincia();
                    if (Mensaje=="Provincia ya Existe.")   //Condicion con mensaje de la base de datos
                    {
                        MessageBox.Show(Mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);    //Muestra ventana emergente con mensaje
                    }
                    else            //Accion contraria a la condicion
                    {
                        MessageBox.Show(Mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);  //Muestra ventana emergente con mensaje
                        butLim.PerformClick();              //realiza un click del butLim
                    }
                }
                else if(res == DialogResult.No)     //Si el resultado de la consulta es no:
                {
                    butVol.Focus();         //Enfocar el butVol
                }
                else if(res == DialogResult.Cancel)     //Si el resultado de la consulta es Cancel:
                {
                    butSal.Focus();     //Enfoca el butSal
                }
            }
            catch (Exception ex)        //Excepcion de las instrucciones dadas
            {
                MessageBox.Show(ex.Message);        //Mensaje de otro tipo de error
            }
            CargarDatos();      //Llamar funcion
        }

        private void butMod_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            String Mensaje = "";    //Variable de tipo String para Mensaje
            try                     //Señala bloque de instrucciones
            {
                if (res == DialogResult.Yes)    //Si el resultado del formulario es Sí:
                {
                    LPro.IdPro = Convert.ToInt32(textId.Text);              //Asignar valor a la variable de la clase llamada
                    LPro.Nombre = textIngMod.Text;                          //Asignar valor a la variable de la clase llamada
                    LPro.IdReg = Convert.ToInt32(comboReg.SelectedValue);   //Convertir a entero el comboReg seleccionado
                    Mensaje = LPro.Act_Provincia();                         //Asignar valor desde la base de datos al mensaje
                    if(Mensaje =="Provincia no Existe.")                       //Condicion con mensaje de la base de datos
                    {
                        MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);   //Mensaje de la base de datos
                    }
                    else
                    {
                        MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);     //Mostrar mensaje de la base de datos
                        butLim.PerformClick();      //Realiza un click al boton butLim
                    }
                }
                else if (res == DialogResult.No)        //Si el resultado de la consulta es No:
                {
                    butVol.Focus();                     //Enfocar el boton butVal
                    butMod.Enabled = false;             //butMod inhabilitado
                }
                else if (res == DialogResult.Cancel)    //Si el resultado de la consulta es Cancel:
                {
                    butSal.Focus();                     //Enfoca el boton butSal
                    butMod.Enabled = false;             //butMod inhabilitado
                }
            }
            catch(Exception ex)             //Excepcion de las instrucciones dadas
            {
                MessageBox.Show(ex.Message);        //Mensaje de otro tipo de error
            }
            CargarDatos();                  //Llama a la funcion
        }

        private void butEli_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            String Mensaje = "";            //Variable de tipo String para Mensaje
            try                             //Señala bloque de instrucciones
            {
                if (res == DialogResult.Yes)        //Si el resultado de la consulta es Sí:
                {
                    LPro.IdPro = Convert.ToInt32(textId.Text);      //Asignar valor a la variable de la clase llamada
                    Mensaje = LPro.Eli_Provincia();                 //Guarda un texto desde la base de datos en Mensaje
                    if(Mensaje=="Provincia no Existe.")             //Condicion con mensaje de la base de datos
                    {
                        MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);       //Muestra ventana emergente con mensaje
                    }
                    else            //Contraria a la condicion
                    {
                        MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);     //Muestra ventana emergente con mensaje
                        butLim.PerformClick();              //Realiza un click al butLim
                    }
                }
                else if (res == DialogResult.No)        //Si el resultado de la consulta es No:
                {
                    butVol.Focus();                 //Enfoca butVol
                    butEli.Enabled = false;         //Deshabilita butEli
                }
                else if (res == DialogResult.Cancel)    //Si el resultado de la consulta es Cancel
                {
                    butSal.Focus();             //Enfoca el butSal
                    butEli.Enabled = false;     //Deshabilita butEli
                }
            }
            catch(Exception ex)                     //Excepcion de las instrucciones dads
            {
                MessageBox.Show(ex.Message);        //Mensaje de otro tipo de error
            }
            CargarDatos();                      //LLama a la funcion
        }

        private void butLim_Click(object sender, EventArgs e)   //Accion de Button click
        {
            textId.Clear();                 //Limpiar textbox
            textIngMod.Clear();             //Limpiar textbox
            textBox1.Clear();               //limpiar textbox
            textBox2.Clear();               //limpiar textbox
            comboReg.Enabled = false;       //inhabilita combobox
            checkMod.CheckState = CheckState.Unchecked; //quitar check a checkMod
            checkEli.CheckState = CheckState.Unchecked;  //quitar check a checkEli
            checkIng.CheckState = CheckState.Unchecked;  //quitar check a checkIng
            textIngMod.Enabled = false;                 //deshabilita el textIngMod
            checkEli.Enabled = false;       //deshabilita el checkeli
            checkMod.Enabled = false;       //deshabilita el checkmod
            checkIng.Enabled = true;        //habilita el checking
            Validar();
            LleComReg();
            CargarDatos();
        }

        private void butVol_Click(object sender, EventArgs e)       //accion de button click
        {
            this.Close();           //volver un formulario atras
        }

        private void butSal_Click(object sender, EventArgs e)
        {
            Application.Exit();             //cerrar la aplicacion
        }

        private void comboReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar();      //Se llama la funcion
        }

        private void textIngMod_TextChanged(object sender, EventArgs e)
        {
            textIngMod.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textIngMod.Text);        //Primera con mayusculas
            textIngMod.SelectionStart = textIngMod.Text.Length;             //Dejar el textbox para que tome la primera letra con mayuscula
            Validar();      //llamar funcion
        }

        private void butNR_Click(object sender, EventArgs e)        //accion de button click
        {
            Form1 ver=new Form1();          //declarar el formulario al que se quiere saltar
            ver.Show();                     //realizar el salto de formulario
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            textId.Clear();                                                                 //se vacia el textbox
            textIngMod.Clear();                                                             //se vacia el textbox
            checkMod.Enabled = true;                                                        //se habilita el checkbox
            checkEli.Enabled = true;                                                        //se habilita el checkbox
            checkIng.CheckState = CheckState.Unchecked;                                     //quitar checkbox
            checkIng.Enabled = false;                                                       //se inhabilita el checkbox
            checkMod.CheckState = CheckState.Unchecked;                                     //quitar checkbox
            checkEli.CheckState = CheckState.Unchecked;                                     //quitar checkbox
            textId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();          //asigna el valor de la grilla indicado al textbox
            textIngMod.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();      //asigna el valor de la grilla indicado al textbox
            textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();        //asigna el valor de la grilla indicado al textbox
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();        //asigna el valor de la grilla indicado al textbox
            textBox3.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();        //asigna el valor de la grilla indicado al textbox
            textIngMod.Enabled = false;                                     //inhabilita textbox
            comboReg.Enabled = false;                                       //inhabilita combobox
        }

        private void comboBusReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            BusReg();                                                                       //llamar funcion
            LPro.IdReg=Convert.ToInt32(comboBusReg.SelectedValue);                          // Asigna el valor seleccionado en comboBusReg a la variable LPro.IdReg
            comboBusPro.DisplayMember = "Nombre";                                           //Mostrar en el combobox "Nombre"
            comboBusPro.ValueMember = "IdPro";                                              //Asignar al combobox los campos con sus id respectivas de la base de datos
            comboBusPro.DataSource = LPro.Fil_Id_Provincia(LPro.IdReg);                     //Se guarda la direccion en la que se almacena la informacion
        }

        private void comboBusPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            BusPro();       //llama a la funcion
        }

        private void butIC_Click(object sender, EventArgs e)        //Accion de click al boton
        {
            Form1 ver = new Form1();            //Asignar el formulario a saltar
            ver.Show();                         //Saltar al formulario
        }
    }
}
