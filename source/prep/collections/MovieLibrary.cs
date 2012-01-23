using System.Collections.Generic;
using prep.utility;

namespace prep.collections
{
  public class MovieLibrary
  {
    IList<Movie> movies;

    public MovieLibrary(IList<Movie> list_of_movies)
    {
      this.movies = list_of_movies;
    }

    public IEnumerable<Movie> all_movies()
    {
      return movies.one_at_a_time();
    }

    public void add(Movie movie)
    {
      if (already_contains(movie)) return;

      movies.Add(movie);
    }

    bool already_contains(Movie movie)
    {
      return movies.Contains(movie);
    }

    public IEnumerable<Movie> all_movies_published_by_pixar()
    {
      return find_all(m => m.production_studio == ProductionStudio.Pixar);
    }

    public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
    {
      return find_all(
        m => m.production_studio == ProductionStudio.Pixar || m.production_studio == ProductionStudio.Disney);
    }

    IEnumerable<Movie> find_all(Condition<Movie> condition)
    {
      return movies.all_items_matching(condition);
    }

    public IEnumerable<Movie> all_movies_not_published_by_pixar()
    {
      var matches = new List<Movie>(this.movies);
      return matches.FindAll(m => m.production_studio != ProductionStudio.Pixar);
    }

    public IEnumerable<Movie> all_movies_published_after(int year)
    {
      var matches = new List<Movie>(this.movies);
      return matches.FindAll(m => m.date_published.Year > year);
    }

    public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
    {
      var matches = new List<Movie>(this.movies);
      return matches.FindAll(m => m.date_published.Year >= startingYear && m.date_published.Year <= endingYear);
    }

    public IEnumerable<Movie> all_kid_movies()
    {
      var matches = new List<Movie>(this.movies);
      return matches.FindAll(m => m.genre == Genre.kids);
    }

    public IEnumerable<Movie> all_action_movies()
    {
      var matches = new List<Movie>(this.movies);
      return matches.FindAll(m => m.genre == Genre.action);
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
    {
      var sorted = new List<Movie>(this.movies);
      sorted.Sort(new MovieCompareDatePublishedDescending());
      return sorted;
    }

    public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
    {
      var sorted = new List<Movie>(this.movies);
      sorted.Sort(new MovieCompareDatePublishedAscending());
      return sorted;
    }

    public IEnumerable<Movie> sort_all_movies_by_title_descending()
    {
      var sortMovies = new List<Movie>(this.movies);
      sortMovies.Sort(new MovieCompareByTitleDescending());

      return sortMovies;
    }

    public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
    {
      var sortOrder = new Dictionary<ProductionStudio, int>
      {
        {ProductionStudio.MGM, 1},
        {ProductionStudio.Pixar, 2},
        {ProductionStudio.Dreamworks, 3},
        {ProductionStudio.Universal, 4},
        {ProductionStudio.Disney, 5}
      };

      var sortMovies = new List<Movie>(this.movies);
      sortMovies.Sort((x, y) =>
      {
        var xrating = sortOrder[x.production_studio];
        var yrating = sortOrder[y.production_studio];

        var result = xrating.CompareTo(yrating);
        if (result == 0)
          result = x.date_published.CompareTo(y.date_published);

        return result;
      });

      return sortMovies;
    }

    public IEnumerable<Movie> sort_all_movies_by_title_ascending()
    {
      var sortMovies = new List<Movie>(this.movies);
      sortMovies.Sort(new MovieCompareByTitleAscending());
      return sortMovies;
    }
  }
}