namespace prep.utility.filtering
{
  public interface IMatchAn<in ItemToMatch>
  {
    bool matches(ItemToMatch item);
  }
}