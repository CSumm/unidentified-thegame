using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestContrrols : MonoBehaviour
{
    public static string objName;
    public Camera secondCam;
    public GameObject uiCamera;
    private ListOfInteractableObjects _interactOBJScript;

    // Start is called before the first frame update
    void Start()
    {
        _interactOBJScript = uiCamera.GetComponent<ListOfInteractableObjects>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hitInfo = new RaycastHit();
            RaycastHit hitInfo2 = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);

            if (hit)
            {
                if (hitInfo.transform.tag == "car")
                {
                    objName = hitInfo.transform.tag;
                }
            }
            else if (objName != "")
            {
                bool hitZoomed = Physics.Raycast(secondCam.ScreenPointToRay(Input.mousePosition), out hitInfo2);
                if (hitInfo2.transform != null)
                    _interactOBJScript.AppearInCamera(hitInfo2.transform.name, hitZoomed);
            }
            else
            {

            }
        }
    }
}
