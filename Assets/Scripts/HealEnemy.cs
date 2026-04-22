using UnityEngine;

public class HealEnemy : Enemy
{

    [SerializeField] private float healValue = 10f; // Số lượng máu được hồi phục\
    protected override void Start()
    {        maxHealth = 40f; // Thiết lập máu tối đa cho HealEnemy

        base.Start();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        damage = 20f;
    }

    protected override void Die()
    {
        HealPlayer();
        base.Die();

    }
    private void HealPlayer()
    {
        if (player != null)
        {
            player.Heal(healValue);
        }
    }
}
