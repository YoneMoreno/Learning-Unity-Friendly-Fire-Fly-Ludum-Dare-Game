using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float factorAumentoPlayer = 1.1f;
    public GameObject player1;
    public GameObject player2;

    public float moveSpeed = 20f;

    // Use this for initialization
    void Start()
    {
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.right * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        IncrementScaleSize();
    }


    private void IncrementScaleSize()
    {
        var scalePlayer1 = player1.transform.localScale;
        //print(other.transform.localScale);       
        scalePlayer1.x *= factorAumentoPlayer;
        scalePlayer1.y *= factorAumentoPlayer;
        player1.transform.localScale = scalePlayer1;
        //print(other.transform.localScale);

        var scalePlayer2 = player2.transform.localScale;
        scalePlayer2.x *= factorAumentoPlayer;
        scalePlayer2.y *= factorAumentoPlayer;
        player2.transform.localScale = scalePlayer2;
    }
}