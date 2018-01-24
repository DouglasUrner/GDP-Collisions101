using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupController : MonoBehaviour {
	
	private void OnDestroy() {
		Debug.Log(name + ".OnDestory()");
	}
}
