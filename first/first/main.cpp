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
	int const n = 5;
	int a[n];
	for (int i = 0; i < n; i++)
	{
		cin >> a[i];
	}
	sequence::task20();
	return 0;
}