using System;

namespace prep.collections
{
  public delegate ProductionStudio ProductionStudioAccessor(Movie movie);

  public class Where<ItemToMatch>
  {
    public static ProductionStudio has_a(ProductionStudioAccessor accessor)
    {
        return accessor();
    }
  }
}