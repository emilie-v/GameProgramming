int numberOfPoints = 100;
int distance = 30;
PVector centerPoint = new PVector();
float offset;

void setup()
{
	size (640, 480);
	strokeWeight(6);
	stroke(54, 117, 136);
	centerPoint = new PVector (width / 2, height / 2);
	numberOfPoints = 0;

}

void draw()
{
	background(0);
	numberOfPoints = 100;
	circleCurve();
	offset = millis() * 0.007;

}


void circleCurve()
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
