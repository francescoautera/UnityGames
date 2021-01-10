using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    [SerializeField] private float timer = 1f;
    public GameObject myprefab;
    public GameObject wallsx;
    public GameObject walldx;
    private float timing = 0f;
    
    // Update is called once per frame
    void Update()
    {
        timing += Time.deltaTime;
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            
        }
        else if (timer <= 0)
        {
            var create = new Vector3(Random.Range(wallsx.transform.position.x, walldx.transform.position.x), 
                                      10, Random.Range(wallsx.transform.position.z, walldx.transform.position.z));
            Instantiate(myprefab, create, Quaternion.identity); // quaternion richima la rotazione dell'oggetto
            DecreseTimer();

        }


    }
    private void DecreseTimer() {
        if (timing < 15)
        {
            timer = 2f;
        }
        else if (timing < 30)
        {
            timer = 1f;

        }
        else
        { 
            timer = 0.5f;
        }
    }
}
