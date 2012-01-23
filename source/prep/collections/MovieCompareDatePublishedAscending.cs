using System.Collections.Generic;

namespace prep.collections
{
  public class MovieCompareDatePublishedAscending : IComparer<Movie>
  {
    public int Compare(Movie x, Movie y)
    {
      return x.date_published.CompareTo(y.date_published);
    }
  }
}