using UnityEngine;
using System.Collections;

public class planeControll : MonoBehaviour {
	public float planeSpeed;
    public uiManager ui;
	Vector3 position;

	// Use this for initialization
	void Start () {
		position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		position.y += Input.GetAxis ("Vertical")*planeSpeed*Time.deltaTime;
		position.y = Mathf.Clamp (position.y, -4.3f, 4.3f);
		position.x += Input.GetAxis ("Horizontal")*planeSpeed*Time.deltaTime;
		position.x = Mathf.Clamp (position.x, -6.8f, 4f);
		transform.position = position;
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "ENEMY")
        {
            ui.gameOverActivated();
            Destroy(gameObject);
        }
    }
}
