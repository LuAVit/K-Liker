using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _maxScale;

    private void FixedUpdate()
    {
        if (transform.localScale.x <= _maxScale)
        {
            transform.position = Vector3.Lerp(transform.position,
                new Vector3(transform.position.x, transform.position.y + _speed, transform.position.z), Time.deltaTime);
            transform.localScale = Vector3.Lerp(transform.localScale,
                new Vector3(transform.localScale.x + _scaleSpeed, transform.localScale.y + _scaleSpeed,
                    transform.localScale.z + _scaleSpeed), Time.deltaTime);

        }
        else
        {
            transform.position = new Vector3(Random.Range(-7.0f, 7.0f), 0, 10);
            transform.localScale = new Vector3(1,1,1);
        }
    }

}
