﻿using UnityEngine;
using System.Collections;

public class Basket_Script : MonoBehaviour 
{
	private float baseAngle = 0.0f;
	private Quaternion startRotation = Quaternion.identity;
	
	void OnMouseDown() 
	{
		Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
		pos = Input.mousePosition - pos;
		baseAngle = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg;
		baseAngle -= Mathf.Atan2(transform.right.y, transform.up.y) * Mathf.Rad2Deg;
		startRotation = transform.rotation;
	}
	
	void OnMouseDrag()
	{
		Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
		pos = Input.mousePosition - pos;
		float ang = Mathf.Atan2(pos.y, pos.x) * Mathf.Rad2Deg - baseAngle;
		transform.rotation = Quaternion.AngleAxis(ang, Vector3.down) * startRotation;
	}
} 