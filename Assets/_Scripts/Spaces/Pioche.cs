using UnityEngine;

public class Pioche : MonoBehaviour
{
    private GameManager _gameManager;

    [SerializeField]
    private Tuile[] Producteurs = new Tuile[1];

    [SerializeField]
    private Tuile[] Nobles = new Tuile[1];

    [SerializeField]
    private Tuile[] Erudits = new Tuile[1];

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
        int tuileClass = Random.Range(0,8) ;

        Tuile[] tuiles = new Tuile[0];

        switch (tuileClass)
        {
            case 0 :
                tuiles = Erudits;
                break;
            case 1 :
                tuiles = Nobles;
                break;
            case >1 :
                tuiles = Producteurs;
                break;
        }
        return tuiles[Random.Range(0, tuiles.Length)];
    }
}
