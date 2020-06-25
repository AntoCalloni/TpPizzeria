namespace Pizzeria
{
    partial class Pedidos
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
            this.TablaPedidos = new System.Windows.Forms.DataGridView();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.checkBoxPrecioTotal = new System.Windows.Forms.CheckBox();
            this.checkBoxId = new System.Windows.Forms.CheckBox();
            this.comboBoxPrecio = new System.Windows.Forms.ComboBox();
            this.comboBoxNombre = new System.Windows.Forms.ComboBox();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(693, 412);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // TablaPedidos
            // 
            this.TablaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPedidos.Location = new System.Drawing.Point(29, 136);
            this.TablaPedidos.Name = "TablaPedidos";
            this.TablaPedidos.Size = new System.Drawing.Size(739, 245);
            this.TablaPedidos.TabIndex = 1;
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(481, 55);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(95, 17);
            this.checkBoxEstado.TabIndex = 16;
            this.checkBoxEstado.Text = "Estado Pedido";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // checkBoxPrecioTotal
            // 
            this.checkBoxPrecioTotal.AutoSize = true;
            this.checkBoxPrecioTotal.Location = new System.Drawing.Point(241, 55);
            this.checkBoxPrecioTotal.Name = "checkBoxPrecioTotal";
            this.checkBoxPrecioTotal.Size = new System.Drawing.Size(83, 17);
            this.checkBoxPrecioTotal.TabIndex = 15;
            this.checkBoxPrecioTotal.Text = "Precio Total";
            this.checkBoxPrecioTotal.UseVisualStyleBackColor = true;
            // 
            // checkBoxId
            // 
            this.checkBoxId.AutoSize = true;
            this.checkBoxId.Location = new System.Drawing.Point(29, 55);
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.Size = new System.Drawing.Size(71, 17);
            this.checkBoxId.TabIndex = 14;
            this.checkBoxId.Text = "Id Pedido";
            this.checkBoxId.UseVisualStyleBackColor = true;
            // 
            // comboBoxPrecio
            // 
            this.comboBoxPrecio.FormattingEnabled = true;
            this.comboBoxPrecio.Location = new System.Drawing.Point(481, 89);
            this.comboBoxPrecio.Name = "comboBoxPrecio";
            this.comboBoxPrecio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrecio.TabIndex = 13;
            // 
            // comboBoxNombre
            // 
            this.comboBoxNombre.FormattingEnabled = true;
            this.comboBoxNombre.Location = new System.Drawing.Point(241, 89);
            this.comboBoxNombre.Name = "comboBoxNombre";
            this.comboBoxNombre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNombre.TabIndex = 12;
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(29, 89);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxID.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Seleccione los filtros para realizar su búsqueda:";
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.checkBoxEstado);
            this.Controls.Add(this.checkBoxPrecioTotal);
            this.Controls.Add(this.checkBoxId);
            this.Controls.Add(this.comboBoxPrecio);
            this.Controls.Add(this.comboBoxNombre);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TablaPedidos);
            this.Controls.Add(this.btn_Volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            ((System.ComponentModel.ISupportInitialize)(this.TablaPedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.DataGridView TablaPedidos;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.CheckBox checkBoxPrecioTotal;
        private System.Windows.Forms.CheckBox checkBoxId;
        private System.Windows.Forms.ComboBox comboBoxPrecio;
        private System.Windows.Forms.ComboBox comboBoxNombre;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Label label2;
    }
}