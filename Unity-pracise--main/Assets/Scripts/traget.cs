
using UnityEngine;

public class traget : MonoBehaviour
{
    public float health = 50f;
    float amount;

    public void TakeDamege(float amount) {
        health -= amount;
        if (health <= 0f) {
            Die();
        }
    }
    public void Die() {
        Destroy(gameObject);  
    }
}
