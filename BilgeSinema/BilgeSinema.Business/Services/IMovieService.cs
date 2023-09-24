using BilgeSinema.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeSinema.Business.Services
{
    public interface IMovieService
    {
        bool AddMovie(AddMovieDto addMovieDto);

        List<GetMovieDto> GetMovie();

        GetMovieDto GetMovie(int id);
        int UpdateMovie(UpdateMovieDto updateMovieDto);
        int DiscountMovie(int id);

        int DeleteMovie(int id);
    }
}
