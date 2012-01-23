using System.Collections.Generic;

namespace prep.collections
{
  public class MovieCompareByTitleDescending : IComparer<Movie>
  {
    public int Compare(Movie x, Movie y)
    {
      return y.title.CompareTo(x.title);
    }
  }
}