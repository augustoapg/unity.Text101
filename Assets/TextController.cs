using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;

	public enum States {cabin_out, around, axe, darkness, cabin_in, cabin_f0p0, phone_f0, phone_f1, flash_p0, 
						flash_p1, cabin_f0p1, cabin_f1p0, cabin_f1p1, cabin_out_f0p1, cabin_out_f1p0,
						cabin_out_f1p1, darkness_f1p1, lost0, lost1, lost2, combat,	hide, beginning};
	public States myState;
	
	// Use this for initialization
	void Start () {
		myState = States.beginning;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (myState == States.cabin_out)			{ cabin_out();}
		else if (myState == States.beginning)		{ beginning();}
		else if (myState == States.around)			{ around();}
		else if (myState == States.axe)				{ axe();}
		else if (myState == States.cabin_in)		{ cabin_in();}
		else if (myState == States.darkness)		{ darkness();}
		else if (myState == States.lost0)			{ lost0();}
		else if (myState == States.cabin_f0p0)		{ cabin_f0p0();}
		else if (myState == States.phone_f0)		{ phone_f0();}
		else if (myState == States.phone_f1)		{ phone_f1();}
		else if (myState == States.flash_p0)		{ flash_p0();}
		else if (myState == States.flash_p1)		{ flash_p1();}
		else if (myState == States.cabin_f0p1)		{ cabin_f0p1();}
		else if (myState == States.cabin_f1p0)		{ cabin_f1p0();}
		else if (myState == States.cabin_f1p1)		{ cabin_f1p1();}
		else if (myState == States.cabin_out_f0p1)	{ cabin_out_f0p1();}
		else if (myState == States.cabin_out_f1p0)	{ cabin_out_f1p0();}
		else if (myState == States.cabin_out_f1p1)	{ cabin_out_f1p1();}
		else if (myState == States.combat)			{ combat();}
		else if (myState == States.hide)			{ hide();}
		else if (myState == States.darkness_f1p1)	{ darkness_f1p1();}
		else if (myState == States.lost1)			{ lost1();}
		else if (myState == States.lost2)			{ lost2();}
	}
	
	void beginning() {
		text.text = "You got lost driving your car. It is already past midnight and you have no idea where " +
					"you are. It has been a while since you saw anything other than the forest. You eventually " +
					"run out of gas. Thinking that your night cannot be worse, it turns into a nightmare. " +
					"You look to your right and see a man, wearing a terrifying white mask, holding a huge " +
					"knife looking at you. You jump out of your car and run into the woods. After running " +
					"for a long time, you know that you got yourself far from that man. But you know " +
					"that it won't last long\n\n" +
					"Press C to Continue";
					
		if (Input.GetKeyDown (KeyCode.C)) { myState = States.cabin_out; }
	}
	
	void lost2() {
		text.text = "You run towards the path, hoping that the ability to see it will take you away from " +
					"that man. The destiny doesn't matter. After chosing randomly your paths, your body " +
					"freezes when you see the same cabin in front of you. You ran in circles. Before being able to choose what " +
					"to do now, you hear a quiet laugh coming from behind you. You can feel his breath on " +
					"your neck. You just close your eyes, and hope it to be over fast.\n\n" +
					"Press P to play again";
					
		if (Input.GetKeyDown (KeyCode.P)) { myState = States.beginning; }
	}
	
	void lost1() {
		text.text = "You run towards the complete darkness, hoping that your knowledge of the path is " +
					"enough to find your way to the town. That hope doesn't last long. On your terror you " +
					"trip on some rocks and hurt your foot really bad. You still try to crawl as fast as you " +
					"can, but as you start to hear the footsteps aproaching, you know that you will not " +
					"be fast enough.\n\n" +
					"Press P to play again";
					
		if (Input.GetKeyDown (KeyCode.P)) { myState = States.beginning; }
	}
	
	void darkness_f1p1() {
		text.text = "You run as fast as you can. Being able to see where you are going and trying to " +
					"remember the directions you got on the phone. You are very glad to have taken the " +
					"time find the flashlight and to make the call. It takes a while, which felt like " +
					"an eternity, but you finally get to the town, and that is the first time that you " +
					"look back since you left the cabin. You swear that you saw a glimpse of that " +
					"terrifing white mask far away, but you cannot be certain. It doesn't matter anymore, " +
					"because you are never getting close to this place again!\n\n" +
					"Press P to play again";
					
		if (Input.GetKeyDown (KeyCode.P)) { myState = States.beginning; }
	}
	
	void combat() {
		text.text = "Time to face your fears. This terrible night has to end, and it will be on your terms. " +
					"You hide beside the door and think of what exactly you should do. You start " +
					"hearing footsteps coming closer. At the moment that you see his right foot coming through " +
					"the door, you swing your axe which rips off half of his foot. He falls screaming on the " +
					"floor and you rush to the dark path without looking back. It takes a while, but you find " +
					"your way to the town, finally putting an end into your nightmare. Next day, the police calls " +
					"to tell you that all they found was blood on the floor. You decide to never get near " +
					"this town again.\n\n" +
					"Press P to play again";
					
		if (Input.GetKeyDown (KeyCode.P)) { myState = States.beginning; }
		
	}
	
	void hide() {
		text.text = "You run towards the bed and hide yourself underneath it. You put both your hands in " +
					"your mouth to avoid emiting any sound. When you see his feet coming through the door, " +
					"your body freezes and your eyes shut. After not hearing nothing for a while, you slowly " +
					"opens your eyes hoping that all you see is darkness. Unfortunatelly, all you see is " +
					"that terrifing mask, and his eyes behind it staring at you. And that is the last thing " +
					"you ever saw.\n\n" +
					"Press P to play again";
					
		if (Input.GetKeyDown (KeyCode.P)) { myState = States.beginning; }
	}
	
	void cabin_out_f1p1() {
		text.text = "You run to the outside of the cabin. You aim the flashlight to the path where you came " +
					"from. You cannot see him, but you can almost feel his presence. You KNOW that he is " +
					"too close. You start to reconsider the option of running in the dark and wonder if " +
					"you can just hide in the cabin and wait for the police to arrive.\n\n" +
					"Press P to follow the Path or H to Hide in the cabin";
					
		if (Input.GetKeyDown (KeyCode.P)) 		{ myState = States.darkness_f1p1; }
		else if (Input.GetKeyDown (KeyCode.H)) 	{ myState = States.cabin_f1p1; }
	}
	
	void cabin_f1p1() {
		text.text = "You run back into the cabin. Knowing very well that the man should be really close " +
					"by now. There is no point running away now. You look at the axe you left on the floor. " +
					"You also remember of a bed you saw when you where searching for the cabin. It is in a " +
					"dark corner. Under it might be a good place to hide.\n\n" +
					"Press A to get the axe to face the man or H to hide under the bed";
					
		if (Input.GetKeyDown (KeyCode.A)) 		{ myState = States.combat; }
		else if (Input.GetKeyDown (KeyCode.H)) 	{ myState = States.hide; }
	}
	
	void cabin_f1p0() {
		text.text = "You run back into the cabin, even though you know that the man is getting closer. \"" +
					"I can't just not know where I am going\", you think.\n\n" +
					"Press E to explore the cabin or O to get Out of the cabin";
		
		if (Input.GetKeyDown (KeyCode.P)) 		{ myState = States.phone_f1; }
		else if (Input.GetKeyDown (KeyCode.O)) 	{ myState = States.cabin_out_f1p0; }
	}
	
	void cabin_f0p1() {
		text.text = "You run back into the cabin, even though you know that the man is getting closer. \"" +
					"I can't just run into the darkness\", you think.\n\n" +
					"Press E to explore the cabin or O to get Out of the cabin";
		
		if (Input.GetKeyDown (KeyCode.E)) 		{ myState = States.flash_p1; }
		else if (Input.GetKeyDown (KeyCode.O)) 	{ myState = States.cabin_out_f0p1; }
	}
	
	void cabin_out_f1p0() {
		text.text = "You run to the outside of the cabin, now being able to see where you are going. " +
					"You aim the flashlight to the path and then to where you came from. Still no " +
					"sign of the man, but you know that he cannot be too far behind. You " +
					" wonder if you should just run to the path and hope to find something.\n\n" +
					"Press P to follow the Path or R to Return to the inside of the Cabin";
		
		if (Input.GetKeyDown (KeyCode.P)) 		{ myState = States.lost2; }
		else if (Input.GetKeyDown (KeyCode.R)) 	{ myState = States.cabin_f1p0; }
	}
	
	void cabin_out_f0p1() {
		text.text = "You run to the outside of the cabin, now knowing where you need to go. You look at " +
					"the path. Almost pitch black. You look where you came from, still no sign of the " +
					"man, but you know that time is not on your side. You wonder if with just what you" +
					" know you can make it to the town.\n\n" +
					"Press P to follow the dark path or R to Return to the inside of the Cabin";
					
		if (Input.GetKeyDown (KeyCode.P)) 		{ myState = States.lost1; }
		else if (Input.GetKeyDown (KeyCode.R)) 	{ myState = States.cabin_f0p1; }
	}
	
	void flash_p1() {
		text.text = "You desperately start looking at anything useful in the cabin. \"It is definately " +
					"not safe for you to stay where you are!\". This phrase echos in your mind, making you " +
					"hurry more and more. You finally open a drawer to find a flashlight and " +
					"remember right away of the dark path outside. More noises. No more time to waste.\n\n" +
					"Press O to get Out of the cabin";
					
		if (Input.GetKeyDown (KeyCode.O)) 	{ myState = States.cabin_out_f1p1; }
	}
	
	void phone_f1() {
		text.text = "You run towards the phone and press the button. Your thoughts are so concerned on " +
					"getting out fast that you don't realize the blessing of the phone having batteries. " +
					"You quickly dial 911. The call is redirected to the local police office, who " +
					"gives you directions on how to get to a small town about 2 km away from where you " +
					"are. \"The police is on its way, but it is definately not safe for you to wait there. " +
					"Everything will be ok, but...\" You heard what you needed! Time o get out!\n\n" +
					"Press O to get Out of the cabin";
					
		if (Input.GetKeyDown (KeyCode.O)) 	{ myState = States.cabin_out_f1p1; }
	}
	
	void flash_p0() {
	 	text.text = "You desperately look around the cabin. Not sure what you are looking for. \"A gun would " +
	 			 	"be nice!\" You think, and imediatelly feel awful for thinking that. When opening a " +
	 				"drawer you see a flashlight, and remember right away of the dark path outside. More noises" +
	 				" outside makes you seriously consider just run towards the path before he gets to you.\n\n" +
	 			 	"Press P to check the Phone or O to get Out";
	 			 
		if (Input.GetKeyDown (KeyCode.P)) 		{ myState = States.phone_f1; }
		else if (Input.GetKeyDown (KeyCode.O)) 	{ myState = States.cabin_out_f1p0; }
	}
	
	void phone_f0() {
		text.text = "You take the phone. You hands shake and you quickly pray for the phone to have battery." +
					"You press the button. Seeing the screen light up makes you smile with hope. You quickly " +
					"dial 911. The call is redirected to the local police office, who tells you to stay calm, " +
					"and give you directions on how to get to a small town about 2 km away from where you " +
					"are. \"The police is on its way, but it is definately not safe for you to wait there. " +
					"Everything will be ok, but you need to hu...\". You look at your phone. Battery is dead.\n\n" +
					"Press E to explore more of the cabin or press O to get Out";
					
		if (Input.GetKeyDown (KeyCode.E)) 		{ myState = States.flash_p1; }
		else if (Input.GetKeyDown (KeyCode.O)) 	{ myState = States.cabin_out_f0p1; }
	}
	
	void cabin_f0p0() {
		text.text = "You bust into the cabin. No one is there. It is dark, you can barelly see anything." +
					"Your eyes catch a glimpse of an object over a table and you step closer to check it out." +
					"It is a big old cellphone.\n\n" +
					"Press P to check Phone or press E to explore the cabin";
					
		if (Input.GetKeyDown (KeyCode.P)) 		{ myState = States.phone_f0; }
		else if (Input.GetKeyDown (KeyCode.E)) 	{ myState = States.flash_p0; }
	}
	
	void lost0() {
		text.text = "\"Forget the cabin! I just want to get out of here!\"\n" +
					"You run towards darkness. After a long time running, having no idea where you are " +
					"going, you notice that you really should have entered that cabin. Alone, lost and " +
					"afraid, all that it is left to do is wait for your terrible fate.\n\n" +
					"Press P to Play again";
		if (Input.GetKeyDown (KeyCode.P)) { myState = States.beginning; }
	}
	
	void darkness() {
		text.text = "You look to the path covered in complete darkness. Your complete terror makes you " +
					"consider just running towards darkness and hope for the best.\n\n" +
					"Press F to follow path or R to Return to the front of the cabin";
		
		if (Input.GetKeyDown (KeyCode.F)) { myState = States.lost0; }
		else if (Input.GetKeyDown (KeyCode.R)) { myState = States.cabin_out; }
	}
	
	void cabin_in() {
		text.text = "You run back to the front of the cabin, trying to shake off the feeling that whoever " +
					"was chasing you is now closer. You frenetically use the axe on the door of the cabin " +
					"until it finally opens.\n\n" +
					"Press E to enter the cabin";
		
		if (Input.GetKeyDown (KeyCode.E)) { myState = States.cabin_f0p0; }
	}
	
	void axe() {
		text.text = "When you get closer you recognize that the object is an axe. You think that you might " +
					"have found a way to enter the cabin.\n\n" +
					"Press T to take the axe or press R to return to the front of the cabin without the axe";
		
		if (Input.GetKeyDown (KeyCode.T)) { myState = States.cabin_in; }
		else if (Input.GetKeyDown (KeyCode.R)) { myState = States.cabin_out; }
	}
	
	void around() {
		text.text = "You run to the back of the cabin. You try to find anyway inside of the cabin through " +
					"here, but no luck. In the darkness, you can barelly see a shape of an object on top of " +
					"bunch of logs.\n\n" +
					"Press L to look at the shape or press R to return to the front of the cabin";
					
		if (Input.GetKeyDown (KeyCode.L)) { myState = States.axe; }
		else if (Input.GetKeyDown (KeyCode.R)) { myState = States.cabin_out; }
	}
	
	void cabin_out() {
		text.text = "You found yourself in front of a cabin, but the door is locked. " +
					"You hear sounds behind you, and shivers run down your spine. That maniac should be " +
					"getting closer! You got to find out how to get out of here fast! Maybe inside the " +
					"cabin there is a phone where I can call for help! But how to get inside?\n\n" +
					"Press A to go Around the cabin or P to check the Path to your right";
		
		if(Input.GetKeyDown(KeyCode.A)) {
			myState = States.around;
		} else if(Input.GetKeyDown(KeyCode.P)) {
			myState = States.darkness;
		}
	}
	
}
