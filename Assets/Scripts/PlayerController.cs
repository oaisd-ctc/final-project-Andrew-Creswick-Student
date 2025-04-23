using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    public GameObject Bolt;
    public float targetTime = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        camera1.enabled = true;
    }

    // Update is called once per frame
    private float speed = 5.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    private float verticalInput;
    private float fireInput;
    private float switchCamera;
    public Camera camera1;
    public Camera camera2;
    
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Forward");
        verticalInput = Input.GetAxis("Up");
        fireInput = Input.GetAxis("Fire1");
        switchCamera = Input.GetAxis("SwitchCamera");
        // Move the vehicle Forward
        transform.Translate(Vector3.forward * Time.deltaTime* speed*forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime* turnSpeed * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * (speed * 2)* verticalInput);
        if(fireInput != 0)
        {

            GameObject Clone = (GameObject)Instantiate(Bolt, transform.position, Quaternion.identity) as GameObject;
            Clone.transform.position = new Vector3(3, 0, 0);
            Clone.transform.SetParent(transform.parent, false);
            Destroy(Clone, targetTime);
        }
        if(switchCamera >=1)
        {
            if(camera1.isActiveAndEnabled) 
            {
                camera1.enabled = false;
                camera2.enabled = true;
            }
            if (camera2.isActiveAndEnabled)
            {
                camera2.enabled = false;
                camera1.enabled = true;
            }
        }
        
    }
}
