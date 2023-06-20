using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{

    public GameObject player;
    int step = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(step == 1)
        {

            player.transform.position -= new Vector3(10 * Time.deltaTime, 0, 0);
        }

        else
        {

        }
    }
    
    public void LeftMove()
    {
        step = 1; 
    }

    public void RigthMove()
    {
        step = 2;
    }

}
