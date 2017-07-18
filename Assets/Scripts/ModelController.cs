﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ModelController : MonoBehaviour {
	[SerializeField] private string idleAnim;
	[SerializeField] private string walkAnim;
	[SerializeField] private float speed;
	[SerializeField] private int directionOfWalk;
	[SerializeField] private Slider scaleSlider;
	private float scale;
	private bool isWalking = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!isWalking && idleAnim != "") {
			GetComponent<Animation> ().wrapMode = WrapMode.Loop;
			GetComponent<Animation> ().CrossFade (idleAnim);
		} else if (isWalking) {
			GetComponent<Animation> ().CrossFade (walkAnim);
			transform.Translate (directionOfWalk * Vector3.forward * speed * Time.fixedDeltaTime);
		}
	}

	public void modifyScale () {
		transform.localScale = new Vector3 (scaleSlider.value, scaleSlider.value, scaleSlider.value);
	}

	public void walkAnimStart () {
		isWalking = true;
	}
}
