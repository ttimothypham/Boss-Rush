using UnityEngine;

public class BossAI : MonoBehaviour
{
    public Transform hero;
    public float speed = 2f;
    public int attackDamage = 10;
    public float attackRange = .5f;
    public float attackCooldown = 1f;

    private float attackTime;

    void Update()
    {
        Vector3 direction = (hero.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;

        if (Vector3.Distance(transform.position, hero.position) <= attackRange && Time.time > attackTime + attackCooldown)
        {
            AttackHero();
        }
    }

    void AttackHero()
    {
        attackTime = Time.time;
        hero.GetComponent<Health>()?.TakeDamage(attackDamage);
        Debug.Log("Boss attacked the Hero!");
    }

}
