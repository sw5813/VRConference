<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

public class QuitOnEscapeOrBack : MonoBehaviour
{
    private void Update()
    {
        // "back" button of phone equals "Escape". quit app if that's pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
=======
﻿using UnityEngine;
using System.Collections;

public class QuitOnEscapeOrBack : MonoBehaviour
{
    private void Update()
    {
        // "back" button of phone equals "Escape". quit app if that's pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
>>>>>>> 3fcd8fda4bc9610008a6f5ef1ff24faad1bce302
