using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public static Action OnTouch;

    private float _health = 100f;
    private float _minHealht = 0f;
    private float _maxHealth = 100f;
    private float _valueHealth = 10f;

    public float Health => _health;
    public float MinHealth => _minHealht;
    public float MaxHealth => _maxHealth;

    public void IncreaseHealth()
    {
        _health = Mathf.Clamp(_health += _valueHealth, _minHealht, _maxHealth);
        OnTouch?.Invoke();
    }
    public void TakeDamage()
    {
        _health = Mathf.Clamp(_health -= _valueHealth, _minHealht, _maxHealth);
        OnTouch?.Invoke();
    }
}