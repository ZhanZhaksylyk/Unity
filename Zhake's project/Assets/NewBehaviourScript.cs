using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    Rigidbody rb;
    public float speed;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    private void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveH, 0f, moveV);

        rb.AddForce(movement * speed);

    }
}
