using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateBlocks : MonoBehaviour
{
    [SerializeField] public static bool isdestroy=true;
    public int size;
    public Material[] materials;
    public GameObject wallUp;
    public GameObject wallDown;
    public GameObject WallYellow;
    public GameObject wallgreen;
    public PlayerAction pa;
    //private float moveUp = 1.5f;
    

    Renderer rend;
    Renderer rendcollider;
    Vector3 rotate;
    void Start()
    {
        
        int choice = Random.Range(0, materials.Length);
        rend = GetComponent<Renderer>();
        rend.sharedMaterial = materials[choice];
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isdestroy)
        {
           int choice= Random.Range(0, materials.Length);
            rend = GetComponent<Renderer>();
            rend.sharedMaterial = materials[choice];
            var pos = new Vector3(Random.Range(wallDown.transform.position.x,wallUp.transform.position.x),5,Random.Range(WallYellow.transform.position.z,wallgreen.transform.position.z));
            
            Instantiate(gameObject, pos, Quaternion.identity);
            isdestroy = false;

        }
        if (pa.isdeath) {
            isdestroy = true;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        rendcollider = collision.gameObject.GetComponent<Renderer>();
        if (collision.gameObject.tag == "YellowPlane" && Material.Equals(rend.sharedMaterial,rendcollider.sharedMaterial)) {
            
            Destroy(gameObject);
            isdestroy = true;
        }
        if (collision.gameObject.tag == "GreenPlane"&& Material.Equals(rend.sharedMaterial, rendcollider.sharedMaterial))
        {
            Destroy(gameObject);
            isdestroy = true;
        }
        if (collision.gameObject.tag == "Wall") {
            transform.position += new Vector3(2,0,0) * Time.deltaTime;
            
        }
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {

           // transform.position = new Vector3(collision.gameObject.transform.position.x, moveUp, collision.gameObject.transform.position.z);


        }
    }
}
