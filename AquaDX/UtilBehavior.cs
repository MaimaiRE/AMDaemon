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
        bool isHoldingEnter = Input.GetKey(KeyCode.Return);

        if (Utils._AimeStatus != isHoldingEnter)
        {
            Utils._AimeStatus = isHoldingEnter;
            MaimaiRE.Logger.Trace($"AimeStatus: {Utils._AimeStatus}");
        }
    }
}
