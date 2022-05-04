using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieDB.Models;


namespace MovieDB.Models.DAL
{
    public class DataServices
    {
        static List<Movie> movieList;

        public int InsertMovie(Movie movie)
        {
            if (movieList == null)
            {
                movieList = new List<Movie>();
            }

            movieList.Add(movie);
            return 1;
        }

        public List<Movie> Get()
        {
            return movieList;
        }

        public Movie Get(String Title,int Id)
        {
            Movie newMovie = new Movie();
            foreach (Movie m in movieList)
            {
                if (m.Title == Title && m.Id == Id)
                    newMovie = m;
            }
            return newMovie;
        }
        public DataServices()
        {

        }
    }
}
    
