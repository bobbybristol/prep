namespace prep.utility.filtering
{
  public class NeverMatch<ItemToMatch> : IMatchAn<ItemToMatch>
  {
    public bool matches(ItemToMatch item)
    {
      return false;
    }
  }
}