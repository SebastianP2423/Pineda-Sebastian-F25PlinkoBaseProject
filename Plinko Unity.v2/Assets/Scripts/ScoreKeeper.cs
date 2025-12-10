using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public TMP_Text scoreDisplay;
    public int score = 0;

    public void Start()
    {
        UpdateScoreDisplay();
    }

    public void AddScore(int points) 
    {
        score += points;
        UpdateScoreDisplay();
    }

    public void UpdateScoreDisplay() 
    {
        scoreDisplay.text = $"Score: {score}";
    }
}
