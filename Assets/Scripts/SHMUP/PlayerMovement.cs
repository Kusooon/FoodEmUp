using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{

    [SerializeField] Rigidbody2D _rb;
    [SerializeField] float _speed = 5f;



    // Start is called before the first frame update
    void Awake()
    {
        TryGetComponent(out _rb);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 _movement = new Vector2( 0,Input.GetAxis("Vertical"));

        if (_movement.sqrMagnitude > 1f)
        {
            _movement = _movement.normalized;
        }

        _rb.velocity = _movement * _speed;


    }
}
