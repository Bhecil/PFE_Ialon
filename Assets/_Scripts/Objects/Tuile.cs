using UnityEngine;
using UnityEngine.UI;

public class Tuile : MonoBehaviour
{
    [field: SerializeField] public string Nom { get; private set; } = "Default Tuile Name";
    [field: SerializeField] public Sprite Image { get; private set; }
    [field: SerializeField] public Sprite HoverImage { get; private set; }
    [field: SerializeField] public GameObject[] Niveaux { get; private set; } = new GameObject[3];
    [field: SerializeField] public Material HoverMaterial { get; private set; }

    public int Score { get; private set; } = 0;
    public Tuile[] _neighboors { get; private set; } = new Tuile[3];
    public int Niveau { get; private set; } = 1;
    public int Valeur { get; private set; } = 0;

    private GameManager _gameManager;
    private Renderer _renderer;
    private Material _defaultMaterial;

    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _renderer = GetComponent<Renderer>();
        _defaultMaterial = _renderer.material;
    }

    private void OnMouseEnter()
    {
        _renderer.material = HoverMaterial;
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

    public void Upgrade()
    {
        Niveaux[Niveau].SetActive(true);
        Niveau++;
    }
}
