using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Statics
{
    public class Player : MonoBehaviour
    {
        public static int playerCount = 0;

        void Start()
        {
            playerCount++;
        }
    }
}
