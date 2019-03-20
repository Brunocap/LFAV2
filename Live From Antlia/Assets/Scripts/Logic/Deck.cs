using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : MonoBehaviour {

    public List<CardAsset> cards = new List<CardAsset>();
    //public List<Card> cards = new List<Card>();

    void Awake()
    {
        cards.Shuffle();
    }
	
}
