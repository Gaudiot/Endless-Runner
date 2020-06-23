using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour{

    public int score;

    public Text ScoreText;

    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Obstacle")){
            score++;
            Debug.Log(score);
        }
    }

    // Update is called once per frame
    void Update(){
        ScoreText.text = score.ToString();
    }
}
