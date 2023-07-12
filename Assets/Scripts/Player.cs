using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private int _countCoin;

    public event UnityAction<int> CoinCollected;
    public UnityEvent TakeCoin;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Coin coin))
        {
            _countCoin++;
            CoinCollected?.Invoke(_countCoin);
            TakeCoin.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
