using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Emplacement")]
public class EmplacementData : ScriptableObject
{
    //Le type d'emplacement
    public string type = "DefaultEmplacementType";
    //le prefab de l'emplacement
    public GameObject Prefab;
    //les emplacements voisins de l'emplacement
    public List<EmplacementData> Voisins = new List<EmplacementData>();
    //la tuile à cet emplacement
    public Tuile Tuile = null;

}
