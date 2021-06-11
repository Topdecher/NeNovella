using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Deck : MonoBehaviour
    {
        public List<Card> cardDeck = new List<Card>();
        public List<Card> burnedCards = new List<Card>();
        public Hand hand;
        public Card upCard;
        public int deckSize = 0;
        public int maxDeckSize = 30;

        public void DrawCard(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                TakeCard();
            }
        }

        public void TakeCard()
        {
            if (!IsEmpty())
            {
                hand.InsertCard(upCard);
                cardDeck.Remove(upCard);
                UpdateChars();
            }
        }

        public void ShuffleCard(Card card)
        {
            if (!IsFull())
            {
                int randIndex = Random.Range(0, deckSize);
                cardDeck.Insert(randIndex, card);
                UpdateChars();
            }
        }

        public void ShuffleCard(Card card, int ind)
        {
            cardDeck.Insert(ind, card);
            UpdateChars();
        }

        public bool IsEmpty() => deckSize <= 0;
        public bool IsFull() => deckSize >= maxDeckSize;

        public void UpdateChars()
        {
            deckSize = cardDeck.Count;
            upCard = cardDeck[0];
        }
    }
}