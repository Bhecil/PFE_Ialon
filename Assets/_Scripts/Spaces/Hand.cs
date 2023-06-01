using UnityEngine;

public class Hand : MonoBehaviour
{
    private GameManager _gameManager;

    [field:SerializeField]
    public Doigt[] Doigts { get; private set; }

    private Doigt SelectedDoigt;

    private void Start()
    {
        _gameManager = FindAnyObjectByType<GameManager>();
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
