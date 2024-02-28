using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Statics
{
    public class Enemy
    {
        public static int enemyCount = 0;

        public Enemy()
        {
            enemyCount++;
        }
    }
}
