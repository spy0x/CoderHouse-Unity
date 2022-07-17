using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Vector3 initialDirection = Vector3.forward;
    public Vector3 currentDirection;
    public float speed = 1f;

    void Start()
    {
        currentHealth = maxHealth;
        int damageTestValue = 50;
        Damage(damageTestValue);
        int healTestValue = 10;
        Heal(healTestValue);
        SetDirection(initialDirection);
    }
    private void Update()
    {
        transform.position += currentDirection * speed * Time.deltaTime;
    }
    private void SetDirection(Vector3 newDirection)
    {
        currentDirection = newDirection;
        Debug.Log("Current Vector Direction: " + currentDirection);
    }
    private void Heal(int hpAmount)
    {
        currentHealth += hpAmount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        DisplayHPStatus();
    }
    private void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        DisplayHPStatus();
    }
    private void DisplayHPStatus()
    {
        Debug.Log("HP: " + currentHealth + "/" + maxHealth);
    }
}
