using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GyreRigTask.Task2
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField]
        private Transform SpawnRoot;

        [SerializeField]
        private float SpeedCube = 2f;

        [SerializeField]
        private float DistanceBeforeDestroy = 10f;

        [SerializeField]
        private float PeriodSpawnSec = 2f;



        private float TimeToNextSpawn = 0;

        private void Start()
        {
            TimeToNextSpawn = Time.time;
        }

        private void Update()
        {
            if(Time.time >= TimeToNextSpawn)
            {
                SpawnCube();
                TimeToNextSpawn = Time.time + PeriodSpawnSec;
            }
        }

        private void SpawnCube()
        {
            CubeLogic cube = Instantiate(Resources.Load<GameObject>("Prefab/Cube"), SpawnRoot).GetComponent<CubeLogic>();
            cube.Speed = SpeedCube;
            cube.Distance = DistanceBeforeDestroy;
        }
    }
}

