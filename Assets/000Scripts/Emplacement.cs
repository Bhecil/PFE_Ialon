using System.Collections.Generic;
using UnityEngine;

public class Emplacement : MonoBehaviour
{
    //la liste des voisins de cet emplacement
    List<Emplacement> ListeDesVoisins = new List<Emplacement>();

    //la tuile à cet emplacement
    public Tuile Tuile;

    [field: SerializeField] private Hand _hand;

    private void OnCollisionEnter(Collision collision)
    {
        ListeDesVoisins.Add(collision.gameObject.GetComponent<Emplacement>());
    }

    private void OnMouseDown()
    {
        if (_hand.SelectedTuile != null)
        {
            if (Tuile == null)
            {
                _hand.SelectedTuile.gameObject.transform.position = transform.position + new Vector3(0, 1.2f ,0);
                _hand.SelectedTuile.gameObject.transform.rotation = transform.rotation;
                _hand.SelectedTuile.IsInHand = false;
                _hand.SelectedTuile = null;
            }
        }
    }
}
