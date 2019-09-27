#include <iostream>
#include <ctime>

// using namespace std;

namespace massiv
{
	// massiv input from keyboard
	void in(int* a, int size)
	{
		for (int i = 0; i < size; i++)
		{
			std::cin >> a[i];
		}
	}

	// massiv random input
	void inRand(int* a, int size)
	{
		srand(time(0));
		for (int i = 0; i < size; i++)
		{
			a[i] = rand() % 100;
		}
	}

	// massiv output to console
	void out(int* a, int size)
	{
		for (int i = 0; i < size; i++)
		{
			std::cout << a[i] << " ";
		}
		std::cout << std::endl;
	}
}