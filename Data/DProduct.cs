using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;

namespace Data
{
    public class DProduct
    {
        public static string connectionString = "Data Source=LAB1504-22\\SQLEXPRESS;Initial Catalog=master;Integrated Security=true";

        public static List<Product> Get()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Abrir la conexión
                connection.Open();

                // Consulta SQL para seleccionar datos
                string query = "select * from products";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Verificar si hay filas
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Leer los datos de cada fila

                                products.Add(new Product
                                {
                                    ProductId = (int)reader["product_id"],
                                    Name = reader["name"].ToString(),
                                    Price = reader["price"].ToString(),
                                    Stock = reader["stock"].ToString(),
                                    Active = reader["active"].ToString(),

                                });

                            }
                        }
                    }
                }
                // Cerrar la conexión
                connection.Close();


            }

            return products;
        }
    }
}
