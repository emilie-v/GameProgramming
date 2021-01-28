import processing.core.*; 
import processing.data.*; 
import processing.event.*; 
import processing.opengl.*; 

import java.util.HashMap; 
import java.util.ArrayList; 
import java.io.File; 
import java.io.BufferedReader; 
import java.io.PrintWriter; 
import java.io.InputStream; 
import java.io.OutputStream; 
import java.io.IOException; 

public class WalkerTest extends PApplet {

WalkerInterface walker;
PVector walkerPos;

public void setup() 
{
  

  //Create a walker from the class Example it has the type of WalkerInterface
  walker = new emivog();

  walkerPos = walker.getStartPosition(width, height);
}

public void draw() 
{
  point(walkerPos.x, walkerPos.y);
  walkerPos.add(walker.update());
  if (walkerPos.x > width || walkerPos.x < 0 || walkerPos.y > height || walkerPos.y < 0) 
  {
    println("dead af");
    exit();
  }
}
interface WalkerInterface {
  //returns the name of the walker, should be your name!
  public String getName();

  //returns the start position for the walker
  public PVector getStartPosition(int playAreaWidth, int playAreaHeight);

  //updates the walker position
  //the walker is only allowed to take one step, left/right or up/down
  //If the walker moves diagonally or too long, it will be killed.
  public PVector update();
}
class emivog implements WalkerInterface 
{

	PVector currentPos = new PVector();
	PVector previousDir = new PVector();

	int boardWidth;
	int boardHeight;

  public String getName()
  {
  	return "Emmie";
  }

  public PVector getStartPosition(int playAreaWidth, int playAreaHeight)
  {
    //Select a starting position or use a random one.
    float x = (int) random(0, playAreaWidth);
    float y = (int) random(0, playAreaHeight);

    boardWidth = playAreaWidth;
    boardHeight = playAreaHeight;

    currentPos = new PVector(x, y);

    //a PVector holds floats but make sure its whole numbers that are returned!
    return new PVector(x, y);
  }

  public PVector update()
  {

  	PVector direction = new PVector();
  	PVector newPos = new PVector();

  	do 
  	{
  		switch((int)random(0, 4)) 
  		{
  			case 0:
  			direction = new PVector(-1, 0);
  			break;

  			case 1:
  			direction = new PVector(1, 0);
  			break;

  			case 2:
  			direction = new PVector(0, 1);
  			break;

  			default:
  			direction = new PVector(0, -1);
  			break;
  		} 
  		newPos = new PVector (currentPos.x, currentPos.y);
  		newPos.add (direction);
  	}

  	while (newPos.x > boardWidth || newPos.x < 0 || newPos.y > boardHeight || newPos.y < 0
  		|| (previousDir.x == direction.x && previousDir.y == direction.y));

  		currentPos.add(direction);
  	previousDir = new PVector (-direction.x, direction.y);

  	return new PVector(direction.x, direction.y);
  }
}
  public void settings() {  size(20, 20); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "WalkerTest" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
