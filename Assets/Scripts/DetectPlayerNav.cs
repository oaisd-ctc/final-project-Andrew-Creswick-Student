using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class DetectPlayerNav : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent agent;
    public float distance;
    [SerializeField] float minimumDistance = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(this.transform.position, Player.position);
        if(distance < minimumDistance)
        {
            agent.destination=Player.position;
        }
    }
}
