using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Hand Hand { get; private set; }
    public Pioche Pioche { get; private set; }

    public ScoreManager ScoreManager { get; private set; }

    [field: SerializeField] public Material _HoverMaterial { get; private set; }
    public Tuile SelectedTuile { get; private set; }

    private List<Tuile> ListOfTuiles = new List<Tuile>();

    private void Start()
    {
        Hand = FindAnyObjectByType<Hand>();
        Pioche = FindAnyObjectByType<Pioche>();
        Hand.Fill();
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
            Hand.ClearDoigt();
            SelectedTuile = null;

            //Mettre à jour le score
            //ListOfTuiles.Add(SelectedTuile);
            //ScoreManager.UpdateScore(ListOfTuiles);
        }
    }

    public void AmeliorerUneTuile(Tuile tuile)
    {
        if (SelectedTuile != null && SelectedTuile.CompareTag(tuile.tag))
        {
            tuile.Upgrade();
            SelectedTuile = null;
            Hand.ClearDoigt();
        }
    }
}
