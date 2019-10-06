#include <iostream>
#include "introduction.h"
#include "combinatorics.h"
#include "myMath.h"
#include "oge.h"
#include "massiv.h"
#include "sequence.h"

using namespace std;

int main()
{
	int const N;
	int a[N];
	for (int i = 0; i < N; i++)
	{
		cin >> a[i];
	}
	cout << in9209(a, N);
	//sequence::task20();
	return 0;
}