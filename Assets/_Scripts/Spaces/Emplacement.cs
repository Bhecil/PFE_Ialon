using System.Collections.Generic;
using UnityEngine;

public class Emplacement : MonoBehaviour
{
    private GameManager _gameManager;

    public bool IsEmpty { get; private set; } = true;

    private Renderer _renderer;

    private Material _defaultMaterial;

    //la liste des vosins de cet emplacement
    public List<Emplacement> ListeOfVoisins;

    private void OnTriggerEnter(Collider other)
    {
        if (TryGetComponent(out Emplacement voisin))
        {
            ListeOfVoisins.Add(voisin);
        }
    }

    private void Start()
    {
        _gameManager = FindAnyObjectByType<GameManager>();
        _renderer = GetComponent<Renderer>();
        _defaultMaterial = _renderer.material;
    }

    private void OnMouseEnter()
    {
        if (IsEmpty)
        {
            _renderer.material = _gameManager._HoverMaterial;
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
        Instantiate (tuile, transform.position, transform.rotation);
        Destroy(gameObject);
        
        
        IsEmpty = false;

    }

    public int CalculateScore()
    {
        int Score = 0;

        return Score;
    }
}
