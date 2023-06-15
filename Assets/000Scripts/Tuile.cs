using UnityEngine;

public class Tuile : MonoBehaviour
{
    //le nom de la tuile
    [field:SerializeField] public string Nom { get; private set; } = "DefaultTuileName";
    //la valeur de la tuile
    [field:SerializeField] public int Valeur { get; set; } = 0;
    //le niveau de la tuile
    [field:SerializeField] public int Niveau { get; set; } = 1;
    //la probabilité de piocher cette tuile
    [field:SerializeField] public int Chance { get; private set; }

    //la main
    public Hand Hand { get; set; }

    public bool IsInHand { get; set; } = false;

    private void OnMouseDown()
    {
        if (IsInHand)
        {
            Hand.SelectedTuile = this;
        }
    }
}
