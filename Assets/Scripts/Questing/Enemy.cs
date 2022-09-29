using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int enemyID;

    void Start(){
        enemyID = 0;
    }

    public void Die(){
        EventController.EnemyDied(enemyID);
    }
}
