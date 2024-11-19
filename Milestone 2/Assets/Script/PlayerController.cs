using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject[] Enemies;
    public int currentIndex;
    public Vector3 enemyPosition;
    private GameObject selectedEnemy;
    // Start is called before the first frame update
    void Start()
    {
        //Resets the current enemy it should look at
        currentIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        LookAt();
    }
    void LookAt()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //It uses indexes for the cycle. Each enemy has index depending on its health. The player goes through each index one after another.
            //It has two conditions. The second condition works when the index of the enemy is almost maximum and resets it after we looked at it. So the next time we press W we look at the enemy with index 1.
            if (currentIndex < Enemies.Length - 1)
            {
                currentIndex++;
                //Gets the enemy with the index that we are looking for
                foreach (GameObject Enemy in Enemies)
                {
                    if (Enemy.GetComponent<EnemyController>().Index == currentIndex)
                    {
                        //Gets the enemy position
                        enemyPosition = Enemy.transform.position;
                    }
                }
                //Makes player look at this enemy
                transform.LookAt(enemyPosition);
            }
            else
            {
                currentIndex++;
                foreach (GameObject Enemy in Enemies)
                {
                    if (Enemy.GetComponent<EnemyController>().Index == currentIndex)
                    {
                        enemyPosition = Enemy.transform.position;
                    }
                }
                transform.LookAt(enemyPosition);
                currentIndex = 0;
            }
        }
    }
}
