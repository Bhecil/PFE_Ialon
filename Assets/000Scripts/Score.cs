using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int ScoreTotal = 0;

    public List<Emplacement> ListeDesEmplacementsOccupes = new List<Emplacement>();

    private void Start()
    {
        gameObject.GetComponent<Text>().text = ScoreTotal.ToString();
    }

    public void UpdateScore()
    {
        ScoreTotal = 0;
        foreach (Emplacement emplacement in ListeDesEmplacementsOccupes)
        {
            ScoreTotal += emplacement.Score;
        }
        gameObject.GetComponent<Text>().text = ScoreTotal.ToString();
    }
}
