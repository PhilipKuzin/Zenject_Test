using UnityEngine;
using System;
using Zenject;

public class Player : MonoBehaviour, IEnemyTarget
{

    private int _maxHealth;
    private int _currentHealth;
    public Vector3 Position => transform.position;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    [Inject]
    private void Construct (PlayerConfigs playerConfigs)
    {
        _currentHealth = _maxHealth = playerConfigs.MaxHealth;
        Debug.Log($"Health {_currentHealth}");
    }

    public void TakeDamage(int damage)
    {
        // проверка входящих значений
        // логика нанесения урона
    }
}
