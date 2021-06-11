using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Player : MonoBehaviour
    {
        public Hand hand;
        public Deck deck;
        public Board board;
        public GameManager gameManager;

        public void Setup(Board board, GameManager gameManager)
        {
            hand = gameObject.AddComponent<Hand>();
            deck = gameObject.AddComponent<Deck>();
            this.board = board;
            this.gameManager = gameManager;
            for (int i = 0; i < 3; i++)
            {
                
            }
        }
    }
}