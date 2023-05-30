using UnityEngine;

public class Emplacement : MonoBehaviour
{
    //Game
    private GameManager gameManager;

    //Material
    private Renderer renderer;
    public Material selectMaterial;
    private Material defaultMaterial;

    //Specific
    public bool isEmpty;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        renderer = GetComponent<Renderer>();
        defaultMaterial = renderer.material;
        isEmpty = true;
    }
    private void OnMouseEnter()
    {
        renderer.material = selectMaterial;
    }
    private void OnMouseExit()
    {
        renderer.material = defaultMaterial;
    }

    private void OnMouseDown()
    {
        if (isEmpty)
        {
            isEmpty = !gameManager.main.PlaceTuileAt(this.transform);
        }
    }
}
