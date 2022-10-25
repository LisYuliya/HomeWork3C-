/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int x1 = 7;
int y1 = -5;
int z1 = 0;


int x2 = 1;
int y2 = -1;
int z2 = 9;


 int X = (x2-x1)*(x2-x1);
int Y = (y2-y1)*(y2-y1);
int Z= (z2-z1)*(z2-z1);

double DistanceAB = Math.Sqrt(X+Y+Z);
System.Console.WriteLine(DistanceAB);


