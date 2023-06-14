using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "DataTable / GameData")]
public class GameData : ScriptableObject
{
    //la tuile selectionnée
    public Tuile SelectedTuile { get; set; }
    //le score total
    public int Score { get; set; }
}
