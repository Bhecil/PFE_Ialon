using UnityEngine;

public class EmplacementInterraction : MonoBehaviour
{
    //Les données globales de la partie
    public GameData GameData;
    //Les données de cet emplacement
    public EmplacementData Emplacement;

    private void OnMouseDown()
    {
        if (GameData.SelectedTuile != null)
        {
            if (Emplacement.Tuile == null)
            {
                Instantiate(GameData.SelectedTuile.TuilePrefab, transform.position + new Vector3(0, 0.2f, 0), transform.rotation);
            }
            else if (Emplacement.Tuile.Type == GameData.SelectedTuile.Type)
            {
                Debug.Log("Upgrade");
            }
        }
    }
}
