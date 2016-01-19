# Project Euler Problem 2
# Charles Profitt 6/5/2011
# github edit

def fibonacci_sequence(s1, s2, l):
	# given seeds of s1 and s2 create a fibonacci sequence limited to l
	a, b = s1, s2
	sum = 0
	while a < l:
		a, b = b, a + b
		if (a % 2 == 0):
			sum += a
	return sum

print fibonacci_sequence(1, 2, 4000000)
