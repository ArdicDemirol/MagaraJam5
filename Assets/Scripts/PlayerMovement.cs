using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Rigidbody2D rb;
    public Animator animator;
        
        
    
    
    public float moveSpeed = 5f;
    Vector2 movement;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }

    void Update()
    {
        movement.x=  Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (movement.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else
        {
            spriteRenderer.flipX = false;
        }

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        //transform.rotation = Quaternion.Euler(0, 90*movement.x, 0);
        
       

    }
}