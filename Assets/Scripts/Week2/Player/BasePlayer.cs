using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class BasePlayer : BaseCharacter
{
    [SerializeField] protected AudioClip hurtSoundClip;
    public UnityEvent<int> onHurtEvent;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        base.Start();
        if (onHurtEvent == null) 
            onHurtEvent = new UnityEvent<int>();
    }
    
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage);
        AudioManager.Instance.PlaySound(hurtSoundClip);

        if (currentHealth < 0) return;
        
        onHurtEvent.Invoke(currentHealth);
        StartCoroutine(Invincibility());
    }

    IEnumerator Invincibility()
    {
        isInvincible = true;
        yield return new WaitForSeconds(1f);
        isInvincible = false;
    }
}
