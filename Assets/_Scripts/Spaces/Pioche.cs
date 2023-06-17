using UnityEngine;

public class Pioche : MonoBehaviour
{
    //la liste des tuiles piochables
    [SerializeField] private Tuile[] Tuiles = new Tuile[3];

    //la somme des probabilités de chaque tuile de la pioche
    [SerializeField] private int Somme = 0;

    private void Start()
    {
        //calcul de la somme des probabilités
        foreach (var tuile in Tuiles)
        { 
            Somme += tuile.Chance;
        }
    }

    public Tuile RandomTuile()
    {
        int random = Random.Range(0, Somme);
        int cumulatedChance = 0;
        Tuile randomTuile = null;

        foreach (var tuile in Tuiles)
        {
            cumulatedChance += tuile.Chance;
            if (random < cumulatedChance)
            {
                randomTuile = tuile;
                break;
            }
        }

        return randomTuile;
    }
}
