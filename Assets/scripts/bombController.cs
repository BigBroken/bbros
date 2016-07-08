using UnityEngine;
using System.Collections;

public class bombController : MonoBehaviour {

	public string player;

	void OnTriggerExit(Collider obj) {
		if(obj.tag == player) {
			
		}
	}
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}
}
