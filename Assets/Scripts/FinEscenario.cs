using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinEscenario : MonoBehaviour
{
    public GameObject escenario;

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
        if (other.transform.CompareTag("Player"))
        {
            Instantiate(escenario, transform.position, Quaternion.identity);
            Destroy(escenario);
        }
    }
}