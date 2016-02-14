<<<<<<< HEAD
using UnityEngine;
using System.Collections;

public class MessageOverlay : MonoBehaviour
{
    public GameObject[] Objects;

    public void Start()
    {
        SetActive(true);
    }

    public void OnJoinedRoom()
    {
        SetActive(false);
    }

    public void OnLeftRoom()
    {
        SetActive(true);
    }

    void SetActive(bool enable)
    {
        foreach (GameObject o in Objects)
        {
            #if UNITY_3_5
            o.SetActiveRecursively(enable);
            #else
            o.SetActive(enable);
            #endif
        }
    }
}
=======
using UnityEngine;
using System.Collections;

public class MessageOverlay : MonoBehaviour
{
    public GameObject[] Objects;

    public void Start()
    {
        SetActive(true);
    }

    public void OnJoinedRoom()
    {
        SetActive(false);
    }

    public void OnLeftRoom()
    {
        SetActive(true);
    }

    void SetActive(bool enable)
    {
        foreach (GameObject o in Objects)
        {
            #if UNITY_3_5
            o.SetActiveRecursively(enable);
            #else
            o.SetActive(enable);
            #endif
        }
    }
}
>>>>>>> 3fcd8fda4bc9610008a6f5ef1ff24faad1bce302
