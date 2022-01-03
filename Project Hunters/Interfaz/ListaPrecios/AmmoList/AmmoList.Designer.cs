
namespace Project_Hunters.Interfaz.ListaPrecios.AmmoList
{
    partial class AmmoList
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
            this.lbl_tipo = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caliber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ammo_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grammage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.box_ammount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price_usd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_calibre = new System.Windows.Forms.Label();
            this.cmb_calibre = new System.Windows.Forms.ComboBox();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.cmb_proveedor = new System.Windows.Forms.ComboBox();
            this.ck_stock = new System.Windows.Forms.CheckBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_tipo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AllowUserToAddRows = false;
            this.lbl_tipo.AllowUserToDeleteRows = false;
            this.lbl_tipo.AllowUserToResizeRows = false;
            this.lbl_tipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.lbl_tipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lbl_tipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.caliber,
            this.ammo_type,
            this.grammage,
            this.brand,
            this.box_ammount,
            this.unit_price_usd,
            this.price,
            this.stock,
            this.supplier,
            this.description});
            this.lbl_tipo.Location = new System.Drawing.Point(12, 173);
            this.lbl_tipo.MultiSelect = false;
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(1150, 371);
            this.lbl_tipo.TabIndex = 0;
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(12, 560);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(119, 42);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(905, 560);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(119, 42);
            this.btn_modificar.TabIndex = 3;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(1043, 560);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(119, 42);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // caliber
            // 
            this.caliber.HeaderText = "Calibre";
            this.caliber.Name = "caliber";
            this.caliber.Width = 64;
            // 
            // ammo_type
            // 
            this.ammo_type.HeaderText = "Tipo";
            this.ammo_type.Name = "ammo_type";
            this.ammo_type.Width = 53;
            // 
            // grammage
            // 
            this.grammage.HeaderText = "Gramaje";
            this.grammage.Name = "grammage";
            this.grammage.Width = 71;
            // 
            // brand
            // 
            this.brand.HeaderText = "Marca";
            this.brand.Name = "brand";
            this.brand.Width = 62;
            // 
            // box_ammount
            // 
            this.box_ammount.HeaderText = "Cantidad por Caja";
            this.box_ammount.Name = "box_ammount";
            this.box_ammount.Width = 87;
            // 
            // unit_price_usd
            // 
            this.unit_price_usd.HeaderText = "Precio Unitario USD";
            this.unit_price_usd.Name = "unit_price_usd";
            this.unit_price_usd.Width = 96;
            // 
            // price
            // 
            this.price.HeaderText = "Precio Final ";
            this.price.Name = "price";
            this.price.Width = 83;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.Name = "stock";
            this.stock.Width = 60;
            // 
            // supplier
            // 
            this.supplier.HeaderText = "Proveedor";
            this.supplier.Name = "supplier";
            this.supplier.Width = 81;
            // 
            // description
            // 
            this.description.HeaderText = "Descripcion";
            this.description.Name = "description";
            this.description.Width = 88;
            // 
            // lbl_calibre
            // 
            this.lbl_calibre.AutoSize = true;
            this.lbl_calibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_calibre.Location = new System.Drawing.Point(35, 71);
            this.lbl_calibre.Name = "lbl_calibre";
            this.lbl_calibre.Size = new System.Drawing.Size(58, 20);
            this.lbl_calibre.TabIndex = 5;
            this.lbl_calibre.Text = "Calibre";
            // 
            // cmb_calibre
            // 
            this.cmb_calibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_calibre.FormattingEnabled = true;
            this.cmb_calibre.Location = new System.Drawing.Point(152, 71);
            this.cmb_calibre.Name = "cmb_calibre";
            this.cmb_calibre.Size = new System.Drawing.Size(240, 28);
            this.cmb_calibre.TabIndex = 6;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(152, 27);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(240, 26);
            this.txt_descripcion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(35, 27);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(92, 20);
            this.lbl_descripcion.TabIndex = 9;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Location = new System.Drawing.Point(152, 121);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(240, 28);
            this.cmb_tipo.TabIndex = 10;
            // 
            // lbl_marca
            // 
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_marca.Location = new System.Drawing.Point(490, 27);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(53, 20);
            this.lbl_marca.TabIndex = 11;
            this.lbl_marca.Text = "Marca";
            // 
            // cmb_marca
            // 
            this.cmb_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(607, 24);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(240, 28);
            this.cmb_marca.TabIndex = 12;
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proveedor.Location = new System.Drawing.Point(490, 74);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(81, 20);
            this.lbl_proveedor.TabIndex = 13;
            this.lbl_proveedor.Text = "Proveedor";
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Location = new System.Drawing.Point(607, 71);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Size = new System.Drawing.Size(240, 28);
            this.cmb_proveedor.TabIndex = 14;
            // 
            // ck_stock
            // 
            this.ck_stock.AutoSize = true;
            this.ck_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ck_stock.Location = new System.Drawing.Point(490, 121);
            this.ck_stock.Name = "ck_stock";
            this.ck_stock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ck_stock.Size = new System.Drawing.Size(87, 24);
            this.ck_stock.TabIndex = 15;
            this.ck_stock.Text = "?Stock¿";
            this.ck_stock.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.Location = new System.Drawing.Point(1043, 107);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(119, 42);
            this.btn_consultar.TabIndex = 16;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            // 
            // AmmoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 614);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.ck_stock);
            this.Controls.Add(this.cmb_proveedor);
            this.Controls.Add(this.lbl_proveedor);
            this.Controls.Add(this.cmb_marca);
            this.Controls.Add(this.lbl_marca);
            this.Controls.Add(this.cmb_tipo);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.cmb_calibre);
            this.Controls.Add(this.lbl_calibre);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_tipo);
            this.Name = "AmmoList";
            this.Text = "AmmoList";
            ((System.ComponentModel.ISupportInitialize)(this.lbl_tipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView lbl_tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn caliber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ammo_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn grammage;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn box_ammount;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price_usd;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lbl_calibre;
        private System.Windows.Forms.ComboBox cmb_calibre;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.ComboBox cmb_marca;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.ComboBox cmb_proveedor;
        private System.Windows.Forms.CheckBox ck_stock;
        private System.Windows.Forms.Button btn_consultar;
    }
}