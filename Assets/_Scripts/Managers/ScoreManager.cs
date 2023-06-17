using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int Score { get; private set; } = 0;
    [field:SerializeField] public int Bonheur { get; private set; } = 0;
    
    private Text _scoreText;

    private void Start()
    {
        _scoreText = GetComponentInChildren<Text>();
        _scoreText.text = Score.ToString();
    }

    public void UpdateScore(List<Emplacement> listOfEmplacements)
    {
        //calcul du bonheur
        Bonheur = 0;
        foreach (Emplacement emplacement in listOfEmplacements)
        {
            Bonheur += emplacement.Tuile.Bonheur;
        }
        
        //calcul du score
        Score = 0;
        foreach (Emplacement emplacement in listOfEmplacements)
        {
            Score += emplacement.CalculateScore();
            //Debug.Log(emplacement.Tuile.Nom + " (" + emplacement.Tuile.Niveau + "): " + Score);
        }
        _scoreText.text = Score.ToString();
    }
}
