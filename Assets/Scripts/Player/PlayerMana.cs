using System.Collections;
using UnityEngine;

    public class PlayerMana : MonoBehaviour
    {
    [Header("Config")]
    [SerializeField] private PlayerStats stats;

    public void UseMana(float amount) 
    {
    if (stats.Mana >= amount)
        {
            stats.Mana = Mathf.Max(stats.Mana -= amount, 0f);


            stats.Mana -= amount;
            if (stats.Mana <= 0) 
            {
                stats.Mana = 0f;
            }
        }
    }
}


