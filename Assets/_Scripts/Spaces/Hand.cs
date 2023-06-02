using UnityEngine;

public class Hand : MonoBehaviour
{
    private GameManager _gameManager;

    public Doigt[] Doigts { get; private set; } = new Doigt[5];

    private Doigt SelectedDoigt;

    private void Start()
    {
        _gameManager = FindAnyObjectByType<GameManager>();
        for (int index = 0; index < 5; index++)
        {
            Doigts[index] = gameObject.transform.GetChild(index).gameObject.GetComponent<Doigt>();
        }
    }

    public void Fill(Pioche pioche)
    {
        foreach (Doigt doigt in Doigts)
        {
            if(doigt.IsEmpty)
            {
                doigt.ObtainTuile(pioche.RandomTuile());
            }
        }
    }

    public void SelectDoigt(Doigt doigt)
    {
        SelectedDoigt = doigt;
        _gameManager.ChoisirUneTuile(doigt.Tuile);
    }

    public void ClearDoigt()
    {
        SelectedDoigt.DropTuile();
        SelectedDoigt = null;
    }
}
