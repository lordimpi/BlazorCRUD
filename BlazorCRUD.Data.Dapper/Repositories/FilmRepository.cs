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
        private SqlConnection Db;
        private string sql;

        public FilmRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected SqlConnection DbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        private void ConnectionDb(string sql)
        {
            Db = DbConnection();
            this.sql = sql;
        }

        public async Task<bool> DeleteFilm(int id)
        {
            ConnectionDb(@"DELETE FROM Films WHERE Id = @id");

            var result = await Db.ExecuteAsync(sql.ToString(), new {Id = id });

            return result > 0;
        }

        public async Task<IEnumerable<Film>> GetAllFilms()
        {
            ConnectionDb(@"SELECT * FROM dbo.Films");

            return await Db.QueryAsync<Film>(sql.ToString(), new { });
        }

        public async Task<Film> GetFilmDetails(int id)
        {
            ConnectionDb(@"SELECT * FROM dbo.Films WHERE Id = @id");

            return await Db.QueryFirstOrDefaultAsync<Film>(sql.ToString(), new { id });
        }

        public async Task<bool> InsertFilm(Film film)
        {
            ConnectionDb(@"INSERT INTO Films (Title, Director, ReleaseDate)
                        VALUES (@Title, @Director, @ReleaseDate)");
            var result = await Db.ExecuteAsync(sql.ToString(),
                new { film.Title, film.Director, film.ReleaseDate });
            return result > 0;
        }

        public async Task<bool> UpdateFilm(Film film)
        {
            ConnectionDb(@"UPDATE Films
                        SET Title = @Title, Director = @Director, ReleaseDate = @ReleaseDate
                        WHERE Id = @id");
            var result = await Db.ExecuteAsync(sql.ToString(),
                new { film.Title, film.Director, film.ReleaseDate , film.Id});

            return result > 0;
        }
    }
}
