using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputSpawner : MonoBehaviour
{
    public GameManager gm;
    public GameObject inputObject;
    public Sprite[] arrowPool;
    public int inputCount;
    // Start is called before the first frame update
    private void Awake()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inputCount < gm.foodsCount)
        {
            if (Input.GetKeyUp(KeyCode.A))
            {
                var ipt = Instantiate(inputObject);
                ipt.GetComponent<Image>().sprite = arrowPool[0];
                ipt.transform.parent = gameObject.transform;
                gm.inputPool.Add(0);
                inputCount++;
            }
            else if (Input.GetKeyUp(KeyCode.S))
            {
                var ipt = Instantiate(inputObject);
                ipt.GetComponent<Image>().sprite = arrowPool[1];
                ipt.transform.parent = gameObject.transform;
                gm.inputPool.Add(1);
                inputCount++;
            }
            else if (Input.GetKeyUp(KeyCode.D))
            {
                var ipt = Instantiate(inputObject);
                ipt.GetComponent<Image>().sprite = arrowPool[2];
                ipt.transform.parent = gameObject.transform;
                gm.inputPool.Add(2);
                inputCount++;
            }
            else if (Input.GetKeyUp(KeyCode.W))
            {
                var ipt = Instantiate(inputObject);
                ipt.GetComponent<Image>().sprite = arrowPool[3];
                ipt.transform.parent = gameObject.transform;
                gm.inputPool.Add(3);
                inputCount++;
            }
            
        }
        if (Input.GetKeyUp(KeyCode.Space) && inputCount==gm.foodsCount)
        {
            gm.InputCheck();
            GameObject[] inputs = GameObject.FindGameObjectsWithTag("Input");
            foreach (GameObject input in inputs)
                Destroy(input);
            gm.inputPool.Clear();
            inputCount = 0;
        }
    }
}
