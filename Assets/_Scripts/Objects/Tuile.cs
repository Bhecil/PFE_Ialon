using UnityEngine;

public class Tuile : MonoBehaviour
{
    //le nom de la tuile
    [field: SerializeField] public string Nom { get; private set; } = "Default Tuile Name";
    //la probabilité de piocher cette tuile
    [field: SerializeField] public int Chance { get; private set; } = 0;
    //l'effet de cette tuile sur le bonheur
    [field: SerializeField] public int Bonheur { get; private set; } = 0;
    //l'image de cette tuile
    [field: SerializeField] public Sprite Image { get; private set; }
    //l'image de cette tuile quand elle est selectionée
    [field: SerializeField] public Sprite HoverImage { get; private set; }

    public int Niveau { get; set; }

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
        for (int index = 0; index < 3; index++)
        {
            Niveaux[index] = gameObject.transform.GetChild(index).gameObject;
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
        if (Niveau < 3)
        {
            _gameManager.AmeliorerUneTuile(this);
        }
    }

    public void Upgrade()
    {
        Niveaux[Niveau+1].SetActive(true);
        Niveau++;
    }
}
