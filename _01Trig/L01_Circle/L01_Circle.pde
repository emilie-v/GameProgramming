PVector centerPoint = new PVector();
float offset;

void setup()
{
	size (640, 480);
	strokeWeight(6);
	
	centerPoint = new PVector (width / 2, height / 2);
}

void draw()
{
	background(0);
	circleCurve();
	spiral();
	offset = millis() * 0.004;

}

void circleCurve()
{
	stroke(54, 117, 136);
	int circlePoints = 100;
	float radius = 232;
	float angle = 0;
	float slice = PI * 2 / circlePoints;

for (int i = 0; i < circlePoints; i++)
	{
		angle = i * slice;
		float x = centerPoint.x + cos(angle + offset) * radius;
		float y = centerPoint.y + sin(angle + offset) * radius;
		point (x, y);	
		//line (x, y, centerPoint.x, centerPoint.y);
	}
}

void spiral()
{
	int spiralPoints = 104;
	float radius = 234;
	float angle = 0;
	float slice = PI * 5 / spiralPoints;

	color from = color (179, 59, 245);
	color to = color (54, 119, 136);

	float colourIncrement = (float) spiralPoints / (spiralPoints * spiralPoints);
	println(colourIncrement);

	for (int i = 0; i < spiralPoints; i++) 
	{
	 	stroke (lerpColor(from, to, colourIncrement * i));

		float distance = ((float) i / spiralPoints);
		angle = i * slice;
		float x = centerPoint.x + cos(angle + offset) * radius * distance;
		float y = centerPoint.y + sin(angle + offset) * radius * distance;
		point (x, y);
	}
}
