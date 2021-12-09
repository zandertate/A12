using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed = 2;
	public Rigidbody rb;
	float horizontalInput;
	public float horizontalMultiplier = 2;

	private void FixedUpdate(){

	Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
	Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * 		horizontalMultiplier;
	rb.MovePosition(rb.position + forwardMove + horizontalMove);
	}
   	// Update is called once per frame
	void Update()

 	{
		horizontalInput = Input.GetAxis("Horizontal");        
    	}
}
