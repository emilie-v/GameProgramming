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

public class L01_Circle extends PApplet {

int frame = 0;
int numberOfPoints = 100;
int distance = 30;
PVector centerPoint = new PVector();
float offset;

public void setup()
{
	
	strokeWeight(6);
	stroke(54, 117, 136);
	centerPoint = new PVector (width / 2, height / 2);
	numberOfPoints = 0;
	frame++;
}

public void draw()
{
	background(0);
	numberOfPoints = 100;
	circleCurve();
	offset = millis() * 0.001f;

frame++;
}


public void circleCurve()
{
	float radius = 150;
	float angle = 0;
	float slice = PI * 2 / numberOfPoints;

for (int i = 0; i < numberOfPoints; i++)
	{
		angle = i * slice;
		float x = centerPoint.x + cos(angle + offset) * radius;
		float y = centerPoint.y + sin(angle + offset) * radius;
		point (x, y);	
	}
}
  public void settings() { 	size (640, 480); }
  static public void main(String[] passedArgs) {
    String[] appletArgs = new String[] { "L01_Circle" };
    if (passedArgs != null) {
      PApplet.main(concat(appletArgs, passedArgs));
    } else {
      PApplet.main(appletArgs);
    }
  }
}
