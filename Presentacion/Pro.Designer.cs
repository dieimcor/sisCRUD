namespace Presentacion
{
    partial class Pro
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
            this.labInfPro = new System.Windows.Forms.Label();
            this.labBusPro = new System.Windows.Forms.Label();
            this.labBusReg = new System.Windows.Forms.Label();
            this.labReg = new System.Windows.Forms.Label();
            this.labVac = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Región = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBusPro = new System.Windows.Forms.ComboBox();
            this.comboBusReg = new System.Windows.Forms.ComboBox();
            this.comboReg = new System.Windows.Forms.ComboBox();
            this.textIngMod = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.butIng = new System.Windows.Forms.Button();
            this.butMod = new System.Windows.Forms.Button();
            this.butEli = new System.Windows.Forms.Button();
            this.butNR = new System.Windows.Forms.Button();
            this.butIC = new System.Windows.Forms.Button();
            this.butSal = new System.Windows.Forms.Button();
            this.butVol = new System.Windows.Forms.Button();
            this.butLim = new System.Windows.Forms.Button();
            this.checkIng = new System.Windows.Forms.CheckBox();
            this.checkMod = new System.Windows.Forms.CheckBox();
            this.checkEli = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labInfPro
            // 
            this.labInfPro.AutoSize = true;
            this.labInfPro.Location = new System.Drawing.Point(248, 21);
            this.labInfPro.Name = "labInfPro";
            this.labInfPro.Size = new System.Drawing.Size(173, 16);
            this.labInfPro.TabIndex = 0;
            this.labInfPro.Text = "Información sobre Provincia";
            // 
            // labBusPro
            // 
            this.labBusPro.AutoSize = true;
            this.labBusPro.Location = new System.Drawing.Point(12, 118);
            this.labBusPro.Name = "labBusPro";
            this.labBusPro.Size = new System.Drawing.Size(134, 16);
            this.labBusPro.TabIndex = 1;
            this.labBusPro.Text = "Buscar por Provincia:";
            // 
            // labBusReg
            // 
            this.labBusReg.AutoSize = true;
            this.labBusReg.Location = new System.Drawing.Point(477, 118);
            this.labBusReg.Name = "labBusReg";
            this.labBusReg.Size = new System.Drawing.Size(122, 16);
            this.labBusReg.TabIndex = 2;
            this.labBusReg.Text = "Buscar por Región:";
            // 
            // labReg
            // 
            this.labReg.AutoSize = true;
            this.labReg.Location = new System.Drawing.Point(12, 360);
            this.labReg.Name = "labReg";
            this.labReg.Size = new System.Drawing.Size(54, 16);
            this.labReg.TabIndex = 3;
            this.labReg.Text = "Región:";
            // 
            // labVac
            // 
            this.labVac.AutoSize = true;
            this.labVac.Location = new System.Drawing.Point(20, 388);
            this.labVac.Name = "labVac";
            this.labVac.Size = new System.Drawing.Size(0, 16);
            this.labVac.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Provincia,
            this.Column1,
            this.Región});
            this.dataGridView1.Location = new System.Drawing.Point(12, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(587, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 250;
            // 
            // Provincia
            // 
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.MinimumWidth = 6;
            this.Provincia.Name = "Provincia";
            this.Provincia.ReadOnly = true;
            this.Provincia.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Región
            // 
            this.Región.HeaderText = "Región";
            this.Región.MinimumWidth = 6;
            this.Región.Name = "Región";
            this.Región.ReadOnly = true;
            this.Región.Width = 125;
            // 
            // comboBusPro
            // 
            this.comboBusPro.FormattingEnabled = true;
            this.comboBusPro.Location = new System.Drawing.Point(12, 154);
            this.comboBusPro.Name = "comboBusPro";
            this.comboBusPro.Size = new System.Drawing.Size(235, 24);
            this.comboBusPro.TabIndex = 6;
            this.comboBusPro.SelectedIndexChanged += new System.EventHandler(this.comboBusPro_SelectedIndexChanged);
            // 
            // comboBusReg
            // 
            this.comboBusReg.FormattingEnabled = true;
            this.comboBusReg.Location = new System.Drawing.Point(247, 154);
            this.comboBusReg.Name = "comboBusReg";
            this.comboBusReg.Size = new System.Drawing.Size(352, 24);
            this.comboBusReg.TabIndex = 7;
            this.comboBusReg.SelectedIndexChanged += new System.EventHandler(this.comboBusReg_SelectedIndexChanged);
            // 
            // comboReg
            // 
            this.comboReg.FormattingEnabled = true;
            this.comboReg.Location = new System.Drawing.Point(122, 352);
            this.comboReg.Name = "comboReg";
            this.comboReg.Size = new System.Drawing.Size(352, 24);
            this.comboReg.TabIndex = 8;
            this.comboReg.SelectedIndexChanged += new System.EventHandler(this.comboReg_SelectedIndexChanged);
            // 
            // textIngMod
            // 
            this.textIngMod.Location = new System.Drawing.Point(251, 382);
            this.textIngMod.Name = "textIngMod";
            this.textIngMod.Size = new System.Drawing.Size(223, 22);
            this.textIngMod.TabIndex = 9;
            this.textIngMod.TextChanged += new System.EventHandler(this.textIngMod_TextChanged);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(247, 486);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(166, 22);
            this.textId.TabIndex = 10;
            // 
            // butIng
            // 
            this.butIng.Location = new System.Drawing.Point(516, 352);
            this.butIng.Name = "butIng";
            this.butIng.Size = new System.Drawing.Size(101, 43);
            this.butIng.TabIndex = 11;
            this.butIng.Text = "Ingresar";
            this.butIng.UseVisualStyleBackColor = true;
            this.butIng.Visible = false;
            this.butIng.Click += new System.EventHandler(this.butIng_Click);
            // 
            // butMod
            // 
            this.butMod.Location = new System.Drawing.Point(516, 352);
            this.butMod.Name = "butMod";
            this.butMod.Size = new System.Drawing.Size(101, 43);
            this.butMod.TabIndex = 12;
            this.butMod.Text = "Modificar";
            this.butMod.UseVisualStyleBackColor = true;
            this.butMod.Visible = false;
            this.butMod.Click += new System.EventHandler(this.butMod_Click);
            // 
            // butEli
            // 
            this.butEli.Location = new System.Drawing.Point(516, 352);
            this.butEli.Name = "butEli";
            this.butEli.Size = new System.Drawing.Size(101, 43);
            this.butEli.TabIndex = 13;
            this.butEli.Text = "Eliminar";
            this.butEli.UseVisualStyleBackColor = true;
            this.butEli.Visible = false;
            this.butEli.Click += new System.EventHandler(this.butEli_Click);
            // 
            // butNR
            // 
            this.butNR.Location = new System.Drawing.Point(504, 400);
            this.butNR.Name = "butNR";
            this.butNR.Size = new System.Drawing.Size(143, 23);
            this.butNR.TabIndex = 14;
            this.butNR.Text = "Nueva Región";
            this.butNR.UseVisualStyleBackColor = true;
            this.butNR.Click += new System.EventHandler(this.butNR_Click);
            // 
            // butIC
            // 
            this.butIC.Location = new System.Drawing.Point(504, 429);
            this.butIC.Name = "butIC";
            this.butIC.Size = new System.Drawing.Size(143, 32);
            this.butIC.TabIndex = 15;
            this.butIC.Text = "Ingresar Comuna";
            this.butIC.UseVisualStyleBackColor = true;
            this.butIC.Click += new System.EventHandler(this.butIC_Click);
            // 
            // butSal
            // 
            this.butSal.Location = new System.Drawing.Point(418, 410);
            this.butSal.Name = "butSal";
            this.butSal.Size = new System.Drawing.Size(56, 51);
            this.butSal.TabIndex = 16;
            this.butSal.Text = "Salir";
            this.butSal.UseVisualStyleBackColor = true;
            this.butSal.Click += new System.EventHandler(this.butSal_Click);
            // 
            // butVol
            // 
            this.butVol.Location = new System.Drawing.Point(122, 415);
            this.butVol.Name = "butVol";
            this.butVol.Size = new System.Drawing.Size(56, 51);
            this.butVol.TabIndex = 17;
            this.butVol.Text = "Volver";
            this.butVol.UseVisualStyleBackColor = true;
            this.butVol.Click += new System.EventHandler(this.butVol_Click);
            // 
            // butLim
            // 
            this.butLim.Location = new System.Drawing.Point(267, 415);
            this.butLim.Name = "butLim";
            this.butLim.Size = new System.Drawing.Size(60, 51);
            this.butLim.TabIndex = 18;
            this.butLim.Text = "Limpiar";
            this.butLim.UseVisualStyleBackColor = true;
            this.butLim.Click += new System.EventHandler(this.butLim_Click);
            // 
            // checkIng
            // 
            this.checkIng.AutoSize = true;
            this.checkIng.Location = new System.Drawing.Point(23, 56);
            this.checkIng.Name = "checkIng";
            this.checkIng.Size = new System.Drawing.Size(78, 20);
            this.checkIng.TabIndex = 19;
            this.checkIng.Text = "Ingresar";
            this.checkIng.UseVisualStyleBackColor = true;
            this.checkIng.CheckedChanged += new System.EventHandler(this.checkIng_CheckedChanged);
            // 
            // checkMod
            // 
            this.checkMod.AutoSize = true;
            this.checkMod.Enabled = false;
            this.checkMod.Location = new System.Drawing.Point(267, 56);
            this.checkMod.Name = "checkMod";
            this.checkMod.Size = new System.Drawing.Size(84, 20);
            this.checkMod.TabIndex = 20;
            this.checkMod.Text = "Modificar";
            this.checkMod.UseVisualStyleBackColor = true;
            this.checkMod.CheckedChanged += new System.EventHandler(this.checkMod_CheckedChanged);
            // 
            // checkEli
            // 
            this.checkEli.AutoSize = true;
            this.checkEli.Enabled = false;
            this.checkEli.Location = new System.Drawing.Point(504, 56);
            this.checkEli.Name = "checkEli";
            this.checkEli.Size = new System.Drawing.Size(77, 20);
            this.checkEli.TabIndex = 21;
            this.checkEli.Text = "Eliminar";
            this.checkEli.UseVisualStyleBackColor = true;
            this.checkEli.CheckedChanged += new System.EventHandler(this.checkEli_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 514);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(287, 514);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 22);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(480, 513);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(166, 22);
            this.textBox3.TabIndex = 24;
            // 
            // Pro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 471);
            this.ControlBox = false;
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkEli);
            this.Controls.Add(this.checkMod);
            this.Controls.Add(this.checkIng);
            this.Controls.Add(this.butLim);
            this.Controls.Add(this.butVol);
            this.Controls.Add(this.butSal);
            this.Controls.Add(this.butIC);
            this.Controls.Add(this.butNR);
            this.Controls.Add(this.butEli);
            this.Controls.Add(this.butMod);
            this.Controls.Add(this.butIng);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.textIngMod);
            this.Controls.Add(this.comboReg);
            this.Controls.Add(this.comboBusReg);
            this.Controls.Add(this.comboBusPro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labVac);
            this.Controls.Add(this.labReg);
            this.Controls.Add(this.labBusReg);
            this.Controls.Add(this.labBusPro);
            this.Controls.Add(this.labInfPro);
            this.Name = "Pro";
            this.Text = "Pro";
            this.Load += new System.EventHandler(this.Pro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labInfPro;
        private System.Windows.Forms.Label labBusPro;
        private System.Windows.Forms.Label labBusReg;
        private System.Windows.Forms.Label labReg;
        private System.Windows.Forms.Label labVac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBusPro;
        private System.Windows.Forms.ComboBox comboBusReg;
        private System.Windows.Forms.ComboBox comboReg;
        private System.Windows.Forms.TextBox textIngMod;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Button butIng;
        private System.Windows.Forms.Button butMod;
        private System.Windows.Forms.Button butEli;
        private System.Windows.Forms.Button butNR;
        private System.Windows.Forms.Button butIC;
        private System.Windows.Forms.Button butSal;
        private System.Windows.Forms.Button butVol;
        private System.Windows.Forms.Button butLim;
        private System.Windows.Forms.CheckBox checkIng;
        private System.Windows.Forms.CheckBox checkMod;
        private System.Windows.Forms.CheckBox checkEli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Región;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}