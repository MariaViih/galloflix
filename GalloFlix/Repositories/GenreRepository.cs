Using GalloFlix.Interfaces;
Using GalloFlix.models;
using MySql.Data.MySqlClient;

namespace GalloFlix.Repositories;
{
    public class GenreRepository : IGenreRepository
    {
        string connectionString= "server=localhost;port=3306;database=galloflixdb;uid=root;pwb=''";

        public void Creat(Genre model)

         using (MySqlconnection connection= new(connectionString))
        {
            string sql= "insert into genre(name) values(@name)";
            MySqlcommand command = new(sql, connection);
            command.commandType = System.Data.CommandType.Text;
            Command.Parameters.AddWithValue("@name",model.Name);
            connection.Open();
            command.ExecuteNonQuery();
            connection.close();
        }

    }
    public void Delete(int? id)
     using (MySqlconnection = new(connectionString))
    {
        var sql = "delete from genre where id = @id";
        MySqlcommand command = new(sql, connection);
        command.commandType = System.Data.CommandType.Text;
         Command.Parameters.AddWithValue("@id",id);
         connection.Open();
         command.ExecuteNonQuery();
         connection.close();
    }

    public List<Genre> ReadAll()
    {
        List<Genre> genres = new();
         using (MySqlConnection connection = new(connectionString))
         {
             var Sql = "Select * from genre";
             MySqlCommand command = new(sql, connection);
             command.commandType = System.Data.CommandType.Text;
             connection.Open()
             MySqlDataReader reader = command.ExecuteRender();
             While (reader.Read())
             {
                 genres.Add(
                     new Genre()
                     {
                         id = covert.ToByte(reader["id"]),
                         Name = reader["name"].ToString()
                     }
                 );
             }
             connection.close();
         }
        return genres;
    }
}