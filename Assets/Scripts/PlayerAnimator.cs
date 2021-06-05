using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(PlayerMovement))]
public class PlayerAnimator : MonoBehaviour
{
    private Animator _animator;
    private PlayerMovement _playerMovement;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _playerMovement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (_playerMovement.IsWalkRight)
        {
            _animator.SetBool("Walk Right", true);
        }
        else
        {
            _animator.SetBool("Walk Right", false);
        }

        if (_playerMovement.IsWalkLeft)
        {
            _animator.SetBool("Walk Left", true);
        }
        else
        {
            _animator.SetBool("Walk Left", false);
        }
    }
}
