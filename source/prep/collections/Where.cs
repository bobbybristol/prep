using System;

namespace prep.collections
{
  public delegate ProductionStudio ProductionStudioAccessor(Movie movie);

  public class Where<ItemToMatch>
  {
    public static void has_a(ProductionStudioAccessor accessor)
    {
      throw new NotImplementedException();
    }
  }
}