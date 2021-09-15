using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSpawner : MonoBehaviour
{

    void Start()
    {

        
    }

    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            gameObject.transform.position = new Vector3(transform.position.x, 1.5f, 16f);
        }

    }

}
