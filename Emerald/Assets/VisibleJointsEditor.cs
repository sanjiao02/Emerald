using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(VisibleJoints))]
public class VisibleJointsEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        VisibleJoints script = (VisibleJoints)target;
        if (GUILayout.Button("Build Colliders"))
        {
            script.BuildColliders();
        }
    }
}
