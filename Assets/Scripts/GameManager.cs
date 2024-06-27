using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int score;

    public static GameManager Inst;

    public Text scoreText;


    public void IncreScore()
    {
        score++;
        scoreText.text = "SCORE: " + score;
    }



    private void Awake()
    {
        Inst = this;
    }


    void Start()
    {
        



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
