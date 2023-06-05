using UnityEngine;

[CreateAssetMenu(fileName = "New Tuile", menuName = "Tuile")]
public class TuileStats : ScriptableObject
{
    [field: SerializeField] public string Name { get; private set; } = "defaultTuileName";

    [field: SerializeField] public int Valeur { get; private set; } = 0;

    [field: SerializeField] public Sprite Image { get; private set; } = null;
}