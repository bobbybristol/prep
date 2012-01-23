using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using prep.collections;

namespace prep.utility
{
    public static class DslExtensions
    {
        public static IMatchAn<Movie> equal_to(this ProductionStudio left_studio, ProductionStudio right_studio)
        {
            return new IsPublishedBy(right_studio);
        }
    }
}
