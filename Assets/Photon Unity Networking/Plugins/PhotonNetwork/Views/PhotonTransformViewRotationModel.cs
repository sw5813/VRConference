<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class PhotonTransformViewRotationModel 
{
    public enum InterpolateOptions
    {
        Disabled,
        RotateTowards,
        Lerp,
    }

    public bool SynchronizeEnabled;

    public InterpolateOptions InterpolateOption = InterpolateOptions.RotateTowards;
    public float InterpolateRotateTowardsSpeed = 180;
    public float InterpolateLerpSpeed = 5;
}
=======
﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class PhotonTransformViewRotationModel 
{
    public enum InterpolateOptions
    {
        Disabled,
        RotateTowards,
        Lerp,
    }

    public bool SynchronizeEnabled;

    public InterpolateOptions InterpolateOption = InterpolateOptions.RotateTowards;
    public float InterpolateRotateTowardsSpeed = 180;
    public float InterpolateLerpSpeed = 5;
}
>>>>>>> 3fcd8fda4bc9610008a6f5ef1ff24faad1bce302
