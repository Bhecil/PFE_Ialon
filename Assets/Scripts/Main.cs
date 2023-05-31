using UnityEngine;

public class Main : MonoBehaviour
{
    private GameManager gameManager;

    public GameObject selectedTuile = null;
    private Pioche pioche;

    public Doigt[] doigts = new Doigt[5];

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        pioche = gameManager.pioche;
    }

    public bool PlaceTuileAt(Transform transform)
    {
        bool success = false;
        if (selectedTuile != null)
        {
            Instantiate(selectedTuile, new Vector3(transform.position.x, transform.position.y + 1.1f, transform.position.z), transform.rotation);
            success = true;
        }
        return success;
    }

    public void SelectTuile(int index)
    {
        if (doigts[index].hasTuile == true)
        {
            selectedTuile = gameManager.tuiles[doigts[index].GetTuileID()];
        }
    }

    public void Refill()
    {
        foreach (var doigt in doigts)
        {
            if (doigt.hasTuile == false)
            {
                doigt.SetTuile(pioche.PickNewTuile());
            }
        }
    }
}
s