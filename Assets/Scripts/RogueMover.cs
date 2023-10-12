using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogueMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _moveDirection;

    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    private void Update()
    {
        _moveDirection = new Vector3(Input.GetAxisRaw(Horizontal), 0, Input.GetAxisRaw(Vertical));

        transform.position += _moveDirection * _speed * Time.deltaTime;
    }
}
