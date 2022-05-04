using MovieDB.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;

namespace MovieDB.Controllers
{


    public class MoviesController : ApiController
    {
        //GET api/<controller>
        public IEnumerable<Movie> Get()
        {
            Movie m = new Movie();
            List<Movie> mmList = m.Get();
            return mmList;
        }


        //GET api/<controller>/5
        public string Get(int id)
        {
            return id.ToString(); 
        }

        //[HttpGet]
        //[Route("api/flights/{Title}")]
        //public IEnumerable<Movie> Get(string Title)
        //{
        //    Movie m = new Movie();
        //    List<Movie> mmList = m.Get(Title);
        //    return mmList;
        //}
    [HttpGet]
    [Route("api/Movies/{Title}/{Id}")]
    public Movie Get(string Title,int Id)
    {
        Movie newMovie = new Movie();
        Movie m = new Movie();
         newMovie = m.Get(Title,Id);
        return newMovie;
    }




    // POST api/<controller>
    public int Post([FromBody] Movie movie)
        {
            return movie.InsertMovie();
            
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            
        }



    }
}