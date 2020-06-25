using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class MenuPizzas : Form
    {
        public MenuPizzas()
        {
            InitializeComponent();
            var conexion = new ConexionBBDD();
            string consulta = "select idPizza 'ID', NombrePizza, PrecioPizza 'Precio' from Pizzas";

            conexion.cnn.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, conexion.cnn);
            DataSet DS = new DataSet();
            var commandBuilder = new SqlCommandBuilder(Adaptador);
            var ds = new DataSet();
            Adaptador.Fill(ds);
            TablaPizzas.ReadOnly = true;
            TablaPizzas.DataSource = ds.Tables[0];
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
