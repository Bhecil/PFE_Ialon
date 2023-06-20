using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [field: SerializeField] public int Score { get; private set; } = 0;
    private Text _scoreText;

    private void Start()
    {
        _scoreText = GetComponentInChildren<Text>();
    }
}
