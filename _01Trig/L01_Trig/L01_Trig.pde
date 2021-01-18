int frame = 0;
float multiplier = 0.302;
int numberOfPoints = 100;
int distance = 30;

void setup()
{
	size (640, 480);
	strokeWeight(6);
	
	numberOfPoints = 0;
	frame++;
}

void draw()
{
	background(0);
	cosCurve();
	circleCurve();
	stroke(255, 110, 199);

	for (int i = 0; i < width; i += distance)
	{
		point (distance + i, 240 + sin ((frame + i) * -0.01) * 100);	
	}

	stroke (127, 69, 249);
	for (int i = 0; i < width; i += distance)
	{
	point (distance + i, 246 + sin ((frame + i) * 0.01) * 130);
	}

frame++;
}

void cosCurve()
{
	stroke (125, 249, 255);
	scale (1,1);

	translate(width, height);
	rotate(PI/1);
	for (int i = 0; i < numberOfPoints; i++) 
	{
		point (i * 10, height / 2 + cos (frame * 0.026));
	}
}


void circleCurve()
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
