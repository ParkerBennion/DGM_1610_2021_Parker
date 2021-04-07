using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public static int Score;
    public Text ScoreText;

    private void Awake()
    {
        Score = 0;
    }

    private void Update()
    {
        ScoreText.text = Score.ToString();
    }
}
