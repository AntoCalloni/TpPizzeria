namespace Pizzeria
{
    partial class MenuEmpanadas
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
            this.TablaEmpanadas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNombreE = new System.Windows.Forms.ComboBox();
            this.checkBoxNombre = new System.Windows.Forms.CheckBox();
            this.Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaEmpanadas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Volver
            // 
            this.btn_Volver.Location = new System.Drawing.Point(682, 405);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.btn_Volver.TabIndex = 0;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = true;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // TablaEmpanadas
            // 
            this.TablaEmpanadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaEmpanadas.Location = new System.Drawing.Point(12, 159);
            this.TablaEmpanadas.Name = "TablaEmpanadas";
            this.TablaEmpanadas.Size = new System.Drawing.Size(766, 192);
            this.TablaEmpanadas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione los filtros para realizar su búsqueda:";
            // 
            // comboBoxNombreE
            // 
            this.comboBoxNombreE.FormattingEnabled = true;
            this.comboBoxNombreE.Location = new System.Drawing.Point(16, 99);
            this.comboBoxNombreE.Name = "comboBoxNombreE";
            this.comboBoxNombreE.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNombreE.TabIndex = 5;
            // 
            // checkBoxNombre
            // 
            this.checkBoxNombre.AutoSize = true;
            this.checkBoxNombre.Location = new System.Drawing.Point(20, 65);
            this.checkBoxNombre.Name = "checkBoxNombre";
            this.checkBoxNombre.Size = new System.Drawing.Size(117, 17);
            this.checkBoxNombre.TabIndex = 8;
            this.checkBoxNombre.Text = "Nombre Empanada";
            this.checkBoxNombre.UseVisualStyleBackColor = true;
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(563, 405);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 9;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            //this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // MenuEmpanadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.checkBoxNombre);
            this.Controls.Add(this.comboBoxNombreE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TablaEmpanadas);
            this.Controls.Add(this.btn_Volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MenuEmpanadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Empanadas";
            ((System.ComponentModel.ISupportInitialize)(this.TablaEmpanadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.DataGridView TablaEmpanadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNombreE;
        private System.Windows.Forms.CheckBox checkBoxNombre;
        private System.Windows.Forms.Button Buscar;
    }
}