using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class GameLevelManager : MonoBehaviour
//{
//    public Player1 player1;
//    public Player2 player2;
//    public string playerClass;

//    public GameObject avatarPrefab;

//    public Transform player1AvatarSpawn;
//    public Transform player2AvatarSpawn;

//    private void start()
//    {
//        playerSetup();
//        player2Setup();
//    }

//    private void playerSetup()
//    {
//        GameObject go = Instantiate(avatarPrefab, new Vector3(player1AvatarSpawn.position.x, player1AvatarSpawn.position.y, player1AvatarSpawn.position.z), Quaternion.identity);
//        Player1Display display = go.GetComponent<Player1Display>();
//        display.playerSetup(playerClass);
//    }

//    private void player2Setup()
//    {
//        GameObject go = Instantiate(avatarPrefab, new Vector3(player2AvatarSpawn.position.x, player2AvatarSpawn.position.y, player2AvatarSpawn.position.z), Quaternion.identity);
//        Player2Display display = go.GetComponent<Player2Display>();
//        display.player2Setup(player2Class);
//    }

//}
