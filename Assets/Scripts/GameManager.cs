using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Main main;
    public Pioche pioche;

    public GameObject[] tuiles = new GameObject[3];

    private void Start()
    {
        main = FindObjectOfType<Main>();
        pioche = FindObjectOfType<Pioche>();
    }

    public GameObject GetTuile(int reference)
    {
        return tuiles[reference];
    }
}
