using UnityEngine;
using System.Collections;

public class bombController : MonoBehaviour {

	public GameObject player;
	public float delay;
	public float blastRadius;
	public SphereCollider sphere;
	void OnTriggerExit(Collider obj) {
		if(obj.tag == player.tag) {
			sphere = gameObject.GetComponent<SphereCollider>();
			sphere.isTrigger = false;
		}

	}
	// Use this for initialization
	void Start () {
		delay = 3.0F;
		blastRadius = 5.0F;
		StartCoroutine(Explode(delay, blastRadius));
	}

	IEnumerator Explode(float delay, float blastRadius) {
		yield return new WaitForSeconds (delay);
		player.GetComponent<playerController> ().placedBombs--;
		sphere.enabled = false;
		Ray[] directions = new Ray[4];
		directions[0] = new Ray(transform.position, Vector3.right);
		directions[1] = new Ray(transform.position, Vector3.left);
		directions[2] = new Ray(transform.position, Vector3.forward);
		directions[3] = new Ray(transform.position, Vector3.back);
		RaycastHit hit;
		foreach(Ray dir in directions){
			if(Physics.Raycast(dir, out hit, blastRadius)) {
				if(hit.transform.gameObject.layer == 8) {
//					hit.transform.GetComponent<Scriptab
					Destroy (hit.transform.gameObject);
				}
			}
		Destroy (gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}

}
