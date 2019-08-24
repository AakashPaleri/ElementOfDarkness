using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public float speed=10.0f;
	public float speedH = 2.0f;
	public float jumpingforce = 20f;
	private float yaw = 0.0f;
	Rigidbody rb;
	private bool isjumping=true;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		}
	
	// Update is called once per frame
	void Update () {

		float moveh = Input.GetAxis ("Vertical") * speed;
		float movev = Input.GetAxis ("Horizontal") * speed;
		moveh *= Time.deltaTime;
		movev *= Time.deltaTime;
		yaw += speedH * Input.GetAxis ("Mouse X");
		transform.Translate (moveh,0, movev);

		if (!isjumping) {
			if (Input.GetKey (KeyCode.Space)) {
				rb.AddForce (0, jumpingforce, 0);
				isjumping = true;
			}
		}
	}
}
