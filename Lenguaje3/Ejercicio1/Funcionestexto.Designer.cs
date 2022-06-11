namespace Ejercicio1
{
    partial class Funcionestexto
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
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdGenerar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLongitud = new System.Windows.Forms.Label();
            this.lblPrimer = new System.Windows.Forms.Label();
            this.lblUltimo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMayusculas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMinusculas = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRemplazar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(27, 34);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(300, 22);
            this.txtCadena.TabIndex = 0;
            this.txtCadena.TextChanged += new System.EventHandler(this.txtCadena_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Longitud: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Primer Caracter: ";
            // 
            // cmdGenerar
            // 
            this.cmdGenerar.Location = new System.Drawing.Point(366, 34);
            this.cmdGenerar.Name = "cmdGenerar";
            this.cmdGenerar.Size = new System.Drawing.Size(75, 23);
            this.cmdGenerar.TabIndex = 3;
            this.cmdGenerar.Text = "Generar";
            this.cmdGenerar.UseVisualStyleBackColor = true;
            this.cmdGenerar.Click += new System.EventHandler(this.cmdGenerar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ultimo Caracter: ";
            // 
            // lblLongitud
            // 
            this.lblLongitud.AutoSize = true;
            this.lblLongitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitud.Location = new System.Drawing.Point(188, 101);
            this.lblLongitud.Name = "lblLongitud";
            this.lblLongitud.Size = new System.Drawing.Size(50, 16);
            this.lblLongitud.TabIndex = 8;
            this.lblLongitud.Text = "label4";
            // 
            // lblPrimer
            // 
            this.lblPrimer.AutoSize = true;
            this.lblPrimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimer.Location = new System.Drawing.Point(188, 154);
            this.lblPrimer.Name = "lblPrimer";
            this.lblPrimer.Size = new System.Drawing.Size(50, 16);
            this.lblPrimer.TabIndex = 9;
            this.lblPrimer.Text = "label4";
            // 
            // lblUltimo
            // 
            this.lblUltimo.AutoSize = true;
            this.lblUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimo.Location = new System.Drawing.Point(188, 206);
            this.lblUltimo.Name = "lblUltimo";
            this.lblUltimo.Size = new System.Drawing.Size(50, 16);
            this.lblUltimo.TabIndex = 10;
            this.lblUltimo.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mayusculas: ";
            // 
            // lblMayusculas
            // 
            this.lblMayusculas.AutoSize = true;
            this.lblMayusculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMayusculas.Location = new System.Drawing.Point(188, 255);
            this.lblMayusculas.Name = "lblMayusculas";
            this.lblMayusculas.Size = new System.Drawing.Size(50, 16);
            this.lblMayusculas.TabIndex = 12;
            this.lblMayusculas.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Minusculas: ";
            // 
            // lblMinusculas
            // 
            this.lblMinusculas.AutoSize = true;
            this.lblMinusculas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinusculas.Location = new System.Drawing.Point(188, 309);
            this.lblMinusculas.Name = "lblMinusculas";
            this.lblMinusculas.Size = new System.Drawing.Size(50, 16);
            this.lblMinusculas.TabIndex = 14;
            this.lblMinusculas.Text = "label4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Remplazar: ";
            // 
            // lblRemplazar
            // 
            this.lblRemplazar.AutoSize = true;
            this.lblRemplazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemplazar.Location = new System.Drawing.Point(188, 357);
            this.lblRemplazar.Name = "lblRemplazar";
            this.lblRemplazar.Size = new System.Drawing.Size(50, 16);
            this.lblRemplazar.TabIndex = 16;
            this.lblRemplazar.Text = "label4";
            // 
            // Funcionestexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.lblRemplazar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMinusculas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMayusculas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUltimo);
            this.Controls.Add(this.lblPrimer);
            this.Controls.Add(this.lblLongitud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdGenerar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCadena);
            this.Name = "Funcionestexto";
            this.Text = " FuncionesTexto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdGenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLongitud;
        private System.Windows.Forms.Label lblPrimer;
        private System.Windows.Forms.Label lblUltimo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMayusculas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMinusculas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRemplazar;
    }
}