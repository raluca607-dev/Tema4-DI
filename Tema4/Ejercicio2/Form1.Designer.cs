namespace Ejercicio2
{
    partial class Ejercicio2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio2));
            this.buttonSalir = new System.Windows.Forms.Button();
            this.textBoxRojo = new System.Windows.Forms.TextBox();
            this.textBoxVerde = new System.Windows.Forms.TextBox();
            this.textBoxAzul = new System.Windows.Forms.TextBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxImagen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonImagen = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalir
            // 
            this.buttonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSalir.Location = new System.Drawing.Point(162, 256);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(94, 20);
            this.buttonSalir.TabIndex = 0;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            this.buttonSalir.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.buttonSalir.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            // 
            // textBoxRojo
            // 
            this.textBoxRojo.Location = new System.Drawing.Point(31, 35);
            this.textBoxRojo.Name = "textBoxRojo";
            this.textBoxRojo.Size = new System.Drawing.Size(100, 20);
            this.textBoxRojo.TabIndex = 1;
            this.textBoxRojo.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // textBoxVerde
            // 
            this.textBoxVerde.Location = new System.Drawing.Point(175, 35);
            this.textBoxVerde.Name = "textBoxVerde";
            this.textBoxVerde.Size = new System.Drawing.Size(100, 20);
            this.textBoxVerde.TabIndex = 2;
            this.textBoxVerde.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // textBoxAzul
            // 
            this.textBoxAzul.Location = new System.Drawing.Point(325, 35);
            this.textBoxAzul.Name = "textBoxAzul";
            this.textBoxAzul.Size = new System.Drawing.Size(100, 20);
            this.textBoxAzul.TabIndex = 3;
            this.textBoxAzul.Enter += new System.EventHandler(this.textBox_Enter);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(175, 90);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(100, 20);
            this.buttonColor.TabIndex = 4;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            this.buttonColor.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.buttonColor.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rojo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Verde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Azul";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // textBoxImagen
            // 
            this.textBoxImagen.Location = new System.Drawing.Point(31, 158);
            this.textBoxImagen.Name = "textBoxImagen";
            this.textBoxImagen.Size = new System.Drawing.Size(100, 20);
            this.textBoxImagen.TabIndex = 9;
            this.textBoxImagen.Enter += new System.EventHandler(this.textBoxImagen_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Path imagen:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(328, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // buttonImagen
            // 
            this.buttonImagen.Location = new System.Drawing.Point(175, 152);
            this.buttonImagen.Name = "buttonImagen";
            this.buttonImagen.Size = new System.Drawing.Size(100, 30);
            this.buttonImagen.TabIndex = 12;
            this.buttonImagen.Text = "Imagen";
            this.buttonImagen.UseVisualStyleBackColor = true;
            this.buttonImagen.Click += new System.EventHandler(this.buttonImagen_Click);
            this.buttonImagen.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.buttonImagen.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(31, 255);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 23);
            this.buttonReset.TabIndex = 13;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            this.buttonReset.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.buttonReset.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            // 
            // Ejercicio2
            // 
            this.AcceptButton = this.buttonColor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonSalir;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonImagen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxImagen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.textBoxAzul);
            this.Controls.Add(this.textBoxVerde);
            this.Controls.Add(this.textBoxRojo);
            this.Controls.Add(this.buttonSalir);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Ejercicio2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TextBox textBoxRojo;
        private System.Windows.Forms.TextBox textBoxVerde;
        private System.Windows.Forms.TextBox textBoxAzul;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxImagen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonImagen;
        private System.Windows.Forms.Button buttonReset;
    }
}

