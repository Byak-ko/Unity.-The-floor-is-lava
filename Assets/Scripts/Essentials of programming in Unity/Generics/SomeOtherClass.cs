using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Generics
{
    public class SomeOtherClass : MonoBehaviour
    {
        void Start()
        {
            SomeClass myClass = new SomeClass();

            myClass.GenericMethod<int>(5);
        }
    }
}
