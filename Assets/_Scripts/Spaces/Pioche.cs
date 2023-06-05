using UnityEngine;

public class Pioche : MonoBehaviour
{
    private GameManager _gameManager;

    [SerializeField]
    private Tuile[] Producteurs = new Tuile[0];

    [SerializeField]
    private Tuile[] Nobles = new Tuile[0];

    [SerializeField]
    private Tuile[] Erudits = new Tuile[0];

    private void Start()
    {
        _gameManager = FindAnyObjectByType<GameManager>();
    }

    public void OnClick()
    {
        _gameManager.Piocher(this);
    }

    public Tuile RandomTuile()
    {
        int tuileClass = Random.Range(0,25) ;

        Tuile[] tuiles = new Tuile[0];

        if (tuileClass < 2)
        {
            tuiles = Erudits;
        }
        else if (tuileClass >= 2 && tuileClass < 5)
        {
            tuiles = Nobles;
        }
        else if (tuileClass >= 5)
        {
            tuiles = Producteurs;
        }

        return tuiles[Random.Range(0, tuiles.Length)];
    }
}
