using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCountView : MonoBehaviour
{
    [SerializeField] private Wallet _wallet;
    [SerializeField] private Text _coinDisplayField;

    private int _coinCount;

    private void FixedUpdate()
    {
        if (_coinCount != _wallet.CoinsCount)
        {
            _coinCount = _wallet.CoinsCount;
            _coinDisplayField.text = _coinCount.ToString();
        }
    }
}
