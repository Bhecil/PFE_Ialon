using UnityEngine;

public class Pioche : MonoBehaviour
{
    private GameManager _gameManager;

    [SerializeField] private Tuile[] Tuiles = new Tuile[3];

    private void Start()
    {
        _gameManager = FindAnyObjectByType<GameManager>();
    }

    public Tuile RandomTuile()
    {
        int indexTuile = Random.Range(0,100) ;

        Tuile tuile = null;

        if (indexTuile < 50)
        {
            tuile = Tuiles[0];
        }
        else if (indexTuile < 75)
        {
            tuile = Tuiles[1];
        }
        else if (indexTuile < 100)
        {
            tuile = Tuiles[2];
        }
        
        return tuile;
    }
}
