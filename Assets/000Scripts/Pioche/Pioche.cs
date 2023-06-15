using UnityEngine;

public class Pioche : MonoBehaviour
{
    //La liste des tuiles piochables
    [field:SerializeField] public TuileData[] listOfTuiles { set; private get; }

    public TuileData RandomTuile()
    {
        TuileData randomTuile = null;
        int random = Random.Range(0, 100);
        int cumulatedChance = 0;

        foreach (TuileData tuile in listOfTuiles)
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
