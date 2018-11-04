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
			
			void FixedUpdate()
			{
				ForwardMovement();
				Rotation();
			}

			private void ForwardMovement()
			{
				float input = Input.GetAxis("Vertical");
				float speed = (Input.GetButton("Fire3")) ? runSpeed : walkSpeed;
				rBody.AddRelativeForce(Vector3.forward * input * speed, ForceMode.Force);
			}

			private void Rotation()
			{
				float input = Input.GetAxis("Horizontal");
				rBody.AddRelativeTorque(Vector3.up * rotationSpeed * input);
			}
		}
	}
}