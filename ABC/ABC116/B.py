s = int(input())
l = []


def f(n):
    if n % 2 == 0:
        return n / 2
    else:
        return 3 * n + 1


for i in range(1000000):
    if i == 0:
        l.append(s)
    else:
        l.append(f(l[i - 1]))

count = [0] * len(l)
for i in range(len(l)):
    count[int(l[i])] += 1
    if 1 < count[int(l[i])]:
        print(i+1)
        break
