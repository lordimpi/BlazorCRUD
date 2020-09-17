using BlazorCRUD.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositories
{
    public interface IFilmRepository
    {
        Task<IEnumerable<Film>> GetAllFilms(int id);
        Task<Film> GetFilmDetails();
        Task<bool> InsertFilm(Film film);
        Task<bool> UpdateFilm(Film id);
        Task<bool> DeleteFilm(int id);
    }
}
