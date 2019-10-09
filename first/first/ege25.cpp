#include <iostream>

using namespace std;

namespace ege
{
	void ege9209()
	{
		int number = 0;
		int amount = 0;
		int sum = 0;
		int k1 = 0;
		int k2 = 0;
		cin >> amount;
		for (int i = 0; i < amount; i++)
		{
			cin >> number;
			sum = sum + number;
			if (number % 2 == 0)
			{
				k1++;
			}
			else
			{
				k2++;
			}

		}

		if (sum % 2 == 0)
		{
			cout << k1;
		}
		else
		{
			cout << k2;
		}
	}

	void ege9209array()
	{
		int const amount = 6;
		int a[amount];
		int sum = 0;
		int k1 = 0;
		int k2 = 0;
		for (int i = 0; i < amount; i++)
		{
			cin >> a[i];
			sum = sum + a[i];
			if (a[i] % 2 == 0)
			{
				k1++;
			}
			else
			{
				k2++;
			}

		}

		if (sum % 2 == 0)
		{
			cout << k1;
		}
		else
		{
			cout << k2;
		}
	}

	void ege9209arrayIn()
	{
		int amount;
		cin >> amount;
		int* a = new int[amount];
		int sum = 0;
		int k1 = 0;
		int k2 = 0;
		for (int i = 0; i < amount; i++)
		{
			cin >> a[i];
			sum = sum + a[i];
			if (a[i] % 2 == 0)
			{
				k1++;
			}
			else
			{
				k2++;
			}

		}

		if (sum % 2 == 0)
		{
			cout << k1;
		}
		else
		{
			cout << k2;
		}
	}

	void ege2907()
	{
		int number = 0;
		int raz = 0;
		int max1 = INT_MIN;
		int max2 = INT_MIN;
		int amount = 0;
		cin >> amount;
		for (int i = 0; i < amount; i++)
		{
			cin >> number;
			if (number % 2 == 0 && number > max1)
			{
				max1 = number;
			}
			if (number % 2 != 0 && number > max2)
			{
				max2 = number;
			}
		}
		raz = max1 - max2;
		cout << raz;
	}

	void in9209(int* a, int size)
	{
		int sum = 0;
		int k1 = 0;
		int k2 = 0;
		for (int i = 0; i < size; i++)
		{
			cin >> a[i];
			sum = sum + a[i];
			if (a[i] % 2 == 0)
			{
				k1++;
			}
			else
			{
				k2++;
			}

		}

		if (sum % 2 == 0)
		{
			cout << k1;
		}
		else
		{
			cout << k2;
		}
	}

	void ege7682array()
	{
		int size = 0;
		cin >> size;
		int* a = new int[size];
		int amount = 0;

		for (int i = 0; i < size; i++)
		{
			cin >> a[i];
		}

		for (int i = 0; i < size - 1; i++)
		{
			int sum = a[i] + a[i + 1];
			if (sum % 2 == 0 && sum % 4 != 0)
			{
				++amount;
			}
		}

		cout << amount;
	}

	void ege7682()
	{
		int size = 0;
		cin >> size;
		int current = 0;
		int next = 0;
		int amount = 0;

		cin >> current;
		for (int i = 0; i < size - 1; i++)
		{
			cin >> next;
			int sum = current + next;
			if (sum % 2 == 0 && sum % 4 != 0)
			{
				++amount;
			}
			current = next;
		}

		cout << amount;
	}

	void ege7770array()
	{
		int size = 0;
		cin >> size;
		int* a = new int[size];
		int amount = 0;
		for (int i = 0; i < size; i++)
		{
			cin >> a[i];
		}
		for (int i = 0; i < size - 1; i++)
		{
			int proizv = a[i] * a[i + 1];
			int sum = a[i] + a[i + 1];
			if (proizv > 0 && sum % 7 == 0)
			{
				amount++;
			}
		}
		cout << amount;
	}

	void ege9811array()
	{
		int size = 0;
		cin >> size;
		int* a = new int[size];
		int min = INT_MAX;
		for (int i = 0; i < size; i++)
		{
			cin >> a[i];
		}
		for (int i = 1; i < size - 1; i++)
		{
			if (a[i - 1] > a[i] && a[i] < a[i + 1] && a[i] < min)
			{
				min = a[i];
			}
		}
		cout << min;
	}

	void ege2914array()
	{
		int size = 0;
		cin >> size;
		int* a = new int[size];
		int min = INT_MAX;
		int max = INT_MIN;
		int sum = 0;
		int raz = 0;
		for (int i = 0; i < size; i++)
		{
			cin >> a[i];
		}
		for (int i = 0; i < size; i++)
		{
			if (a[i] < min)
			{
				min = a[i];
			}
			if (a[i] > max)
			{
				max = a[i];
			}
			sum = sum + a[i];
		}
		double sr1 = (max + min) / 2.0;
		double sr2 = double(sum) / size;
		raz = sr1 - sr2;
		cout << raz;
	}

	void ege2901array()
	{
		int size = 0;
		cin >> size;
		int* a = new int[size];
		int amount = 0;
		int sum = 0;
		for (int i = 0; i < size; i++)
		{
			cin >> a[i];
		}
		for (int i = 0; i < size; i++)
		{
			if (a[i] % 2 != 0)
			{
				amount++;
				sum = sum + a[i];
			}
		}
		double sr = double(sum) / amount;
		cout << sr;
	}

	void ege3622array()
	{
		int size = 0;
		cin >> size;
		int* a = new int[size];
		int len = 1;
		int sum = 0;
		int max = INT_MIN;
		for (int i = 0; i < size; i++)
		{
			cin >> a[i];
		}
		sum = a[0];
		for (int i = 0; i < size - 1; i++)
		{
			if (a[i] <= a[i + 1])
			{
				++len;
				sum = sum + a[i + 1];
			}
			else
			{
				if (len > max)
				{
					max = len;
					len = 0;
					sum = a[i + 1];
				}
			}
		}
		cout << sum;
	}
}