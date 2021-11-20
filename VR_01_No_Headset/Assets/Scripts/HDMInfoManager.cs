using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HDMInfoManager : MonoBehaviour
{
    void Start()
    {
        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No Headsets are plugged in");
        }
        else if (XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "MockHMD" || XRSettings.loadedDeviceName == "MockHMDDisplay"))
        {
            Debug.Log("Using Mock HMD");
        }
        else {
            Debug.Log("We have a headset : " + XRSettings.loadedDeviceName);
        }
    }

    void Update()
    {
        
    }
}
