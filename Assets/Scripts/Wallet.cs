using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
    [SerializeField] private UnityEvent _counCountChenged;
    
    private List<Coin> _coins = new List<Coin>();

    private int _coinCount;
    public int CoinCount => _coinCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            _coins.Add(coin);
            _coinCount = _coins.Count;
            _counCountChenged?.Invoke();
            coin.Destroy();
        }
    }
}
