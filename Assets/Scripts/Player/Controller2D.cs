using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameOff2018
{
	namespace Player
	{
		public class Controller2D : MonoBehaviour
		{
			[SerializeField] private float walkSpeed;
			[SerializeField] private float runSpeed;

			private Rigidbody2D rigidbody2D;
			private SpriteRenderer spriteRenderer;

			void Start()
			{
				rigidbody2D = GetComponent<Rigidbody2D>();
				spriteRenderer = GetComponent<SpriteRenderer>();
			}
			
			void Update()
			{
				HorizontalMovement();
			}

			private void HorizontalMovement()
			{
				float speed = (Input.GetButton("Fire3")) ? runSpeed : walkSpeed;
				float input = Input.GetAxis("Horizontal");
				rigidbody2D.velocity = new Vector2(input * speed, rigidbody2D.velocity.y);
				if (input > 0) spriteRenderer.flipX = false;
				if (input < 0) spriteRenderer.flipX = true;
			}
		}
	}
}
