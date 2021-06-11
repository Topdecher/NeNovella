using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Hand : MonoBehaviour
    {
        public int maxHandSize = 10;
        public int handSize = 0;
        public List<Card> cardArray = new List<Card>();

        public bool IsFull() => handSize >= maxHandSize;

        public void InsertCard(Card card)
        {
            if (handSize < maxHandSize)
            {
                cardArray.Add(card);
            }
        }

        public void UpdateChars()
        {
            handSize = cardArray.Count;
        }
    }


}