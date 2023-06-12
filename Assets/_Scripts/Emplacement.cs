using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Emplacement")]
public class Emplacement : ScriptableObject
{
    public string type = "DefaultEmplacementType";

    public List<Emplacement> Voisins { get; set; } = new List<Emplacement>();

    public GameObject EmplacementPrefab;
}
