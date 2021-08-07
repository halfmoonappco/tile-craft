using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_Generation : MonoBehaviour
{

    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }



    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube")
        {
            Instantiate(cube, transform.position + (transform.forward * 2), transform.rotation);
            Instantiate(cube, transform.position + (transform.forward * -2), transform.rotation);
            Instantiate(cube, transform.position + (transform.right * 2), transform.rotation);
            Instantiate(cube, transform.position + (transform.right * -2), transform.rotation);
        }
    }
}
