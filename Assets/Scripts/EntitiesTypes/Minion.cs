using System.Collections;
using UnityEngine;

namespace Assets.Scripts.EntitiesTypes
{
    public class Minion : Vulnerable
    {
        public int moveCost = 0;
        public int range = 1;
        public bool isMelee = false;
    }
}