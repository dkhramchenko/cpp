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
			int sum = number % 10 + (number / 10) % 10;
			++a[sum];
		}
		for (int i = 0; i < 19; i++)
		{
			if (a[i] >= max)
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

	void task15643()
	{
		int N = 0;
		int number = 0;
		int n2 = 0;
		int n17 = 0;
		int n34 = 0;
		cin >> N;
		for (int i = 0; i < N; i++)
		{
			cin >> number;
			if (number % 2 == 0 && number % 17 != 0)
			{
				++n2;
			}
			if (number % 17 == 0 && number % 2 != 0)
			{
				++n17;
			}
			if (number % 2 == 0 && number % 17 == 0)
			{
				++n34;
			}
		}
		int n0 = N - (n2 + n17 + n34);
		cout << n0*(1 + n2 + n17);
	}

	void task15812()
	{
		int number = 0;
		int n = 0;
		cin >> n;
		int n1 = 0;
		int n2 = 0;
		int n3 = 0;
		int n4 = 0;
		for (int i = 0; i < n; i++)
		{
			cin >> number;
			if (number % 3 == 0 && number % 2 == 0)
			{
				++n1;
			}
			if (number % 3 == 0 && number % 2 != 0)
			{
				++n2;
			}
			if (number % 3 != 0 && number % 2 == 0)
			{
				++n3;
			}
			if (number % 3 != 0 && number % 2 != 0)
			{
				++n4;
			}
		}
		cout << n1 * (n2 + n4) + n3 * n2;
	}

	void task15867()
	{
		int n = 0;
		cin >> n;
		int number = 0;
		int n2 = 0;
		int n7 = 0;
		int n14 = 0;
		int n0 = 0;
		for (int i = 0; i < n; i++)
		{
			cin >> number;
			if (number % 2 == 0 && number % 7 != 0)
			{
				++n2;
			}
			if (number % 7 == 0 && number % 2 != 0)
			{
				++n7;
			}
			if (number % 2 == 0 && number % 7 == 0)
			{
				++n14;
			}
			if (number % 2 != 0 && number % 7 != 0)
			{
				++n0;
			}
		}
		cout << n0 * (n2 + n7) + n2*(n2-1)/2 + n7*(n7-1)/2 + n0*(n0-1)/2;
	}

	void task15937()
	{
		int n = 0;
		cin >> n;
		int number = 0;
		int m1 = 0;
		int m2 = 0;
		int m3 = 0;
		int m4 = 0;
		for (int i = 0; i < n; i++)
		{
			cin >> number;
			if (number % 3 == 0 && number % 2 == 0 && number > m1)
			{
				m1 = number;
			}
			if (number % 3 == 0 && number % 2 != 0 && number > m2)
			{
				m2 = number;
			}
			if (number % 3 != 0 && number % 2 == 0 && number > m3)
			{
				m3 = number;
			}
			if (number % 3 != 0 && number % 2 != 0 && number > m4)
			{
				m4 = number;
			}
		}
		int p1 = m1 * m2;
		int p2 = m1 * m4;
		int p3 = m2 * m3;

		if (p1 + p2 + p3 == 0)
		{
			cout << 0;
			return;
		}

		if (p1 >= p2 && p1 >= p3)
		{
			cout << m1 << " " << m2;
			return;
		}

		if (p2 >= p1 && p2 >= p3)
		{
			cout << m1 << " " << m4;
			return;
		}

		if (p3 >= p2 && p3 >= p1)
		{
			cout << m2 << " " << m3;
			return;
		}
	}

	void task14286()
	{
		int N = 0;
		int number = 0;
		int min = INT_MAX;
		int minInd = 0;
		cin >> N;
		int* a = new int[19];
		for (int i = 0; i < 19; i++)
		{
			a[i] = 0;
		}
		for (int i = 0; i < N; i++)
		{
			cin >> number;
			int sum = number % 10 + (number / 10) % 10;
			++a[sum];
		}
		for (int i = 0; i < 19; i++)
		{
			if (a[i] < min && a[i] > 0)
			{
				min = a[i];
				minInd = i;
			}
		}
		cout << minInd;
		delete[] a;
	}

	void task14713()
	{
		int number = 0;
		int n = 0;
		cin >> n;
		int m[7];
		for (int i = 0; i < 7; i++)
		{
			m[i] = 0;
		}
		for (int i = 0; i < n; i++)
		{
			cin >> number;
			int ost = number % 7;
			for (int i = 0; i < 7; i++)
			{
				if (i % 7 == ost)
				{
					++m[i];
				}
			}
		}

		cout << m[1] * m[6] + m[2] * m[5] + m[3] * m[4] + m[0] * (m[0] - 1) / 2;
	}

	void task15122()
	{
		int number = 0;
		int n = 0;
		cin >> n;
		int m[8];
		for (int i = 0; i < 8; i++)
		{
			m[i] = 0;
		}
		for (int i = 0; i < n; i++)
		{
			cin >> number;
			int ost = number % 8;
			for (int i = 0; i < 8; i++)
			{
				if (i % 8 == ost)
				{
					++m[i];
				}
			}
		}
		
		cout << m[3] * m[5] + m[1] * m[7] + m[2] * m[6] + m[4] * (m[4] - 1) / 2 + m[0] * (m[0] - 1) / 2;
	}

	void task15839()
	{
		int number = 0;
		int n = 0;
		cin >> n;
		int n1 = 0;
		int n2 = 0;
		int n3 = 0;
		int n4 = 0;
		for (int i = 0; i < n; i++)
		{
			cin >> number;
			if (number % 5 == 0 && number % 2 == 0)
			{
				++n1;
			}
			if (number % 5 == 0 && number % 2 != 0)
			{
				++n2;
			}
			if (number % 5 != 0 && number % 2 == 0)
			{
				++n3;
			}
			if (number % 5 != 0 && number % 2 != 0)
			{
				++n4;
			}
		}
		cout << n1 * (n2 + n4) + n3 * n2;
	}

	void task15964()
	{
		int n = 0;
		cin >> n;
		int number = 0;
		int m1 = 0;
		int m2 = 0;
		int m3 = 0;
		int m4 = 0;
		for (int i = 0; i < n; i++)
		{
			cin >> number;
			if (number % 5 == 0 && number % 2 == 0 && number > m1)
			{
				m1 = number;
			}
			if (number % 5 == 0 && number % 2 != 0 && number > m2)
			{
				m2 = number;
			}
			if (number % 5 != 0 && number % 2 == 0 && number > m3)
			{
				m3 = number;
			}
			if (number % 5 != 0 && number % 2 != 0 && number > m4)
			{
				m4 = number;
			}
		}
		int p1 = m1 * m2;
		int p2 = m1 * m4;
		int p3 = m2 * m3;

		if (p1 + p2 + p3 == 0)
		{
			cout << 0;
			return;
		}

		if (p1 >= p2 && p1 >= p3)
		{
			cout << m1 << " " << m2;
			return;
		}

		if (p2 >= p1 && p2 >= p3)
		{
			cout << m1 << " " << m4;
			return;
		}

		if (p3 >= p2 && p3 >= p1)
		{
			cout << m2 << " " << m3;
			return;
		}
	}

	void task14788()
	{
		int number = 0;
		int n = 0;
		cin >> n;
		int m[9];
		for (int i = 0; i < 9; i++)
		{
			m[i] = 0;
		}
		for (int i = 0; i < n; i++)
		{
			cin >> number;
			int ost = number % 9;
			for (int i = 0; i < 9; i++)
			{
				if (i % 9 == ost)
				{
					++m[i];
				}
			}
		}

		cout << m[1] * m[8] + m[2] * m[7] + m[3] * m[6] + m[4] * m[5] + m[0] * (m[0] - 1) / 2;
	}

	void task15149()
	{
		int number = 0;
		int n = 0;
		cin >> n;
		int m[10];
		for (int i = 0; i < 10; i++)
		{
			m[i] = 0;
		}
		for (int i = 0; i < n; i++)
		{
			cin >> number;
			int ost = number % 10;
			for (int i = 0; i < 10; i++)
			{
				if (i % 10 == ost)
				{
					++m[i];
				}
			}
		}

		cout << m[1] * m[9] + m[2] * m[8] + m[3] * m[7] + m[4] * m[6] + m[0] * (m[0] - 1) / 2 + m[5] * (m[5] - 1) /2;
	}


}