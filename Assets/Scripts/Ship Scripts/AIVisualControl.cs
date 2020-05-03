using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIVisualControl : ShipVisualControl
{
    public Transform path;
    private List<Transform> nodes;
    private Transform[] checkPointList;
    private int currentNode = 0;

    
    void Start(){
        findNodes();
    }

    void FixedUpdate()
    {
        if(!active){return;}
        float speed = 0.05f;
        Quaternion currentRotation = transform.rotation;
        transform.LookAt(nodes[currentNode]);
        Quaternion targetRotation = transform.rotation;
        transform.rotation = Quaternion.Lerp(currentRotation, targetRotation, Time.time * speed);

        MaintainPosition();
        CheckWaypointDistance();
    }

    private void findNodes(){
        Transform[] pathTransforms = path.GetComponentsInChildren<Transform>();
        nodes = new List<Transform>();     
        for (int i = 0; i < pathTransforms.Length; i++){
            if(pathTransforms[i] != path.transform){
                nodes.Add(pathTransforms[i]);    
            }
        }
    }

    private void CheckWaypointDistance(){
        if(Vector3.Distance(transform.position, nodes[currentNode].position) < 15f){ 
            if(currentNode == nodes.Count - 1){
                currentNode = 0;
            }else{
                currentNode++;                
            }
        }
    }
}
