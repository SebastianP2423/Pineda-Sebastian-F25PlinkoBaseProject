using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public ScoreKeeper scoreKeeper;
    public int points = 1;
    public int multiplier = 1;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (!collider.CompareTag("Disc")) return;
        int finalScore = points * multiplier;
        scoreKeeper.AddScore(finalScore);
        Destroy(collider.gameObject);
    }
}
