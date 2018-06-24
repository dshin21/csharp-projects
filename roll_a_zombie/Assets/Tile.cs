using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {
	public GameManager gameManager;
	public AudioClip hit;
	AudioSource source;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnTriggerEnter (Collider other) {
		gameManager.AddPoint ();
		source.PlayOneShot (hit);
	}
}