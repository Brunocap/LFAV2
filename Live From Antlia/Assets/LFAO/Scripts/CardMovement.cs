using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardMovement : MonoBehaviour
{
       
    	 void OnMouseEnter()
        {
        transform.Translate(Vector3.forward * Time.deltaTime);

        transform.localScale += new Vector3(1, 1, 1);
        gameObject.layer = 8;
    }
         void OnMouseExit()
        {
        transform.Translate(Vector3.back * Time.deltaTime);

        transform.localScale += new Vector3(-1, -1, -1);
        gameObject.layer = 9;
    }

}
