using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodObject : MonoBehaviour
{
    public int typeFood;
    public Sprite[] spritePool;
    // Start is called before the first frame update
    private void Awake()
    {
        typeFood = Random.Range(0, spritePool.Length);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Image>().sprite = spritePool[typeFood];
    }
}
