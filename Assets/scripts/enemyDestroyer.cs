using UnityEngine;
using System.Collections;

public class enemyDestroyer : MonoBehaviour {

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		
		if (col.gameObject.tag == "GULI") {
			Destroy (col.gameObject);
			Destroy (gameObject);
		} else if (col.gameObject.tag == "ENEMY") {
			Destroy (col.gameObject);
		}
	}
}
