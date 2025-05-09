using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DidPlayerFallMap : MonoBehaviour
{
    private PlayerInteraction playerInter;
    private GameManager gameManager;
    private Transform playerTrans;
    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        playerInter = FindAnyObjectByType<PlayerInteraction>();
        playerTrans = playerInter.gameObject.transform;
    }
    // Update is called once per frame
    // How did we get here?
    void Update()
    {
        if(playerTrans.position.y < -100)
        {
            gameManager.LoadScene("GameOver");
            gameManager.GrabMouse(false);
            Debug.Log("How did we get here?");
        }
    }
}
