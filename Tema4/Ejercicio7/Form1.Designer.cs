namespace Ejercicio7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioSuma = new System.Windows.Forms.RadioButton();
            this.radioResta = new System.Windows.Forms.RadioButton();
            this.radioMultiplicacion = new System.Windows.Forms.RadioButton();
            this.radioDivisison = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(158, 33);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // radioSuma
            // 
            this.radioSuma.AutoSize = true;
            this.radioSuma.Checked = true;
            this.radioSuma.Location = new System.Drawing.Point(158, 68);
            this.radioSuma.Name = "radioSuma";
            this.radioSuma.Size = new System.Drawing.Size(31, 17);
            this.radioSuma.TabIndex = 2;
            this.radioSuma.TabStop = true;
            this.radioSuma.Text = "+";
            this.radioSuma.UseVisualStyleBackColor = true;
            // 
            // radioResta
            // 
            this.radioResta.AutoSize = true;
            this.radioResta.Location = new System.Drawing.Point(195, 68);
            this.radioResta.Name = "radioResta";
            this.radioResta.Size = new System.Drawing.Size(28, 17);
            this.radioResta.TabIndex = 3;
            this.radioResta.Text = "-";
            this.radioResta.UseVisualStyleBackColor = true;
            // 
            // radioMultiplicacion
            // 
            this.radioMultiplicacion.AutoSize = true;
            this.radioMultiplicacion.Location = new System.Drawing.Point(229, 68);
            this.radioMultiplicacion.Name = "radioMultiplicacion";
            this.radioMultiplicacion.Size = new System.Drawing.Size(29, 17);
            this.radioMultiplicacion.TabIndex = 4;
            this.radioMultiplicacion.Text = "*";
            this.radioMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // radioDivisison
            // 
            this.radioDivisison.AutoSize = true;
            this.radioDivisison.Location = new System.Drawing.Point(264, 68);
            this.radioDivisison.Name = "radioDivisison";
            this.radioDivisison.Size = new System.Drawing.Size(30, 17);
            this.radioDivisison.TabIndex = 5;
            this.radioDivisison.Text = "/";
            this.radioDivisison.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 134);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioDivisison);
            this.Controls.Add(this.radioMultiplicacion);
            this.Controls.Add(this.radioResta);
            this.Controls.Add(this.radioSuma);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioSuma;
        private System.Windows.Forms.RadioButton radioResta;
        private System.Windows.Forms.RadioButton radioMultiplicacion;
        private System.Windows.Forms.RadioButton radioDivisison;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

