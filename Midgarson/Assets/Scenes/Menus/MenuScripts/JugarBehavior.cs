using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JugarBehavior : MonoBehaviour
{
    public void OnButtonPress(){
        SceneManager.LoadScene("SeleccionDificultad");
    }
    
}
