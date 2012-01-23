namespace prep.utility.filtering
{
  public class Where<ItemToMatch>
  {
    public static MatchFactory<ItemToMatch, PropertyType> has_a<PropertyType>(
      PropertyAccessor<ItemToMatch, PropertyType> accessor)
    {
      return new MatchFactory<ItemToMatch, PropertyType>(accessor);
    }
  }
}