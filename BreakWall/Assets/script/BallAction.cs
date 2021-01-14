using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallAction : MonoBehaviour
{
    Rigidbody rb;
   
    Vector3 moveback;

    
    [SerializeField] private float velocity = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
        moveback = new Vector3(0, -1,Random.Range(-1,1));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveback * velocity * Time.deltaTime;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            moveback.y = -moveback.y;

        }
        if (collision.gameObject.tag == "Block")
        {
            moveback.y = -moveback.y;
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == "WallSx"|| collision.gameObject.tag == "WallDx") {
            moveback.z = -moveback.z;
        }

        if (collision.gameObject.tag == "Wall") { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }
    }
}
