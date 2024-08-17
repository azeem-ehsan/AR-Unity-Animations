using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnatchAnim_Controller : MonoBehaviour
{

    [SerializeField] private Animator animator;
    [SerializeField] private GameObject snatch_dumbell;



    // Start is called before the first frame update
    void Start()
    {
        Deactivate_SnatchDumbell();
    }



    public void SetActivation_SnatchDumbell(bool value)
    {
        snatch_dumbell.SetActive(value);
    }

    public void Activate_SnathcDumbell()
    {
        SetActivation_SnatchDumbell(true);
    }

    public void Deactivate_SnatchDumbell()
    {
        SetActivation_SnatchDumbell(false);
    }

}
