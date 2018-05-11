using UnityEngine;
using System.Collections;

public class guliSpawn : MonoBehaviour {
	public GameObject guli;
	float timer;
	public float delayTime = .5f;
  //  public audioManager am;

    void awake()
    {
      //  am.guliSound.Play();
    }

	// Use this for initialization
	void Start () {
		timer = delayTime;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer <= 0) {
			Instantiate (guli, transform.position, transform.rotation);
          //  am.guliSound.Play();
			timer = delayTime;
		}
	}
}
