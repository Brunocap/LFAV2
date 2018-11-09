using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject AttackCardPrefab;
    public GameObject BoostCardPrefab;
    public GameObject TrapCardPrefab;
    public GameObject InstantCardPrefab;
    public GameObject StressCardPrefab;

    public AttackCard[] attackCards;
    public BoostCard[] boostCards;
    public TrapCard[] trapCards;
    public InstantCard[] instantCards;
    public StressCard[] stressCards;

    public Vector3[] spawnPoints;
    private void Start()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            int cardtype = Random.Range(0, 5);

            if (cardtype == 0)
            {
                GameObject go = Instantiate(AttackCardPrefab, spawnPoints[i], Quaternion.identity);
                AttackCardDisplay display = go.GetComponent<AttackCardDisplay>();
                display.cardSetup(attackCards[Random.Range(0, attackCards.Length)]);
            }

            if (cardtype == 1)
            {
                GameObject go = Instantiate(BoostCardPrefab, spawnPoints[i], Quaternion.identity);
                BoostCardDisplay display = go.GetComponent<BoostCardDisplay>();
                display.cardSetup(boostCards[Random.Range(0, boostCards.Length)]);
            }

            if (cardtype == 2)
            {
                GameObject go = Instantiate(TrapCardPrefab, spawnPoints[i], Quaternion.identity);
                TrapCardDisplay display = go.GetComponent<TrapCardDisplay>();
                display.cardSetup(trapCards[Random.Range(0, trapCards.Length)]);
            }

            if (cardtype == 3)
            {
                GameObject go = Instantiate(InstantCardPrefab, spawnPoints[i], Quaternion.identity);
                InstantCardDisplay display = go.GetComponent<InstantCardDisplay>();
                display.cardSetup(instantCards[Random.Range(0, instantCards.Length)]);
            }

            if (cardtype == 4)
            {
                GameObject go = Instantiate(StressCardPrefab, spawnPoints[i], Quaternion.identity);
                StressCardDisplay display = go.GetComponent<StressCardDisplay>();
                display.cardSetup(stressCards[Random.Range(0, stressCards.Length)]);
            }
        } 

    }
    
}
