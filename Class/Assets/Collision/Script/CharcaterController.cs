using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharcaterController : MonoBehaviour
{
    bool condition;
    public float speed;

    Rigidbody rigid;
    Vector3 direction;


    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

  
    void Update()
    {
        direction.x = Input.GetAxis("Horziontal");
        direction.z = Input.GetAxis("Vertical");

        if(Input.GetKeyDown(KeyCode.Space) && condition == true)
        {
            rigid.AddForce(new Vector3(0, 200, 0));
            condition = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        condition = true;
    }

    private void OnCollisionStay(Collision collision)
    {
        transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }



    private void OnCollisionExit(Collision collision)
    {
        condition = false;
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
    }

}
