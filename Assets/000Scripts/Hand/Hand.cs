using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Hand", menuName = "DataTable / Hand")]
public class Hand : ScriptableObject
{
    //Le nombre maximal de tuiles que la main peut contenir
    [field:SerializeField] public int NombreDeDoigt { get; private set; } = 3;
    //L'écart entre les deux doigts les plus opposés
    [field:SerializeField] public int Largeur { get; private set; } = 50;
    //Le prefab d'un doigt
    [field: SerializeField] public GameObject DoigtPrefab { get; private set; }
    //La liste des doigts de la main
    [field: SerializeField] public List<GameObject> ListeDeDoigts { get; set; } = new List<GameObject>();

    /*private void Refill()
    {
        TuileData tuile;
        foreach (GameObject doigt in ListDeDoigts)
        {
            tuile = Pioche.RandomTuile();
            doigt.ObtainTuile(tuile);
        }
    }*/
}
