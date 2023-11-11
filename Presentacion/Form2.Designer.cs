namespace Presentacion
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labInf = new System.Windows.Forms.Label();
            this.labBusCom = new System.Windows.Forms.Label();
            this.labBusPor = new System.Windows.Forms.Label();
            this.labBusReg = new System.Windows.Forms.Label();
            this.labReg = new System.Windows.Forms.Label();
            this.labPro = new System.Windows.Forms.Label();
            this.labVacio = new System.Windows.Forms.Label();
            this.checkIng = new System.Windows.Forms.CheckBox();
            this.checkMod = new System.Windows.Forms.CheckBox();
            this.checkEli = new System.Windows.Forms.CheckBox();
            this.ComboBusCom = new System.Windows.Forms.ComboBox();
            this.ComboBusPro = new System.Windows.Forms.ComboBox();
            this.ComboBusReg = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboIngModReg = new System.Windows.Forms.ComboBox();
            this.ComboIngMod = new System.Windows.Forms.ComboBox();
            this.textIngMod = new System.Windows.Forms.TextBox();
            this.butIng = new System.Windows.Forms.Button();
            this.butMod = new System.Windows.Forms.Button();
            this.butEli = new System.Windows.Forms.Button();
            this.butNP = new System.Windows.Forms.Button();
            this.butLim = new System.Windows.Forms.Button();
            this.butVol = new System.Windows.Forms.Button();
            this.butSal = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.textConCom = new System.Windows.Forms.TextBox();
            this.textConPro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labInf
            // 
            this.labInf.AutoSize = true;
            this.labInf.Location = new System.Drawing.Point(381, 5);
            this.labInf.Name = "labInf";
            this.labInf.Size = new System.Drawing.Size(174, 16);
            this.labInf.TabIndex = 0;
            this.labInf.Text = "Información sobre Comunas";
            // 
            // labBusCom
            // 
            this.labBusCom.AutoSize = true;
            this.labBusCom.Location = new System.Drawing.Point(86, 98);
            this.labBusCom.Name = "labBusCom";
            this.labBusCom.Size = new System.Drawing.Size(128, 16);
            this.labBusCom.TabIndex = 1;
            this.labBusCom.Text = "Buscar por Comuna:";
            // 
            // labBusPor
            // 
            this.labBusPor.AutoSize = true;
            this.labBusPor.Location = new System.Drawing.Point(319, 98);
            this.labBusPor.Name = "labBusPor";
            this.labBusPor.Size = new System.Drawing.Size(134, 16);
            this.labBusPor.TabIndex = 2;
            this.labBusPor.Text = "Buscar por Provincia:";
            // 
            // labBusReg
            // 
            this.labBusReg.AutoSize = true;
            this.labBusReg.Location = new System.Drawing.Point(643, 98);
            this.labBusReg.Name = "labBusReg";
            this.labBusReg.Size = new System.Drawing.Size(122, 16);
            this.labBusReg.TabIndex = 3;
            this.labBusReg.Text = "Buscar por Región:";
            // 
            // labReg
            // 
            this.labReg.AutoSize = true;
            this.labReg.Location = new System.Drawing.Point(99, 347);
            this.labReg.Name = "labReg";
            this.labReg.Size = new System.Drawing.Size(54, 16);
            this.labReg.TabIndex = 4;
            this.labReg.Text = "Región:";
            // 
            // labPro
            // 
            this.labPro.AutoSize = true;
            this.labPro.Location = new System.Drawing.Point(99, 377);
            this.labPro.Name = "labPro";
            this.labPro.Size = new System.Drawing.Size(66, 16);
            this.labPro.TabIndex = 5;
            this.labPro.Text = "Provincia:";
            // 
            // labVacio
            // 
            this.labVacio.AutoSize = true;
            this.labVacio.Location = new System.Drawing.Point(99, 403);
            this.labVacio.Name = "labVacio";
            this.labVacio.Size = new System.Drawing.Size(0, 16);
            this.labVacio.TabIndex = 6;
            // 
            // checkIng
            // 
            this.checkIng.AutoSize = true;
            this.checkIng.Location = new System.Drawing.Point(89, 61);
            this.checkIng.Name = "checkIng";
            this.checkIng.Size = new System.Drawing.Size(78, 20);
            this.checkIng.TabIndex = 7;
            this.checkIng.Text = "Ingresar";
            this.checkIng.UseVisualStyleBackColor = true;
            this.checkIng.CheckedChanged += new System.EventHandler(this.checkIng_CheckedChanged);
            // 
            // checkMod
            // 
            this.checkMod.AutoSize = true;
            this.checkMod.Location = new System.Drawing.Point(438, 61);
            this.checkMod.Name = "checkMod";
            this.checkMod.Size = new System.Drawing.Size(84, 20);
            this.checkMod.TabIndex = 8;
            this.checkMod.Text = "Modificar";
            this.checkMod.UseVisualStyleBackColor = true;
            this.checkMod.CheckedChanged += new System.EventHandler(this.checkMod_CheckedChanged);
            // 
            // checkEli
            // 
            this.checkEli.AutoSize = true;
            this.checkEli.Location = new System.Drawing.Point(772, 61);
            this.checkEli.Name = "checkEli";
            this.checkEli.Size = new System.Drawing.Size(77, 20);
            this.checkEli.TabIndex = 9;
            this.checkEli.Text = "Eliminar";
            this.checkEli.UseVisualStyleBackColor = true;
            this.checkEli.CheckedChanged += new System.EventHandler(this.checkEli_CheckedChanged);
            // 
            // ComboBusCom
            // 
            this.ComboBusCom.FormattingEnabled = true;
            this.ComboBusCom.Location = new System.Drawing.Point(64, 151);
            this.ComboBusCom.Name = "ComboBusCom";
            this.ComboBusCom.Size = new System.Drawing.Size(268, 24);
            this.ComboBusCom.TabIndex = 10;
            this.ComboBusCom.SelectedIndexChanged += new System.EventHandler(this.ComboBusCom_SelectedIndexChanged);
            // 
            // ComboBusPro
            // 
            this.ComboBusPro.FormattingEnabled = true;
            this.ComboBusPro.Location = new System.Drawing.Point(322, 151);
            this.ComboBusPro.Name = "ComboBusPro";
            this.ComboBusPro.Size = new System.Drawing.Size(276, 24);
            this.ComboBusPro.TabIndex = 11;
            this.ComboBusPro.SelectedIndexChanged += new System.EventHandler(this.ComboBusPro_SelectedIndexChanged);
            // 
            // ComboBusReg
            // 
            this.ComboBusReg.FormattingEnabled = true;
            this.ComboBusReg.Location = new System.Drawing.Point(599, 151);
            this.ComboBusReg.Name = "ComboBusReg";
            this.ComboBusReg.Size = new System.Drawing.Size(250, 24);
            this.ComboBusReg.TabIndex = 12;
            this.ComboBusReg.SelectedIndexChanged += new System.EventHandler(this.ComboBusReg_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(64, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(785, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Comuna";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Colum1";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Provincia";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Colum2";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Region";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 200;
            // 
            // ComboIngModReg
            // 
            this.ComboIngModReg.FormattingEnabled = true;
            this.ComboIngModReg.Location = new System.Drawing.Point(182, 344);
            this.ComboIngModReg.Name = "ComboIngModReg";
            this.ComboIngModReg.Size = new System.Drawing.Size(325, 24);
            this.ComboIngModReg.TabIndex = 14;
            this.ComboIngModReg.SelectedIndexChanged += new System.EventHandler(this.ComboIngModReg_SelectedIndexChanged);
            // 
            // ComboIngMod
            // 
            this.ComboIngMod.FormattingEnabled = true;
            this.ComboIngMod.Location = new System.Drawing.Point(283, 374);
            this.ComboIngMod.Name = "ComboIngMod";
            this.ComboIngMod.Size = new System.Drawing.Size(224, 24);
            this.ComboIngMod.TabIndex = 15;
            this.ComboIngMod.SelectedIndexChanged += new System.EventHandler(this.ComboIngMod_SelectedIndexChanged);
            // 
            // textIngMod
            // 
            this.textIngMod.Location = new System.Drawing.Point(322, 404);
            this.textIngMod.Name = "textIngMod";
            this.textIngMod.Size = new System.Drawing.Size(185, 22);
            this.textIngMod.TabIndex = 16;
            this.textIngMod.TextChanged += new System.EventHandler(this.textIngMod_TextChanged);
            // 
            // butIng
            // 
            this.butIng.Location = new System.Drawing.Point(543, 344);
            this.butIng.Name = "butIng";
            this.butIng.Size = new System.Drawing.Size(123, 46);
            this.butIng.TabIndex = 17;
            this.butIng.Text = "Ingresar";
            this.butIng.UseVisualStyleBackColor = true;
            this.butIng.Click += new System.EventHandler(this.butIng_Click);
            // 
            // butMod
            // 
            this.butMod.Location = new System.Drawing.Point(543, 344);
            this.butMod.Name = "butMod";
            this.butMod.Size = new System.Drawing.Size(123, 46);
            this.butMod.TabIndex = 18;
            this.butMod.Text = "Modificar";
            this.butMod.UseVisualStyleBackColor = true;
            this.butMod.Click += new System.EventHandler(this.butMod_Click);
            // 
            // butEli
            // 
            this.butEli.Location = new System.Drawing.Point(543, 344);
            this.butEli.Name = "butEli";
            this.butEli.Size = new System.Drawing.Size(123, 46);
            this.butEli.TabIndex = 19;
            this.butEli.Text = "Eliminar";
            this.butEli.UseVisualStyleBackColor = true;
            this.butEli.Click += new System.EventHandler(this.butEli_Click);
            // 
            // butNP
            // 
            this.butNP.Location = new System.Drawing.Point(543, 403);
            this.butNP.Name = "butNP";
            this.butNP.Size = new System.Drawing.Size(140, 23);
            this.butNP.TabIndex = 20;
            this.butNP.Text = "Nueva Provincia";
            this.butNP.UseVisualStyleBackColor = true;
            // 
            // butLim
            // 
            this.butLim.Location = new System.Drawing.Point(737, 332);
            this.butLim.Name = "butLim";
            this.butLim.Size = new System.Drawing.Size(65, 46);
            this.butLim.TabIndex = 21;
            this.butLim.Text = "Limpiar";
            this.butLim.UseVisualStyleBackColor = true;
            this.butLim.Click += new System.EventHandler(this.butLim_Click);
            // 
            // butVol
            // 
            this.butVol.Location = new System.Drawing.Point(700, 388);
            this.butVol.Name = "butVol";
            this.butVol.Size = new System.Drawing.Size(65, 46);
            this.butVol.TabIndex = 22;
            this.butVol.Text = "Volver";
            this.butVol.UseVisualStyleBackColor = true;
            this.butVol.Click += new System.EventHandler(this.butVol_Click);
            // 
            // butSal
            // 
            this.butSal.Location = new System.Drawing.Point(772, 388);
            this.butSal.Name = "butSal";
            this.butSal.Size = new System.Drawing.Size(65, 46);
            this.butSal.TabIndex = 23;
            this.butSal.Text = "Salir";
            this.butSal.UseVisualStyleBackColor = true;
            this.butSal.Click += new System.EventHandler(this.butSal_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(121, 480);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(185, 22);
            this.textId.TabIndex = 24;
            // 
            // textConCom
            // 
            this.textConCom.Location = new System.Drawing.Point(337, 480);
            this.textConCom.Name = "textConCom";
            this.textConCom.Size = new System.Drawing.Size(185, 22);
            this.textConCom.TabIndex = 25;
            // 
            // textConPro
            // 
            this.textConPro.Location = new System.Drawing.Point(556, 480);
            this.textConPro.Name = "textConPro";
            this.textConPro.Size = new System.Drawing.Size(185, 22);
            this.textConPro.TabIndex = 26;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 542);
            this.ControlBox = false;
            this.Controls.Add(this.textConPro);
            this.Controls.Add(this.textConCom);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.butSal);
            this.Controls.Add(this.butVol);
            this.Controls.Add(this.butLim);
            this.Controls.Add(this.butNP);
            this.Controls.Add(this.butEli);
            this.Controls.Add(this.butMod);
            this.Controls.Add(this.butIng);
            this.Controls.Add(this.textIngMod);
            this.Controls.Add(this.ComboIngMod);
            this.Controls.Add(this.ComboIngModReg);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ComboBusReg);
            this.Controls.Add(this.ComboBusPro);
            this.Controls.Add(this.ComboBusCom);
            this.Controls.Add(this.checkEli);
            this.Controls.Add(this.checkMod);
            this.Controls.Add(this.checkIng);
            this.Controls.Add(this.labVacio);
            this.Controls.Add(this.labPro);
            this.Controls.Add(this.labReg);
            this.Controls.Add(this.labBusReg);
            this.Controls.Add(this.labBusPor);
            this.Controls.Add(this.labBusCom);
            this.Controls.Add(this.labInf);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labInf;
        private System.Windows.Forms.Label labBusCom;
        private System.Windows.Forms.Label labBusPor;
        private System.Windows.Forms.Label labBusReg;
        private System.Windows.Forms.Label labReg;
        private System.Windows.Forms.Label labPro;
        private System.Windows.Forms.Label labVacio;
        private System.Windows.Forms.CheckBox checkIng;
        private System.Windows.Forms.CheckBox checkMod;
        private System.Windows.Forms.CheckBox checkEli;
        private System.Windows.Forms.ComboBox ComboBusCom;
        private System.Windows.Forms.ComboBox ComboBusPro;
        private System.Windows.Forms.ComboBox ComboBusReg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ComboIngModReg;
        private System.Windows.Forms.ComboBox ComboIngMod;
        private System.Windows.Forms.TextBox textIngMod;
        private System.Windows.Forms.Button butIng;
        private System.Windows.Forms.Button butMod;
        private System.Windows.Forms.Button butEli;
        private System.Windows.Forms.Button butNP;
        private System.Windows.Forms.Button butLim;
        private System.Windows.Forms.Button butVol;
        private System.Windows.Forms.Button butSal;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textConCom;
        private System.Windows.Forms.TextBox textConPro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}