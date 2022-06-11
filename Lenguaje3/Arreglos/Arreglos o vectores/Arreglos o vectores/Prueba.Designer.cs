namespace Arreglos_o_vectores
{
    partial class Prueba
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
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(495, 118);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(75, 23);
            this.cmdMostrar.TabIndex = 0;
            this.cmdMostrar.Text = "Agregar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(253, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 84);
            this.listBox1.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(523, 57);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 22);
            this.txtnombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // cmdList
            // 
            this.cmdList.Location = new System.Drawing.Point(297, 227);
            this.cmdList.Name = "cmdList";
            this.cmdList.Size = new System.Drawing.Size(160, 23);
            this.cmdList.TabIndex = 4;
            this.cmdList.Text = "pasar al listbox";
            this.cmdList.UseVisualStyleBackColor = true;
            this.cmdList.Click += new System.EventHandler(this.cmdList_Click);
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmdMostrar);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdList;
    }
}