using BlazorCRUD.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private readonly string ConnectionString;

        public FilmRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected SqlConnection DbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public Task<bool> DeleteFilm(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Film>> GetAllFilms()
        {
            var db = DbConnection();
            var sql = @"SELECT * FROM dbo.Films";

            return await db.QueryAsync<Film>(sql.ToString(), new { });
        }

        public async Task<Film> GetFilmDetails(int id)
        {
            var db = DbConnection();
            var sql = @"SELECT * FROM dbo.Films WHERE Id = @id";

            return await db.QueryFirstOrDefaultAsync<Film>(sql.ToString(), new { id });
        }

        public async Task<bool> InsertFilm(Film film)
        {
            var db = DbConnection();
            var sql = @"
                        INSERT INTO Films (Title, Director, ReleaseDate)
                        VALUES (@Title, @Director, @ReleaseDate)";
            var result = await db.ExecuteAsync(sql.ToString(),
                new { film.Title, film.Director, film.ReleaseDate });
            return result > 0;
        }

        public Task<bool> UpdateFilm(Film film)
        {
            throw new NotImplementedException();
        }
    }
}
