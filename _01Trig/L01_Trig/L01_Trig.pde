int frame;
float multiplier = 0.302;
int numberOfPoints;

void setup()
{
	size (640, 480);
	strokeWeight(6);
	stroke(255, 110, 199);
	clearBackground();
	numberOfPoints = 0;
	frame++;
}

void clearBackground()
{
	background(0);
}

void sineCurve()
{
	for (int i = 0; i < numberOfPoints; i++) 
	{
		ponts(i * 5, height / 2 + sin ((frame * 0.05) + (i + 0.15)) + 200);	
	}
}

void cosCurve()
{
	
}