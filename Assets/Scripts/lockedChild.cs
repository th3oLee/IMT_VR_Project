using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockedChild : MonoBehaviour
{
  private  Vector3 iniRot;
  
  public void Start()
  {
      iniRot = transform.eulerAngles;
  }
  
  public void LateUpdate(){
      iniRot.y = transform.eulerAngles.y; // keep current rotation about Y
      transform.eulerAngles = iniRot; // restore original rotation with new Y
  }
}
