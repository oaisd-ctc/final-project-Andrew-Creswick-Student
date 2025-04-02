using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Projectile : MonoBehaviour
{
    public Rigidbody rigidBody;
    public GameObject explosionPrefab;
    public float forceAmount = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        Vector3 forceDirection = transform.forward;
        rigidBody.AddForce (forceDirection * forceAmount, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        //print("Collides with "+ collision.gameObject.name);
        if(collision.gameObject.CompareTag("Castle"))
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            //Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
