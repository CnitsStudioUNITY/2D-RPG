using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeath : MonoBehaviour, IDamageable
{
    [Header("config")]
    [SerializeField] private PlayerStats stats;

    private PlayerAnimation playerAnimations;

    private void Awake()
    {
        playerAnimations = GetComponent < PlayerAnimation>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)) 
        {
            TakeDamage(1f);
        }
    }

    public void TakeDamage(float amount) 
    { 
        stats.Health -= amount; 
        if (stats.Health <= 0f)
        { 
        PlayerDead();
        }
    }

    private void PlayerDead() 
    {
        playerAnimations.SetDeadAnimation();
    }

}






