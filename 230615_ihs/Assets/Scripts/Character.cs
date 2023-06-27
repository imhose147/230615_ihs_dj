using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour

{
    private string name;
    private string job;
    private int hp;
    private int atk;

    public Character(string name, string job, int hp, int atk)
    {

    }

    public string Name
    {
        get
        {
            return this.name;
        }
    }
    public string Job
    {
        get
        {
            return this.job;
        }
    }
    public int Hp
    {
        get
        {
            return this.hp;
        }
    }
    public int Atk
    {
        get
        {
            return this.atk;
        }
    }

    public void GetInfo();{

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
