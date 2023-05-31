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
        main.Refill();
    }

    public int PickNewTuile()
    {
        return Random.Range(0, 3);
    }
}
