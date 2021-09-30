using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using MySql.Data;

namespace MovieAPI.Models
{
    [Table("movies")]
    public class Movie
    {
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public string category { get; set; }
    }
}
