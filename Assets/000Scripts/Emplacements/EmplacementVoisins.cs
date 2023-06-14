using UnityEngine;

public class EmplacementVoisins : MonoBehaviour
{
    //Les données de cet emplacement
    public EmplacementData Emplacement;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.TryGetComponent(out EmplacementVoisins emplacementVoisin);
        if(emplacementVoisin != null)
        {
            Emplacement.Voisins.Add(emplacementVoisin.Emplacement);
        }
    }
}