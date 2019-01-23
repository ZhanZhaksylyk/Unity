using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FindAndSetGravity();
        }
    }

    void FindAndSetGravity()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject g in enemies)
        {
            g.GetComponent<Rigidbody>().useGravity = true;
            //Rigidbody r = g.GetComponent<Rigidbody>();
        }

    }
}
