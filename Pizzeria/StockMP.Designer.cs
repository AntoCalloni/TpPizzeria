namespace Pizzeria
{
    partial class StockMP
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
            this.btn_Volver = new System.Windows.Forms.Button();
            this.TablaStock = new System.Windows.Forms.DataGridView();
            this.checkBoxProveedor = new System.Windows.Forms.CheckBox();
            this.checkBoxNombre = new System.Windows.Forms.CheckBox();
            this.checkBoxId = new System.Windows.Forms.CheckBox();
            this.comboBoxPrecio = new System.Windows.Forms.ComboBox();
            this.comboBoxNombre = new System.Windows.Forms.ComboBox();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaStock)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(691, 411);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // TablaStock
            // 
            this.TablaStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaStock.Location = new System.Drawing.Point(37, 191);
            this.TablaStock.Name = "TablaStock";
            this.TablaStock.Size = new System.Drawing.Size(729, 135);
            this.TablaStock.TabIndex = 1;
            //this.TablaStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaStock_CellContentClick_1);
            // 
            // checkBoxProveedor
            // 
            this.checkBoxProveedor.AutoSize = true;
            this.checkBoxProveedor.Location = new System.Drawing.Point(489, 78);
            this.checkBoxProveedor.Name = "checkBoxProveedor";
            this.checkBoxProveedor.Size = new System.Drawing.Size(75, 17);
            this.checkBoxProveedor.TabIndex = 16;
            this.checkBoxProveedor.Text = "Proveedor";
            this.checkBoxProveedor.UseVisualStyleBackColor = true;
            // 
            // checkBoxNombre
            // 
            this.checkBoxNombre.AutoSize = true;
            this.checkBoxNombre.Location = new System.Drawing.Point(249, 78);
            this.checkBoxNombre.Name = "checkBoxNombre";
            this.checkBoxNombre.Size = new System.Drawing.Size(130, 17);
            this.checkBoxNombre.TabIndex = 15;
            this.checkBoxNombre.Text = "Nombre Materia Prima";
            this.checkBoxNombre.UseVisualStyleBackColor = true;
            // 
            // checkBoxId
            // 
            this.checkBoxId.AutoSize = true;
            this.checkBoxId.Location = new System.Drawing.Point(37, 78);
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.Size = new System.Drawing.Size(102, 17);
            this.checkBoxId.TabIndex = 14;
            this.checkBoxId.Text = "Id Materia Prima";
            this.checkBoxId.UseVisualStyleBackColor = true;
            // 
            // comboBoxPrecio
            // 
            this.comboBoxPrecio.FormattingEnabled = true;
            this.comboBoxPrecio.Location = new System.Drawing.Point(489, 112);
            this.comboBoxPrecio.Name = "comboBoxPrecio";
            this.comboBoxPrecio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrecio.TabIndex = 13;
            // 
            // comboBoxNombre
            // 
            this.comboBoxNombre.FormattingEnabled = true;
            this.comboBoxNombre.Location = new System.Drawing.Point(249, 112);
            this.comboBoxNombre.Name = "comboBoxNombre";
            this.comboBoxNombre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNombre.TabIndex = 12;
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(37, 112);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxID.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seleccione los filtros para realizar su búsqueda:";
            // 
            // StockMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.checkBoxProveedor);
            this.Controls.Add(this.checkBoxNombre);
            this.Controls.Add(this.checkBoxId);
            this.Controls.Add(this.comboBoxPrecio);
            this.Controls.Add(this.comboBoxNombre);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TablaStock);
            this.Controls.Add(this.btn_Volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StockMP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Materia Prima";
            ((System.ComponentModel.ISupportInitialize)(this.TablaStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.DataGridView TablaStock;
        private System.Windows.Forms.CheckBox checkBoxProveedor;
        private System.Windows.Forms.CheckBox checkBoxNombre;
        private System.Windows.Forms.CheckBox checkBoxId;
        private System.Windows.Forms.ComboBox comboBoxPrecio;
        private System.Windows.Forms.ComboBox comboBoxNombre;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Label label1;
    }
}