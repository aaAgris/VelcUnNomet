using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour,IDropHandler {

	//uzglabas velkama objekta un nomesanas lauka z rotaciju
	//kaarii rotaacijas un izmeru pielaujamo starpibu
	private float vietasZrot, velkObjZrot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmeruStarp, yIzmeruStarp;
	//Norade uz Objekti skriptu
	public Objekti objektuSkripts;


	//nostradas ja objektu censas nomest uz jebkuras nomesanas vietas
	public void OnDrop(PointerEventData notikums){
		//parabuda vai tika vilkts un atlaists vispar kads objekts
		if (notikums.pointerDrag != null) {
			//ja nomesanas vietas tags sakrit ar vilkta objekta tagu
			if (notikums.pointerDrag.tag.Equals(tag)) {
			
			//iegust objekta rotaciju grados
				vietasZrot = notikums.pointerDrag.GetComponent<RectTransform>().eulerAngles.z;
				velkObjZrot = GetComponent<RectTransform>().eulerAngles.z;
				//apreika abu obj z rotacijas starp
				rotacijasStarpiba = Mathf.Abs(vietasZrot - velkObjZrot);
				//japiefikse ari izmeri pa x un y asiim

				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform> ().localScale;
				velkObjIzm = GetComponent<RectTransform> ().localScale;
				xIzmeruStarp = Mathf.Abs (vietasIzm.x - velkObjIzm.x);
				yIzmeruStarp = Mathf.Abs (vietasIzm.y - velkObjIzm.y);

				if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
				   && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1)) {
					objektuSkripts.vaiIstajaVieta = true;
					//Noliktais objekts smuki iecentrejas nemesanas laukaa
					notikums.pointerDrag.GetComponent<RectTransform> ().anchoredPosition = GetComponent<RectTransform> ().anchoredPosition;
					//rotacija

					notikums.pointerDrag.GetComponent<RectTransform> ().localRotation = GetComponent<RectTransform> ().localRotation;

					//izmeram
					notikums.pointerDrag.GetComponent<RectTransform> ().localScale = GetComponent<RectTransform> ().localScale;

					switch (notikums.pointerDrag.tag) {
					case "Atkritumi":
						objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition = objektuSkripts.atkrKoord;
						break;

					case "Slimnica":
						objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition = objektuSkripts.atroKoord;
						break;

					case "Skola":
						objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition = objektuSkripts.bussKoord;
						break;

					default:
						Debug.Log ("Nedefinéts tags!");
						break;
					}
				}

		}
	
	}
}
}
