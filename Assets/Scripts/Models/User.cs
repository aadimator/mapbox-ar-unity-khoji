﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User {

	// Class properties
	public string name;
	public string email;
	public string photoUrl;

	public User(string name, string email, string photoUrl) {
		this.name = name;
		this.email = email;
		this.photoUrl = photoUrl;
	}

	public User(IDictionary<string, object> dict) {
		this.email = dict ["email"].ToString();
		this.name = dict ["name"].ToString();
		this.photoUrl = dict ["photoUrl"].ToString();
	}

}
