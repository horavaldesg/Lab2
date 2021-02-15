using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderForce : MonoBehaviour
{
    Slider slider;
    [SerializeField]private float forceNormal;
    private float addForce;
    
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { ValueChangeCheck(); });
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(addForce);
        //Debug.Log(slider.value);

       
    }
    public void ValueChangeCheck()
    {
        addForce = slider.value * forceNormal;

        Debug.Log(slider.value);
    }


}
