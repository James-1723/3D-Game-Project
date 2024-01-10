using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Flower;

public class Dialogue_scene2 : MonoBehaviour
{
    FlowerSystem fs;
    
    

    void Start()
    {
        fs = FlowerManager.Instance.CreateFlowerSystem("default,false");

        fs.SetupDialog();
        fs.ReadTextFromResource("intro_scene2");
        fs.RegisterCommand("bg_activate",(List<string> state)=>{
            GameObject targetObject = GameObject.Find("bg");
            Image imageComponent = targetObject.GetComponent<Image>();
            if (imageComponent != null)
            {
                bool visibility = bool.Parse(state[0]);
                // 切换 Image 组件的显示状态
                imageComponent.enabled = visibility;
             }
        });
        fs.RegisterCommand("racer_activate",(List<string> state)=>{
            GameObject targetObject = GameObject.Find("bg_racer");
            Image imageComponent = targetObject.GetComponent<Image>();
            if (imageComponent != null)
            {
                bool visibility = bool.Parse(state[0]);
                // 切换 Image 组件的显示状态
                imageComponent.enabled = visibility;
             }
        });
        fs.RegisterCommand("friend_activate",(List<string> state)=>{
            GameObject targetObject = GameObject.Find("bg_friend");
            Image imageComponent = targetObject.GetComponent<Image>();
            if (imageComponent != null)
            {
                bool visibility = bool.Parse(state[0]);
                // 切换 Image 组件的显示状态
                imageComponent.enabled = visibility;
             }
        });
        fs.RegisterCommand("both_activate",(List<string> state)=>{
            GameObject targetObject = GameObject.Find("bg_both");
            Image imageComponent = targetObject.GetComponent<Image>();
            if (imageComponent != null)
            {
                bool visibility = bool.Parse(state[0]);
                // 切换 Image 组件的显示状态
                imageComponent.enabled = visibility;
             }
        });
        fs.RegisterCommand("load_scene",(List<string>_params)=>{
            SceneManager.LoadScene(_params[0]);
        });

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            fs.Next();
        }       
    }


    
}
