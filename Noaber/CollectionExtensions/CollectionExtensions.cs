using System;
using System.Collections;
using System.Collections.Generic;

using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;


   public static partial class CollectionExtensions
    {
       public static short Sum(this IEnumerable<short> value ) {
           if (value == null)
           {
               throw new ArgumentNullException("value", "value is null");
           }
           return value.Aggregate((short acc,short v) => (short)(acc+v));     
       }

    }

