using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class DetectPlayerNav : MonoBehaviour
{
    public PlayerInteraction playerInteraction;
    public Transform Player;
    public NavMeshAgent agent;
    public Animator animator;
    public float distance;
    [SerializeField] float minimumDistance = 10.0f;
    [SerializeField] bool FollowingPlayer = false;
    [SerializeField] bool PlayerNotInDrone = false;
    [SerializeField] InputHandlerNoMovement playerInputHandler;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator= GetComponent<Animator>();
        if (animator)
        {
            animator.SetBool("isFollowingPlayer", FollowingPlayer);
        }
        playerInteraction = FindAnyObjectByType<PlayerInteraction>();
        playerInputHandler = FindAnyObjectByType<InputHandlerNoMovement>();
        Player = playerInteraction.gameObject.transform;

    }

    // Update is called once per frame
    void Update()
    {
        PlayerNotInDrone = playerInputHandler.ControllingDrone;
        distance = Vector3.Distance(this.transform.position, Player.position);
        if (distance < minimumDistance && PlayerNotInDrone == false)
        {
            agent.destination = Player.position;
            FollowingPlayer = true;
            UseAnimator();
        }
        else
        {
            FollowingPlayer = false;
            UseAnimator();
        }
        if (PlayerNotInDrone == false)
        {
            agent.isStopped = false;
        } else
        {
            agent.isStopped = true;
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
