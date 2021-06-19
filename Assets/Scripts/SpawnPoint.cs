using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    public void SpawnEnemy()
    {
        var recentEnemy = Instantiate(_enemy, transform.position, Quaternion.identity);

        SpriteRenderer recentSR = recentEnemy.GetComponent<SpriteRenderer>();

        recentSR.color = Random.ColorHSV(0.3f, 0.8f, 0.3f, 0.81f, 0.3f, 0.8f);
    }
}
