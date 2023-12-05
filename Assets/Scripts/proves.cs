using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class proves : MonoBehaviour
{
    public List<GameObject> arrowList;

    public GameObject arrowPrefab;
    public GameObject arrowPrefab1;
    public GameObject arrowPrefab2;
    public GameObject arrowPrefab3;

    private void Start()
    {
        arrowList = new List<GameObject>();
        arrowList.Add(arrowPrefab);
        arrowList.Add(arrowPrefab1);
        arrowList.Add(arrowPrefab2);
        arrowList.Add(arrowPrefab3);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {

            Debug.Log(arrowList);
        }
    }
}
