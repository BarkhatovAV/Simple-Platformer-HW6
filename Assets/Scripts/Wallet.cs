using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wallet : MonoBehaviour
{
   [SerializeField] private Text _text; 

   private List<Coin> _coins = new List<Coin>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            _coins.Add(coin);
            _text.text = _coins.Count.ToString();
            coin.DestroyCoin();
        }
    }
}
