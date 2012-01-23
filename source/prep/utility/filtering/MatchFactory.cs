using System;

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
      return new LambdaMatch<ItemToMatch>(x => accessor(x).Equals(value));
    }

    public IMatchAn<ItemToMatch> equal_to_any(params PropertyType[] values)
    {
      throw new NotImplementedException();
    }
  }
}