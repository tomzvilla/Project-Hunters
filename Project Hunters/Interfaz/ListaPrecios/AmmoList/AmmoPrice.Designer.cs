﻿
namespace Project_Hunters.Interfaz.ListaPrecios.AmmoList
{
    partial class AmmoPrice
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
            this.lbl_precio_titulo = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.txt_precio_usd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_precio_ars = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_precio_titulo
            // 
            this.lbl_precio_titulo.AutoSize = true;
            this.lbl_precio_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio_titulo.Location = new System.Drawing.Point(290, 37);
            this.lbl_precio_titulo.Name = "lbl_precio_titulo";
            this.lbl_precio_titulo.Size = new System.Drawing.Size(166, 55);
            this.lbl_precio_titulo.TabIndex = 2;
            this.lbl_precio_titulo.Text = "Precio";
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.Location = new System.Drawing.Point(40, 148);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(64, 25);
            this.lbl_item.TabIndex = 3;
            this.lbl_item.Text = "Item: ";
            // 
            // txt_item
            // 
            this.txt_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item.Location = new System.Drawing.Point(249, 145);
            this.txt_item.Name = "txt_item";
            this.txt_item.ReadOnly = true;
            this.txt_item.Size = new System.Drawing.Size(553, 31);
            this.txt_item.TabIndex = 4;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(40, 210);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(182, 25);
            this.lbl_precio.TabIndex = 5;
            this.lbl_precio.Text = "Precio Final USD:";
            // 
            // txt_precio_usd
            // 
            this.txt_precio_usd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_usd.Location = new System.Drawing.Point(249, 204);
            this.txt_precio_usd.Name = "txt_precio_usd";
            this.txt_precio_usd.ReadOnly = true;
            this.txt_precio_usd.Size = new System.Drawing.Size(553, 31);
            this.txt_precio_usd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Precio Final ARS:";
            // 
            // txt_precio_ars
            // 
            this.txt_precio_ars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio_ars.Location = new System.Drawing.Point(249, 265);
            this.txt_precio_ars.Name = "txt_precio_ars";
            this.txt_precio_ars.ReadOnly = true;
            this.txt_precio_ars.Size = new System.Drawing.Size(553, 31);
            this.txt_precio_ars.TabIndex = 8;
            // 
            // AmmoPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 317);
            this.Controls.Add(this.txt_precio_ars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_precio_usd);
            this.Controls.Add(this.lbl_precio);
            this.Controls.Add(this.txt_item);
            this.Controls.Add(this.lbl_item);
            this.Controls.Add(this.lbl_precio_titulo);
            this.Name = "AmmoPrice";
            this.Text = "AmmoPrice";
            this.Load += new System.EventHandler(this.AmmoPrice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_precio_titulo;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.TextBox txt_precio_usd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_precio_ars;
    }
}