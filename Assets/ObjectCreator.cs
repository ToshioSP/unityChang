using UnityEngine;
using System.Collections;
using System;
using UnityEditor;
using UnityEngine.UI;

public class ObjectCreator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Createpopupwindow(){
		RectTransform popuprect;
		GameObject popupwindow = new GameObject ();
		popupwindow.name = "popupwindow";

		GameObject parent = GameObject.Find ("Canvas");
		popupwindow.transform.parent = parent.transform;
		popuprect = popupwindow.AddComponent<RectTransform>();
		popuprect.localPosition = new Vector3 (0,0,0);
		popuprect.sizeDelta = new Vector2 (500, 300);
		Image popupimage = popupwindow.AddComponent<Image>();
		Texture2D texture = Resources.Load ("nya") as Texture2D;
		popupimage.sprite = Sprite.Create(texture,new Rect(0, 0, texture.width, texture.height), Vector2.zero);

		GameObject button = new GameObject ();
		button.transform.parent = popupwindow.transform;
		RectTransform buttonrect= button.AddComponent<RectTransform>();
		buttonrect.sizeDelta = new Vector2 (100,20);
		buttonrect.localPosition = new Vector3(0,0,0);
		Image buttonimage = button.AddComponent<Image> ();
		Texture2D aaa = Resources.Load ("7200") as Texture2D;
		buttonimage.sprite = Sprite.Create(aaa,new Rect(0, 0, aaa.width, aaa.height), Vector2.zero);
	}
}
