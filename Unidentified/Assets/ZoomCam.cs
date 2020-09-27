using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCam : MonoBehaviour
{
    void Start()
    {
        GetComponent<Camera>().enabled = false;
    }

    private void Update()
    {

        if (!string.IsNullOrEmpty(TestContrrols.objName) && TestContrrols.objName.Equals("car"))
        {
            GetComponent<Camera>().enabled = true;
        }

        if (Input.GetMouseButtonDown(1) && TestContrrols.objName != "")
        {
            TestContrrols.objName = "";
            GetComponent<Camera>().enabled = false;
        }
    }
}
