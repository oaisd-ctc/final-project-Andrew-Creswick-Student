using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class DetectPlayerNav : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent agent;
    public Animator animator;
    public float distance;
    [SerializeField] float minimumDistance = 10.0f;
    [SerializeField] bool FollowingPlayer = false;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator= GetComponent<Animator>();
        if (animator)
        {
            animator.SetBool("isFollowingPlayer", FollowingPlayer);
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(this.transform.position, Player.position);
        if(distance < minimumDistance)
        {
            agent.destination=Player.position;
            FollowingPlayer = true;
            UseAnimator();
        }
        else
        {
            FollowingPlayer = false;
            UseAnimator();
        }
    }
    private void UseAnimator()
    {
        if (animator)
        {
           animator.SetBool("isFollowingPlayer", FollowingPlayer);
        }
    }
}
