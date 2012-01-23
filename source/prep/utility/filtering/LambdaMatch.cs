namespace prep.utility.filtering
{
  public class LambdaMatch<ItemToMatch> : IMatchAn<ItemToMatch>
  {
    Condition<ItemToMatch> condition;

    public LambdaMatch(Condition<ItemToMatch> condition)
    {
      this.condition = condition;
    }

    public bool matches(ItemToMatch item)
    {
      return condition(item);
    }
  }
}