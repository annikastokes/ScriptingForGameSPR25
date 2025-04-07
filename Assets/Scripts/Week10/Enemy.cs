using System.Runtime.CompilerServices;
using UnityEngine;
using System.Collections.Generic;   
using UnityEngine.AI;
using System.Transactions;

public class Enemy : MonoBehaviour
{

    public int health;
    public int attackDamage;
    public float attackRange;

    protected Player player;

    public float attackSpeed;

    private float attackTimer;

    protected NavMeshAgent navAgent;

    protected bool hasSeenPlayer = false;

    [SerializeField]
    protected float aggroRange = 30f;

    [SerializeField]
    protected List<Transform> patrolPoints = new List<Transform>();

    protected int patrolPointIndex = 0;

    protected virtual void Start()
    {
        player = FindAnyObjectByType<Player>();
        navAgent = GetComponent<NavMeshAgent>();
        navAgent.SetDestination(patrolPoints[patrolPointIndex].position);
    }
    protected virtual void Update()
    {
        if (hasSeenPlayer == true)
        {
            if (navAgent.remainingDistance < 0.5f) //enemy reached the player's Last KNOWN location
            {
                if (Vector3.Distance(transform.position, player.transform.position) > aggroRange) //if the player is further than aggrorange, 
                {
                    hasSeenPlayer = false; //enemy can't see the player anymore, and will be forced to return to patroling
                }
                else //meaning the player isn't out of aggrorange
                {
                    if (IsPlayerInLOS() == true) //if the player is in LOS,
                    {
                        navAgent.SetDestination(player.transform.position); //the enemy will continue to chase them
                        navAgent.isStopped = false; //make sure enemy is allowed to move

                    }
                    else //if the player is within range, but not within LOS...
                    {
                        hasSeenPlayer = false;
                        navAgent.isStopped = false;
                    }
                }
            }

            //if player is within attack range
            if (Vector3.Distance(this.transform.position, player.transform.position) > attackRange)
            {
                //AND in the line of sight
                if (IsPlayerInLOS() == true)
                {
                    //chase the player
                    navAgent.SetDestination(player.transform.position);
                    //make sure enemy is allowed to move!
                    navAgent.isStopped = false;
                }

            }
            else
            { //if player is within attack ragne
                if (IsPlayerInLOS() == true) //and is in the LOS
                {
                    navAgent.isStopped = true; //stop the nav movement
                    this.transform.LookAt(player.transform.position); //keep looking at the player

                    attackTimer += Time.deltaTime; //increase the attack timer

                    if (attackTimer > attackSpeed) //once the attack timer reaches 0
                    {
                        Attack();
                        attackTimer = 0;
                    }
                }
            }


            if (Vector3.Distance(this.transform.position, player.transform.position) > attackRange)
            {

                RaycastHit hit;

                Vector3 dir = player.transform.position - this.transform.position;
                dir.Normalize();

                if (Physics.Raycast(this.transform.position, dir, out hit))
                {
                    if (hit.collider.tag == "Player")
                    {
                        navAgent.SetDestination(player.transform.position);
                        navAgent.isStopped = false;
                    }
                }
            }
            else
            {
                RaycastHit hit;

                Vector3 dir = player.transform.position - this.transform.position;
                dir.Normalize();

                if (Physics.Raycast(this.transform.position, dir, out hit))
                {
                    if (hit.collider.tag == "Player")
                    {

                        navAgent.isStopped = true;
                        this.transform.LookAt(player.transform.position);

                        attackTimer += Time.deltaTime;

                        if (attackTimer > attackSpeed)
                        {
                            Attack();
                            attackTimer = 0;
                        }

                    }
                    else
                    {
                        navAgent.SetDestination(player.transform.position);
                        navAgent.isStopped = false;

                    }
                }

            }

        }
        else //if th player has not beem seen
        {
            if (navAgent.remainingDistance < 0.5f) //if the navagent reaches its destination
            {
                patrolPointIndex++; //increase the patrol point index so it will move to the next patrol ponit

                if (patrolPointIndex >= patrolPoints.Count) //if the patrol point index is out of range
                {
                    patrolPointIndex = 0; //reset it to 0 so that it will go back to the first point
                }

                navAgent.SetDestination(patrolPoints[patrolPointIndex].position); //setdestination to determined point
                navAgent.isStopped = false;
            }
        }

    }

    protected virtual void Attack()
    {
        //call attack animation, or deal damage to player
        player.TakeDamage(attackDamage);

    }

    public void TakeDamage(int damageTaken)
    {
        health -= damageTaken;
    }

    public void Die()
    {
        //call death animation or destroy object
    }

    public void SeePlayer()
    {
        if (IsPlayerInLOS() == true)
        {
       hasSeenPlayer = true;
        }
    }

    protected bool IsPlayerInLOS()
    {
        RaycastHit hit;

        Vector3 dir = player.transform.position - this.transform.position;
        dir.Normalize();

        if (Physics.Raycast(this.transform.position, dir, out hit))
        {
            if (hit.collider.tag == "Player")
            {
                return true;

            }
        }
        return false;
    }
}
