<<<<<<< HEAD
﻿using UnityEngine;

namespace ExitGames.Client.GUI
{
    public enum GizmoType
    {
        WireSphere,
        Sphere,
        WireCube,
        Cube,
    }

    public class GizmoTypeDrawer
    {
        public static void Draw( Vector3 center, GizmoType type, Color color, float size )
        {
            Gizmos.color = color;

            switch( type )
            {
            case GizmoType.Cube:
                Gizmos.DrawCube( center, Vector3.one * size );
                break;
            case GizmoType.Sphere:
                Gizmos.DrawSphere( center, size * 0.5f );
                break;
            case GizmoType.WireCube:
                Gizmos.DrawWireCube( center, Vector3.one * size );
                break;
            case GizmoType.WireSphere:
                Gizmos.DrawWireSphere( center, size * 0.5f );
                break;
            }
        }
    }
=======
﻿using UnityEngine;

namespace ExitGames.Client.GUI
{
    public enum GizmoType
    {
        WireSphere,
        Sphere,
        WireCube,
        Cube,
    }

    public class GizmoTypeDrawer
    {
        public static void Draw( Vector3 center, GizmoType type, Color color, float size )
        {
            Gizmos.color = color;

            switch( type )
            {
            case GizmoType.Cube:
                Gizmos.DrawCube( center, Vector3.one * size );
                break;
            case GizmoType.Sphere:
                Gizmos.DrawSphere( center, size * 0.5f );
                break;
            case GizmoType.WireCube:
                Gizmos.DrawWireCube( center, Vector3.one * size );
                break;
            case GizmoType.WireSphere:
                Gizmos.DrawWireSphere( center, size * 0.5f );
                break;
            }
        }
    }
>>>>>>> 3fcd8fda4bc9610008a6f5ef1ff24faad1bce302
}