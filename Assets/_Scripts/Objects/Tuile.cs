using UnityEngine;
using UnityEngine.UI;

public class Tuile : MonoBehaviour
{
    [field: SerializeField] public string Nom { get; private set; } = "Default Tuile Name";

    [field: SerializeField] public int Niveau { get; private set; } = 1;

    [field: SerializeField] public int Valeur { get; private set; } = 0;

    [field: SerializeField] public Sprite Image { get; private set; }
    [field: SerializeField] public Sprite HoverImage { get; private set; }

    public int Score { get; private set; } = 0;

    public Tuile[] _neighboors { get; private set; } = new Tuile[3];

    private GameObject[] Niveaux = new GameObject[3];
    private GameManager _gameManager;
    private Renderer _renderer;
    private Material _defaultMaterial;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _renderer = GetComponent<Renderer>();
        _defaultMaterial = _renderer.material;

        //get all lvl meshes
        for (int index = 0; index < Niveaux.Length; index++)
        {
            if (gameObject.transform.childCount == 3)
            {
                Niveaux[index] = gameObject.transform.GetChild(index).gameObject;
            }
            
        }
    }

    private void OnMouseEnter()
    {
        _renderer.material = _gameManager._HoverMaterial;
    }
    private void OnMouseExit()
    {
        _renderer.material = _defaultMaterial;
    }

    private void OnMouseDown()
    {
        if(Niveau < 3)
        {
            _gameManager.AmeliorerUneTuile(this);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        int indexOfFirstEmpty = 0;
        for (int index = 0; index < _neighboors.Length; index++ )
        {
            if (_neighboors[index] == null)
            {
                indexOfFirstEmpty = index; 
            }
        }
        _neighboors[indexOfFirstEmpty] = other.gameObject.GetComponent<Tuile>();
    }

    public int CalculateScore()
    {
        if (Nom == "Habitant")
        {
            if (_gameManager.ScoreManager.Bonheur >= 0)
            {
                Score = 1;
            }
            else
            {
                Score = 0;
            }
        }
        else if (Nom == "Bucheron")
        {

        }
        else if (Nom == "Agriculteur")
        {
        }
        return Score;
    }

    private int GetNeighboorsCount()
    {
        int count = 0;

        foreach (Tuile neighboor in _neighboors)
        {
            if (neighboor != null)
            {
                count++;
            }
        }

        return count;
    }

    public void Upgrade()
    {
        Niveau++;
        Niveaux[Niveau-1].SetActive(true);
    }
}
