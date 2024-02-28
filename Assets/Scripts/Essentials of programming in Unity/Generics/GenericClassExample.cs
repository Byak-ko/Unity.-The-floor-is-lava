using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Generics
{
    public class GenericClassExample : MonoBehaviour
    {
        void Start()
        {
            GenericClass<int> myClass = new GenericClass<int>();

            myClass.UpdateItem(5);
        }
    }
}
