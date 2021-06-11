using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Card : SolidObject
    {
        public int mana = 0;
        public string cardType = null;
        public Vector3 posInHand;

        private void OnMouseOver()
        {
            transform.position = posInHand + new Vector3(0, 0.5f, -1f);
        }
        private void OnMouseExit()
        {
            transform.position = posInHand;
        }
        private void OnMouseDrag()
        {

        }
        private void OnMouseUpAsButton()
        {
            
        }
    }
}
