using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Generics
{
    public class SomeClass
    {
        public T GenericMethod<T>(T param)
        {
            return param;
        }
    }
}
