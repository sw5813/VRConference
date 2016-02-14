<<<<<<< HEAD
﻿using UnityEngine;

public class OnClickRightDestroy : MonoBehaviour
{
    public void OnPressRight()
    {
        Debug.Log("RightClick Destroy");
        PhotonNetwork.Destroy(gameObject);
    }
=======
﻿using UnityEngine;

public class OnClickRightDestroy : MonoBehaviour
{
    public void OnPressRight()
    {
        Debug.Log("RightClick Destroy");
        PhotonNetwork.Destroy(gameObject);
    }
>>>>>>> 3fcd8fda4bc9610008a6f5ef1ff24faad1bce302
}