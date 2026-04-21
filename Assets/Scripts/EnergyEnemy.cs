using UnityEngine;

public class EnergyEnemy : Enemy
{    [SerializeField] private GameObject energyOrb;

      protected override void Start()
    {
        base.Start();
        damage = 20f; // Thiết lập sát thương cho BasicEnemy
    }
    protected override void Die()
    {
        base.Die();
        GameObject orb = Instantiate(energyOrb, transform.position, Quaternion.identity);
        Destroy(orb, 5f); // Hủy quả cầu năng lượng sau 5 giây nếu không được thu thập
    }
}
