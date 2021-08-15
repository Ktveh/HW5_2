using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _object;
    [SerializeField] private float _secondsBetweenSpawn;
    [SerializeField] private Transform[] _spawnPoints;

    private float _ellapsedTime;
    private int _spawnNumber;

    private void Update()
    {
        _ellapsedTime += Time.deltaTime;
        if (_ellapsedTime >= _secondsBetweenSpawn)
        {
            Create();
            SelectSpawnPoint();
            _ellapsedTime = 0;
        }
    }

    private void SelectSpawnPoint()
    {
        _spawnNumber++;
        if (_spawnNumber == _spawnPoints.Length)
            _spawnNumber = 0;
    }

    private void Create()
    {
        Instantiate(_object, _spawnPoints[_spawnNumber].position, Quaternion.identity);
    }
}
