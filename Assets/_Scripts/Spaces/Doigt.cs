using UnityEngine;
using UnityEngine.UI;

public class Doigt : MonoBehaviour
{
    private GameManager _gameManager;

    public bool IsEmpty { get; private set; } = true;

    public Tuile Tuile { get; private set; } = null;

    public Hand _hand { get; private set; }

    private Text _text;
    private Image _image;
    
    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _hand = FindObjectOfType<Hand>();
        _image = GetComponent<Button>().image;
        DropTuile();
    }

    public void OnClick()
    {
        if (_gameManager.SelectedTuile == null)
        {
            _hand.SelectDoigt(this);
            _image.sprite = Tuile.HoverImage;
        }
        else
        {
            _gameManager.FusionnerDeuxTuiles(this);
        }
    }

    public void DropTuile()
    {
        IsEmpty = true;
        Tuile = null;
        gameObject.SetActive(false);
    }

    public void ObtainTuile(Tuile tuile)
    {
        IsEmpty = false;
        Tuile = tuile;
        gameObject.SetActive(true);
        _image.sprite = Tuile.Image;
    }
}