using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using Dapper;
using MySql.Data.MySqlClient;

namespace MovieAPI.Models
{
    public class DAL
    {
        public static MySqlConnection DB;
        public static List<Movie> GetAllMovies()
        {
            return DB.GetAll<Movie>().ToList();
        }
        public static Movie GetOneMovie(int id)
        {
            return DB.Get<Movie>(id);
        }
        public static List<Movie> GetAllByCategory(string cat)
        {
            var myparams = new { category = cat };
            string sql = "select * from movies where category = @category";

            List<Movie> films = DB.Query<Movie>(sql, myparams).ToList();
            return films;
        }

        public static bool DeleteMovie(int id)
        {
            Movie temp = new Movie() { id = id };
            DB.Delete<Movie>(temp);
            return true;
        }
        public static Movie AddMovie(Movie mov)
        {
            DB.Insert<Movie>(mov);
            return mov;
        }
        public static Movie UpdateMovie(Movie mov)
        {
            DB.Update<Movie>(mov);
            return mov;
        }

        
    }
     
    
}
