using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] InputAction playerControlls;
    [SerializeField] InputAction playerAttack;
    [SerializeField] InputAction ui;
    [SerializeField] float playerSpeed = 10f;
    [SerializeField] Sword sword;
    Rigidbody2D rb;
    Collider2D collider;
    Vector2 moveDirection;

    [SerializeField] private GameObject uiPanel;
    
    [SerializeField] private AudioClip swordSound;
    
    private void OnEnable()
    {
        playerControlls.Enable();
        playerAttack.Enable();
        ui.Enable();
    }

    private void OnDisable()
    {
        playerControlls.Disable();
        playerAttack.Disable();
        ui.Disable();
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<Collider2D>();
        sword = GetComponent<Sword>();
        uiPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = playerControlls.ReadValue<Vector2>();

        if (playerAttack.triggered)
        {
            Attack();
        }

        if (ui.triggered)
        {
            uiPanel.SetActive(!uiPanel.activeSelf);

            if (uiPanel.activeSelf)
            {
                Time.timeScale = 0;
            }
            else
            {
                Time.timeScale = 1;
            }
        }
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        rb.linearVelocity = playerSpeed *  moveDirection;
    }

    void Attack()
    {
        sword.Attack();
        AudioManager.Instance.PlaySound(swordSound);
    }
}
