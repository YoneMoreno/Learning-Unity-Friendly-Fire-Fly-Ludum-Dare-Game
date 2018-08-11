using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float scale = 2f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        var transformLocalScale = other.transform.localScale;
        //print(other.transform.localScale);       
        transformLocalScale.x *= scale;
        transformLocalScale.y *= scale;
        other.transform.localScale = transformLocalScale;
        //print(other.transform.localScale);
    }
}