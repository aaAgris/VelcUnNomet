using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//jaimportee lai lietotu I interfeisus
using UnityEngine.EventSystems;

public class DragDropSkripts : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler {
	//Velkamajam objektam piestiprinata komponente
	private CanvasGroup kanvasGrupa;
	//Priekś parvietojama objekta atrasnaas vietas uzglabasanas
	private RectTransform velkObjRectTransf;
	//norade uz objektu skriptu
	public Objekti objektuSkripts;

	// Use this for initialization
	void Start () {
		//Pieklust objekta piestiprinatajai CanvasGroup komponentei
		kanvasGrupa = GetComponent<CanvasGroup>();
		//Pieklust objekta RectTransform kompo
		velkObjRectTransf = GetComponent<RectTransform>();
	}
	
	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Uzklikśḱinats uz velkama objekta!");
	}

	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsakta vilksana!");
		//velkot objekts paliek caurspidigs
		kanvasGrupa.alpha = 0.6f;
		//Lai objektam velktoit iet cauri raycast stari
		kanvasGrupa.blocksRaycasts = false;
	}

	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Notiek vilksana!");
		// maina x,y koordinatas
		velkObjRectTransf.anchoredPosition += notikums.delta / objektuSkripts.kanva.scaleFactor;
	}

	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("BeigtaObjektaVilksana");
		kanvasGrupa.alpha =1f;
		//ja obj nav ista vieta
		if(objektuSkripts.vaiIstajaVieta == false){
			//tad to atkal var vilkt
			kanvasGrupa.blocksRaycasts = true;
		}else{
			//aizmirst pedejo objektu kas vilkts
			objektuSkripts.pedejaisVilktais = null;
		}
		//ja viens objekts ista vieta
		objektuSkripts.vaiIstajaVieta = false;

}

}
