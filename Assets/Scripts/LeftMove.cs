using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LeftMove : MonoBehaviour
{


	public float moveSpeed = 10f;

	// Use this for initialization
	void Start ()
	{
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate(-transform.right*moveSpeed*Time.deltaTime);	
	}
}
