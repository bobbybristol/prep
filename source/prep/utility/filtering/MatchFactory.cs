using System;
using System.Collections.Generic;

namespace prep.utility.filtering
{
  public class MatchFactory<ItemToMatch, PropertyType>
  {
    PropertyAccessor<ItemToMatch, PropertyType> accessor;

    public MatchFactory(PropertyAccessor<ItemToMatch, PropertyType> accessor)
    {
      this.accessor = accessor;
    }

    public IMatchAn<ItemToMatch> equal_to(PropertyType value)
    {
      return equal_to_any(value);
    }

    public IMatchAn<ItemToMatch> equal_to_any(params PropertyType[] values)
    {
      return new LambdaMatch<ItemToMatch>(x => new List<PropertyType>(values).Contains(accessor(x)));
    }

    public IMatchAn<ItemToMatch> not_equal_to(PropertyType value)
    {
      throw new NotImplementedException();
    }
  }
}