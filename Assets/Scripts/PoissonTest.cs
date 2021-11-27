using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoissonTest : MonoBehaviour
{
    public float radius = 1;
    public Vector2 regionSize = new Vector2(50,50); //Vector2.one;
    public int rejectionSamples = 30;
    public float displayRadius = 1;
    List<Vector2> points;

    void OnValidate() {
        points = PoissonDiscSampling.GeneratePoints(radius, regionSize, rejectionSamples);
    }

    void OnDrawGizmosS() {
        Gizmos.DrawWireCube(regionSize/2, regionSize);
        Gizmos.color = Color.yellow;
        if (points != null){
            foreach (Vector2 point in points){
                Gizmos.DrawSphere(point, displayRadius);
            }
        }
    }
}
