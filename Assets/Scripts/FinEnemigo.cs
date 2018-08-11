using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinEnemigo : MonoBehaviour
{
    public GameObject spawnEnemy;
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
            Instantiate(enemy, spawnEnemy.transform.position+Vector3.right*10, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}