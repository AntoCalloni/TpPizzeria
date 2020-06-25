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

            var conexion = new ConexionBBDD();
            conexion.CargarComboNombreE(comboBoxNombreE);
            string consulta = "select idEmpanada 'ID', NombreEmpanada, PrecioEmpanada 'Precio' from Empanadas";

            conexion.cnn.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, conexion.cnn);
            DataSet DS = new DataSet();
            var commandBuilder = new SqlCommandBuilder(Adaptador);
            var ds = new DataSet();
            Adaptador.Fill(ds);
            TablaEmpanadas.ReadOnly = true;
            TablaEmpanadas.DataSource = ds.Tables[0];
        }

        private void btn_Volver_Click(object sender, EventArgs e) //Botón Volver me cierra la pantalla
        {
            this.Close();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            var conexion = new ConexionBBDD();
            string consulta = "select idEmpanada 'ID', NombreEmpanada, PrecioEmpanada 'Precio' from Empanadas";
            if (checkBoxNombre.Checked)
            {
                consulta = consulta + $"where ";
                if (checkBoxNombre.Checked)
                {
                    var nombre = int.Parse(comboBoxNombreE.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboBoxNombreE.SelectedItem, null).ToString());
                    consulta = consulta + $"AND Empanada.NombreEmpanada = {nombre} ";
                }

                consulta = consulta.Replace("where AND", "where");
            }
            conexion.cnn.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, conexion.cnn);
            DataSet DS = new DataSet();
            var commandBuilder = new SqlCommandBuilder(Adaptador);
            var ds = new DataSet();
            Adaptador.Fill(ds);
            TablaEmpanadas.ReadOnly = true;
            TablaEmpanadas.DataSource = ds.Tables[0];
        }
        
        private void comboBoxNombreE_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nombre = 0;
            if (comboBoxNombreE.SelectedItem != null)
            {
                nombre = int.Parse(comboBoxNombreE.SelectedItem.GetType()
                    .GetProperty("Value").GetValue(comboBoxNombreE.SelectedItem, null).ToString());
            }
            var conexion = new ConexionBBDD();
        }

        /* public void TablaEmpanadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             var conexion = new ConexionBBDD();
             //string consulta = "select * from Empanadas";
             string consulta = "select idEmpanada 'ID', NombreEmpanada, PrecioEmpanada 'Precio' from Empanadas"

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
