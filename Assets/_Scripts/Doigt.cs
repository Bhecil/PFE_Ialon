using UnityEngine;

public class Doigt : MonoBehaviour
{
    public Tuile _tuile;

    private void OnMouseDown()
    {
        Debug.Log("clicked");
    }

    public void ObtainTuile(Tuile tuile)
    {
        _tuile = tuile;
        Instantiate(_tuile.Prefab, transform.position + new Vector3(0, 1, 0), transform.rotation);
    }
}
