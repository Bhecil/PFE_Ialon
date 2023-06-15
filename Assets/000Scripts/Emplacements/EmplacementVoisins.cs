using UnityEngine;

public class EmplacementVoisins : MonoBehaviour
{
    //Les données de cet emplacement
    public EmplacementData Emplacement;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out EmplacementVoisins emplacementVoisin))
        {
            Emplacement.Voisins.Add(emplacementVoisin.Emplacement);
        }
    }
}