using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
        [SerializeField] private int health = 100;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }
    void Start()
    {

    }

    void Update()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        Vector2 playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb.linearVelocity = playerInput.normalized * _speed;
        if (playerInput.x < 0)
        {
            spriteRenderer.flipX = true;
        }
        else if (playerInput.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        // Thay vì viết cả cụm if/else dài dòng
        animator.SetBool("isRun", playerInput != Vector2.zero);
    }
        public virtual void TakeDamage()
    {
        // Xử lý khi nhân vật bị tấn công
        Die();
    }
    public virtual void Die()
    {
        // Xử lý khi nhân vật bị tấn công
        Destroy(gameObject);
    }
}
