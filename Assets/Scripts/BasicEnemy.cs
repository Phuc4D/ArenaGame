using UnityEngine;

public class BasicEnemy : Enemy
{
    protected override void Start()
    {
        maxHealth = 50f; // Thiết lập máu tối đa cho BasicEnemy
               base.Start();
        damage = 10f; // Thiết lập sát thương cho BasicEnemy
    }
    
}
