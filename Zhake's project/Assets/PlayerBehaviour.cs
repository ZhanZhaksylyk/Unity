using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    //[HideInInspector]
    public float speed = 5f;
    public float rotSpeed = 20f;
    public Rigidbody rb;
    public float force = 20f;
    Collider capsuleCollider;
    void Awake()
    {
        capsuleCollider = GetComponent<Collider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.right * Time.deltaTime * rotSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.left * Time.deltaTime * rotSpeed);
        }
    }
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //*rb.AddForceAtPosition(Vector3.right * force, Vector3.left * 0.1f);
            rb.AddForce(Vector3.right * force, ForceMode.Force);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Stone")
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.name == "Stone")
        {
            
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.name == "Stone")
        {
            Debug.Log("CollisionExit");

            gameObject.GetComponent<MeshRenderer>().material.color = Color.white;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("OKAY!!!");
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Spot")
        {
            Debug.Log("Spot");
            rb.AddForce(Vector3.up * force, ForceMode.Force);
        }
    }
    private void OnMouseDown()
    {
        rb.AddForce(Vector3.forward * force, ForceMode.Force);
    }
}
