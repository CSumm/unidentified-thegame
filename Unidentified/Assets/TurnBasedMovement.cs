using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedMovement : MonoBehaviour
{
    public GameObject[] rooms;
    public GameObject[] maps;
    float hourInSeconds = 3600;

    // Start is called before the first frame update
    void Start()
    {
        maps[1].SetActive(false);
        maps[2].SetActive(false);
        maps[3].SetActive(false);
        maps[4].SetActive(false);
        maps[5].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time == hourInSeconds)
        {
            Debug.Log("game over");
        }
    }

    public void MoveToRoom2FromRoomOne()
    {
   
        rooms[1].SetActive(true);
        maps[1].SetActive(true);
        maps[0].SetActive(false);
        rooms[0].SetActive(false);
      
    }

    public void MoveToRoom1FromRoom2()
    {
      
        rooms[0].SetActive(true);
        maps[0].SetActive(true);
        maps[1].SetActive(false);
        rooms[1].SetActive(false);
       
    }
}
