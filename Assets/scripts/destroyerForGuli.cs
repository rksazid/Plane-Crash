using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class destroyerForGuli : MonoBehaviour {


	// Use this for initialization
	void Start () {
  
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "ENEMY" || col.gameObject.tag == "GULI") {
            Destroy (col.gameObject);
		}
	}
}
