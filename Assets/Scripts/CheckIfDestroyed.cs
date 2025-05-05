using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIfDestroyed : MonoBehaviour
{
    // Start is called before the first frame update
    [Tooltip("Drone Console that is being used to control this car.")]
    [SerializeField] private DroneConsole droneConsole;
    void Start()
    {
        droneConsole = FindAnyObjectByType<DroneConsole>();
    }
    private void OnDestroy()
    {
        if (droneConsole.ControllingDrone)
        {
            droneConsole.TakeControl();
        }
        droneConsole.CanControlDrone = false;
    }
}
