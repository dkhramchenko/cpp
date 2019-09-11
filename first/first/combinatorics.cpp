int factorial(int number)
{
	int f = 1;
	for (int i = 2; i <= number; i++)
	{
		f *= i;
	}
	return f;
}

int razmeshenie(int n, int k)
{
	return factorial(n) / factorial(n - k);
}