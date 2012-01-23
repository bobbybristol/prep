using System.Collections.Generic;

namespace prep.collections
{
  public class MovieCompareByTitleAscending : IComparer<Movie>
  {
    public int Compare(Movie x, Movie y)
    {
      return x.title.CompareTo(y.title);
    }
  }
}