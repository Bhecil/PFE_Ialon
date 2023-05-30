using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Main main;

    public GameObject[] tuiles = new GameObject[10];

    public GameObject getTuile(int reference)
    {
        return tuiles[reference];
    }
}
