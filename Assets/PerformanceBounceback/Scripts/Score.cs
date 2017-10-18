using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    private int oldScore = 0;
    [SerializeField]
    private Text text;

    void Start() {
        text.text = "Score: " + GameManager.score.ToString();
    }

    // Update is called once per frame
    void Update () {      
         if (GameManager.score != oldScore) {
            oldScore = GameManager.score;
            ChangeScore();
        }
    }

    private void ChangeScore() {
        text.text = "Score: " + GameManager.score.ToString();
    }
}
