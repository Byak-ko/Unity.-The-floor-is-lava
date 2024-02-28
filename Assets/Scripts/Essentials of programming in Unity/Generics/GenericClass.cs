using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Generics
{
    public class GenericClass <T>
    {
        T item;

        public void UpdateItem(T newItem)
        {
            item = newItem;
        }
    }
}
