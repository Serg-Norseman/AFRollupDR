﻿using System;
using OSIsoft.AF.Asset;
using OSIsoft.AF.Time;

namespace AFAttrLookupDR
{
    public static class Extensions
    {
        public static bool IsStringVal(object objVal)
        {
            return (objVal is String);
        }

        public static bool IsStringVal(Type valType)
        {
            return (valType == typeof(String));
        }

        public static bool IsDateTimeVal(object objVal)
        {
            return (objVal is DateTime);
        }

        public static bool IsDateTimeVal(Type valType)
        {
            return (valType == typeof(DateTime));
        }

        public static AFValue CreateBadValue(this AFAttribute attribute, AFTime time)
        {
            return AFValue.CreateSystemStateValue(attribute, AFSystemStateCode.NoResult, time);
        }
    }
}