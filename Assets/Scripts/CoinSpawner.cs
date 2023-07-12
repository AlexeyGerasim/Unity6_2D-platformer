using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin coinPrefab;
    [SerializeField] private Transform[] spawnPoints;

    private int currentCoinIndex = 0;

    private void Start()
    {
        SpawnNextCoin();
    }

    private void SpawnNextCoin()
    {
        if (currentCoinIndex < spawnPoints.Length)
        {
            Instantiate(coinPrefab, spawnPoints[currentCoinIndex].position, Quaternion.identity);
        }
    }

    public void TakeCoin()
    {
        currentCoinIndex++;
        SpawnNextCoin();
    }
}
