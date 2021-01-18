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
float multiplier = 0.302f;
int numberOfPoints = 100;
int distance = 30;

public void setup()
{
	
	strokeWeight(6);
	
	numberOfPoints = 0;
	frame++;
}

public void draw()
{
	background(0);
	cosCurve();
	circleCurve();
	stroke(255, 110, 199);

	for (int i = 0; i < width; i += distance)
	{
		point (distance + i, 240 + sin ((frame + i) * -0.01f) * 100);	
	}

	stroke (127, 69, 249);
	for (int i = 0; i < width; i += distance)
	{
	point (distance + i, 246 + sin ((frame + i) * 0.01f) * 130);
	}

frame++;
}

public void cosCurve()
{
	stroke (125, 249, 255);
	scale (1,1);

	translate(width, height);
	rotate(PI/1);
	for (int i = 0; i < numberOfPoints; i++) 
	{
		point (i * 10, height / 2 + cos (frame * 0.026f));
	}
}


public void circleCurve()
{
	float centerX = width / 2;
	float centerY = height / 2;
	float radius = 150;
	float angle = 0;
	float slice = PI * 2 / numberOfPoints;

	translate(width / 2, height / 2);

for (int i = 0; i < numberOfPoints; i++)
	{
		angle = i * slice;
		centerX = cos(angle) * radius;
		centerY = sin(angle) * radius;
		point (centerX, centerY);	
	}
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
