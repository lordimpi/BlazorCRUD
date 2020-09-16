using BlazorCRUD.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositories
{
    public interface IFilmRepository
    {
        Task<IEnumerable<Film>> GetAllFilms();
        Task<Film> GetFilmDetails();
        Task<bool> InsertFilm();
        Task<bool> UpdateFilm();
        Task<bool> DeleteFilm();
    }
}
