using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buldingsController : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField]
    List<GameObject> goChild = new List<GameObject>();

    void Start()
    {
        foreach(Transform trans in gameObject.transform)
        {
            goChild.Add(trans.gameObject);
            foreach(Transform transChild in trans)
            {
                transChild.GetComponent<Rigidbody>().velocity = transform.forward * -speed;
            }
        }
        
        

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            speed = speed + 1;
            foreach (Transform transChild in goChild[0].gameObject.transform)
            {
                transChild.GetComponent<Rigidbody>().velocity = transform.forward * -speed;
            }
            foreach (Transform transChild in goChild[1].gameObject.transform)
            {
                transChild.GetComponent<Rigidbody>().velocity = transform.forward * -speed;
            }
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            speed = speed - 1;
            foreach (Transform transChild in goChild[0].gameObject.transform)
            {
                transChild.GetComponent<Rigidbody>().velocity = transform.forward * -speed;
            }
            foreach (Transform transChild in goChild[1].gameObject.transform)
            {
                transChild.GetComponent<Rigidbody>().velocity = transform.forward * -speed;
            }
        }
    }
}
