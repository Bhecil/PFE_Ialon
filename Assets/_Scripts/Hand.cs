using UnityEngine;

public class Hand : MonoBehaviour
{
    [field:SerializeField] public static int NombreDeDoigt { get; private set; } = 3;
    [field:SerializeField] public GameObject Doigt { get; private set; }
    [field:SerializeField] public Pioche Pioche { get; private set; }
    [field: SerializeField] public int Largeur { get; private set; } = 50;

    private Doigt[] Doigts = new Doigt[NombreDeDoigt];

    private void Start()
    {
        SpawnDoigts();
        Refill();
    }

    private void SpawnDoigts()
    {
        float step = Largeur / NombreDeDoigt;
        Vector3 position = new Vector3(6, 0, -step * (NombreDeDoigt - 1) / 2);

        for (int index = 0; index < NombreDeDoigt; ++index)
        {
            Doigts[index] = Instantiate(Doigt, position, Quaternion.identity).GetComponent<Doigt>();
            position.z += step;
        }
    }

    private void Refill()
    {
        Tuile tuile;
        foreach (Doigt doigt in Doigts)
        {
            tuile = Pioche.RandomTuile();
            doigt.ObtainTuile(tuile);
        }
    }
}
