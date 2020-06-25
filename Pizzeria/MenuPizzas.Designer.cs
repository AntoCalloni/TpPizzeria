namespace Pizzeria
{
    partial class MenuPizzas
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.TablaPizzas = new System.Windows.Forms.DataGridView();
            this.checkBoxPrecio = new System.Windows.Forms.CheckBox();
            this.checkBoxNombre = new System.Windows.Forms.CheckBox();
            this.checkBoxId = new System.Windows.Forms.CheckBox();
            this.comboBoxPrecio = new System.Windows.Forms.ComboBox();
            this.comboBoxNombre = new System.Windows.Forms.ComboBox();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPizzas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(713, 417);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // TablaPizzas
            // 
            this.TablaPizzas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPizzas.Location = new System.Drawing.Point(30, 164);
            this.TablaPizzas.Name = "TablaPizzas";
            this.TablaPizzas.Size = new System.Drawing.Size(724, 227);
            this.TablaPizzas.TabIndex = 1;
            // 
            // checkBoxPrecio
            // 
            this.checkBoxPrecio.AutoSize = true;
            this.checkBoxPrecio.Location = new System.Drawing.Point(482, 66);
            this.checkBoxPrecio.Name = "checkBoxPrecio";
            this.checkBoxPrecio.Size = new System.Drawing.Size(84, 17);
            this.checkBoxPrecio.TabIndex = 16;
            this.checkBoxPrecio.Text = "Precio Pizza";
            this.checkBoxPrecio.UseVisualStyleBackColor = true;
            // 
            // checkBoxNombre
            // 
            this.checkBoxNombre.AutoSize = true;
            this.checkBoxNombre.Location = new System.Drawing.Point(242, 66);
            this.checkBoxNombre.Name = "checkBoxNombre";
            this.checkBoxNombre.Size = new System.Drawing.Size(91, 17);
            this.checkBoxNombre.TabIndex = 15;
            this.checkBoxNombre.Text = "Nombre Pizza";
            this.checkBoxNombre.UseVisualStyleBackColor = true;
            // 
            // checkBoxId
            // 
            this.checkBoxId.AutoSize = true;
            this.checkBoxId.Location = new System.Drawing.Point(30, 66);
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.Size = new System.Drawing.Size(63, 17);
            this.checkBoxId.TabIndex = 14;
            this.checkBoxId.Text = "Id Pizza";
            this.checkBoxId.UseVisualStyleBackColor = true;
            // 
            // comboBoxPrecio
            // 
            this.comboBoxPrecio.FormattingEnabled = true;
            this.comboBoxPrecio.Location = new System.Drawing.Point(482, 100);
            this.comboBoxPrecio.Name = "comboBoxPrecio";
            this.comboBoxPrecio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPrecio.TabIndex = 13;
            // 
            // comboBoxNombre
            // 
            this.comboBoxNombre.FormattingEnabled = true;
            this.comboBoxNombre.Location = new System.Drawing.Point(242, 100);
            this.comboBoxNombre.Name = "comboBoxNombre";
            this.comboBoxNombre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNombre.TabIndex = 12;
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(30, 100);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(121, 21);
            this.comboBoxID.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Seleccione los filtros para realizar su búsqueda:";
            // 
            // MenuPizzas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.checkBoxPrecio);
            this.Controls.Add(this.checkBoxNombre);
            this.Controls.Add(this.checkBoxId);
            this.Controls.Add(this.comboBoxPrecio);
            this.Controls.Add(this.comboBoxNombre);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TablaPizzas);
            this.Controls.Add(this.btnVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "MenuPizzas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Pizzas";
            ((System.ComponentModel.ISupportInitialize)(this.TablaPizzas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView TablaPizzas;
        private System.Windows.Forms.CheckBox checkBoxPrecio;
        private System.Windows.Forms.CheckBox checkBoxNombre;
        private System.Windows.Forms.CheckBox checkBoxId;
        private System.Windows.Forms.ComboBox comboBoxPrecio;
        private System.Windows.Forms.ComboBox comboBoxNombre;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.Label label1;
    }
}