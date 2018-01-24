using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	public GameObject pickupPrefab;
	
	void Start () {
		var pu = Instantiate(pickupPrefab);
		pu.name = "Pickup(1)";
	}
}
