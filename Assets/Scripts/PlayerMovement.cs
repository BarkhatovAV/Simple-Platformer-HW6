using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.Events;

[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private ContactFilter2D _filter;
    [SerializeField] private UnityEvent _walkRaght;
    [SerializeField] private UnityEvent _walkLeft;
    [SerializeField] private UnityEvent _idled;

    private bool _inAir;

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
            _walkRaght?.Invoke();
            
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-_speed * Time.deltaTime, 0, 0);
            _walkLeft?.Invoke();

        }
        else
        {
            _idled?.Invoke();
        }
        
        if (Input.GetKey(KeyCode.Space) && !_inAir)
        {
            _inAir = true;
            _rigidbody2D.AddForce(Vector2.up * _jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
            _inAir = false;
    }
}