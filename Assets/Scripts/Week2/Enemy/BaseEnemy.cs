using System.Collections;
using UnityEngine;


public abstract class BaseEnemy : BaseCharacter
{
    [SerializeField] protected int damage;
    [SerializeField] protected float moveSpeed;
    private Collider2D collider;

    protected Transform player;
    protected Rigidbody2D rb;
    
    [SerializeField] protected AudioClip hurtSound;
    [SerializeField] protected AudioClip deathSound;

    protected virtual void Start()
    {
       base.Start();
       player = GameObject.FindWithTag("Player").transform;
    }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            BaseCharacter player = collision.gameObject.GetComponent<BaseCharacter>();
            player.TakeDamage(damage);
        }
    }
    
    public override void TakeDamage(int damage)
    {
        if (isInvincible) return;
        
        base.TakeDamage(damage);
        AudioManager.Instance.PlaySound(hurtSound);
        StartCoroutine(Invincibility());
    }

    IEnumerator Invincibility()
    {
        isInvincible = true;
        yield return new WaitForSeconds(0.5f);
        isInvincible = false;
    }

    protected override void Death()
    {
        base.Death();
        AudioManager.Instance.PlaySound(deathSound);
        Destroy(gameObject);
    }
}
