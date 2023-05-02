using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] Text ScoreText;
    [SerializeField] int score;
    public GameObject gameOverPanel;

    public void SetScore(int value)
    {
        score += value;
        ScoreText.text = "Score: "+ score.ToString();
    }
    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
