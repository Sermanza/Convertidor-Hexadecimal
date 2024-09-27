namespace Convertidor_Hexa
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
            this.decibox = new System.Windows.Forms.TextBox();
            this.hexabox = new System.Windows.Forms.TextBox();
            this.botonconv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.botondd = new System.Windows.Forms.RadioButton();
            this.botondq = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // decibox
            // 
            this.decibox.Location = new System.Drawing.Point(12, 37);
            this.decibox.Name = "decibox";
            this.decibox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.decibox.Size = new System.Drawing.Size(229, 20);
            this.decibox.TabIndex = 0;
            this.decibox.TextChanged += new System.EventHandler(this.decibox_TextChanged);
            // 
            // hexabox
            // 
            this.hexabox.Location = new System.Drawing.Point(327, 37);
            this.hexabox.Name = "hexabox";
            this.hexabox.ReadOnly = true;
            this.hexabox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hexabox.Size = new System.Drawing.Size(229, 20);
            this.hexabox.TabIndex = 1;
            this.hexabox.TextChanged += new System.EventHandler(this.hexabox_TextChanged);
            // 
            // botonconv
            // 
            this.botonconv.Location = new System.Drawing.Point(247, 140);
            this.botonconv.Name = "botonconv";
            this.botonconv.Size = new System.Drawing.Size(75, 23);
            this.botonconv.TabIndex = 2;
            this.botonconv.Text = "Convertir";
            this.botonconv.UseVisualStyleBackColor = true;
            this.botonconv.Click += new System.EventHandler(this.botonconv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dé el número a convertir:";
            // 
            // botondd
            // 
            this.botondd.AutoSize = true;
            this.botondd.Checked = true;
            this.botondd.Location = new System.Drawing.Point(12, 65);
            this.botondd.Name = "botondd";
            this.botondd.Size = new System.Drawing.Size(91, 17);
            this.botondd.TabIndex = 7;
            this.botondd.TabStop = true;
            this.botondd.Text = "Flotante a DD";
            this.botondd.UseVisualStyleBackColor = true;
            // 
            // botondq
            // 
            this.botondq.AutoSize = true;
            this.botondq.Location = new System.Drawing.Point(12, 88);
            this.botondq.Name = "botondq";
            this.botondq.Size = new System.Drawing.Size(91, 17);
            this.botondq.TabIndex = 8;
            this.botondq.TabStop = true;
            this.botondq.Text = "Flotante a DQ";
            this.botondq.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(387, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero Convertido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 196);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botondq);
            this.Controls.Add(this.botondd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonconv);
            this.Controls.Add(this.hexabox);
            this.Controls.Add(this.decibox);
            this.Name = "Form1";
            this.Text = "Convertidor Hexadecimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox decibox;
        private System.Windows.Forms.TextBox hexabox;
        private System.Windows.Forms.Button botonconv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton botondd;
        private System.Windows.Forms.RadioButton botondq;
        private System.Windows.Forms.Label label1;
    }
}

