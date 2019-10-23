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
}