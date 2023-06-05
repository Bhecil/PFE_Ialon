using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [field: SerializeField] public int Score { get; private set; } = 0;
    private Text _scoreText;

    private void Start()
    {
        _scoreText = GetComponentInChildren<Text>();
    }

    public void UpdateScore(List<Tuile> listOfTuiles)
    {
        int score = 0;
        foreach (Tuile tuile in listOfTuiles)
        {
            score += tuile.CalculateScore();
        }
        Score = score;
        _scoreText.text = Score.ToString();
    }
}
