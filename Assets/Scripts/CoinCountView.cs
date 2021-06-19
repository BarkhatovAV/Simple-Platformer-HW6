using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCountView : MonoBehaviour
{
    [SerializeField] private Wallet wallet;
    [SerializeField] private Text _coinDisplayField;

    public void View()
    {
        _coinDisplayField.text = wallet.CoinCount.ToString();
    }
}
