using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour {
	//public GameObject pickupPrefab;
	
	private bool quitting = false;

	private GameObject player;

	private void OnApplicationQuit() {
		quitting = true;
	}

	private void OnDestroy() {
		Debug.Log(name + ".OnDestory()");
		
		// Create a new pickup. It won't be active so we don't need to worry about
		// colliding with it as soon as we create it.
		if (!quitting) {
			var newPickup = Instantiate(GameController.puPrefab);
			player = GameObject.Find("Player");
			var playerPosition = player.transform.position;
			newPickup.transform.position = playerPosition + new Vector3(1, 0, 1);
			newPickup.name = "Pickup(" + (++GameController.pickupNumber) + ")";
			newPickup.SetActive(true);
		}
	}
}
