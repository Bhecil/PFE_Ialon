using UnityEngine;

public class Emplacement : MonoBehaviour
{
    public Material selectMaterial;
    public GameObject defaultTile;

    private Renderer renderer;
    private Material defaultMaterial;

    public bool isEmpty;

    private void Start()
    {
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
            Instantiate(defaultTile, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), transform.rotation);
            isEmpty = false;
        }
    }
}
