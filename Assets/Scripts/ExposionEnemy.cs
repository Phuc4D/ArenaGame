using UnityEngine;

public class ExposionEnemy : Enemy
{
    [SerializeField] private GameObject explosionEffect;

    protected override void Start()
    {
        maxHealth = 50f; // Thiết lập máu tối đa cho HealEnemy
        base.Start();
    }

    protected override void Die()
    {
        Explode();
        base.Die();
    }
    private void Explode()
    {
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
        }
    }
}
