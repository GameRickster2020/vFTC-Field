﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueGoal : MonoBehaviour
{
    private ScoreKeeper scoreKeeper;
    public int pointsPerGoal = 0;
    public string tagOfGameObject = "Ring";

    public string goalType = "";

    private GameTimer gameTimer;

    void Awake()
    {
        scoreKeeper = GameObject.Find("ScoreKeeper").GetComponent<ScoreKeeper>();
        gameTimer = GameObject.Find("ScoreKeeper").GetComponent<GameTimer>();
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == tagOfGameObject)
        {
            if (goalType == "low")
            {
                pointsPerGoal = 2;
                if (gameTimer.getGameType() == "auto")
                    pointsPerGoal = 3;
            }
            if (goalType == "mid")
            {
                pointsPerGoal = 4;
                if (gameTimer.getGameType() == "auto")
                    pointsPerGoal = 6;
            }
            if (goalType == "high")
            {
                pointsPerGoal = 6;
                if (gameTimer.getGameType() == "auto")
                    pointsPerGoal = 12;
            }
            if (goalType == "power")
            {
                pointsPerGoal = 0;
                if (gameTimer.getGameType() == "auto" || gameTimer.getGameType() == "end" || gameTimer.getGameType() == "freeplay")
                    pointsPerGoal = 15;
            }

            scoreKeeper.addScoreBlue(pointsPerGoal);
            Destroy(collision.gameObject.transform.parent.gameObject);
        }
    }
}
