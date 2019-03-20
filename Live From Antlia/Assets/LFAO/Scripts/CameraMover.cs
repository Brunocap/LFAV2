using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {

    public void moveCameraUp()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 4.0f, transform.position.z);
    }
    public void moveCameraDown()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 4.0f, transform.position.z);
    }
}
