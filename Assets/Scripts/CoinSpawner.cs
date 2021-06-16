using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private Coin _template;
    [SerializeField] private Transform _pathOfCoins;

    private void Start()
    {
        for (int i = 0; i < _pathOfCoins.childCount; i++)
        {
            Instantiate(_template, _pathOfCoins.GetChild(i).position, Quaternion.identity);
        }
    }
}
