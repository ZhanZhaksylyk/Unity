﻿using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    public GameObject player;
    Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
