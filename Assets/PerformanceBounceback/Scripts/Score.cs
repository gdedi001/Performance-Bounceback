using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
    [SerializeField]
    private Text text; 


	// Update is called once per frame
	void Update () {
        text.text = "Score: " + gameManager.score.ToString();		
	}
}
