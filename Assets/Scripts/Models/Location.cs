﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserLocation {

	public long time;
	public float speed;
	public double altitude;
	public double longitude;
	public double latitude;

	public UserLocation(long time, float speed, double altitude, double longitude, double latitude) {
		this.time = time;
		this.speed = speed;
		this.altitude = altitude;
		this.longitude = longitude;
		this.latitude = latitude;
	}

    public UserLocation(IDictionary<string, object> dict)
    {
        this.time = long.Parse(dict["time"].ToString());
        this.speed = float.Parse(dict["speed"].ToString());
        this.altitude = double.Parse(dict["altitude"].ToString());
        this.longitude = double.Parse(dict["longitude"].ToString());
        this.latitude = double.Parse(dict["latitude"].ToString());
    }

}
