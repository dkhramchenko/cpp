#include "LIMITS.h"

int sum(int number)
{
	int f = 0;
	for (int i = 1; i <= number; i++)
	{
		f += i;
	}
	return f;
}

int max(int a, int b)
{
	if (a > b)
	{
		return a;
	}
	else
	{
		return b;
	}
}

int max(int a, int b, int c)
{
	int m = 0;
	if (a > b)
	{
		m = a;
	}
	else
	{
		m = b;
	}
	if (m > c)
	{
		return m;
	}
	else
	{
		return c;
	}
}

int max(int a1, int a2, int a3, int a4)
{
	int m = a1;
	if (a2 > m)
	{
		m = a2;
	}
	if (a3 > m)
	{
		m = a3;
	}
	if (a4 > m)
	{
		m = a4;
	}
	return m;
}

int max(int* a, int size)
{
	int m = INT_MIN;
	for (int i = 0; i < size; i++)
	{
		if (a[i] > m)
		{
			m = a[i];
		}
	}
	return m;
}