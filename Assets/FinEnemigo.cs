using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinEnemigo : MonoBehaviour
{
    public GameObject finEscenario;
    public GameObject enemy;

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
        print(other);
        if (other.transform.CompareTag("Enemy"))
        {
            print("Enemy");
            Instantiate(enemy, finEscenario.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}