using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Hand Hand { get; private set; }
    public Pioche Pioche { get; private set; }

    private Tuile SelectedTuile;

    private void Start()
    {
        Hand = FindAnyObjectByType<Hand>();
        Pioche = FindAnyObjectByType<Pioche>();
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
            emplacement.SpawnTuile(SelectedTuile);
            Hand.ClearDoigt();
            SelectedTuile = null;
        }
    }
}