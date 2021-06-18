using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCountView : MonoBehaviour
{
    [SerializeField] private Text _coinDisplayField;

    public void View(List<Coin> coins)
    {
        _coinDisplayField.text = coins.Count.ToString();
    }
}
