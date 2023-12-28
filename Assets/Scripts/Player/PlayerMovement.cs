using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    [Header("config")]
    [SerializeField] private float speed;

    private PlayerAnimation playeranimations;
    private PlayerActions actions;
    private Player player;
    private Rigidbody2D rb2D;
    private Vector2 movedirection;

    private void Awake()
    {
        player = GetComponent<Player>();
        actions = new PlayerActions();
        rb2D = GetComponent<Rigidbody2D>();
        playeranimations = GetComponent<PlayerAnimation>();
    }

    private void Update()
    {
        Readmovement();
    }
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        if (player.Stats.Health <= 0) return;
        rb2D.MovePosition(rb2D.position + movedirection * (speed * Time.fixedDeltaTime));
    }
    private void Readmovement()
    {
        movedirection = actions.Movement.Move.ReadValue<Vector2>().normalized;
        
            if (movedirection == Vector2.zero)
            {
            playeranimations.SetMoveBoolTransition(false);
                return;
            }

        playeranimations.SetMoveBoolTransition(true);
        playeranimations.SetMoveAnimation(movedirection);
        }


    private void OnEnable()
    {
        actions.Enable();
    }
    private void OnDisable()
    {
        actions.Disable(); 
    }
    }