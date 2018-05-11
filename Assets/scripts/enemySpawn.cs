using UnityEngine;
using System.Collections;

public class enemySpawn : MonoBehaviour {
	public GameObject[] enemy;
	float timer;
    int i = 0;
	public float delayTime = 1f;
	Vector3 enemyPos;
	// Use this for initialization
	void Start () {
		timer = delayTime;
	}

	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer <= 0) {
            i = Random.Range(0, 3);
			enemyPos = new Vector3 (transform.transform.position.x, Random.Range (-4.3f, 4.3f), transform.position.z);
			Instantiate (enemy[i], enemyPos, transform.rotation);
			timer = delayTime;
		}
	}
}
