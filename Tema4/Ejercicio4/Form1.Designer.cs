namespace Ejercicio4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxMulti = new System.Windows.Forms.ListBox();
            this.listBoxUnica = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonQuitar = new System.Windows.Forms.Button();
            this.buttonTrasp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1a2 = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.radioButton2a1 = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMulti
            // 
            this.listBoxMulti.FormattingEnabled = true;
            this.listBoxMulti.Location = new System.Drawing.Point(32, 99);
            this.listBoxMulti.Name = "listBoxMulti";
            this.listBoxMulti.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxMulti.Size = new System.Drawing.Size(149, 225);
            this.listBoxMulti.TabIndex = 0;
            this.listBoxMulti.SelectedIndexChanged += new System.EventHandler(this.listBoxMulti_SelectedIndexChanged);
            // 
            // listBoxUnica
            // 
            this.listBoxUnica.FormattingEnabled = true;
            this.listBoxUnica.Location = new System.Drawing.Point(415, 99);
            this.listBoxUnica.Name = "listBoxUnica";
            this.listBoxUnica.Size = new System.Drawing.Size(149, 225);
            this.listBoxUnica.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(220, 99);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(162, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Añadir";
            this.toolTip1.SetToolTip(this.buttonAdd, "Añade un elemento a la lista 1\r\n\r\n");
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.Location = new System.Drawing.Point(220, 128);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(162, 23);
            this.buttonQuitar.TabIndex = 3;
            this.buttonQuitar.Text = "Quitar";
            this.toolTip1.SetToolTip(this.buttonQuitar, "Quita los elementos seleccionados ");
            this.buttonQuitar.UseVisualStyleBackColor = true;
            this.buttonQuitar.Click += new System.EventHandler(this.buttonQuitar_Click);
            // 
            // buttonTrasp
            // 
            this.buttonTrasp.Location = new System.Drawing.Point(220, 232);
            this.buttonTrasp.Name = "buttonTrasp";
            this.buttonTrasp.Size = new System.Drawing.Size(162, 23);
            this.buttonTrasp.TabIndex = 4;
            this.buttonTrasp.Text = "Traspasar";
            this.toolTip1.SetToolTip(this.buttonTrasp, "Traspasar elementos entre listas");
            this.buttonTrasp.UseVisualStyleBackColor = true;
            this.buttonTrasp.Click += new System.EventHandler(this.buttonTrasp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 335);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(532, 20);
            this.textBox1.TabIndex = 5;
            this.toolTip1.SetToolTip(this.textBox1, "Texto a añadir en la celda");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(36, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Lista 1";
            this.toolTip1.SetToolTip(this.radioButton1, "Opcion para eliminar elementos de la lista 1");
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(36, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.Text = "Lista 2";
            this.toolTip1.SetToolTip(this.radioButton2, "Opcion para eliminar elementos de la lista 2\r\n");
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1a2
            // 
            this.radioButton1a2.AutoSize = true;
            this.radioButton1a2.Location = new System.Drawing.Point(36, 19);
            this.radioButton1a2.Name = "radioButton1a2";
            this.radioButton1a2.Size = new System.Drawing.Size(69, 17);
            this.radioButton1a2.TabIndex = 10;
            this.radioButton1a2.Text = "De 1 a 2 ";
            this.toolTip1.SetToolTip(this.radioButton1a2, "Opcion para traspasar elementos de la lista 1 a la lista 2");
            this.radioButton1a2.UseVisualStyleBackColor = true;
            this.radioButton1a2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2a1
            // 
            this.radioButton2a1.AutoSize = true;
            this.radioButton2a1.Location = new System.Drawing.Point(36, 42);
            this.radioButton2a1.Name = "radioButton2a1";
            this.radioButton2a1.Size = new System.Drawing.Size(66, 17);
            this.radioButton2a1.TabIndex = 11;
            this.radioButton2a1.Text = "De 2 a 1";
            this.toolTip1.SetToolTip(this.radioButton2a1, "Opcion para traspasar elementos de la lista 2 a la lista 1");
            this.radioButton2a1.UseVisualStyleBackColor = true;
            this.radioButton2a1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(234, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 68);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.radioButton1a2);
            this.groupBox2.Controls.Add(this.radioButton2a1);
            this.groupBox2.Location = new System.Drawing.Point(234, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 68);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonTrasp);
            this.Controls.Add(this.buttonQuitar);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxUnica);
            this.Controls.Add(this.listBoxMulti);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMulti;
        private System.Windows.Forms.ListBox listBoxUnica;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonQuitar;
        private System.Windows.Forms.Button buttonTrasp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1a2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButton2a1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

