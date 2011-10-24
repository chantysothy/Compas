using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compas.Helpers
{
    public class GroupResult<T>
    {
        public object Key { get; set; }
        public int Count { get; set; }
        public IEnumerable<T> Items { get; set; }
        public IEnumerable<GroupResult<T>> SubGroups { get; set; }
        public override string ToString()
        { return string.Format("{0} ({1})", Key, Count); }
    }
}
