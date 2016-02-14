<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

public class Demo2DJumpAndRun : MonoBehaviour 
{
    void OnJoinedRoom()
    {
        if( PhotonNetwork.isMasterClient == false )
        {
            return;
        }

        PhotonNetwork.InstantiateSceneObject( "Physics Box", new Vector3( -4.5f, 5.5f, 0 ), Quaternion.identity, 0, null );
        PhotonNetwork.InstantiateSceneObject( "Physics Box", new Vector3( -4.5f, 4.5f, 0 ), Quaternion.identity, 0, null );
        PhotonNetwork.InstantiateSceneObject( "Physics Box", new Vector3( -4.5f, 3.5f, 0 ), Quaternion.identity, 0, null );

        PhotonNetwork.InstantiateSceneObject( "Physics Box", new Vector3( 4.5f, 5.5f, 0 ), Quaternion.identity, 0, null );
        PhotonNetwork.InstantiateSceneObject( "Physics Box", new Vector3( 4.5f, 4.5f, 0 ), Quaternion.identity, 0, null );
        PhotonNetwork.InstantiateSceneObject( "Physics Box", new Vector3( 4.5f, 3.5f, 0 ), Quaternion.identity, 0, null );
    }
}
=======
﻿using UnityEngine;
using System.Collections;

public class Demo2DJumpAndRun : MonoBehaviour 
{
    void OnJoinedRoom()
    {
        if( PhotonNetwork.isMasterClient == false )
        {
            return;
        }

        PhotonNetwork.InstantiateSceneObject( "Physics Box", new Vector3( -4.5f, 5.5f, 0 ), Quaternion.identity, 0, null );
        PhotonNetwork.InstantiateSceneObject( "Physics Box", new Vector3( -4.5f, 4.5f, 0 ), Quaternion.identity, 0, null );
        PhotonNetwork.InstantiateSceneObject( "Physics Box", new Vector3( -4.5f, 3.5f, 0 ), Quaternion.identity, 0, null );

        PhotonNetwork.InstantiateSceneObject( "Physics Box", new Vector3( 4.5f, 5.5f, 0 ), Quaternion.identity, 0, null );
        PhotonNetwork.InstantiateSceneObject( "Physics Box", new Vector3( 4.5f, 4.5f, 0 ), Quaternion.identity, 0, null );
        PhotonNetwork.InstantiateSceneObject( "Physics Box", new Vector3( 4.5f, 3.5f, 0 ), Quaternion.identity, 0, null );
    }
}
>>>>>>> 3fcd8fda4bc9610008a6f5ef1ff24faad1bce302
