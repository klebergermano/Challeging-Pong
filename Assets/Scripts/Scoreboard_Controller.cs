using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoreboard_Controller : MonoBehaviour {

    public static Scoreboard_Controller instance;
    public Text PlayerOneScoreText;
    public Text PlayerTwoScoreText;

    int playerOneScore = 0;
    int playerTwoScore = 0;



    // Use this for initialization
    void Start () {

        instance = this;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GiveAPointPlayerOne() {

        playerOneScore += 1;
        PlayerOneScoreText.text = playerOneScore.ToString();
        if (playerOneScore >= 3) {
            SceneManager.LoadScene("Player1_Win");
        }
    }

    public void GiveAPointPlayerTwo()
    {
      
        playerTwoScore += 1;
        PlayerTwoScoreText.text = playerTwoScore.ToString();
        if (playerTwoScore >= 3)
        {
            SceneManager.LoadScene("Player2_Win");
        }
    }
}
