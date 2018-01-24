using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float speed = 1f;

	private Rigidbody rb;

	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
		rb.AddForce(speed * Input.GetAxis("Horizontal"), 0, speed * Input.GetAxis("Vertical"));
	}

	private void OnCollisionEnter(Collision other) {
		Debug.Log("OnCollisionEnter(): " + name + " collided with " + other.gameObject.name);
		Destroy(other.gameObject);
	}

	private void OnTriggerEnter(Collider other) {
		Debug.Log("OnTriggerEnter(): " + name + " meets " + other.gameObject.name);
		Destroy(other.gameObject);
	}
}
