using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score;

    public Text txtScore;
    
    public void upScore() {
        this.score++;
        this.txtScore.text = "Score: " + this.score.ToString();
    }
}
