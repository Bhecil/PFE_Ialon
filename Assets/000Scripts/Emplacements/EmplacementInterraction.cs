using UnityEngine;

public class EmplacementInterraction : MonoBehaviour
{
    //Les données globales de la partie
    public HandData HandData;
    //Les données de cet emplacement
    public EmplacementData Emplacement;

    private void OnMouseDown()
    {
        Debug.Log(HandData.SelectedTuile.name);
        if (HandData.SelectedTuile != null)
        {
            HandData.SelectedTuile.TryGetComponent(out Tuile tuile);
            if (Emplacement.Tuile == null)
            {
                PlaceTuile(tuile);
                HandData.SelectedTuile = null;
            }
            else if (Emplacement.Tuile.Nom == tuile.TuileData.Nom)
            {
                UpgradeTuile();
                HandData.SelectedTuile = null;
            }
        }
    }

    private void PlaceTuile(Tuile tuile)
    {
        Emplacement.Tuile = tuile.TuileData;
        tuile.transform.position = transform.position + new Vector3(0, 1, 0);
        tuile.transform.rotation = transform.rotation;
    }

    private void UpgradeTuile()
    {
        Debug.Log("Upgrade");
    }
}
