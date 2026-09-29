using UnityEngine;

public abstract class BaseCharacter : MonoBehaviour
{
    [SerializeField] protected int maxHealth;
    [SerializeField] protected int currentHealth;
    protected bool isInvincible = false;
    protected bool isDead = false;

    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }
    
    public virtual void TakeDamage(int damage)
    {
        if (isInvincible) return;
        
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Death();
        }
    }
    
    protected virtual void Death()
    {
        isDead = true;
        Debug.Log(gameObject.name + " died");
    }
}
