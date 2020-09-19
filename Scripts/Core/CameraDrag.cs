using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraDrag : MonoBehaviour
{
    public Camera cameraObj;
    public GameObject myGameObj;
    public float speed = 2f;

    void Update()
    {
        RotateCamera();
    }

    void RotateCamera()
    {
        if (Input.GetMouseButton(0))
        {
            cameraObj.transform.RotateAround(myGameObj.transform.position,
                                            cameraObj.transform.up,
                                            -Input.GetAxis("Mouse X") * speed);

            cameraObj.transform.RotateAround(myGameObj.transform.position,
                                            cameraObj.transform.right,
                                            -Input.GetAxis("Mouse Y") * speed);
        }
    }
}
