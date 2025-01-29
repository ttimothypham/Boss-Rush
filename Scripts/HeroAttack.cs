using UnityEngine;

public class HeroAttack : MonoBehaviour
{
    public int attackDamage = 10;
    public float attackRange = .5f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            MeleeAttack();
        }
    }

    void MeleeAttack()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, attackRange);
        foreach (Collider hitCollider in hitColliders)
        {
            if (hitCollider.CompareTag("Boss"))
            {
                hitCollider.GetComponent<Health>().TakeDamage(attackDamage);
                Debug.Log("Hero attacked the Boss!");
            }
        }
    }

}
