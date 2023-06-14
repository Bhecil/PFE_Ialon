using UnityEngine;

public class HandSpawner : MonoBehaviour
{
    //Les données de la main
    public Hand Hand;

    void Start()
    {
        SpawnDoigts();
    }

    private void SpawnDoigts()
    {
        float step = Hand.Largeur / Hand.NombreDeDoigt;
        Vector3 position = new Vector3(6, 0, - step * (Hand.NombreDeDoigt - 1) / 2);
        for (int index = 0; index < Hand.NombreDeDoigt; ++index)
        {
            Hand.ListeDeDoigts.Add(Instantiate(Hand.DoigtPrefab, position, Quaternion.identity));
            position.z += step;
        }
    }
}
