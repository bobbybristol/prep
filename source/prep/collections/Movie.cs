using System;
using System.Collections.Generic;

namespace prep.collections
{
  public class Movie : IEquatable<Movie>
  {
    public string title { get; set; }
    public ProductionStudio production_studio { get; set; }
    public Genre genre { get; set; }
    public int rating { get; set; }
    public DateTime date_published { get; set; }

    public override bool Equals(object obj)
    {
      return Equals(obj as Movie);
    }

    public bool Equals(Movie other)
    {
      if (other == null) return false;

      return ReferenceEquals(this,other) || other.title == title;
    }

    public override int GetHashCode()
    {
      return title.GetHashCode();
    }
  }

  public class MovieCompareByTitleAscending : IComparer<Movie>
  {
    public int Compare(Movie x, Movie y)
    {
      return x.title.CompareTo(y.title);
    }
  }

  public class MovieCompareByTitleDescending : IComparer<Movie>
  {
    public int Compare(Movie x, Movie y)
    {
      return y.title.CompareTo(x.title);
    }
  }

  public class MovieCompareDatePublishedAscending : IComparer<Movie>
  {
    public int Compare(Movie x, Movie y)
    {
      return x.date_published.CompareTo(y.date_published);
    }
  }

  public class MovieCompareDatePublishedDescending : IComparer<Movie>
  {
    public int Compare(Movie x, Movie y)
    {
      return y.date_published.CompareTo(x.date_published);
    }
  }
}