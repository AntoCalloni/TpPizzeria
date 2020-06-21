namespace Pizzeria
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.MenuPizzas = new System.Windows.Forms.Button();
            this.MenuEmpanadas = new System.Windows.Forms.Button();
            this.RevisarStock = new System.Windows.Forms.Button();
            this.VerPedidos = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizzería El Tanito";
            // 
            // MenuPizzas
            // 
            this.MenuPizzas.BackColor = System.Drawing.SystemColors.Highlight;
            this.MenuPizzas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuPizzas.Location = new System.Drawing.Point(176, 122);
            this.MenuPizzas.Name = "MenuPizzas";
            this.MenuPizzas.Size = new System.Drawing.Size(162, 74);
            this.MenuPizzas.TabIndex = 1;
            this.MenuPizzas.Text = "Menú Pizzas";
            this.MenuPizzas.UseVisualStyleBackColor = false;
            this.MenuPizzas.Click += new System.EventHandler(this.MenuPizzas_Click);
            // 
            // MenuEmpanadas
            // 
            this.MenuEmpanadas.BackColor = System.Drawing.SystemColors.Highlight;
            this.MenuEmpanadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuEmpanadas.Location = new System.Drawing.Point(176, 224);
            this.MenuEmpanadas.Name = "MenuEmpanadas";
            this.MenuEmpanadas.Size = new System.Drawing.Size(162, 76);
            this.MenuEmpanadas.TabIndex = 2;
            this.MenuEmpanadas.Text = "Menú Empanadas";
            this.MenuEmpanadas.UseVisualStyleBackColor = false;
            this.MenuEmpanadas.Click += new System.EventHandler(this.MenuEmpanadas_Click);
            // 
            // RevisarStock
            // 
            this.RevisarStock.BackColor = System.Drawing.SystemColors.Highlight;
            this.RevisarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RevisarStock.Location = new System.Drawing.Point(395, 122);
            this.RevisarStock.Name = "RevisarStock";
            this.RevisarStock.Size = new System.Drawing.Size(142, 74);
            this.RevisarStock.TabIndex = 3;
            this.RevisarStock.Text = "Revisar Stock";
            this.RevisarStock.UseVisualStyleBackColor = false;
            this.RevisarStock.Click += new System.EventHandler(this.RevisarStock_Click);
            // 
            // VerPedidos
            // 
            this.VerPedidos.BackColor = System.Drawing.SystemColors.Highlight;
            this.VerPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerPedidos.Location = new System.Drawing.Point(400, 224);
            this.VerPedidos.Name = "VerPedidos";
            this.VerPedidos.Size = new System.Drawing.Size(137, 81);
            this.VerPedidos.TabIndex = 4;
            this.VerPedidos.Text = "Ver Pedidos";
            this.VerPedidos.UseVisualStyleBackColor = false;
            this.VerPedidos.Click += new System.EventHandler(this.VerPedidos_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.SystemColors.Highlight;
            this.Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Location = new System.Drawing.Point(606, 397);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(122, 42);
            this.Salir.TabIndex = 5;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pizzeria.Properties.Resources.pizza_sabrosa_redonda_colorida_1284_10219;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.VerPedidos);
            this.Controls.Add(this.RevisarStock);
            this.Controls.Add(this.MenuEmpanadas);
            this.Controls.Add(this.MenuPizzas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzería";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MenuPizzas;
        private System.Windows.Forms.Button MenuEmpanadas;
        private System.Windows.Forms.Button RevisarStock;
        private System.Windows.Forms.Button VerPedidos;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

