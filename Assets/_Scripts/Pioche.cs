using UnityEngine;

public class Pioche : MonoBehaviour
{
    [field: SerializeField] public Tuile[] listOfTuiles { get; private set; } = new Tuile[0];

    public Tuile RandomTuile()
    {
        Tuile randomTuile = null;
        int random = Random.Range(0, 100);
        int cumulatedChance = 0;

        foreach (Tuile tuile in listOfTuiles)
        {
            cumulatedChance += tuile.DropRate;
            if (random < cumulatedChance)
            {
                randomTuile = tuile;
                break;
            }
        }
        return randomTuile;
    }
}
