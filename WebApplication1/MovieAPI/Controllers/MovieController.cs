using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieAPI.Models;
using System.Net.Http;

namespace MovieAPI.Controllers
{
    [Route("api/movie")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        [HttpGet("allmovies")]
        public List<Movie> getAll()
        {
            return DAL.GetAllMovies();
        }
        [HttpGet("{id}")]
        public Movie GetSingleMovie(int id)
        {
            return DAL.GetOneMovie(id);
        }

        [HttpGet("readbycategory")]
        public List<Movie> GetMoviesInCategory(string cat)
        {
            return DAL.GetAllByCategory(cat);
        }

        [HttpDelete("delete")] 
        public bool deleteMovie(int id)
        {
            return DAL.DeleteMovie(id);
        }
        [HttpPost("add")] 
        public Movie addMovie(Movie movie)
        {
            return DAL.AddMovie(movie);
        }
        [HttpPut("update")] 
        public Movie updateMovie(Movie movie)
        {
            return DAL.UpdateMovie(movie);
        }
    }
}
