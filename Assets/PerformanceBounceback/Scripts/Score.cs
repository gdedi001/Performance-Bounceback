using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
    private int oldScore = 0;
    [SerializeField]
    private Text text;


	// Update is called once per frame
	void Update () {
        if (gameManager.score != oldScore) {
            oldScore = gameManager.score;
            ChangeScore();
        }
	}

    private void ChangeScore() {
        text.text = "Score: " + gameManager.score.ToString();
    }
}
