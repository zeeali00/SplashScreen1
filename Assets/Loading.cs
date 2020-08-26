using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public Transform loadingbar;
    [SerializeField]
    private float currentAmount;  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        loadingbar.GetComponent<Image>().fillAmount = currentAmount / 100;
        currentAmount++;
    }
}
