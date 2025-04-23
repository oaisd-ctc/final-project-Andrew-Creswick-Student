using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    [SerializeField] private float teleportX = 0f;
    [SerializeField] private float teleportY = 0f;
    [SerializeField] private float teleportZ = 0f;
    public GameObject player;
    private Vector3 teleport = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        teleport.x = teleportX;
        teleport.y = teleportY;
        teleport.z = teleportZ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Teleport()
    {
        player.transform.position = teleport;
        Debug.Log("I teleported!");
    }
}
