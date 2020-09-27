using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMenu : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mousePosition.y <= Screen.height * 0.3)
        {
            canvas.SetActive(true);
        } else
        {
            canvas.SetActive(false);
        }
    }
}
