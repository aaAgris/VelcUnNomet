using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public Canvas kanva;
	// Use this for initialization
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;

	//uzglabaa objekta sakitnejkas vietas koordinatas
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;

	//uzglabas audi avotu kur bus attelu skanas efekti
	public AudioSource skanasAvots;
	//Masivs kas uzglava visas iespejamas skanas
	public AudioClip[] skanaKoAtskanot;
	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
