using System;
using prep.collections;

namespace prep.utility.filtering
{
  public class Where<ItemToMatch>
  {
    public static Something has_a<PropertyType>(PropertyAccessor<ItemToMatch, PropertyType> accessor)
    {
      throw new NotImplementedException();
    }
  }

  public class Something
  {
    public IMatchAn<Movie> equal_to(ProductionStudio pixar)
    {
      throw new NotImplementedException();
    }
  }
}