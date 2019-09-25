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

int task4(int* a, int size)
{
	int m = INT_MIN;
	for (int i = 0; i < size; i++)
	{
		if (a[i] % 7 == 0 && a[i] % 10 == 9 && a[i] > m)
		{
			m = a[i];
		}
	}
	return m;
}

int task5(int* a, int size)
{
	int k = 0;
	for (int i = 0; i < size; i++)
	{
		if (a[i] % 2 == 0 && a[i] > 7 && a[i] < 78)
		{
			k++; 
		}
	}
	return k;
}

int task6(int* a, int size)
{
	int m1 = INT_MIN;
	int m2 = INT_MIN;
	int k1 = 0;
	int k2 = 0;
	int s = 0;
	for (int i = 0; i < size; i++)
	{
		s += a[i];
		if (a[i] % 2 == 0)
		{
			k1++;
		}
		if (a[i] % 2 != 0)
		{
			k2++;
		}
		if (a[i] % 2 == 0 && a[i] > m1)
		{
			m1 = a[i];
		}
		if (a[i] % 2 != 0 && a[i] > m2)
		{
			m2 = a[i];
		}
	}
	if (k1 == k2)
	{
		return s;
	}
	if (k1 > k2)
	{
		return m1;
	}
	if (k2 > k1)
	{
		return m2;
	}
}
	
	
int task7(int* a, int size)
{
	int sa = 0;
	int k = 0;
	int s = 0;
	for (int i = 0; i < size; i++)
	{
		if (a[i] % 7 == 0)
		{
			k++;
			s = s + a[i];
			sa = s / k;
		}
	}
	return sa;

}

int task8(int* a, int size)
{
	double prosent = 0;
	int k = 0;
	for (int i = 0; i < size; i++)
	{
		if (a[i] > 0)
		{
			k++;
		}
	}
	prosent = k * 100;
	prosent = prosent / size;
	return prosent;
}

int task9(int* a, int size)
{
	int r = 0;
	int k1 = 0;
	int k2 = 0;
	for (int i = 0; i < size; i++)
	{
		if (a[i] % 2 == 0)
		{
			k1++;
		}
		if (a[i] % 2 != 0)
		{
			k2++;
		}
		
	}
	r = k1 - k2;
	return r;
}

int task10(int* a, int size)
{
	int r = 0;
	int s = 0;
	int p = 1;
	for (int i = 0; i < size; i++)
	{
		if (a[i] % 3 == 0)
		{
			s = s + a[i];
		}
		
		if (a[i] % 7 == 0)
		{
			p = p * a[i];
		}
		
	}
	r = s - p;
	return r;
}

int task11(int* a, int size)
{
	int m1 = INT_MIN;
	int m2 = INT_MIN;
	for (int i = 0; i < size; i++)
	{
		if (a[i] > m1)
		{
			m1 = a[i];
			m2 = m1;
			
		}
	}
	return m2;
}




