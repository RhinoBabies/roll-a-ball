using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb; //where the GameObject will store its Rigidbody component's id
	public float speed;

	void Start()
	{
		rb = GetComponent<Rigidbody> (); //grabs reference to this GameObject's Rigidbody component
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed); //when pushing correct keys, adds physics forces to the Rigidbody component for movement
	}
}
