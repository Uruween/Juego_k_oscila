using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] int currentScore;
    public void AddScore (int score) 
    {
        currentScore += score;
    }
    public void RemoveScore(int score) 
    {
        currentScore -= score;
        if (currentScore < 0)
        {
            currentScore = 0;
        }
    }
}
