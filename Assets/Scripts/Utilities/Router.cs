﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Unity.Editor;

public class Router : MonoBehaviour {

	private static DatabaseReference baseRef = FirebaseDatabase.DefaultInstance.RootReference;

	public static DatabaseReference Users() {
		return baseRef.Child ("users");
	}

	public static DatabaseReference UserWithUID(string uid) {
		return baseRef.Child ("users").Child (uid);
	}

	public static DatabaseReference Contacts() {
		return baseRef.Child ("contacts");
	}

	public static DatabaseReference ContactsOfUID(string uid) {
		return Contacts().Child (uid);
	}

	public static DatabaseReference Locations() {
		return baseRef.Child ("locations");
	}

	public static DatabaseReference LocationOfUID(string uid) {
		return Locations().Child (uid);
	}
}
