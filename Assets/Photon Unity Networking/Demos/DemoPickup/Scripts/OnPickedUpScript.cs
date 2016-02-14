<<<<<<< HEAD
using UnityEngine;
using System.Collections;

public class OnPickedUpScript : MonoBehaviour {

	public void OnPickedUp(PickupItem item)
	{
	    if (item.PickupIsMine)
	    {
	        Debug.Log("I picked up something. That's a score!");
	        PhotonNetwork.player.AddScore(1);
	    }
	    else
	    {
            Debug.Log("Someone else picked up something. Lucky!");
	    }
	}
}
=======
using UnityEngine;
using System.Collections;

public class OnPickedUpScript : MonoBehaviour {

	public void OnPickedUp(PickupItem item)
	{
	    if (item.PickupIsMine)
	    {
	        Debug.Log("I picked up something. That's a score!");
	        PhotonNetwork.player.AddScore(1);
	    }
	    else
	    {
            Debug.Log("Someone else picked up something. Lucky!");
	    }
	}
}
>>>>>>> 3fcd8fda4bc9610008a6f5ef1ff24faad1bce302
