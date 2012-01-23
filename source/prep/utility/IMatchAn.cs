namespace prep.utility
{
  public interface IMatchAn<in ItemToMatch>
  {
    bool matches(ItemToMatch item);
  }
}