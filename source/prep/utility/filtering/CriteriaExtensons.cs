namespace prep.utility.filtering
{
  public static class CriteriaExtensons
  {
    public static IMatchAn<ItemToMatch> or<ItemToMatch>(this IMatchAn<ItemToMatch> left,
                                                        IMatchAn<ItemToMatch> right)
    {
      return new OrMatch<ItemToMatch>(left, right);
    }

  }
}