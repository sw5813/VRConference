<<<<<<< HEAD
﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class PhotonTransformViewScaleModel 
{
    public enum InterpolateOptions
    {
        Disabled,
        MoveTowards,
        Lerp,
    }

    public bool SynchronizeEnabled;

    public InterpolateOptions InterpolateOption = InterpolateOptions.Disabled;
    public float InterpolateMoveTowardsSpeed = 1f;
    public float InterpolateLerpSpeed;
}
=======
﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class PhotonTransformViewScaleModel 
{
    public enum InterpolateOptions
    {
        Disabled,
        MoveTowards,
        Lerp,
    }

    public bool SynchronizeEnabled;

    public InterpolateOptions InterpolateOption = InterpolateOptions.Disabled;
    public float InterpolateMoveTowardsSpeed = 1f;
    public float InterpolateLerpSpeed;
}
>>>>>>> 3fcd8fda4bc9610008a6f5ef1ff24faad1bce302
