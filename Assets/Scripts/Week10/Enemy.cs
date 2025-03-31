using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health;
    public int attackDamage;
    public float attackRange;

    protected Player player;

    public float attackSpeed;

    private float attackTimer;

    protected virtual void Start()
    {
        player = FindAnyObjectByType<Player>();
    }
    protected virtual void Update()
    {
        if (Vector3.Distance(this.transform.position, player.transform.position) < attackRange)
        {
            attackTimer += Time.deltaTime;

            if (attackTimer > attackSpeed)
            {
                Attack();
                attackTimer = 0;
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
}
