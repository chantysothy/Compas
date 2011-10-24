using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compas.Helpers
{
    public static class GroupEnumerableExtensions
    {
        public static IEnumerable<GroupResult<TElement>> GroupByMany<TElement>(
           this IEnumerable<TElement> elements,
           params Func<TElement, object>[] groupSelectors)
        {
            if (groupSelectors.Length > 0)
            {
                var selector = groupSelectors.First();
                var nextSelectors = groupSelectors.Skip(1).ToArray();
                return
                    elements.GroupBy(selector).Select(
                        g => new GroupResult<TElement>
                        {
                            Key = g.Key,
                            Count = g.Count(),
                            Items = g,
                            SubGroups = g.GroupByMany(nextSelectors)
                        });
            }
            else
                return null;
        }
    }
}
