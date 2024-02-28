using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PolymorphismAndCasting
{
    public class PetShop : MonoBehaviour
    {
        [SerializeReference]
        public Mammal mammal = new Cat();
    }
}
