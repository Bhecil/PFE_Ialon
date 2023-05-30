using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject selectedTuile = null;
    public GameObject[] heldTuiles = new GameObject[2];

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
        selectedTuile = heldTuiles[index];
    }
}
