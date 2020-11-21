using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class VisibleJoints : MonoBehaviour
{

    public Transform rootNode;
    public Transform[] childNodes;

    [Range(0f, 0.2f)]
    public float HeadSize;
    [Range(0f, 0.2f)]
    public float SpineSize;
    [Range(0f, 0.2f)]
    public float ArmSize;
    [Range(0f, 0.2f)]
    public float LegSize;

    void OnDrawGizmosSelected()
    {
        if (rootNode != null)
        {         
            if (childNodes == null || childNodes.Length == 0)
            {
                //get all joints to draw
                PopulateChildren();
            }


            foreach (Transform child in childNodes)
            {

                if (child == rootNode)
                {
                    //list includes the root, if root then larger, green cube
                    Gizmos.color = Color.green;
                    Gizmos.DrawCube(child.position, new Vector3(.1f, .1f, .1f));
                }
                else
                {
                    if (child.name.Contains("Nub")) continue;
                    if (child.parent.name == "Root") continue;
                    if (!child.gameObject.activeSelf) continue;
                    Gizmos.color = Color.blue;

                    float s = 0.05f;
                    if (child.parent.name.ToUpper().Contains("SPINE"))
                        s = SpineSize;
                    if (child.parent.name.ToUpper().Contains("NECK"))
                        s = HeadSize;
                    if (child.parent.name.ToUpper().Contains("ARM"))
                        s = ArmSize;
                    if (child.parent.name.ToUpper().Contains("THIGH") || child.parent.name.ToUpper().Contains("CALF"))
                        s = LegSize;

                    //Gizmos.DrawLine(child.position, child.parent.position);
                    DrawWireCapsule(Vector3.Lerp(child.position, child.parent.position, 0.5f), Quaternion.FromToRotation(Vector3.up, child.position - child.parent.position), s, Vector3.Distance(child.parent.position, child.position) * 1.2f);
                    Gizmos.DrawCube(child.position, new Vector3(.01f, .01f, .01f));
                }
            }

        }
    }

    public void PopulateChildren()
    {
        childNodes = rootNode.GetComponentsInChildren<Transform>();
    }

    public static void DrawWireCapsule(Vector3 _pos, Quaternion _rot, float _radius, float _height, Color _color = default(Color))
    {
        if (_color != default(Color))
            Handles.color = _color;
        Matrix4x4 angleMatrix = Matrix4x4.TRS(_pos, _rot, Handles.matrix.lossyScale);
        using (new Handles.DrawingScope(angleMatrix))
        {
            var pointOffset = (_height - (_radius * 2)) / 2;

            //draw sideways
            Handles.DrawWireArc(Vector3.up * pointOffset, Vector3.left, Vector3.back, -180, _radius);
            Handles.DrawLine(new Vector3(0, pointOffset, -_radius), new Vector3(0, -pointOffset, -_radius));
            Handles.DrawLine(new Vector3(0, pointOffset, _radius), new Vector3(0, -pointOffset, _radius));
            Handles.DrawWireArc(Vector3.down * pointOffset, Vector3.left, Vector3.back, 180, _radius);
            //draw frontways
            Handles.DrawWireArc(Vector3.up * pointOffset, Vector3.back, Vector3.left, 180, _radius);
            Handles.DrawLine(new Vector3(-_radius, pointOffset, 0), new Vector3(-_radius, -pointOffset, 0));
            Handles.DrawLine(new Vector3(_radius, pointOffset, 0), new Vector3(_radius, -pointOffset, 0));
            Handles.DrawWireArc(Vector3.down * pointOffset, Vector3.back, Vector3.left, -180, _radius);
            //draw center
            Handles.DrawWireDisc(Vector3.up * pointOffset, Vector3.up, _radius);
            Handles.DrawWireDisc(Vector3.down * pointOffset, Vector3.up, _radius);
        }
    }

    public void BuildColliders()
    {
        foreach (Transform child in childNodes)
        {
            if (child == rootNode)
            {
            }
            else
            {
                if (child.name.Contains("Nub")) continue;
                if (child.parent.name == "Root") continue;
                if (!child.gameObject.activeSelf) continue;

                float s = 0.05f;
                if (child.parent.name.ToUpper().Contains("SPINE"))
                    s = SpineSize;
                if (child.parent.name.ToUpper().Contains("NECK"))
                    s = HeadSize;
                if (child.parent.name.ToUpper().Contains("ARM"))
                    s = ArmSize;
                if (child.parent.name.ToUpper().Contains("THIGH") || child.parent.name.ToUpper().Contains("CALF"))
                    s = LegSize;

                DestroyImmediate(child.parent.gameObject.GetComponent<CapsuleCollider>());

                CapsuleCollider collider = child.parent.gameObject.GetComponent<CapsuleCollider>();
                if (collider == null)
                    collider = child.parent.gameObject.AddComponent<CapsuleCollider>();

                collider.direction = 1;
                collider.radius = s;
                collider.height = Vector3.Distance(child.parent.position, child.position) * 1.2f;
                collider.center = Vector3.Lerp(Vector3.zero, child.localPosition, 0.5f);

                //DrawWireCapsule(Vector3.Lerp(child.position, child.parent.position, 0.5f), Quaternion.FromToRotation(Vector3.up, child.position - child.parent.position), s, Vector3.Distance(child.parent.position, child.position) * 1.2f);

            }
        }
    }
}