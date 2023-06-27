using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Enemy
{
    enum EnemyType
    {
        Basic = 0,
        Range,
    }

    private EnemyType enemyType;
    private int hp;
    private int atk;
    private int speed;


    public Enemy(Enemy type, int hp, int atk, int speed) // 생성자   초기화 해주는 것
    {
        this.enemyType = type;
        this.hp = hp;
        this.atk = akt;
        this.speed = speed;
    }

    public int Hp
    {
        get { return this.hp; }
    }
    public int Atk
    {
        get { return this.atk; }
    }
    public int Speed
    {
        get { return this.speed}
    }

    public bool Hit(int dmg)
    {
        if (this.hp - dmg <= 0) return false;
        this.hp -= dmg;
        return true;
    }

    

  
}

