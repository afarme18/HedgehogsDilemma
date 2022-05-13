using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MonsterGenerator : MonoBehaviour
{

    public Transform[] spawnZones;
    public GameObject[] enemies;
    private int enemyCounter = 0;

    private void Start()
    {
        InvokeRepeating("GenerateEnemy", 2.0f, 1.0f);
    }

    // Update is called once per frame
    void GenerateEnemy()
    {
        int randLocation = Random.Range(0, spawnZones.Length);
        int randEnemy = Random.Range(0, enemies.Length);

        Instantiate(enemies[randEnemy], spawnZones[randLocation].position, transform.rotation);
        enemyCounter++;

        if (enemyCounter > 60){
            InvokeRepeating("QuitTimer", 5.0f, 10.0f);
        }
    }

    void QuitTimer()
    {

        SceneManager.LoadScene("Menu");
    }
}
