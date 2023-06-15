using UnityEngine;

public class Tuile : MonoBehaviour
{
    //le nom de la tuile
    [field:SerializeField] public string Nom { get; private set; } = "DefaultTuileName";
    //la valeur de la tuile
    public int Valeur { get; set; } = 0;
    //le niveau de la tuile
    [field:SerializeField] public int NiveauUpgrade { get; set; } = 1;
    //le niveau de fusion de la tuile
    [field: SerializeField] public int NiveauFusion { get; set; } = 0;
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
