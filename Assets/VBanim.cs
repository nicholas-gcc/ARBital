using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class VirtualButtonEA : MonoBehaviour {

    #region PUBLIC_MEMBERS

    public Material m_VirtualButtonDefault;
    public Material m_VirtualButtonPressed;
    public float m_ButtonReleaseTimeDelay;

    #endregion // PUBLIC_MEMBERS

    #region PRIVATE_MEMBERS
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    #endregion // PRIVATE_MEMBERS

    #region MONOBEHAVIOUR_METHODS
    public abstract void Awake();

    public abstract void Destroy();

    #endregion // MONOBEHAVIOUR_METHODS


    #region PUBLIC_METHODS
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public abstract void OnButtonPressed(VirtualButtonBehaviour vb);

    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public abstract void OnButtonReleased(VirtualButtonBehaviour vb);
    #endregion //PUBLIC_METHODS


    #region PRIVATE_METHODS
    abstract void SetVirtualButtonMaterial(Material material);

    #endregion // PRIVATE METHODS
}

