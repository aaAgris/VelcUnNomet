using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public Canvas kanva;
	// Use this for initialization
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject policija;
	public GameObject cementamas;
	public GameObject ugunsdzesejs;
	public GameObject TraktorsSej;
	public GameObject traktors;
	public GameObject ekskavators;
	public GameObject bembis;
	public GameObject b2;


	//uzglabaa objekta sakitnejkas vietas koordinatas
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 policjaKoord;
	[HideInInspector]
	public Vector2 cementaKoord;
	[HideInInspector]
	public Vector2 ugunsKoord;
	[HideInInspector]
	public Vector2 TraktorsSejKoord;
	[HideInInspector]
	public Vector2 TraktorsKoord;
	[HideInInspector]
	public Vector2 ekskavatorsKoord;
	[HideInInspector]
	public Vector2 bembisKoord;
	[HideInInspector]
	public Vector2 b2Koord;

	//uzglabas audi avotu kur bus attelu skanas efekti
	public AudioSource skanasAvots;
	//Masivs kas uzglava visas iespejamas skanas
	public AudioClip[] skanaKoAtskanot;
	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;

	void Start () {
		atroKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		atroKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		bussKoord = autobuss.GetComponent<RectTransform> ().localPosition;
		policjaKoord = policija.GetComponent<RectTransform> ().localPosition;
		cementaKoord = cementamas.GetComponent<RectTransform> ().localPosition;
		ugunsKoord = ugunsdzesejs.GetComponent<RectTransform> ().localPosition;
		TraktorsSejKoord = TraktorsSej.GetComponent<RectTransform> ().localPosition;
		TraktorsKoord = traktors.GetComponent<RectTransform> ().localPosition;
		ekskavatorsKoord = ekskavators.GetComponent<RectTransform> ().localPosition;
		bembisKoord = bembis.GetComponent<RectTransform> ().localPosition;
		b2Koord = b2.GetComponent<RectTransform> ().localPosition;


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
