<<<<<<< HEAD
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class OnClickCallMethod : Photon.MonoBehaviour
{
    public GameObject TargetGameObject;
    public string TargetMethod;

    // called by InputToEvent script if that's on a camera
    public void OnClick()
    {
        if (this.TargetGameObject == null || string.IsNullOrEmpty(this.TargetMethod))
        {
            Debug.LogWarning(this + " can't call, cause GO or Method are empty.");
            return;
        }

        this.TargetGameObject.SendMessage(this.TargetMethod);
    }
}
=======
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class OnClickCallMethod : Photon.MonoBehaviour
{
    public GameObject TargetGameObject;
    public string TargetMethod;

    // called by InputToEvent script if that's on a camera
    public void OnClick()
    {
        if (this.TargetGameObject == null || string.IsNullOrEmpty(this.TargetMethod))
        {
            Debug.LogWarning(this + " can't call, cause GO or Method are empty.");
            return;
        }

        this.TargetGameObject.SendMessage(this.TargetMethod);
    }
}
>>>>>>> 3fcd8fda4bc9610008a6f5ef1ff24faad1bce302
