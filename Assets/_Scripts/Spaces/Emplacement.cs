using System.Collections.Generic;
using UnityEngine;

public class Emplacement : MonoBehaviour
{
    [field: SerializeField] public string Type { get; private set; } = "Default Emplacement Name";

    //la liste des vosins de cet emplacement
    public List<Emplacement> ListeOfVoisins { get; private set; } = new List<Emplacement>();
    //la tuile à cet emplacement
    public Tuile Tuile { get; private set; } = null;

    //le renderer de cet emplacement
    private Renderer _renderer;
    //le material par défaut de cet emplacement
    private Material _defaultMaterial;
    //le GameManager
    private GameManager _gameManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Emplacement voisin))
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
        _renderer.material = _gameManager._HoverMaterial;
    }

    private void OnMouseExit()
    {
        _renderer.material = _defaultMaterial;
    }

    private void OnMouseDown()
    {
        if (Tuile == null)
        {
            _gameManager.PoserUneTuile(this);
        }
    }

    public void SpawnTuile(Tuile tuile)
    {
        Instantiate (tuile, transform.position, transform.rotation);
        Tuile = tuile;
        Tuile.Niveau = 1;
        if (Type == "Foret")
        {
            Type = "Plaine";
            gameObject.SetActive(false);
            //gameObject.transform.GetChild(0).gameObject.SetActive(false);
            //_defaultMaterial = Tuile.GetComponent<Renderer>().sharedMaterial;
        }
    }

    public int CalculateScore()
    {
        int Score = 0;

        switch (Tuile.Nom)
        {
            case "Agriculteur":
                Score = 0 + Tuile.Niveau - 1;
                break;
            case "Bucheron":
                var nombreDeForetsVoisines = 0;
                foreach (Emplacement voisin in ListeOfVoisins)
                {
                    if (voisin.Type == "Foret")
                    {
                        nombreDeForetsVoisines++;
                    }
                }
                Score = nombreDeForetsVoisines * 3 + Tuile.Niveau - 1;
                break;
            case "Habitant":
                if (_gameManager.ScoreManager.Bonheur >= 0)
                {
                    Score = 3 + Tuile.Niveau - 1;
                }
                else
                {
                    Score = 1 + Tuile.Niveau - 1;
                }
                break;

        }

        return Score;
    }
}
