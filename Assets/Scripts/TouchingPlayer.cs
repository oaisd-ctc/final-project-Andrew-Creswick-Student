using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class TouchingPlayer : MonoBehaviour
{
    public PlayerInteraction playerInteraction;
    public Transform Player;
    public UnityEvent OnPlayerTouch = new UnityEvent();
    public GameManager gameManager;
    public CarBehaviour carBehaviour;
    public Transform carTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        playerInteraction = FindAnyObjectByType<PlayerInteraction>();
        Player = playerInteraction.gameObject.transform;
        carBehaviour = FindAnyObjectByType<CarBehaviour>();
        carTransform = carBehaviour.gameObject.transform;
        gameManager = FindAnyObjectByType<GameManager>();
        
    }
    private void Update()
    {
        if (Vector3.Distance(transform.position, Player.position) < 1.5)
        { 
            OnPlayerTouch.Invoke();
            gameManager.LoadScene("GameOver");
            gameManager.GrabMouse(false);
        }
        if (carTransform != null)
        {
            if (Vector3.Distance(transform.position, carTransform.position) < 1.5)
            {
                Destroy(carBehaviour.gameObject);
            }
        }
        
    }
}
