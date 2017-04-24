using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaGente : MonoBehaviour {
	float tiempoI = 1;
	public GameObject gente;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (tiempoI <= 0) {
			tiempoI = Random.Range (3, 10);

			Instantiate(gente, transform.position, Quaternion.identity);

		}
		tiempoI-=Time.deltaTime;
	}
}
