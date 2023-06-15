using UnityEngine;

[CreateAssetMenu(fileName = "Tuile")]
public class TuileData : ScriptableObject
{
    //Le nom de la tuile
    public string Nom = "DefaultTuileName";
    //La valeur de la tuile
    public int Valeur = 0;
    //La probabilité de piocher cette tuile ( sur 100)
    public int DropRate = 0;
    //Le prefab de la tuile
    public GameObject TuilePrefab;

}
