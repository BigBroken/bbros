using UnityEngine;
using System.Collections;

public class startup : MonoBehaviour {
	public float startX;
	public float endX;
	public float startY;
	public float endY;
	public GameObject block;
	// Use this for initialization
	void Start () {
		for (float i = startX; i < endX; i = i + 2.5F) {
			for (float j = startY; j < endY; j = j + 1.5F){
				Instantiate(block, new Vector3(i, 0.7F, j), Quaternion.identity);
			}	
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
