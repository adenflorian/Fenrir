﻿using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	Animator animator;

	void Awake () {
		gameObject.SetActive(false);
	}

	void Start () {
		animator = GetComponent<Animator>();
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.Mouse0)) {
			animator.SetTrigger("skip");
		}
	}
}
