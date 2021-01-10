using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movment : MonoBehaviour
{
    [SerializeField] private float velocity= 1f;
    // Update is called once per frame
    void Update()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += move * velocity * Time.deltaTime;
      
    }
}
