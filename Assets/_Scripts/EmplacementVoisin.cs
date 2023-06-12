using UnityEngine;

public class EmplacementVoisin : MonoBehaviour
{
    public Emplacement Emplacement;

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.TryGetComponent(out EmplacementVoisin emplacementVoisin);
        if(emplacementVoisin != null)
        {
            Emplacement.Voisins.Add(emplacementVoisin.Emplacement);
        }
    }
}