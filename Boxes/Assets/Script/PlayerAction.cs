using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerAction : MonoBehaviour
{
    [SerializeField] private float velocity = 1f;
    Vector3 move;
    Vector3 rotate;
    public bool isdeath;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rotate = new Vector3(0, -90, 0);
            move = new Vector3(-1, 0, 0);
            transform.position += move * velocity * Time.deltaTime;
            transform.Rotate(rotate * Time.deltaTime);


        }
        if (Input.GetKey(KeyCode.D))
        {
            rotate = new Vector3(0, 90, 0);
            move = new Vector3(1, 0, 0);
            transform.position += move * velocity * Time.deltaTime;
            transform.Rotate(rotate * Time.deltaTime);


        }
        if (Input.GetKey(KeyCode.W))
        {
            move = new Vector3(0, 0, 1);
            transform.position += move * velocity * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S))
        {
            move = new Vector3(0, 0, -1);
            transform.position += move * velocity * Time.deltaTime;

        }



    }







    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            isdeath = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
    }


}
