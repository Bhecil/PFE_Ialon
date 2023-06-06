using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Hand Hand { get; private set; }
    public Pioche Pioche { get; private set; }

    public ScoreManager ScoreManager { get; private set; }

    public Tuile SelectedTuile { get; private set; }

    [field:SerializeField] private List<Tuile> ListOfTuiles = new List<Tuile>();

    private void Start()
    {
        Hand = FindAnyObjectByType<Hand>();
        Pioche = FindAnyObjectByType<Pioche>();
        //ScoreManager = FindAnyObjectByType<ScoreManager>();
    }

    public void Piocher(Pioche pioche)
    {
        Hand.Fill(pioche);
    }

    public void ChoisirUneTuile(Tuile tuile)
    {
        SelectedTuile = tuile;
    }

    public void PoserUneTuile(Emplacement emplacement)
    {
        if (SelectedTuile != null)
        {
            //Poser la tuile
            emplacement.SpawnTuile(SelectedTuile);
            ListOfTuiles.Add(SelectedTuile);
            Hand.ClearDoigt();
            SelectedTuile = null;

            //mettre à jour le score
            ScoreManager.UpdateScore(ListOfTuiles);
        }
    }
}