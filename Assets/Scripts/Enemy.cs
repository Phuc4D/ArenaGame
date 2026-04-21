using System;
using UnityEngine;
using UnityEngine.UI;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] protected float enemyMoveSpeed = 1f;
    [SerializeField] protected float maxHealth = 50f;
    protected float currentHealth = 50f;
     [SerializeField]private Image hpBar;
    protected Player player;
    protected float damage;
    protected virtual void Start()
    {
        player = FindAnyObjectByType<Player>();
        currentHealth = maxHealth;
                UpdateHpBar();

    }
    protected virtual void Update()
    {
        MoveToPlayer();
    }
    protected void MoveToPlayer()
    {
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, enemyMoveSpeed * Time.deltaTime);
            FlipEnemy();
        }
    }
    protected void FlipEnemy()
    {
        if (player != null)
        {
            transform.localScale = new Vector3(player.transform.position.x < transform.position.x ? -1 : 1, 1, 1);
        }
    }
    public virtual void TakeDamage(float damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
        UpdateHpBar();
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    protected virtual void Die()
    {
        Destroy(gameObject);
    }
    protected void UpdateHpBar()
    {
        if(hpBar!= null)
        {
            hpBar.fillAmount = currentHealth/maxHealth;
        }
    }
private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.TakeDamage(damage);
            Die();
        }
    }


}
