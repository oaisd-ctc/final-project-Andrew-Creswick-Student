using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlayerModel : MonoBehaviour
{
    FirstPersonCamera firstPersonCamera;

    // Start is called before the first frame update
    void Start()
    {
        firstPersonCamera = GetComponent<FirstPersonCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.rotation = Camera.main.transform.rotation;
    }
}
