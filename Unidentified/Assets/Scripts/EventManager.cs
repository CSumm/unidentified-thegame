using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    Vector3 worldPosition;
    public GameObject uiCamera;
    private ListOfInteractableObjects _interactOBJScript;

    private void Start()
    {
        _interactOBJScript = uiCamera.GetComponent<ListOfInteractableObjects>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)
            {
                _interactOBJScript.AppearInCamera(hitInfo.transform.name, hit);
            }
        }
    }
}
