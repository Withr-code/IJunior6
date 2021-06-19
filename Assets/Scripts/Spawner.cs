using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _spawnIntensity;
    [SerializeField] private List<SpawnPoint> _spawners;

    private float _runningTime;

    private void Update()
    {
        _runningTime += Time.deltaTime;

        if (_runningTime >= _spawnIntensity)
        {
            SpawnPoint chosenSpawnPoint = _spawners[Random.Range(0, _spawners.Count)];

            chosenSpawnPoint.SpawnEnemy();
            _runningTime = 0;
        }
    }
}
