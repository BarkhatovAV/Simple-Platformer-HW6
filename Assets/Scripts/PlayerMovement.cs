using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private Rigidbody2D _rigidbody2D;

    [SerializeField] private UnityEvent _walkRaght;
    [SerializeField] private UnityEvent _walkLeft;
    [SerializeField] private UnityEvent _idled;

    private float _distanceToSurface = 0.2f;
    private RaycastHit2D[] hitBuffer = new RaycastHit2D[2];

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
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_rigidbody2D.Cast(Vector2.down, hitBuffer, _distanceToSurface) > 0)
            {
                _rigidbody2D.AddForce(Vector2.up * _jumpForce);
            }
        }
    }
}