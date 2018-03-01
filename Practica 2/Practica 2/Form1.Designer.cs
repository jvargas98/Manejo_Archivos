namespace Practica_2
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
            this.btnAbrirImagen = new System.Windows.Forms.Button();
            this.txtTamañoBytes = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBitsPixel = new System.Windows.Forms.TextBox();
            this.lblPos = new System.Windows.Forms.Label();
            this.btnAbrirAgenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirImagen
            // 
            this.btnAbrirImagen.Location = new System.Drawing.Point(135, 40);
            this.btnAbrirImagen.Name = "btnAbrirImagen";
            this.btnAbrirImagen.Size = new System.Drawing.Size(123, 32);
            this.btnAbrirImagen.TabIndex = 0;
            this.btnAbrirImagen.Text = "Abrir imagen";
            this.btnAbrirImagen.UseVisualStyleBackColor = true;
            this.btnAbrirImagen.Click += new System.EventHandler(this.btnAbrirImagen_Click);
            // 
            // txtTamañoBytes
            // 
            this.txtTamañoBytes.Location = new System.Drawing.Point(135, 115);
            this.txtTamañoBytes.Name = "txtTamañoBytes";
            this.txtTamañoBytes.Size = new System.Drawing.Size(123, 24);
            this.txtTamañoBytes.TabIndex = 1;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(135, 161);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(123, 24);
            this.txtAncho.TabIndex = 2;
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(135, 211);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(123, 24);
            this.txtAlto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tamaño(bytes)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ancho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bits por pixel";
            // 
            // txtBitsPixel
            // 
            this.txtBitsPixel.Location = new System.Drawing.Point(135, 263);
            this.txtBitsPixel.Name = "txtBitsPixel";
            this.txtBitsPixel.Size = new System.Drawing.Size(123, 24);
            this.txtBitsPixel.TabIndex = 7;
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(308, 47);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(0, 18);
            this.lblPos.TabIndex = 9;
            // 
            // btnAbrirAgenda
            // 
            this.btnAbrirAgenda.Location = new System.Drawing.Point(288, 255);
            this.btnAbrirAgenda.Name = "btnAbrirAgenda";
            this.btnAbrirAgenda.Size = new System.Drawing.Size(123, 32);
            this.btnAbrirAgenda.TabIndex = 10;
            this.btnAbrirAgenda.Text = "Abrir Agenda";
            this.btnAbrirAgenda.UseVisualStyleBackColor = true;
            this.btnAbrirAgenda.Click += new System.EventHandler(this.btnAbrirAgenda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 299);
            this.Controls.Add(this.btnAbrirAgenda);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBitsPixel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlto);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.txtTamañoBytes);
            this.Controls.Add(this.btnAbrirImagen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Practica 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirImagen;
        private System.Windows.Forms.TextBox txtTamañoBytes;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBitsPixel;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Button btnAbrirAgenda;
    }
}

