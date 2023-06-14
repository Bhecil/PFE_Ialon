using UnityEngine;

public class Doigt : MonoBehaviour
{
    //le GameManager
    [field:SerializeField] public GameData GameData { get; private set; }
    //La tuile dans ce doigt
    public Tuile Tuile { get; private set; }

    private void OnMouseDown()
    {
        GameData.SelectedTuile = Tuile;
    }

    public void ObtainTuile(Tuile tuile)
    {
        Tuile = tuile;
        Instantiate(Tuile.TuilePrefab, transform.position + new Vector3(0, 0.2f, 0), transform.rotation);
    }
}
