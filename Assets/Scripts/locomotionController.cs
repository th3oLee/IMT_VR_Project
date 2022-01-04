using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class locomotionController : MonoBehaviour
{
    // Start is called before the first frame update
    public XRController leftTeleportRay;
    public XRController rightTeleportRay;

    public InputHelpers.Button teleportActivationButton;
    public float activationThreshold = 0.1f;

    public bool EnableRightTeleport {get; set;} = true;

    public bool checkIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated, activationThreshold);
        return isActivated;
    }

    // Update is called once per frame
    void Update()
    {
        if(rightTeleportRay)
        {
          rightTeleportRay.gameObject.SetActive(EnableRightTeleport && checkIfActivated(rightTeleportRay));

        }
    }
}
