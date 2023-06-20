using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        bool isChange = false;
        float posX = this.transform.position.x;
        float posY = this.transform.position.y;

        if(this.transform.position.y >= 2f)
        {
            isChange = false;
        }
        else
        {
            isChange = true;
        }

        if (this.transform.position.y <= 2f)
        {
            this.transform.position = this.transform.position + new Vector3(0, 2f * Time.deltaTime, 0);
        }

        else if(this.transform.position.y >= 2f)
        {
            this.transform.position = this.transform.position - new Vector3(0, 2f * Time.deltaTime, 0);
        }

       new Vec




    }
}
