using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMoveSecondBird : MonoBehaviour
{
    public Transform[] WayPoints;

    //public float SpeedMove = 0.5f;
    // public float SpeedRotate = 15f;

    private int _count = 0;
    

    private void Update()
    {
        if (Stats.isReady == true)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, WayPoints[_count].position, Time.deltaTime * Stats.MovementVelocitySecondBird);
            this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, WayPoints[_count].rotation, Time.deltaTime * Stats.RotateVelocitySecondBird);

            if (this.transform.position == WayPoints[_count].position && this.transform.rotation == WayPoints[_count].rotation)
                _count++;
        }
    }
}
