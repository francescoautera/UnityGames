using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    private const int mid = 0;
    [SerializeField] private float move = 2f;
    Vector3 Vect;
    private void Start()
    {
        if (gameObject.transform.position.x >= mid)
        {
            Vect = new Vector3(-move, 0);
        }
        else {
            Vect = new Vector3(move, 0);
        }

    }

    private void Update()
    {
        transform.position += Vect * Time.deltaTime;
    }

}

    


    
        

