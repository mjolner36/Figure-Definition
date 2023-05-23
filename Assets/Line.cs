using System;
using UnityEngine;

public class Line:MonoBehaviour
{
   private LineRenderer _lineRenderer;

   private void OnEnable()
   {
      _lineRenderer = GetComponent<LineRenderer>();
   }

   public void SetPosition(Vector2 pos)
   {
      if (!CanAppend(pos)) return;
      _lineRenderer.SetPosition(_lineRenderer.positionCount++,pos);
   }

   private bool CanAppend(Vector2 pos)
   {
      var positionCount = _lineRenderer.positionCount;
      return positionCount == 0 || 
             CheckDistance(_lineRenderer.GetPosition(positionCount - 1), pos, DrawManager2D.RESOLUTION);
   }
   private static bool CheckDistance(Vector2 a, Vector2 b, float distance)
   {
      float num1 = a.x - b.x;
      float num2 = a.y - b.y;
      return  num1 * num1 + num2 * num2 > distance;
   }
}
