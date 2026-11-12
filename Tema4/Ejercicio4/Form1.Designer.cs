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
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.rblista1 = new System.Windows.Forms.RadioButton();
            this.rbLista2 = new System.Windows.Forms.RadioButton();
            this.rb1a2 = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rb2a1 = new System.Windows.Forms.RadioButton();
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
            this.listBoxMulti.TabIndex = 9;
            this.listBoxMulti.SelectedIndexChanged += new System.EventHandler(this.listBoxMulti_SelectedIndexChanged);
            // 
            // listBoxUnica
            // 
            this.listBoxUnica.FormattingEnabled = true;
            this.listBoxUnica.Location = new System.Drawing.Point(415, 99);
            this.listBoxUnica.Name = "listBoxUnica";
            this.listBoxUnica.Size = new System.Drawing.Size(149, 225);
            this.listBoxUnica.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(220, 100);
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
            this.buttonQuitar.Location = new System.Drawing.Point(220, 129);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(162, 23);
            this.buttonQuitar.TabIndex = 5;
            this.buttonQuitar.Text = "Eliminar de 1";
            this.toolTip1.SetToolTip(this.buttonQuitar, "Quita los elementos seleccionados ");
            this.buttonQuitar.UseVisualStyleBackColor = true;
            this.buttonQuitar.Click += new System.EventHandler(this.buttonQuitar_Click);
            // 
            // buttonTrasp
            // 
            this.buttonTrasp.Location = new System.Drawing.Point(220, 232);
            this.buttonTrasp.Name = "buttonTrasp";
            this.buttonTrasp.Size = new System.Drawing.Size(162, 23);
            this.buttonTrasp.TabIndex = 8;
            this.buttonTrasp.Text = "Traspasar";
            this.toolTip1.SetToolTip(this.buttonTrasp, "Traspasar elementos entre listas");
            this.buttonTrasp.UseVisualStyleBackColor = true;
            this.buttonTrasp.Click += new System.EventHandler(this.buttonTrasp_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(32, 73);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(532, 20);
            this.txtAdd.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtAdd, "Texto a añadir en la celda");
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(29, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 6;
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(29, 46);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(0, 13);
            this.lbl2.TabIndex = 7;
            // 
            // rblista1
            // 
            this.rblista1.AutoSize = true;
            this.rblista1.Checked = true;
            this.rblista1.Location = new System.Drawing.Point(36, 19);
            this.rblista1.Name = "rblista1";
            this.rblista1.Size = new System.Drawing.Size(56, 17);
            this.rblista1.TabIndex = 1;
            this.rblista1.TabStop = true;
            this.rblista1.Tag = "1";
            this.rblista1.Text = "Lista 1";
            this.toolTip1.SetToolTip(this.rblista1, "Opcion para eliminar elementos de la lista 1");
            this.rblista1.UseVisualStyleBackColor = true;
            this.rblista1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbLista2
            // 
            this.rbLista2.AutoSize = true;
            this.rbLista2.Location = new System.Drawing.Point(36, 42);
            this.rbLista2.Name = "rbLista2";
            this.rbLista2.Size = new System.Drawing.Size(56, 17);
            this.rbLista2.TabIndex = 2;
            this.rbLista2.TabStop = true;
            this.rbLista2.Tag = "2";
            this.rbLista2.Text = "Lista 2";
            this.toolTip1.SetToolTip(this.rbLista2, "Opcion para eliminar elementos de la lista 2\r\n");
            this.rbLista2.UseVisualStyleBackColor = true;
            this.rbLista2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb1a2
            // 
            this.rb1a2.AutoSize = true;
            this.rb1a2.Location = new System.Drawing.Point(36, 19);
            this.rb1a2.Name = "rb1a2";
            this.rb1a2.Size = new System.Drawing.Size(69, 17);
            this.rb1a2.TabIndex = 1;
            this.rb1a2.TabStop = true;
            this.rb1a2.Tag = "1 -> 2";
            this.rb1a2.Text = "De 1 a 2 ";
            this.toolTip1.SetToolTip(this.rb1a2, "Opcion para traspasar elementos de la lista 1 a la lista 2");
            this.rb1a2.UseVisualStyleBackColor = true;
            this.rb1a2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb2a1
            // 
            this.rb2a1.AutoSize = true;
            this.rb2a1.Location = new System.Drawing.Point(36, 42);
            this.rb2a1.Name = "rb2a1";
            this.rb2a1.Size = new System.Drawing.Size(66, 17);
            this.rb2a1.TabIndex = 2;
            this.rb2a1.TabStop = true;
            this.rb2a1.Tag = "1 <- 2";
            this.rb2a1.Text = "De 2 a 1";
            this.toolTip1.SetToolTip(this.rb2a1, "Opcion para traspasar elementos de la lista 2 a la lista 1");
            this.rb2a1.UseVisualStyleBackColor = true;
            this.rb2a1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            this.groupBox1.Controls.Add(this.rblista1);
            this.groupBox1.Controls.Add(this.rbLista2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(234, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.rb1a2);
            this.groupBox2.Controls.Add(this.rb2a1);
            this.groupBox2.Location = new System.Drawing.Point(234, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 68);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtAdd);
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
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.RadioButton rblista1;
        private System.Windows.Forms.RadioButton rbLista2;
        private System.Windows.Forms.RadioButton rb1a2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rb2a1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

