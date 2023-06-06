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
        int indexTuile = Random.Range(0,100) ;

        Tuile tuile = null;

        if (indexTuile < 8)
        {
            tuile = Erudits[0];
        }
        else if (indexTuile < 20)
        {
            tuile = Nobles[0];
        }
        else if (indexTuile < 42)
        {
        tuile = Producteurs[0];
        }
        else if (indexTuile < 55)
        {
        tuile = Producteurs[1];
        }
        else if (indexTuile < 68)
        {
        tuile = Producteurs[2];
        }
        else if (indexTuile < 81)
        {
        tuile = Producteurs[3];
        }
        else if (indexTuile < 94)
        {
        tuile = Producteurs[4];
        }
        else if (indexTuile < 100)
        {
        tuile = Producteurs[5];
        }   
        return tuile;
    }
}
