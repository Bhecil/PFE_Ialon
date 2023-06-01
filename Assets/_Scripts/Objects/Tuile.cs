using UnityEngine;

[CreateAssetMenu(fileName = "New Tuile", menuName = "Tuile")]
public class Tuile : ScriptableObject
{
    [field: SerializeField]
    public int Valeur { get; private set; } = 0;

    [field: SerializeField]
    public Sprite Image { get; private set; }

    [field: SerializeField]
    public GameObject Prefab { get; private set; }
}
