using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy
{
    private string name;
    private int hp;

    public Enemy(string name, int hp) // 생성자   초기화 해주는 것
    {
        this.name = name;
        this.hp = hp;
    }


    public void GetEnemyinfo()
    {
        Debug.Log("dddddd");
    }
  
}

