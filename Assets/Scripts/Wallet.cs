using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    private List<Coin> _coins = new List<Coin>();
    private int _coinsCount;

    public int CoinsCount => _coinsCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            _coins.Add(coin);
            _coinsCount = _coins.Count;
            coin.Destroy();
        }
    }
}
