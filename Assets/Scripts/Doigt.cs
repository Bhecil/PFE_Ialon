using UnityEngine;

public class Doigt : MonoBehaviour
{
    private int tuileID;
    public bool hasTuile = false;

    public void SetTuile(int id)
    {
        tuileID = id;
        hasTuile = true;
    }

    public int GetTuileID()
    {
        return tuileID;
    }

    public void EraseTuile()
    {
        hasTuile = false;
    }
}
