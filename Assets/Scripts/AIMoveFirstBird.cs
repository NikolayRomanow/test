using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DodoDataModel;

public class AIMoveFirstBird : MonoBehaviour
{
   public Transform[] WayPoints;

   //public float SpeedMove = 0.5f;
  // public float SpeedRotate = 15f;

   private int _count = 0;

   private void Update()
   {
        if (Stats.isReady==true)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, WayPoints[_count].position, Time.deltaTime * Stats.MovementVelocityFirstBird);
            this.transform.rotation = Quaternion.RotateTowards(this.transform.rotation, WayPoints[_count].rotation, Time.deltaTime * Stats.RotateVelocityFirstBird);

            if (this.transform.position == WayPoints[_count].position && this.transform.rotation == WayPoints[_count].rotation)
                _count++;
        }
   }
}
