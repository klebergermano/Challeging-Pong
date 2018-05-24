using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input_Controller : MonoBehaviour {

    public float speedBats; 

    public GameObject leftBat;
    public GameObject rightBat;




    // Use this for initialization
    void Start() {



    }

 

    // Update is called once per frame
    void Update() {


        //Controller LeftBat


        // leftBat.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);

     

        if (Input.GetKey(KeyCode.W) && leftBat.transform.position.y < 3.62f)
            {
                leftBat.transform.Translate(0f, speedBats * Time.deltaTime, 0f);
 
        }

        if (Input.GetKey(KeyCode.S) && leftBat.transform.position.y > -3.60f)
            {
                leftBat.transform.Translate(0f, -speedBats * Time.deltaTime, 0f);



        }

        if (Input.GetKey(KeyCode.UpArrow) && rightBat.transform.position.y < 3.62f)
        {
            rightBat.transform.Translate(0f, speedBats * Time.deltaTime, 0f);


        }

        if (Input.GetKey(KeyCode.DownArrow) && rightBat.transform.position.y > -3.60f)

        {
            rightBat.transform.Translate(0f, -speedBats * Time.deltaTime, 0f);


        }

    }




}
