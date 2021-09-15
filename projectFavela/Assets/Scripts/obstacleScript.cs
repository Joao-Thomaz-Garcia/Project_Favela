using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleScript : MonoBehaviour
{
    float[] spawnPositions = new float[3] { -2.5f, 0, 2.5f };
    void Start()
    {
        //StartAtPos();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void StartAtPos()
    {
        gameObject.transform.position = new Vector3(spawnPositions[Random.Range(0, 3)], 1.5f, 16f);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            StartAtPos();
        }

    }
}
