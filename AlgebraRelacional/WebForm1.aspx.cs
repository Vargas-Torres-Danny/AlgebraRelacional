using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlgebraRelacional
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string cadenaConexion = "Server=localhost;Database=BDVentas;Trusted_Connection=True;";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Consulta 1: Selección - Clientes cuya dirección sea 'Cusco'
        protected void btnConsulta1_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM TCliente WHERE Direccion = 'Cusco'";
            EjecutarConsulta(consulta);
        }

        // Consulta 2: Proyección - Nombre de productos
        protected void btnConsulta2_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT Nombre FROM TProducto";
            EjecutarConsulta(consulta);
        }

        // Consulta 3: Renombramiento - Datos de clientes renombrados
        protected void btnConsulta3_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT CodCliente AS Codigo, Apellidos AS ApellidoCliente, Nombres AS NombreCliente FROM TCliente";
            EjecutarConsulta(consulta);
        }

        // Consulta 4: Selección - Productos con precio > 10
        protected void btnConsulta4_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM TProducto WHERE Precio > 10";
            EjecutarConsulta(consulta);
        }

        // Consulta 5: Proyección - Apellidos y nombres de los vendedores
        protected void btnConsulta5_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT Apellidos, Nombres FROM TVendedor";
            EjecutarConsulta(consulta);
        }

        // Consulta 6: Renombramiento - Productos con alias
        protected void btnConsulta6_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT CodProduto AS Codigo, Nombre AS Producto, Precio AS PrecioUnitario FROM TProducto";
            EjecutarConsulta(consulta);
        }

        // Consulta 7: Selección - Vendedores cuyo apellido empieza con 'A'
        protected void btnConsulta7_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM TVendedor WHERE Apellidos LIKE 'A%'";
            EjecutarConsulta(consulta);
        }

        // Consulta 8: Proyección - Fechas de boletas
        protected void btnConsulta8_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT Fecha FROM TBoleta";
            EjecutarConsulta(consulta);
        }

        // Consulta 9: Renombramiento - Boletas con columnas renombradas
        protected void btnConsulta9_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT NroBoleta AS Numero, Fecha AS Dia, Anulado AS EstaAnulado FROM TBoleta";
            EjecutarConsulta(consulta);
        }


        protected void btnConsulta10_Click(object sender, EventArgs e)
        {
            // Ejemplo: Unión de dos selecciones del mismo tipo
            string query = "SELECT CodCliente, Apellidos FROM TCliente WHERE Apellidos LIKE 'A%' " +
                           "UNION " +
                           "SELECT CodCliente, Apellidos FROM TCliente WHERE Apellidos LIKE 'B%'";
            EjecutarConsulta(query);
        }

        protected void btnConsulta11_Click(object sender, EventArgs e)
        {
            string query = "SELECT Nombre FROM TProducto WHERE Stock > 50 " +
                           "UNION " +
                           "SELECT Nombre FROM TProducto WHERE Precio < 10";
            EjecutarConsulta(query);
        }

        protected void btnConsulta12_Click(object sender, EventArgs e)
        {
            string query = "SELECT CodCategoria FROM TCategoria WHERE CategoriaPadre IS NOT NULL " +
                           "UNION " +
                           "SELECT CodCategoria FROM TCategoria WHERE CategoriaPadre IS NULL";
            EjecutarConsulta(query);
        }

        protected void btnConsulta13_Click(object sender, EventArgs e)
        {
            string query = "SELECT CodProducto FROM TProducto WHERE Stock > 100 " +
                           "EXCEPT " +
                           "SELECT CodProducto FROM TProducto WHERE Precio > 20";
            EjecutarConsulta(query);
        }

        protected void btnConsulta14_Click(object sender, EventArgs e)
        {
            string query = "SELECT CodCliente FROM TBoleta " +
                           "EXCEPT " +
                           "SELECT CodCliente FROM TBoleta WHERE Anulado = 1";
            EjecutarConsulta(query);
        }

        protected void btnConsulta15_Click(object sender, EventArgs e)
        {
            string query = "SELECT CodVendedor FROM TVendedor " +
                           "EXCEPT " +
                           "SELECT CodVendedor FROM TBoleta";
            EjecutarConsulta(query);
        }

        protected void btnConsulta16_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TCliente CROSS JOIN TVendedor";
            EjecutarConsulta(query);
        }

        protected void btnConsulta17_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TProducto CROSS JOIN TCategoria";
            EjecutarConsulta(query);
        }

        protected void btnConsulta18_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM TVendedor CROSS JOIN TCategoria";
            EjecutarConsulta(query);
        }

        // Método reutilizable para ejecutar consultas
        private void EjecutarConsulta(string consulta)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                gvConsulta.DataSource = tabla;
                gvConsulta.DataBind();
            }
        }
    }
}