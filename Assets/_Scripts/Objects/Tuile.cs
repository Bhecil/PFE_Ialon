using UnityEngine;

public class Tuile : MonoBehaviour
{
    //[field: SerializeField] public TuileStats stats { get; private set; }

    [field: SerializeField] public string Name { get; private set; } = "defaultTuileName";

    [field: SerializeField] public int Valeur { get; private set; } = 0;

    [field: SerializeField] public Sprite Image { get; private set; } = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
