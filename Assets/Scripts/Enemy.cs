using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public static event UnityAction OnCollisionWithPlayer;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Player player))
        {
            OnCollisionWithPlayer?.Invoke();
            Destroy(collision.gameObject);
        }
    }
}
