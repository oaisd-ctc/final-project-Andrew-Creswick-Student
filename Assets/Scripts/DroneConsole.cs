using KinematicCharacterController.Examples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneConsole : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Camera playerCamera;
    [SerializeField] ExamplePlayer playerMovementInputs;
    [SerializeField] CarBehaviour car;
    [SerializeField] Camera carCamera;
    [SerializeField] InputHandlerNoMovement standardInput;
    [SerializeField] bool ControllingDrone = false;
    
    public void TakeControl()
    {
        if(!ControllingDrone)
        {
            player.SetActive(false);
            playerCamera.gameObject.SetActive(false);
            playerMovementInputs.enabled = true;
            car.enabled = true;
            carCamera.enabled = true;
            ControllingDrone = true;
            standardInput.ControllingDrone = true;
        }
        else
        {
            player.SetActive(true);
            playerCamera.gameObject.SetActive(true);
            playerMovementInputs.enabled=true;
            car.enabled = false;
            carCamera.enabled = false;
            ControllingDrone = false;
            standardInput.ControllingDrone = false;
        }
    }
}
