using System;


using System.Collections.Generic;
using System.ComponentModel;

namespace prep.collections
{
    public class MovieLibrary 
    {
        private readonly IList<Movie> movies;

        public MovieLibrary(IList<Movie> list_of_movies)
        {
            movies = list_of_movies;
        }

        public IEnumerable<Movie> all_movies()
        {
            return movies;
        }

        public void add(Movie movie)
        {
           movies.Add(movie);
        }

        public IEnumerable<Movie> sort_all_movies_by_title_descending()
        {
            
        }

        public IEnumerable<Movie>
            all_movies_published_by_pixar()
        {
            var list = new List<Movie>();
            foreach (var movie in  movies)
            {
                if (movie.production_studio.Equals(ProductionStudio.Pixar))
                    list.Add(movie);

            }
            return list;
           
        }

        public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
        {
            var list = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie.production_studio.Equals(ProductionStudio.Pixar) || (movie.production_studio.Equals(ProductionStudio.Disney)))
                    list.Add(movie);

            }
            return list;

        }

        public IEnumerable<Movie> sort_all_movies_by_title_ascending()
        {

            
           
            

        }

        public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
        {
                    }

        public IEnumerable<Movie> all_movies_not_published_by_pixar()
        {
         
            foreach (var movie in movies)
            {
                if (!(movie.production_studio.Equals(ProductionStudio.Pixar)))
                    yield return movie;

            }
        
        }

        public IEnumerable<Movie> all_movies_published_after(int year)
        {
            foreach (var movie in movies)
            {
                if (movie.date_published.Year>year)
                    yield return movie;

            }
        }

        public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
        {
            foreach (var movie in movies)
            {
                if ((movie.date_published.Year >= startingYear) || (movie.date_published.Year >= endingYear))
                    yield return movie;

            }
        }

        public IEnumerable<Movie> all_kid_movies()
        {
            foreach (var movie in movies)
            {
                if (movie.genre==Genre.kids)
                    yield return movie;

            }
        }

        public IEnumerable<Movie> all_action_movies()
        {
            foreach (var movie in movies)
            {
                if (movie.genre == Genre.action)
                    yield return movie;

            }
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
        {
            
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
        {
            throw new NotImplementedException();
        }
    }
}