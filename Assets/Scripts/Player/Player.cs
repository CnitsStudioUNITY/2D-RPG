using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("config")]
    [SerializeField] private PlayerStats stats;

    public PlayerStats Stats => stats;

    private PlayerAnimation animations;

    private void Awake()
    {
        animations = GetComponent<PlayerAnimation>();
    }

    public void ResetPlayer()
    {
        stats.ResetPlayer();
        animations.ResetPlayer();
    }
    
}
