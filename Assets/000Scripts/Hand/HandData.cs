using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HandData", menuName = "Data Table / Hand Data")]
public class HandData : ScriptableObject
{
    //Le nombre maximal de tuiles que la main peut contenir
    [field:SerializeField] public int NombreDeDoigts { get; private set; } = 3;
    //L'écart entre les deux doigts les plus opposés
    [field:SerializeField] public int Largeur { get; private set; } = 50;
    //Le prefab d'un doigt
    [field: SerializeField] public GameObject DoigtPrefab { get; private set; }

    //La liste des doigts de la main
    [field: SerializeField] public List<GameObject> ListOfDoigts { get; set; }

    //La tuile selectionnée
    public GameObject SelectedTuile { get; set; }
}
