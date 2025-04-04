using UnityEngine;
public interface IDamageable
{
    Vector3 Position { get; }
    void Damage(float damage);
}
public class PlayerHealth : MonoBehaviour, IDamageable
{
    public float startingHealth = 100f;
    float m_CurrentHealth;
    [SerializeReference]
    public IDamageable shield = new ProtonShield();
    Vector3 Position
    {
        get
        {
            return transform.position;
        }
    }

    Vector3 IDamageable.Position => Position;

    void Start()
    {
        m_CurrentHealth = startingHealth;
    }
    public void Damage(float damage)
    {
        m_CurrentHealth -= damage;
    }
   
}
public class ProtonShield : IDamageable
{
    public float hitPoints = 10f;
    public Vector3 Position { get; }
    public void Damage(float damage)
    {
        hitPoints -= damage;
    }
}

