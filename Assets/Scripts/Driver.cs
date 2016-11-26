using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(Setup))]
[RequireComponent(typeof(Farm))]
[RequireComponent(typeof(Farmer))]
[RequireComponent(typeof(Crow))]
[RequireComponent(typeof(Mine))]
[RequireComponent(typeof(Rock))]
[RequireComponent(typeof(Kobold))]
[RequireComponent(typeof(Forest))]
[RequireComponent(typeof(Elf))]
[RequireComponent(typeof(Ent))]

public class Driver : MonoBehaviour {
	public Choice leftChoice;
	public Choice rightChoice;

	public Button leftButton;
	public Button rightButton;

	public float luck;

	public Setup setup {
		get {
			return GetComponent<Setup> ();
		}
	}

	public Farm farm { 
		get {
			return GetComponent<Farm> ();
		}
	}

	public Crow crow {
		get {
			return GetComponent<Crow> ();
		}
	}

	public Farmer farmer {
		get {
			return GetComponent<Farmer> ();
		}
	}

	public Mine mine {
		get {
			return GetComponent<Mine> ();
		}
	}

	public Rock rock {
		get {
			return GetComponent<Rock> ();
		}
	}

	public Kobold kobold {
		get {
			return GetComponent<Kobold> ();
		}
	}

	public Forest forest {
		get {
			return GetComponent<Forest> ();
		}
	}

	public Elf elf {
		get {
			return GetComponent<Elf> ();
		}
	}

	public Ent ent {
		get {
			return GetComponent<Ent> ();
		}
	}

	public void ClickLeft() {
		this.leftChoice.Clicked ();
	}

	public void ClickRight() {
		this.rightChoice.Clicked ();
	}
}
