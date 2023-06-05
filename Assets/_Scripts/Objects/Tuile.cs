using UnityEngine;

public class Tuile : MonoBehaviour
{
    [field: SerializeField] public string Class { get; private set; } = "Default Tuile Class";

    [field: SerializeField] public int Valeur { get; private set; } = 0;

    [field: SerializeField] public int Score { get; private set; } = 0;

    [field: SerializeField] public Tuile[] _neighboors { get; private set; } = new Tuile[3];

    private void OnTriggerEnter(Collider other)
    {
        int indexOfFirstEmpty = 0;
        for (int index = 0; index < _neighboors.Length; index++ )
        {
            if (_neighboors[index] == null)
            {
                indexOfFirstEmpty = index; 
            }
        }
        _neighboors[indexOfFirstEmpty] = other.gameObject.GetComponent<Tuile>();
    }

    public int CalculateScore()
    {
        if (Class == "Producteur")
        {
            Debug.Log("producteur");
            Score = Valeur;
        }
        else if (Class == "Noble")
        {
            Debug.Log("noble");
            Score = Valeur * GetNeighboorsCount();
        }
        else if (Class == "Erudit")
        {
            Debug.Log("erudit");
        }
        return Score;
    }

    private int GetNeighboorsCount()
    {
        int count = 0;

        foreach (Tuile neighboor in _neighboors)
        {
            if (neighboor != null)
            {
                count++;
            }
        }

        return count;
    }
}
