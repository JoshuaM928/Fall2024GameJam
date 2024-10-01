using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseVisibility : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None; // Unlock the cursor
        Cursor.visible = true; // Make the cursor visible
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
