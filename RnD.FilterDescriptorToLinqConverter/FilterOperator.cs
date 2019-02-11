using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RnD.FilterDescriptorToLinqConverter
{
    public enum FilterOperator
    {
          IsLike = 0
        , IsNotLike = 1
        , IsLessThan = 2
        , IsLessThanOrEqualTo = 3
        , IsEqualTo = 4
        , IsNotEqualTo = 5
        , IsGreaterThanOrEqualTo = 6
        , IsGreaterThan = 7
        , StartsWith = 8
        , EndsWith = 9
        , Contains = 10
        , NotContains = 11
        , IsNull = 12
        , IsNotNull = 13
        , IsContainedIn = 14
        , IsNotContainedIn = 15
    }
}
