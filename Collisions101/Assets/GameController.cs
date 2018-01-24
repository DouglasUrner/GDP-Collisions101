using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject pickupPrefab;
	
	public static GameObject puPrefab;
	public static int pickupNumber = 1;		// The number of pickups we've created.
	
	void Start () {
		puPrefab = pickupPrefab;
		var pu = Instantiate(puPrefab);
		pu.name = "Pickup(1)";
	}
}
