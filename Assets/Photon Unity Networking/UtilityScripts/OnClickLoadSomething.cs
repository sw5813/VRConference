<<<<<<< HEAD
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// This component makes it easy to switch scenes or open webpages on click.
/// Requires a InputToEvent component on the camera to forward clicks on screen.
/// </summary>
public class OnClickLoadSomething : MonoBehaviour
{
    public enum  ResourceTypeOption : byte
    {
        Scene,
        Web
    }

    public ResourceTypeOption ResourceTypeToLoad = ResourceTypeOption.Scene;
    public string ResourceToLoad;

    public void OnClick()
    {
        switch (ResourceTypeToLoad)
        {
            case ResourceTypeOption.Scene:
                SceneManager.LoadScene(ResourceToLoad);
                break;
            case ResourceTypeOption.Web:
                Application.OpenURL(ResourceToLoad);
                break;
        }
    }
}
=======
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// This component makes it easy to switch scenes or open webpages on click.
/// Requires a InputToEvent component on the camera to forward clicks on screen.
/// </summary>
public class OnClickLoadSomething : MonoBehaviour
{
    public enum  ResourceTypeOption : byte
    {
        Scene,
        Web
    }

    public ResourceTypeOption ResourceTypeToLoad = ResourceTypeOption.Scene;
    public string ResourceToLoad;

    public void OnClick()
    {
        switch (ResourceTypeToLoad)
        {
            case ResourceTypeOption.Scene:
                SceneManager.LoadScene(ResourceToLoad);
                break;
            case ResourceTypeOption.Web:
                Application.OpenURL(ResourceToLoad);
                break;
        }
    }
}
>>>>>>> 3fcd8fda4bc9610008a6f5ef1ff24faad1bce302
