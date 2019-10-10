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

	void ege7709array()
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
			if (sum % 3 == 0 && sum % 9 != 0)
			{
				++amount;
			}
		}

		cout << amount;

	}

	void ege7797array()
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
			int proizv = a[i] * a[i + 1];
			if (sum % 6 != 0 && proizv < 1000)
			{
				++amount;
			}
		}
		cout << amount;
	}

	void ege8113array()
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
			if (a[i] % 3 == 0 && a[i + 1] % 3 == 0)
			{
				amount++;
			}
		}
		cout << amount;
	}

	void ege6936array()
	{
		int size = 0;
		cin >> size;
		int* a = new int[size];
		int max = INT_MIN;
		int el1 = 0;
		int el2 = 0;
		for (int i = 0; i < size; i++)
		{
			cin >> a[i];
		}
		for (int i = 0; i < size - 1; i++)
		{
			int raz = a[i + 1] - a[i];
			if (raz > max)
			{
				max = raz;
				el1 = a[i];
				el2 = a[i + 1];
			}
		}
		cout << el1 << endl << el2;
	}

	void ege11361array()
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
			
			if (a[i] % 10 == 2 || a[i + 1] % 10 == 2)
			{
				++amount;
			}
		}

		cout << amount;
	}

	void ege9317array()
	{
		int size = 0;
		cin >> size;
		int* a = new int[size];
		int amount1 = 0;
		int amount2 = 0; 
		int sum = 0;
		for (int i = 0; i < size; i++)
		{
			cin >> a[i];
		}

		for (int i = 0; i < size; i++)
		{
			
			sum = sum + a[i];
			if (a[i] % 2 == 0)
			{
				++amount1;
			}
			else
			{
				++amount2;
			}
		}
		if (sum % 2 == 0)
		{
			cout << amount2;
		}
		else
		{
			cout << amount1;
		}
	}

	void ege2909array()
	{
		int size = 0;
		cin >> size;
		int* a = new int[size];
		int sum = 0;
		int amount = 0;
		for (int i = 0; i < size; i++)
		{
			cin >> a[i];
		}

		for (int i = 0; i < size; i++)
		{
			if (a[i] < 0)
			{
				++amount;
				sum = sum + a[i];
			}
		}
		if (amount > 0)
		{
			cout << sum;
		}
		else
		{
			cout << "NO";
		}
	}

	void ege2925array()
	{
		int size = 0;
		cin >> size;
		int* a = new int[size];
		int sum = 0;
		int amount = 0;
		
		for (int i = 0; i < size; i++)
		{
			cin >> a[i];
		}

		for (int i = 0; i < size-1; i++)
		{
			if (a[i] < a[size-1])
			{
				sum = sum + a[i];
				++amount;
			}
		}
		double sr = double(sum) / amount;
		cout << sr;
	}

	void ege7214array()
	{
		int size = 0;
		cin >> size;
		int* a = new int[size];
		int sum = 0;
		int amount = 0;
		for (int i = 0; i < size; i++)
		{
			cin >> a[i];
		}

		for (int i = 0; i < size - 1; i++)
		{
			if (a[i] < 0)
			{
				++amount;
				sum = sum + a[i];
			}
		}
		double sr = double(sum) / amount;
		cout << sr;
	}

	void ege7383array()
	{
		int size = 0;
		cin >> size;
		int* a = new int[size];
		int sum1 = 0;
		int amount1 = 0;
		int sum2 = 0;
		int amount2 = 0;
		for (int i = 0; i < size; i++)
		{
			cin >> a[i];
		}

		for (int i = 0; i < size - 1; i++)
		{
			if (a[i] = 4)
			{
				++amount1;
				sum1 = sum1 + a[i];
			}
			if (a[i] = 5)
			{
				++amount2;
				sum2 = sum2 + a[i];
			}
		}
		double sr1 = double(sum1) / amount1;
		double sr2 = double(sum2) / amount2;
		cout << sr1 << endl << sr2;
	}
}