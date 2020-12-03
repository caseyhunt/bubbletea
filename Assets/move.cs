using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{

    public Vector2 startPos;
    public Vector2 direction;

    public GameObject teaCup;
    public Camera teaCam;
    string message;
    bool hasShot;
    List<GameObject> References;
    int count;
    public Text y_text;
    public Text x_text;

    void Start()
    {
        hasShot = false;
        References = new List<GameObject>();
        count = 0;
    }



    void Update()
    {
        Quaternion camrot = teaCam.transform.rotation;
        Vector3 camloc = teaCam.transform.position;
        float xRot = -camrot.x*30;
        float yRot = camrot.y;
        float zRot = camrot.z;
        Quaternion tarRot = Quaternion.Euler(Quaternion.identity.x, Quaternion.identity.y, 21);
        teaCup.GetComponent<Rigidbody>().AddTorque(Quaternion.identity.x,Quaternion.identity.y , xRot);
        y_text.text = yRot.ToString();
        x_text.text = xRot.ToString();

        // Track a single touch as a direction control.
        //    if (Input.touchCount > 0)
        //    {
        //        Touch touch = Input.GetTouch(0);

        //        // Handle finger movements based on TouchPhase
        //        switch (touch.phase)
        //        {
        //            //When a touch has first been detected, change the message and record the starting position
        //            case TouchPhase.Began:
        //                Vector3 sphereStart = camloc + new Vector3(0, 0f, 1.2f);
        //                GameObject clone;
        //                clone = Instantiate(projectile, sphereStart, transform.rotation);
        //                clone.gameObject.tag = "ball";
        //                References.Add(clone);
        //                References[count].GetComponent<Rigidbody>().AddForce(new Vector3(Mathf.Sin(yRot) * 18, -Mathf.Sin(xRot) * 15, 10) * shootForce);

        //                //References[count].GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 10) * shootForce);
        //                count++;

        //                if (count % 3 == 0)

        //                {
        //                    foreach (GameObject shot in References)
        //                    {
        //                        Destroy(shot);
        //                    }
        //                }
        //                break;



        //    }
        //}



    }
}
