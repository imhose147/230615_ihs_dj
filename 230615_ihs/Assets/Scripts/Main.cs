using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

 
    // Start is called before the first frame update
    void Start()
    {
        Enemy e1 = new Enemy("alf", 10);
        Enemy e2 = new Enemy("dragon", 100);

        e1 GetEnemyinfo();
        e2 GetEnemyinfo();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
