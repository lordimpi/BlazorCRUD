using BlazorCRUD.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private string ConnectionString;

        public FilmRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected SqlConnection DbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public Task<bool> DeleteFilm()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Film>> GetAllFilms()
        {
            throw new NotImplementedException();
        }

        public Task<Film> GetFilmDetails()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertFilm()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateFilm()
        {
            throw new NotImplementedException();
        }
    }
}
