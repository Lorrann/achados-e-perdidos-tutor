using AchadosPerdidos.Business.Model;
using AchadosPerdidos.Business.Repository;
using System.Data.SqlClient;

namespace AchadosPerdidos.Data.SqlRepository
{
    public class SqlUserRepository : IUserRepository
    {
        public void Create(User user)
        {
            var sqlConnection = new SqlConnection("Data Source=.;Initial Catalog=AchadosPerdidos;Integrated Security=True");
            var command = new SqlCommand("Insert into [AchadosPerdidos].[dbo].[User](name, fone, mail, cpf, password) " +
                "values(@name, @fone, @mail, @cpf, @password)", sqlConnection);
            command.Parameters.AddWithValue("@name", user.Name);
            command.Parameters.AddWithValue("@fone", user.Fone);
            command.Parameters.AddWithValue("@mail", user.Mail);
            command.Parameters.AddWithValue("@cpf", user.CPF);
            command.Parameters.AddWithValue("@password", user.Password);

            sqlConnection.Open();
            command.ExecuteNonQuery();
            command.Clone();
            sqlConnection.Close();
        }
    }
}
