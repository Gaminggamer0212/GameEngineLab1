using UnityEngine;

public class Octorok : BaseEnemy
{
    protected virtual void Start()
    {
        base.Start();
        rb = GetComponent<Rigidbody2D>();
    }
    
    protected virtual void FixedUpdate()
    {
        if (isDead) return;
        MoveTowardsPlayer();
    }

    protected virtual void MoveTowardsPlayer()
    {
        Vector2 direction = (player.position - transform.position).normalized;
        rb.linearVelocity = direction * moveSpeed;
    }

}
