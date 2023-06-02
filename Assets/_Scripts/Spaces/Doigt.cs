using UnityEngine;
using UnityEngine.UI;

public class Doigt : MonoBehaviour
{
    public bool IsEmpty { get; private set; } = true;

    [field: SerializeField]
    public Tuile Tuile { get; private set; } = null;

    public Hand _hand { get; private set; }

    private Text _text;
    
    private void Start()
    {
        _hand = FindObjectOfType<Hand>();
        _text = GetComponentInChildren<Text>();
        DropTuile();
    }

    public void OnClick()
    {
        _hand.SelectDoigt(this);
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
        _text.text = Tuile.name;
    }
}