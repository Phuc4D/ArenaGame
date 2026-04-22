using UnityEngine;

public class ExplosionEFfect : MonoBehaviour
{
    [SerializeField] private float damage = 20f;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        Player player = collision.GetComponent<Player>();
        if (collision.CompareTag("Enemy") || collision.CompareTag("Player"))
        {
            enemy.TakeDamage(damage);
            player.TakeDamage(damage);
        }
    }
    public void OnDestroy()
    {
        Destroy(gameObject);
    }



}

