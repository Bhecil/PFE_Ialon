using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int Score { get; private set; } = 0;
    public int Bonheur { get; private set; } = 0;
    
    private Text _scoreText;

    private void Start()
    {
        _scoreText = GetComponentInChildren<Text>();
        _scoreText.text = Score.ToString();
    }

    public void UpdateScore(List<Emplacement> listOfEmplacements)
    {
        //calcul du bonheur
        foreach (Emplacement emplacement in listOfEmplacements)
        {
            emplacement.CalculateScore();
        }
        /*
        //calcul du score
        Score = 0;
        foreach (Tuile tuile in listOfTuiles)
        {
            Score += tuile.CalculateScore();
        }
        _scoreText.text = Score.ToString();*/
    }
}
