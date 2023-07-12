using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _score;

    private void OnEnable()
    {
        _player.CoinCollected += OnCoinCollected;
    }

    private void OnDisable()
    {
        _player.CoinCollected -= OnCoinCollected;
    }

    private void OnCoinCollected(int coinCount)
    {
        _score.text = coinCount.ToString();
    }
}
