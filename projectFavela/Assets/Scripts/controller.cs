using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{


    //Movement
    [SerializeField]
    float speed = 1f;
    [SerializeField]
    Vector3 targetLane;

    //Score
    [SerializeField]
    bool isAlive;

    [SerializeField]
    float scoreAcount;
    [SerializeField]
    float scoreTimer;
    [SerializeField]
    float scoreMultiplier = 1f;

    [SerializeField]
    Text pointsTxt;

    void Start()
    {
        targetLane = transform.position;
        isAlive = true;
    }

    void Update()
    {
        while (isAlive)
        {
            ChoseLanes();
            MultiplyScore();

            break;
        }


    }
    private void FixedUpdate()
    {
        while (isAlive)
        {
            transform.position = Vector3.Lerp(transform.position, targetLane, speed * Time.deltaTime);
            GatherScore();

            break;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject)
        {
            print(scoreAcount);
            SceneManager.LoadScene(0);

        }
    }

    void ChoseLanes()
    {
        if (Input.GetKeyDown(KeyCode.D) & targetLane.x < 2.5f)
        {
            targetLane = targetLane + new Vector3(2.5f, 0, 0);

        }
        if (Input.GetKeyDown(KeyCode.A) & targetLane.x > -2.5f)
        {
            targetLane = targetLane - new Vector3(2.5f, 0, 0);

        }
    }

    void GatherScore()
    {
        scoreTimer += Time.fixedDeltaTime;
        if(scoreTimer >= 1f)
        {
            scoreAcount += 100f * scoreMultiplier;
            pointsTxt.text = scoreAcount.ToString("F2");
            scoreTimer = 0;
        }
    }

    void MultiplyScore()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, transform.forward * 2f, out hit))
        {
            /*if (hit.transform.gameObject.layer == 6)
            {
               print(hit.transform.gameObject.layer + " " + hit.transform.gameObject.name);
               scoreMultiplier++;

            }*/
        }
        Debug.DrawRay(transform.position, transform.forward * 1f, Color.blue);

    }

}
