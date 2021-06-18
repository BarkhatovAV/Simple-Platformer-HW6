using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    [SerializeField] private CoinCountView _coinCountView;

    private List<Coin> _coins = new List<Coin>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            _coins.Add(coin);
            _coinCountView.View(_coins);
            coin.Destroy();
        }
    }
}
