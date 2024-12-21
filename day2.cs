using UnityEngine;
//PlayerHealth
public class PlayerHealth : MonoBehaviour
{
    public int maxhealth = 100;
    private int currenthealth;

    void Start()
    {
        currenthealth = maxhealth;
    }
    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        Debug.Log("Health: " + currenthealth);
        if (currenthealth <= 0){
            Die();
        }
    }
    void Die(){
        Debug.Log("Player Died")
        Destroy(gameobject);
    }

}