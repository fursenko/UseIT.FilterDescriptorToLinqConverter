using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnD.FilterDescriptorToLinqConverter
{
    public class FilterDescriptor
    {
        public string Member { get; set; }
        public Type MemberType { get; set; }
        public FilterOperator Operator { get; set; }
        public object Value { get; set; }
    }
}
