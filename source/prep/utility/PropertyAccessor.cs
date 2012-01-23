namespace prep.utility
{
  public delegate PropertyType PropertyAccessor<in Target, out PropertyType>(Target item);

}