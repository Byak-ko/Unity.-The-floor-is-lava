using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MemberHiding
{
    public class Enemy : Humanoid
    {
        new public void Yell()
        {
            Debug.Log("Enemy version of the Yell() method");
        }
    }
}
