using AchadosPerdidos.Business.Model;
using AchadosPerdidos.Business.Repository;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace AchadosPerdidos.Data.SqlRepository
{
	public class SqlProductRepository : IProducRepository
	{
		private string connectionString = ConfigurationManager.ConnectionStrings["AchadosPerdidosDB"].ConnectionString;

		public void Create(Product product)
		{
			var sqlConnection = new SqlConnection(connectionString);
			var command = new SqlCommand("Insert into [AchadosPerdidos].[dbo].[Product](type, color, size) " +
				"values(@type, @color, @size)", sqlConnection);
			command.Parameters.AddWithValue("@type", product.Type);
			command.Parameters.AddWithValue("@color", product.Color);
			command.Parameters.AddWithValue("@size", product.Size);

			sqlConnection.Open();
			command.ExecuteNonQuery();
			command.Clone();
			sqlConnection.Close();
		}
	}
}
