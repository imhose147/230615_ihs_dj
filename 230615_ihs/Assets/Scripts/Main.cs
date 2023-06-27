using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    List<Character> characterList;

    void Start()
    {
        characterList = new List<Character>();


    }


    public void CreateCharacter(Character c)
    {
        characterList.Add(c);
    }

    public void RemoveCharacter(int index)
    {

    }

 
  

    // Update is called once per frame
    void Update()
    {
        
    }
}
