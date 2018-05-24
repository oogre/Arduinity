using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;
using System.Linq;

public class ArduinoListener : MonoBehaviour {


    SerialPort stream;
    public string ArduinoName = "/dev/cu.wchusbserial1420";
    public int BaudRate = 9600;
    public string [] input;
	

	void Start () {
        stream = new SerialPort(ArduinoName, BaudRate);
        stream.ReadTimeout = 10;
        stream.Open();
	}
	
	void Update () {
        try
        {
            string value = stream.ReadLine();
            input = value.Split('/');
            stream.BaseStream.Flush();
        }
        catch (Exception e){}
	}
}
