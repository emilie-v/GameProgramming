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

public class L01_Trig extends PApplet {

int frame = 0;
float speed = 0.01f;
int numberOfPoints = 100;
int distance = 30;
int curvePos = 240;
int curveHeight = 120;

public void setup()
{
	
	strokeWeight(6);
	
	numberOfPoints = 0;
	frame++;
}

public void draw()
{
	background(0);
	stroke(255, 110, 199);

	for (int i = 0; i < width; i += distance)
	{
		point (distance + i, curvePos + sin ((frame + i) * speed) * curveHeight);	
	}

	stroke (127, 69, 249);
	for (int i = 0; i < width; i += distance)
	{
	point (distance + i, curvePos + cos ((frame + i) * speed + PI / 2) * curveHeight);
	}

frame++;
}
  public void settings() { 	size (640, 480); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "L01_Trig" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
