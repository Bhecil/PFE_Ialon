using UnityEngine;

public class Doigt : MonoBehaviour
{
    //La main
    public HandData HandData {get; set; }
    //La tuile dans ce doigt
    public TuileData TuileData { get; private set; }
    //Le gameObject de la tuile du doigt
    public GameObject Tuile { get; private set; }

    private void OnMouseDown()
    {
        if (TuileData != null)
        {
            HandData.SelectedTuile = Tuile;
        }
    }

    public void ObtainTuile(TuileData newTuile)
    {
        TuileData = newTuile;
        Tuile = Instantiate(TuileData.TuilePrefab, transform.position + new Vector3(0, 0.2f, 0), transform.rotation);
        if (Tuile.TryGetComponent(out Tuile tuile))
        {
            tuile.TuileData = TuileData;
        }
    }
}
