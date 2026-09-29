using UnityEngine;

public class SwordHitbox : MonoBehaviour
{
    [SerializeField] private int damage = 1;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            BaseCharacter  character = other.GetComponent<BaseCharacter>();
            if (character != null)
            {
                character.TakeDamage(damage);
            }
        }
    }
}
