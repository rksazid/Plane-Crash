using UnityEngine;
using System.Collections;

public class guliControll : MonoBehaviour {
	public float guliSpeed = 2.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (new Vector3(1,0,0)* guliSpeed*Time.deltaTime);
	}
}
