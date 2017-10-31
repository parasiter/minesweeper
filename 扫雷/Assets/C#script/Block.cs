using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
	[SerializeField] private GameObject blockBack;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnMouseDown(){
		if (blockBack.activeSelf)
			blockBack.SetActive (false);
	}
	public void SetImage(Sprite image)
	{
		GetComponent<SpriteRenderer> ().sprite = image;
	}
}
