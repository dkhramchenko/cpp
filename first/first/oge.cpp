#include "LIMITS.h"

int task1(int* a, int size)
{
	int m = INT_MIN;
	for (int i = 0; i < size; i++)
	{
		if (a[i] % 3 == 0 && a[i] > m)
		{
			m = a[i];
		}
	}
	return m;
}

int task2(int* a, int size)
{
	int m = INT_MAX;
	for (int i = 0; i < size; i++)
	{
		if (a[i] % 10 == 4 && a[i] < m)
		{
			m = a[i];
		}
	}
	return m;
}

int task3(int* a, int size)
{
	int s = 0;
	for (int i = 0; i < size; i++)
	{
		if (a[i] % 2 == 0)
		{
			s = s + a[i];
		}
	}
	return s;
}