using UnityEngine;

public class Pioche : MonoBehaviour
{
    private GameManager gameManager;

    private Main main;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        main = gameManager.main;
    }
    public void Piocher()
    {
        for(int index = 0; index < main.heldTuiles.Length; index++)
        {
            //if (main.heldTuiles[index] == null)
            //{
                main.heldTuiles[index] = getNewTuile();
            //}
        }
    }

    private GameObject getNewTuile()
    {
        int reference = Random.Range(0, 2);
        print(reference);

        return gameManager.getTuile(reference);
    }
}
