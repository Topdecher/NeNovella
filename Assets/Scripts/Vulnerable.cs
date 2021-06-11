using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Vulnerable : SolidObject
    {
        public int maxHealth = 1;
        public int health = 1;
        public int attack = 1;
        public int takenDamage = 0;
        public int healedDamage = 0;
        public int takenDamageThisTurn = 0;
        public int healedDamageThisTurn = 0;

        public void Heal(int healAmount)
        {
            if (health + healAmount > maxHealth)
            {
                healedDamage += maxHealth - health;
                healedDamageThisTurn += maxHealth - health;
                health = maxHealth;
            }
            else
            {
                health += healAmount;
                healedDamage += healAmount;
                healedDamageThisTurn += healAmount;
            }
        }

        public void Damage(int damage)
        {
            health -= damage;
            takenDamage += damage;
            takenDamageThisTurn += damage;
        }

        public void UpdateChars()
        {
            takenDamageThisTurn = 0;
            healedDamageThisTurn = 0;
        }

        public bool IsDead() => health <= 0;
    }
}