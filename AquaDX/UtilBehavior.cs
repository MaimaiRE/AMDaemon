using AMDaemon.AquaDX;
using MaimaiRE;
using UnityEngine;

public class UtilBehavior : MonoBehaviour
{

    public void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Utils._AimeStatus = !Utils._AimeStatus;
            MaimaiRE.Logger.Trace($"AimeStatus: {Utils._AimeStatus}");
        }
    }
}