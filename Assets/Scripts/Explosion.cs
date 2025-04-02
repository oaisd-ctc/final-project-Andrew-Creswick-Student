using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float force, radius, modifier;
    public GameObject explosionFX;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyExplosion", 0.1f);
        Instantiate(explosionFX, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if(rb)
        {
            rb.AddExplosionForce(force, transform.position, radius, modifier, ForceMode.VelocityChange);
        }
    }
    void DestroyExplosion()
    {
        Destroy(gameObject);
    }
}
