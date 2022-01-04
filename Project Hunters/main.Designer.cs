
namespace Project_Hunters
{
    partial class main
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_lista_precios = new System.Windows.Forms.Button();
            this.btn_cotizacion = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(576, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // btn_lista_precios
            // 
            this.btn_lista_precios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lista_precios.Location = new System.Drawing.Point(230, 180);
            this.btn_lista_precios.Name = "btn_lista_precios";
            this.btn_lista_precios.Size = new System.Drawing.Size(254, 59);
            this.btn_lista_precios.TabIndex = 1;
            this.btn_lista_precios.Text = "Lista de precios Municiones";
            this.btn_lista_precios.UseVisualStyleBackColor = true;
            this.btn_lista_precios.Click += new System.EventHandler(this.btn_lista_precios_Click);
            // 
            // btn_cotizacion
            // 
            this.btn_cotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cotizacion.Location = new System.Drawing.Point(230, 258);
            this.btn_cotizacion.Name = "btn_cotizacion";
            this.btn_cotizacion.Size = new System.Drawing.Size(254, 59);
            this.btn_cotizacion.TabIndex = 2;
            this.btn_cotizacion.Text = "Cotizacion Dolar";
            this.btn_cotizacion.UseVisualStyleBackColor = true;
            this.btn_cotizacion.Click += new System.EventHandler(this.btn_cotizacion_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(230, 333);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(254, 59);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_cotizacion);
            this.Controls.Add(this.btn_lista_precios);
            this.Controls.Add(this.label1);
            this.Name = "main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_lista_precios;
        private System.Windows.Forms.Button btn_cotizacion;
        private System.Windows.Forms.Button btn_salir;
    }
}

