#include <limits>
#include <iostream>

using namespace std;

namespace ege27couple
{
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

	void task11363()
	{
		int a = 0;
		int b = 0;
		int sum = 0;
		int min = INT_MAX;
		int n = 0;
		int amount = 0;

		cin >> n;

		for (int i = 0; i < n; i++)
		{
			cin >> a >> b;
			sum += max(a, b);
			int subtruct = abs(a - b);
			if (subtruct < min && subtruct % 3 != 0)
			{
				min = subtruct;
				++amount;
			}
		}
		if (sum % 3 != 0)
		{
			cout << sum;
			return;
		}
		if (amount == 0)
		{
			cout << 0;
			return;
		}
		cout << sum - min;
	}

	int sumOfDigit(int n)
	{
		int s = 0;

		while (n != 0)
		{
			s += n % 10;
			n /= 10;
		}

		return s;
	}

	void task13423()
	{
		int N = 0;
		int number = 0;
		int max = INT_MIN;
		int maxInd = 0;
		cin >> N;
		int* a = new int[28];
		for (int i = 0; i < 28; i++)
		{
			a[i] = 0;
		}
		for (int i = 0; i < N; i++)
		{
			cin >> number;
			int sum = sumOfDigit(number);
			++a[sum];
		}
		for (int i = 0; i < 28; i++)
		{
			if (a[i] > max)
			{
				max = a[i];
				maxInd = i;
			}
		}
		cout << maxInd;
		delete[] a;
	}

	void task13476()
	{
		int N = 0;
		cin >> N;
		int number = 0;
		int min = INT_MAX;
		int minInd = 0;
		int* a = new int[28];
		for (int i = 0; i < 28; i++)
		{
			a[i] = 0;
		}
		for (int i = 0; i < N; i++)
		{
			cin >> number;
			int sum = sumOfDigit(number);
			++a[sum];
		}
		for (int i = 0; i < 28; i++)
		{
			if (a[i] <= min)
			{
				min = a[i];
				minInd = i;
			}
		}
		cout << minInd;
		delete[] a;
	}

	void task13503()
	{
		int N = 0;
		cin >> N;
		int number = 0;
		int max = INT_MIN;
		int* a = new int[10];
		for (int i = 0; i < 10; i++)
		{
			a[i] = 0;
		}
		for (int i = 0; i < N; i++)
		{
			cin >> number;
			while (number != 0)
			{
				int digit = number % 10;
				++a[digit];
				number /= 10;
			}
		}
		for (int i = 0; i < 10; i++)
		{
			if (a[i] > max)
			{
				max = a[i];
			}
		}
		for (int i = 0; i < 10; i++)
		{
			if (a[i] == max)
			{
				cout << i;
			}
		}
		delete[] a;
	}

	void task13530()
	{
		int N = 0;
		cin >> N;
		int number = 0;
		int max = INT_MIN;
		int max1 = INT_MIN;
		int* a = new int[10];
		for (int i = 0; i < 10; i++)
		{
			a[i] = 0;
		}
		for (int i = 0; i < N; i++)
		{
			cin >> number;
			while (number != 0)
			{
				int digit = number % 10;
				++a[digit];
				number /= 10;
			}
		}
		for (int i = 0; i < 10; i++)
		{
			if (a[i] >= max)
			{
				max = a[i];
			}

		}


		cout << max;
		delete[] a;
	}

	void task13557()
	{
		int number = 0;
		int sum = 0;
		int max = INT_MIN;
		int n = 0;
		int amount = 0;

		cin >> n;

		for (int i = 0; i < n; i++)
		{
			cin >> number;
			sum += number;
			if (sum > max && sum % 6 != 0)
			{

				max = sum;
				++amount;
			}
		}

		if (amount == 0)
		{
			cout << 0;
			return;
		}
		cout << amount << sum;

	}

}