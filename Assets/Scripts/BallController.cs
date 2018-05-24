using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
    public float speedBall = 8f;
    //ball's components
    Rigidbody rb;
    Vector3 spawDir;
    // Use this for initialization

    void LauchBall() {
        //Ball direction

        int rand = Random.Range(1, 4);
        if (rand == 1)
        {
            spawDir = new Vector3(1f, 1f, 0f);

        }
        else if (rand == 2)
        {
            spawDir = new Vector3(1f, -1f);


        }
        else if (rand == 3)
        {
            spawDir = new Vector3(-1f, 1f, 0f);


        }
        else if (rand == 4)
        {

            spawDir = new Vector3(-1f, -1f, 0f);

        }
        rb.velocity = (spawDir * speedBall);

    }
    void Start () {

        rb = this.gameObject.GetComponent<Rigidbody>();
        StartCoroutine(WaitLauch());



    }

    IEnumerator WaitLauch() {

        transform.position = Vector3.zero;
        rb.velocity = Vector3.zero;
        yield return new WaitForSeconds(2.5f);
        LauchBall();

        Debug.Log("OKKKKKKKKX");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Goal_Player1")
        {
            Scoreboard_Controller.instance.GiveAPointPlayerTwo();
        StartCoroutine(WaitLauch());




        }
        if (other.gameObject.name == "Goal_Player2")
        {
            Scoreboard_Controller.instance.GiveAPointPlayerOne();

            StartCoroutine(WaitLauch());




        }

    }
    void OnCollisionEnter(Collision col)
    {
       
        //Left Bat Direction of ball
        if (col.gameObject.name == "Left_Bat")
        {

            float left_bat_y = col.transform.position.y;
            float ball_y = this.transform.position.y;
            float ball_half = ball_y - left_bat_y;

            if (ball_half > 0.1)
            {
                rb.velocity = new Vector3(speedBall, speedBall, 0f);

            }
            else if (ball_half < -0.1)
            {
                rb.velocity = new Vector3(speedBall, -speedBall, 0f);
            }
            else
            {
                rb.velocity = new Vector3(speedBall, 0f, 0f);
            }
        }


        //Right Bat Direction of ball
        if (col.gameObject.name == "Right_Bat")
        {

            float right_bat_y = col.transform.position.y;
            float ball_y = this.transform.position.y;
            float ball_half = ball_y - right_bat_y;

            if (ball_half > 0.1)
            {
                rb.velocity = new Vector3(-speedBall, speedBall, 0f);

            }
            else if (ball_half < -0.1)
            {
                rb.velocity = new Vector3(-speedBall, -speedBall, 0f);
            }
            else
            {
                rb.velocity = new Vector3(-speedBall, 0f, 0f);
            }
        }


  
    }



    // Update is called once per frame
    void Update () {
          

        //transform.Translate(speedBall * Time.deltaTime, speedBall * Time.deltaTime, 0f);

    }

  
}
