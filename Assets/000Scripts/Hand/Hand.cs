using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    //Les données de la main
    [field:SerializeField] public HandData HandData { get; private set; }
    //la pioche
    [field:SerializeField] public Pioche Pioche { get; private set; }

    void Start()
    {
        SpawnDoigts();
        Refill();
    }

    private void SpawnDoigts()
    {
        float step = HandData.Largeur / HandData.NombreDeDoigts;
        Vector3 position = new Vector3(6, 0, - step * (HandData.NombreDeDoigts - 1) / 2);

        HandData.ListOfDoigts = new List<GameObject>(0);

        for (int index = 0; index < HandData.NombreDeDoigts; ++index)
        {
            HandData.ListOfDoigts.Add(Instantiate(HandData.DoigtPrefab, position, Quaternion.identity));
            HandData.ListOfDoigts[index].GetComponent<Doigt>().HandData = HandData;
            position.z += step;
        }
    }

    private void Refill()
    {
        foreach (GameObject doigtPrefab in HandData.ListOfDoigts)
        {
            if (doigtPrefab.TryGetComponent(out Doigt doigt))
            {
                doigt.ObtainTuile(Pioche.RandomTuile());
            }
        }
    }
}
