using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

[RequireComponent(typeof(Animator))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private Transform _transform;
    [SerializeField] private ContactFilter2D _filter;

    private bool _inAir;

    private bool _isWalkRight;
    public bool IsWalkRight => _isWalkRight;

    private bool _isWalkLeft;
    public bool IsWalkLeft => _isWalkLeft;

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
            _isWalkRight = true;
        }
        else
        {
            _isWalkRight = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-_speed * Time.deltaTime, 0, 0);
            _isWalkLeft = true;
        }
        else
        {
            _isWalkLeft = false;
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
