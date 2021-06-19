using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Collider2D _previousEnemyCollider;

    private void Update()
    {
        _previousEnemyCollider = Physics2D.OverlapPoint(transform.position);

        if (_previousEnemyCollider != null && _previousEnemyCollider != GetComponent<Collider2D>())
            Destroy(gameObject);
    }
}
