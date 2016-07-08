using UnityEngine;
using System.Collections;

public class bombController : MonoBehaviour {

	public GameObject player;
	public float delay = 3.0F;
	public SphereCollider sphere;
	void OnTriggerExit(Collider obj) {
		if(obj.tag == player.tag) {
			sphere = gameObject.GetComponent<SphereCollider>();
			sphere.isTrigger = false;
		}

	}
	// Use this for initialization
	void Start () {
		StartCoroutine("Explode");
		
	}

	IEnumerator Explode() {
		yield return new WaitForSeconds (delay);
		player.GetComponent<playerController> ().placedBombs--;
		Destroy (gameObject);

	}
	// Update is called once per frame
	void Update () {
		
	
	}
}
