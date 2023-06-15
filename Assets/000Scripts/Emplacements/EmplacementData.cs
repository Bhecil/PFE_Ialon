using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Emplacement", menuName = "Emplacement")]
public class EmplacementData : ScriptableObject
{
    //Le type d'emplacement
    [field:SerializeField] public string Type { get; private set; } = "DefaultEmplacementType";
    //le prefab de l'emplacement
    [field:SerializeField] public GameObject Prefab { get; private set; }
    //les emplacements voisins de l'emplacement
    public List<EmplacementData> Voisins { get; set; } = new List<EmplacementData>();
    //la tuile à cet emplacement
    public TuileData Tuile { get; set; } = null;

}
