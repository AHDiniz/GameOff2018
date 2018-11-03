using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    [Tooltip("The player's speed while walking")]
	[SerializeField] private float walkSpeed;

    private Rigidbody2D rBody2D;	
    private SpriteRenderer spriteRenderer;

	private void Start()
	{
		rBody2D = GetComponent<Rigidbody2D>();
		spriteRenderer = GetComponent<SpriteRenderer>();
		
	}

	private void Update()
	{
		HorizontalMovement();
	}

	private void HorizontalMovement()
	{
		float input = Input.GetAxis("Horizontal");
		rBody2D.velocity = new Vector2(input * walkSpeed, rBody2D.velocity.y);
		if (input > 0) spriteRenderer.flipX = false;
		if (input < 0) spriteRenderer.flipX = true;
	}
}
