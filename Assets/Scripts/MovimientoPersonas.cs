using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class MovimientoPersonas : MonoBehaviour {
	private Vector3 PosicionInicial=new Vector3(0,0,0);
	private Vector3 PosicionFinal=new Vector3(0,0,0);
	private bool Calmado=true, rotado=false;
	Animator anim;

	float smooth=1f;
	int cgiros=0;
	//float tiempoSound=5, tiempoPasos=2;
	// Use this for initialization
	void Start () {
		PosicionInicial = transform.position;
		PosicionFinal = PosicionInicial + new Vector3 (0,0,18);
		//anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		float step = 3* Time.deltaTime;

		transform.position = Vector3.MoveTowards (transform.position, PosicionFinal, step);
		if (transform.position== PosicionFinal){
			if (cgiros == 0) {
				PosicionFinal = PosicionFinal + new Vector3 (-20, 0, 0);
			} else if (cgiros == 1) {
				PosicionFinal = PosicionFinal + new Vector3 (0, 0, -25);
			} else if (cgiros == 2) {
				PosicionFinal = PosicionFinal + new Vector3 (3, 0, 0);
			}else if (cgiros == 3) {
				PosicionFinal = PosicionFinal + new Vector3 (0, -6, 15);
			}else if (cgiros == 4) {
				PosicionFinal = PosicionFinal + new Vector3 (-8, 0, 0);
			}else if (cgiros == 5) {
				PosicionFinal = PosicionFinal + new Vector3 (0, 0, -5);
			}else if (cgiros == 6) {
				PosicionFinal = PosicionFinal + new Vector3 (Random.Range(-1,-30), 0, 0);
			}else if (cgiros == 7) {
				PosicionFinal = PosicionFinal + new Vector3 (0, 0, -4);
			}
			cgiros++;
		}

//		if (tiempoSound <= 0) {
//			tiempoSound = Random.Range (3, 10);
//		}
//		tiempoSound-=Time.deltaTime;
//
//		if (!Calmado) {
//			float step = 3 * Time.deltaTime;
//
//
//
//			if (!rotado) {
//				transform.rotation *= Quaternion.Euler (0, 180f, 0);
//				rotado = true;
//			}
//
//			if (tiempoPasos <= 0) {
//				tiempoPasos = 1.9f;
//			}
//			tiempoPasos -= Time.deltaTime;
//
//
//		}
//
//		if (transform.position==PosicionInicial){
//			Calmado = true;
//			anim.SetTrigger ("IDLE");
//			if (rotado) {
//				transform.rotation *= Quaternion.Euler (0, 180f, 0);
//				rotado = false;
//			}
//		}
	}

//	void OnTriggerEnter(Collider other) {
//		if(other.gameObject.tag == "Vampire")
//		{
//			anim.SetTrigger ("Run");
//			print ("Run");
//			tiempoPasos = 0;
//		}
//
//	}
//
//	void OnTriggerStay(Collider other) {
//		if (other.gameObject.tag == "Vampire") {
//			transform.Translate (Vector3.forward * Time.deltaTime * 5);
//			anim.SetTrigger ("Run");
//			if (tiempoPasos <= 0) {
//				tiempoPasos = 1.9f;
//			}
//			tiempoPasos -= Time.deltaTime;
//		}
//
//	}
//	void OnTriggerExit(Collider other) {
//		Calmado = false;
//	}
//	void OnCollisionEnter(Collision collision) {
//		anim.SetTrigger ("Attack");
//	}

}
