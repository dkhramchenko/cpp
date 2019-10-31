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
		for (int i = 9; i >= 0; --i)
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

		int maxIndex = INT_MIN;
		for (int i = 0; i < 10; i++)
		{
			if (a[i] >= max)
			{
				max = a[i];
				maxIndex = i;
			}
		}


		cout << maxIndex;
		delete[] a;
	}

	void task13557()
	{
		int number = 0;
		int sum = 0;
		int n = 0;
		int min = INT_MAX;

		cin >> n;

		for (int i = 0; i < n; i++)
		{
			cin >> number;
			sum += number;
			if (number < min && number % 6 != 0)
			{
				min = number;
			}
		}

		if (sum % 6 != 0)
		{
			cout << n << " " << sum;
			return;
		}
		if (min != INT_MAX)
		{
			cout << n - 1 << " " << sum - min;
		}
		else
		{
			cout << 0 << " " << 0;
		}

	}

	void task13584()
	{
		int number = 0;
		int n = 0;
		int sum = 0;
		int min = INT_MAX;
		cin >> n;
		for (int i = 0; i < n; i++)
		{
			cin >> number;
			sum += number;
			if (number < min && number % 8 != 0)
			{
				min = number;
			}
		}
		if (sum % 8 != 0)
		{
			cout << n << ' ' << sum;
			return;
		}
		if (min != INT_MAX)
		{
			cout << n - 1 << ' ' << sum - min;
		}
		else
		{
			cout << 0 << ' ' << 0;
		}
	}

	int amountOfDigit(int n)
	{
		int l = 0;
		while (n != 0)
		{
			++l;
			n /= 10;
		}
		return l;
	}

	void task13611()
	{
		int n = 0;
		int amount = 0;
		int number = 0;
		int max = INT_MIN;
		int maxInd = INT_MIN;
		int* a = new int[9];
		for (int i = 0; i < 9; i++)
		{
			a[i] = 0;
		}
		cin >> n;
		for (int i = 0; i < n; i++)
		{
			cin >> number;
			int len = amountOfDigit(number);
			++a[len];
		}
		for (int i = 0; i < 9; i++)
		{
			if (a[i] >= max)
			{
				max = a[i];
				maxInd = i;
			}
		}
		cout << maxInd << ' ' << max;
		delete[] a;
	}

	void task13638()
	{
		int n = 0;
		int number = 0;
		int min = INT_MAX;
		int minInd = INT_MAX;
		int* a = new int[9];
		for (int i = 0; i < 9; i++)
		{
			a[i] = 0;
		}
		cin >> n;
		for (int i = 0; i < n; i++)
		{
			cin >> number;
			int len = amountOfDigit(number);
			++a[len];
		}
		for (int i = 0; i < 9; i++)
		{
			if (a[i] < min && a[i] > 0)
			{
				min = a[i];
				minInd = i;
			}
		}
		cout << minInd << ' ' << min;
		delete[] a;
	}

	void task13754()
	{
		int n = 0;
		cin >> n;
		int n2 = 0;
		int n13 = 0;
		int n26 = 0;
		int number = 0;

		for (int i = 0; i < n; i++)
		{
			cin >> number;
			if (number % 2 == 0 && number % 13 != 0)
			{
				++n2;
				continue;
			}
			if (number % 13 == 0 && number % 2 != 0)
			{
				++n13;
				continue;
			}
			if (number % 2 == 0 && number % 13 == 0)
			{
				++n26;
				continue;
			}
		}
		int n0 = n - (n2 + n13 + n26);
		cout << n26 * (n2 + n13 + n0) + n13 * n2;
	}

	void task14242()
	{
		int N = 0;
		int number = 0;
		int max = INT_MIN;
		int maxInd = 0;
		cin >> N;
		int* a = new int[19];
		for (int i = 0; i < 19; i++)
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

	void task18096()
	{
		int n = 0;
		cin >> n;
		int n2 = 0;
		int n31 = 0;
		int n62 = 0;
		int number = 0;
		for (int i = 0; i < n; i++)
		{
			cin >> number;
			if (number % 2 == 0 && number % 31 != 0)
			{
				++n2;
				continue;
			}
			if (number % 31 == 0 && number % 2 != 0)
			{
				++n31;
				continue;
			}
			if (number % 2 == 0 && number % 31 == 0)
			{
				++n62;
				continue;
			}
		}
		int n0 = n - (n2 + n31 + n62);
		cout << n62 * (n2 + n31 + n0) + n31 * n2;
	}

	void task18455()
	{
		int n = 0;
		cin >> n;
		int n2 = 0;
		int n5 = 0;
		int n10 = 0;
		int number = 0;
		for (int i = 0; i < n; i++)
		{
			cin >> number;
			if (number % 2 == 0 && number % 5 != 0)
			{
				++n2;
				continue;
			}
			if (number % 5 == 0 && number % 2 != 0)
			{
				++n5;
				continue;
			}
			if (number % 2 == 0 && number % 5 == 0)
			{
				++n10;
				continue;
			}
		}
		int n0 = n - (n2 + n5 + n10);
		cout << n10 * (n2 + n5 + n0) + n5 * n2;
	}
}