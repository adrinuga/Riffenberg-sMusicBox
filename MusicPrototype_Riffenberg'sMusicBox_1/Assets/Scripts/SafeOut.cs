﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeOut : MonoBehaviour,InteractableObject {

	// Use this for initialization
	void Start ()
    {
        GameManager.m_instance.m_interactableObjects.Add(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnClick()
    {
    }
    public void MouseOver()
    {
    }
    public Transform ReturnObject()
    {
        return this.transform;
    }
}