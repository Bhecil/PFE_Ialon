using UnityEngine;

[CreateAssetMenu(fileName = "Tuile")]
public class Tuile : ScriptableObject
{
    [field:SerializeField] public string Name { get; private set; } = "DefaultTuileName";
    [field:SerializeField] public int Valeur { get; private set; } = 0;
    [field: SerializeField] public int DropRate { get; private set; } = 0;
    [field: SerializeField] public GameObject Prefab { get; private set; }

}
