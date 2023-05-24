using UnityEngine;

public class Tuile : MonoBehaviour
{
    public Material selectMaterial;

    private Renderer renderer;
    private Material defaultMaterial;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        defaultMaterial = renderer.material;
    }

    private void OnMouseEnter()
    {
        renderer.material = selectMaterial;
    }
    private void OnMouseExit()
    {
        renderer.material = defaultMaterial;
    }

}
