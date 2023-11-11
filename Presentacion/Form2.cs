using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Logica;           //Llama la capa logica

namespace Presentacion
{
    public partial class Form2 : Form
    {
        LLReg LReg = new LLReg();
        LLCom LCom = new LLCom();
        LLPro LPro = new LLPro();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)     //Método que se ejecuta al cargar el formulario
        {
            LleComReg();        //Llena combobox region
            CargarDatos();      //Cargar datos en datagridview
        }
        private void CargarDatos()      //Cargarr datos en datagridview
        {
            DataTable dt = new DataTable();
            dt = LCom.Bus_Comuna();
            try
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][4].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
        }
        public void LleComReg()         //Método para llenar el combobox de region
        {
            ComboBusReg.DisplayMember = "Nombre";
            ComboBusReg.ValueMember = "IdReg";
            ComboBusReg.DataSource = LReg.Lis_Region();
            ComboIngModReg.DisplayMember = "Nombre";
            ComboIngModReg.ValueMember = "IdReg";
            ComboIngModReg.DataSource = LReg.Lis_Region();
        }

        private void ComboBusReg_SelectedIndexChanged(object sender, EventArgs e)   //Evento cuando se selecciona un elemento en el combobox de region
        {
            BusReg();
            LPro.IdReg = Convert.ToInt32(ComboBusReg.SelectedValue);
            ComboBusPro.DisplayMember = "Nombre";
            ComboBusPro.ValueMember = "IdPro";
            ComboBusPro.DataSource = LPro.Fil_Id_Provincia(LPro.IdReg);
        }
        private void BusReg()       //Método para llenar la grilla con Region
        {
            try
            {
                DataTable dt = new DataTable();
                LCom.IdReg = Convert.ToInt32(ComboBusReg.SelectedValue);
                dt = LCom.Fil_IdReg_Región(LCom.IdReg);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][4].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
        }

        private void ComboBusPro_SelectedIndexChanged(object sender, EventArgs e)       //Evento cuando se selecciona un elemento en combobox provincia
        {
            BusPro();
            LCom.IdPro = Convert.ToInt32(ComboBusPro.SelectedValue);
            ComboBusCom.DisplayMember = "Nombre";
            ComboBusCom.ValueMember = "IdPro";
            ComboBusCom.DataSource = LCom.Fil_Id_Comuna(LCom.IdPro);
        }
        private void BusPro()           //Metodo para llenar la grilla con provincia
        {
            try
            {
                DataTable dt = new DataTable();
                LCom.IdReg = Convert.ToInt32(ComboBusPro.SelectedValue);
                dt = LCom.Fil_IdReg_Provincia(LCom.IdReg);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][4].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
        }
        private void BusCom()           //Metodo para llenar la grilla con comuna
        {
            try
            {
                DataTable dt = new DataTable();
                LCom.Nombre = ComboBusCom.Text;
                dt = LCom.Fil_Nom_Comuna();
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(dt.Rows[i][0]);
                    dataGridView1.Rows[i].Cells[0].Value = dt.Rows[i][0].ToString();
                    dataGridView1.Rows[i].Cells[1].Value = dt.Rows[i][1].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dt.Rows[i][2].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dt.Rows[i][3].ToString();
                    dataGridView1.Rows[i].Cells[5].Value = dt.Rows[i][4].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridView1.ClearSelection();
        }

        private void ComboBusCom_SelectedIndexChanged(object sender, EventArgs e)       //Evento cuando se selecciona un elemento en combobox buscar comuna
        {
            BusCom();       //Llamar funcion
        }
        public void Validar()       //Metodo para validar la habilitacion de los botones
        {
            if (textIngMod.Text.Trim() != "")
            {
                if ((textIngMod.Text == textConCom.Text) && (ComboIngMod.Text == textConPro.Text))
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)      //Evento al hacer doble click en la grilla
        {
            textId.Clear();             //vaciar textbox
            textIngMod.Clear();         //vaciar textbox
            checkMod.Enabled = true;                        //habilitar checkbox
            checkEli.Enabled = true;                        //habilitar checkbox
            checkIng.CheckState = CheckState.Unchecked;     //quitar check
            checkIng.Enabled = false;                       //inhabilitar checkbox
            checkMod.CheckState = CheckState.Unchecked;     //quitar check
            checkEli.CheckState = CheckState.Unchecked;     //quitar check
            textId.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();          //asigna el valor de la grilla indicado al textbox
            textIngMod.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();      //asigna el valor de la grilla indicado al textbox
            textConCom.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();      //asigna el valor de la grilla indicado al textbox
            ComboIngMod.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();     //asigna el valor de la grilla indicado al textbox
            textConPro.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();      //asigna el valor de la grilla indicado al textbox
            ComboIngMod.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();     //asigna el valor de la grilla indicado al textbox
            textIngMod.Enabled = false;         //inhabilita textbox
            ComboIngMod.Enabled = false;        //inhabilita combobox
            ComboIngModReg.Enabled = false;     //inhabilita combobox
        }

        private void checkIng_CheckedChanged(object sender, EventArgs e)    //Si cambia el estado del check
        {
            if (checkIng.CheckState == CheckState.Checked)
            {
                //Limpia los valores actuales y permite la edicion de campos
                checkMod.CheckState = CheckState.Unchecked;
                checkEli.CheckState = CheckState.Unchecked;
                labVacio.Text = "Ingresar Comuna:";
                textIngMod.Enabled = true;
                ComboIngMod.Enabled = true;
                ComboIngModReg.Enabled = true;
                textIngMod.Clear();
                textId.Clear();
                butIng.Visible = true;
            }
            else
            {
                //Restaura la interfaz
                labVacio.Text = "";
                butIng.Visible = false;
            }
        }

        private void checkMod_CheckedChanged(object sender, EventArgs e)        //Si cambia el estado del check
        {
            if (checkMod.CheckState == CheckState.Checked)
            {
                //Limpia los valores actuales y permite la edicion de campos
                checkIng.CheckState = CheckState.Unchecked;
                checkEli.CheckState = CheckState.Unchecked;
                labVacio.Text = "Actualizar Comuna:";
                textIngMod.Enabled = true;
                ComboIngMod.Enabled = true;
                ComboIngModReg.Enabled = true;
                butMod.Visible = true;
            }
            else
            {
                //Restaura la interfaz
                labVacio.Text = "";
                butMod.Visible = false;
            }
            Validar();      //llamar funcion
        }

        private void checkEli_CheckedChanged(object sender, EventArgs e)            //Si cambia el estado del check
        {
            if (checkEli.CheckState == CheckState.Unchecked)
            {
                //Limpia los valores actuales y permite utilizar butEli
                checkIng.CheckState = CheckState.Unchecked;
                checkMod.CheckState = CheckState.Unchecked;
                labVacio.Text = "Eliminar Comuna:";
                textIngMod.Enabled = false;
                butEli.Visible = true;
                butEli.Enabled = true;
            }
            else
            {
                //Restaura la interfaz
                labVacio.Text = "";
                butEli.Visible = false;
                butEli.Enabled = false;
            }
            Validar();      //llamar funcion
        }

        private void ComboIngModReg_SelectedIndexChanged(object sender, EventArgs e)        //Si se selecciona un elemento del combobox
        {
            LPro.IdReg = Convert.ToInt32(ComboIngModReg.SelectedValue);     
            ComboIngMod.DisplayMember = "Nombre";                           
            ComboIngMod.ValueMember = "IdPro";                              
            ComboIngMod.DataSource = LPro.Fil_Id_Provincia(LPro.IdReg);     
        }

        private void ComboIngMod_SelectedIndexChanged(object sender, EventArgs e)           //Si se selecciona un elemento del combobox
        {
            Validar();  //llamar funcion
        }

        private void textIngMod_TextChanged(object sender, EventArgs e)         //evento cuando se ingresa algo en textbox
        {
            //Convierte la primera letra de las palabras en mayusculas
            textIngMod.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(textIngMod.Text);
            textIngMod.SelectionStart = textIngMod.Text.Length;
            Validar();
        }

        private void butIng_Click(object sender, EventArgs e)       //Evento de click en boton ingresar
        {
            //Muestra un cuadro de dialogo para confirmar la accion
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            String Mensaje = "";
            try
            {
                if (res == DialogResult.Yes)
                {
                    //Recopila los datos ingresados
                    LCom.Nombre = textIngMod.Text;
                    LCom.IdPro = Convert.ToInt32(ComboIngMod.SelectedValue);
                    Mensaje = LCom.Ing_Comuna();
                    if (Mensaje == "Los Datos ya Existen.")
                    {
                        MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        butLim.PerformClick();
                    }
                }
                else if (res == DialogResult.No)
                {
                    butVol.Focus();
                }
                else if (res == DialogResult.Cancel)
                {
                    butSal.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CargarDatos();      //Recarga los datos en la grilla
        }

        private void butMod_Click(object sender, EventArgs e)       //evento de click en butMod
        {
            //Muestra un cuadro de dialogo para confirmar la accion
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            String Mensaje = "";
            try
            {
                if (res == DialogResult.Yes)
                {
                    //Recopila los datos ingresados
                    LCom.IdCom = Convert.ToInt32(textId.Text);
                    LCom.Nombre = textIngMod.Text;
                    LCom.IdPro = Convert.ToInt32(ComboIngMod.SelectedValue);
                    Mensaje = LCom.Act_Comuna();
                    if (Mensaje == "Comuna no Existe.")
                    {
                        MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        butLim.PerformClick();
                    }
                }
                else if (res == DialogResult.No)
                {
                    butVol.Focus();
                    butMod.Enabled = false;
                }
                else if (res == DialogResult.Cancel)
                {
                    butSal.Focus();
                    butMod.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CargarDatos();          //Recarga los datos en la grilla

        }

        private void butEli_Click(object sender, EventArgs e)
        {
            //Muestra un cuadro de dialogo para confirmar la accion
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            String Mensaje = "";
            try
            {
                if (res == DialogResult.Yes)
                {
                    //Recopila los datos ingresados
                    LCom.IdCom = Convert.ToInt32(textId.Text);
                    Mensaje = LCom.Eli_Comuna();
                    if (Mensaje =="Comuna no Existe.")
                    {
                        MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(Mensaje, "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        butLim.PerformClick();
                    }
                }
                else if (res == DialogResult.No)
                {
                    butVol.Focus();
                    butEli.Enabled = false;
                }
                else if (res == DialogResult.Cancel)
                {
                    butSal.Focus();
                    butEli.Enabled = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            CargarDatos();      //Carga los datos en la grilla
        }

        private void butLim_Click(object sender, EventArgs e)       //Evento de click en butLim
        {
            //Limpia y restaura la interfaz
            textId.Clear();
            textIngMod.Clear();
            textConCom.Clear();
            textConPro.Clear();
            textIngMod.Enabled=false;
            checkIng.CheckState = CheckState.Unchecked;
            checkMod.CheckState = CheckState.Unchecked;
            checkEli.CheckState = CheckState.Unchecked;
            checkIng.Enabled = true;
            checkMod.Enabled = false;
            checkEli.Enabled=false;
            ComboBusReg.Enabled = true;
            ComboBusPro.Enabled = true;
            Validar();
            LleComReg();
            CargarDatos();
        }

        private void butVol_Click(object sender, EventArgs e)   //Evento de click en butVol
        {
            this.Close();       //Cierra el formulario
        }

        private void butSal_Click(object sender, EventArgs e)       //Evento de click en butSal
        {
            Application.Exit();         //Salir de la aplicacion
        }
    } 
}
