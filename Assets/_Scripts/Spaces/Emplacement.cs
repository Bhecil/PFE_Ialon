using UnityEngine;

public class Emplacement : MonoBehaviour
{
    private GameManager _gameManager;

    public bool IsEmpty { get; private set; } = true;

    private Renderer _renderer;

    [SerializeField]
    private Material _highlightMaterial;
    private Material _defaultMaterial;

    private void Start()
    {
        _gameManager = FindAnyObjectByType<GameManager>();
        if (TryGetComponent(out Renderer renderer))
        {
            _renderer = renderer;
            _defaultMaterial = _renderer.material;
        }
    }

    private void OnMouseEnter()
    {
        if (IsEmpty)
        {
            _renderer.material = _highlightMaterial;
        }
    }

    private void OnMouseExit()
    {
        _renderer.material = _defaultMaterial;
    }

    private void OnMouseDown()
    {
        if (IsEmpty)
        {
            _gameManager.PoserUneTuile(this);
        }
    }

    public void SpawnTuile(Tuile tuile)
    {
        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y + 1.2f, transform.position.z);
        Instantiate (tuile.Prefab, spawnPosition, transform.rotation);
        IsEmpty = false;
    }
}
