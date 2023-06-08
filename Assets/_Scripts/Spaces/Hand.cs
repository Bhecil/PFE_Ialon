using UnityEngine;

public class Hand : MonoBehaviour
{
    private GameManager _gameManager;

    public Doigt[] Doigts { get; private set; } = new Doigt[3];

    [field: SerializeField] public int NombreDeDoigt { get; private set; } = 3;

    private Doigt SelectedDoigt;

    private int NombreDeDoigtsVides = 0;

    private void Start()
    {
        _gameManager = FindAnyObjectByType<GameManager>();
        for (int index = 0; index < NombreDeDoigt; index++)
        {
            Doigts[index] = gameObject.transform.GetChild(index).gameObject.GetComponent<Doigt>();
        }
    }

    public void Fill()
    {
       foreach (Doigt doigt in Doigts)
       {
            doigt.ObtainTuile(_gameManager.Pioche.RandomTuile());
       }
        NombreDeDoigtsVides = 0;
    }

    public void SelectDoigt(Doigt doigt)
    {
        SelectedDoigt = doigt;
        _gameManager.ChoisirUneTuile(doigt.Tuile);
    }

    public void DeselectDoigt()
    {
        SelectedDoigt = null;
    }

    public void ClearDoigt()
    {
        SelectedDoigt.DropTuile();
        SelectedDoigt = null;
        NombreDeDoigtsVides++;

        if (NombreDeDoigtsVides == NombreDeDoigt)
        {
            Fill();
        }
    }
}
