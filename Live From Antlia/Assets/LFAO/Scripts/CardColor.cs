using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardColor : CardDisplay {

    public Sprite integrity; // I attched these from editor
    public Sprite popularity;
    public Sprite funds;
    public Sprite stress;
    public Sprite trap;


    public void Start()
    {
        if (costType.text == "integrity")
        {
            GetComponent<Image>().sprite = integrity;

        }
        if (costType.text == "funds")
        {
            GetComponent<Image>().sprite = funds;
        }
        if (costType.text == "popularity")
        {
            GetComponent<Image>().sprite = popularity;
        }
        if (card.isTrap) //Not Working - Redo
        {
            GetComponent<Image>().sprite = trap;
        }
        //else
        //{
        //    GetComponent<Image>().sprite = stress;
        //}

    }
}
