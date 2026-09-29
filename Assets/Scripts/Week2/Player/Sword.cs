using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Sword : MonoBehaviour
{
    [SerializeField] private Transform swordTransform;
    [SerializeField] private float swordDistance = 1.2f;

    private Camera camera;
    private bool isAttacking = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        camera = Camera.main;
        swordTransform.gameObject.SetActive(false);
    }

    public void Attack()
    {
        isAttacking = true;

        Vector2 direction = MousePosition();
        
        swordTransform.localPosition = direction *  swordDistance;
        
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        swordTransform.localEulerAngles = new Vector3(0, 0, angle);
        
        swordTransform.gameObject.SetActive(true);
        StartCoroutine(EndAttack());
    }

    IEnumerator EndAttack()
    {
        yield return new WaitForSeconds(0.5f);
        isAttacking = false;
        swordTransform.gameObject.SetActive(false);
    }
    
    private Vector2 MousePosition()
    {
        Vector3 mouseCurrPos = Mouse.current.position.ReadValue();
        Vector3 mouseWorldPos = camera.ScreenToWorldPoint(mouseCurrPos);
        mouseWorldPos.z = 0f;
        return (mouseWorldPos - transform.position).normalized;
    }
}
