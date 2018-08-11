using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    /// <summary>
    /// Define el número de jugador
    /// </summary>
    public enum NumPlayer
    {
        player1 = 0,
        player2 = 1
    }

    /// <summary>
    /// Número de jugador
    /// </summary>
    public NumPlayer numPlayer;

    public float jumpSpeed = 50f;

    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (numPlayer == NumPlayer.player1)
        {
            rb.AddForce((transform.up *
                         Time.deltaTime *
                         jumpSpeed *
                         Input.GetAxis("VerticalPlayer1")), ForceMode.VelocityChange);
        }

        if (numPlayer == NumPlayer.player2)
        {
            rb.AddForce((transform.up *
                         Time.deltaTime *
                         jumpSpeed *
                         Input.GetAxis("VerticalPlayer2")), ForceMode.VelocityChange);
        }
    }
}