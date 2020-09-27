using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOfInteractableObjects : MonoBehaviour
{
    public GameObject[] objects;
    public GameObject threeDView;
    Vector3 origin = new Vector3(100, 0, 0);
    public Vector3 shownPos;
    public Vector3 shownScale;
    public static string getCurrentObject;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            getCurrentObject = "";
           threeDView.SetActive(false);
        }
    }

    public void AppearInCamera(string hitInfo, bool hit)
    {

        //checks if something has been hit
        if (hit)
        {
            for (int i = 0; i < objects.Length; i++)
            {

                if (objects[i].name.Equals(hitInfo) && !string.IsNullOrEmpty(getCurrentObject))
                {
                    for (int j = 0; j < objects.Length; j++)
                    {
                        if (objects[j].name.Equals(getCurrentObject))
                        {
                            objects[j].transform.position = origin;
                            break;
                        }
                    }
                }

                /*loops array and checks if name ofwhat has 
                been hit is in array and sets its position and scale*/
                if (objects[i].name.Equals(hitInfo))
                {
                    threeDView.SetActive(true);
                    objects[i].transform.position = shownPos;
                    objects[i].transform.localScale = shownScale;
                    getCurrentObject = objects[i].name;
                    break;
                }
            }
        }
    }
}
