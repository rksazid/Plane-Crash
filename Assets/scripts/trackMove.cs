using UnityEngine;
using System.Collections;

public class trackMove : MonoBehaviour {
	public float trackSpeed;
	Vector2 offset;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		offset = new Vector2 (Time.time * trackSpeed, 0);
		GetComponent<Renderer> ().material.mainTextureOffset = offset;
	}
}
