﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStompScript : MonoBehaviour {
    public PlayerCombatScript playerScript;
    public AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
	}
	
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "stomp")
        {
            playerScript.StompJump();
            audioSource.Play();
        }
    }
	// Update is called once per frame
	void Update () {
		
	}
}
