using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    GameObject _enemy;


    void Update()
    {
        if(_enemy == null)
        {
            float angle = Random.Range(0, 360);

            _enemy = Instantiate(enemyPrefab);
            _enemy.transform.position = new Vector3(15, 1, 0);
            _enemy.transform.Rotate(0, angle, 0);
        }
    }
}