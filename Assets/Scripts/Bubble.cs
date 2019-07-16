using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private float _maxScale;
    [SerializeField] private int _bubbleLifetime;
    private int _timeCounter = 0;

    private void FixedUpdate()
    {


        if (_timeCounter <= _bubbleLifetime)

        {
          //  print(_timeCounter);
            if (_timeCounter >= _bubbleLifetime - 3)
                _timeCounter = 0;

            _timeCounter = _timeCounter + 1;
        }

        // else
       // {
       //    _timeCounter = _timeCounter - _bubbleLifetime;
       //     print(_timeCounter);
       // }
        
 //       if (transform.localScale.x <= _maxScale)
            if (RayCastHelper.Instance.hitCounts <= 3)
               
        {
            if (transform.localScale.x <= _maxScale)
            {
                transform.position = Vector3.Lerp(transform.position,
                    new Vector3(transform.position.x, transform.position.y + _speed, transform.position.z),
                    Time.deltaTime);
                transform.localScale = Vector3.Lerp(transform.localScale,
                    new Vector3(transform.localScale.x + _scaleSpeed, transform.localScale.y + _scaleSpeed,
                        transform.localScale.z + _scaleSpeed), Time.deltaTime);

            }
            else
            {
                transform.position = new Vector3(Random.Range(-4.0f, 4.0f), 0, 10);
                transform.localScale = new Vector3(1,1,1);
                
            }


        }
        else
        {
            transform.position = new Vector3(Random.Range(-4.0f, 4.0f), Random.Range(-2.0f, 2.0f), 10);
            transform.localScale = new Vector3(1,1,1);
        }
    }




   
  /* 
        if (_timeCounter <= _bubbleLifetime)
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
    
*/
}
