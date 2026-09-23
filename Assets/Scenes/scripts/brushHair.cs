using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brushHair : MonoBehaviour
{

    public int length;
    public LineRenderer lineRend;
    public Vector3[] segmentPoses;
    private Vector3[] segmentV;
    public float smoothSpeed;

    public Transform targetDirection;
    public float targetDistance;
    // Start is called before the first frame update
    void Start()
    {
        lineRend.positionCount = length;
        segmentPoses = new Vector3[length];
        segmentV = new Vector3[length];
    }

    // Update is called once per frame
    void Update()
    {
        segmentPoses[0] = targetDirection.position; //first point is at head point/base pos
        for (int i = 0; i < segmentPoses.Length; i++)
        
        {
            segmentPoses[i] = Vector3.SmoothDamp(segmentPoses[i], segmentPoses[i-1] + targetDirection.right * targetDistance, ref segmentV[i], smoothSpeed);


        }
        lineRend.SetPositions(segmentPoses);
    }
}
