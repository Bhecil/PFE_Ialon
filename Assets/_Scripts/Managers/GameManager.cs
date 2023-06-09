using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Hand Hand { get; private set; }
    public Pioche Pioche { get; private set; }

    public ScoreManager ScoreManager { get; private set; }

    [field: SerializeField] public Material _HoverMaterial { get; private set; }
    public Tuile SelectedTuile { get; private set; }

    [field: SerializeField] public List<Tuile> NF2Tuiles { get; private set; } = new List<Tuile>();

    private Dictionary<string, Tuile> TableDeFusion= new Dictionary<string, Tuile>();

    private void Start()
    {
        Hand = FindAnyObjectByType<Hand>();
        Pioche = FindAnyObjectByType<Pioche>();
        Hand.Fill();

        //generation de la table de fusion
        TableDeFusion.TryAdd("AgriculteurBucheron", NF2Tuiles[0]);  //Intendant
        TableDeFusion.TryAdd("AgriculteurHabitant", NF2Tuiles[1]);  //Meunier
        TableDeFusion.TryAdd("BucheronHabitant", NF2Tuiles[2]);     //Meunisier
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

            //Mettre � jour le score
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

    public void FusionnerDeuxTuiles(Doigt doigt)
    {
        //calcule de la cl�
        string name1 = SelectedTuile.tag;
        string name2 = doigt.Tuile.tag;
        string key = "";

        if (name1.CompareTo(name2) > 0)
        {
            key = name2 + name1;
        }
        else if (name1.CompareTo(name2) < 0)
        {
            key = name1 + name2;
        }

        //recherche de la cl� dans la table de fusion
        if (TableDeFusion.TryGetValue(key, out Tuile tuile))
        {
            doigt.ObtainTuile(tuile);
            SelectedTuile = null;
            Hand.ClearDoigt();
        }
    }
}
