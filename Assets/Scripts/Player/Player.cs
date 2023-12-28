using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("config")]
    [SerializeField] private PlayerStats stats;

    public PlayerStats Stats => stats;
    
        
    
}
