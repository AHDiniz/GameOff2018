using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameOff2018
{
	namespace Player
	{
		public class Controller3D : MonoBehaviour
		{
			[SerializeField] private float walkSpeed;
			[SerializeField] private float runSpeed;
			[SerializeField] private float rotationSpeed;

			private Rigidbody rBody;

			void Start()
			{
				rBody = GetComponent<Rigidbody>();
			}
			
			void Update()
			{
				ForwardMovement();
				Rotation();
			}

			private void ForwardMovement()
			{
				float speed = (Input.GetButton("Fire3")) ? runSpeed : walkSpeed;
				float input = Input.GetAxis("Vertical");
				rBody.AddForce(new Vector3(0, 0, input * speed));
			}

			private void Rotation()
			{
				float input = Input.GetAxis("Horizontal");
				rBody.AddTorque(new Vector3(0, input * rotationSpeed, 0));
			}
		}
	}
}