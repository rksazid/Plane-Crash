using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiManager : MonoBehaviour {
    public Text scoreText;
    public Button[] buttons;
    int score ;
    float timer ;
    float delay = 1f;
    bool gameOver = false;



	// Use this for initialization
	void Start () {
        timer = delay;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer <= 0 && !gameOver)
        {
            timer = delay;
            scoreText.text = "Time : " + score + " s";
            score++;
        }
        timer -= Time.deltaTime;
        if (gameOver)
        {
            foreach (Button button in buttons)
            {
                button.gameObject.SetActive(true);
            }
        }
	}

    public void gameOverActivated(){
        gameOver = true;
    }


	public void Pause(){
		if (Time.timeScale == 0) {
			Time.timeScale = 1;
		} else if (Time.timeScale == 1) {
			Time.timeScale = 0;
		}
	}


    public void Replay()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }

    public void Menu()
    {
        SceneManager.LoadScene("menu", LoadSceneMode.Single);
    }

    public void Play()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }
}
