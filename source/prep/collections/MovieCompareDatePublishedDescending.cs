using System.Collections.Generic;

namespace prep.collections
{
  public class MovieCompareDatePublishedDescending : IComparer<Movie>
  {
    public int Compare(Movie x, Movie y)
    {
      return y.date_published.CompareTo(x.date_published);
    }
  }
}