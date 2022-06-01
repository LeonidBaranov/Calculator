using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;

public class Calculator : MonoBehaviour
{
    public Text TextData;
    public string Input_Num;
    private string Output_Data;
    

    public void OnClickButton()
    {
        TextData.text += Input_Num;

    }

    public void OnClickResetText()
    {
        TextData.text = "";
    }

    public void OnClickEnter()
    {
        DataTable DT = new DataTable();
        Output_Data = (DT.Compute(TextData.text, "")).ToString();   
        double First_Res = double.Parse(Output_Data);
        string Final_Res = string.Format("{0:g6}", First_Res);
        TextData.text = Final_Res.Replace(",", ".");       
    }
}
