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
    public partial class MenuEmpanadas : Form
    {
        public MenuEmpanadas() //Inicializo el componente
        {
            InitializeComponent();

        }

        private void btn_Volver_Click(object sender, EventArgs e) //Botón Volver me cierra la pantalla
        {
            this.Close();
        }

        public void TablaEmpanadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var conexion = new ConexionBBDD();
            //string consulta = "select * from Empanadas";
            string consulta = "select idEmpanada 'ID', NombreEmpanada, PrecioEmpanada 'Precio' from Empanadas";
            /*string consulta = $"select IdCliente 'DNI', Nombre 'Nombre', Telefono 'Telefono', " +
               $"case when SocioDeCoop = 1 then 'SI' else 'NO'end 'Socio de Cooperadora'" +
               $"from Cliente ";
            if (checkBoxId.Checked || checkBoxNombre.Checked || checkBoxTelefono.Checked || checkBoxSocioDeCoop.Checked)
            {
                consulta = consulta + $"where ";
                if (checkBoxId.Checked)
                {
                    consulta = consulta + $" IdCliente = {textBoxId.Text} ";
                }
                if (checkBoxNombre.Checked)
                {
                    consulta = consulta + $"AND Nombre = '{textBoxNombre.Text}' ";
                }
                if (checkBoxTelefono.Checked)
                {
                    consulta = consulta + $"AND Telefono = '{textBoxTelefono.Text}' ";
                }
                if (checkBoxSocioDeCoop.Checked)
                {
                    var Socio= int.Parse(comboBoxSocio.SelectedItem.GetType()
                .GetProperty("Value").GetValue(comboBoxSocio.SelectedItem, null).ToString());
                    consulta = consulta + $"AND SocioDeCoop = {Socio}";
                }
                consulta= consulta.Replace("where AND", "where");

            }*/
            conexion.cnn.Open(); //Conexion a BDD
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, conexion.cnn); //
            DataSet DS = new DataSet(); 
            var commandBuilder = new SqlCommandBuilder(Adaptador);
            var ds = new DataSet(); 
            Adaptador.Fill(ds); 
            TablaEmpanadas.ReadOnly = true;  //Para que tabla no esté vacía
            TablaEmpanadas.DataSource = ds.Tables[0]; 
            
        /*    public static DataTable MostrarDatos()
        {
            cnn.Open(); //Ver que esté en Conexion!!!!!!
            SqlCommand cmd = new SqlCommand("select * from Empanadas", cnn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            cnn.Close();
            return ds.Tables["tabla"];
        }*/
        }
    }
}
