# Ngan xep
    # Khoi luong hoa chat 
# from queue import LifoQueue

# n = int(input())
# ls = []
# for i in range(0, n):
#     ls.append(input())

# k = {'(':0, 'C':12, 'H':1, 'O':16}

# for s in ls:
#     lq = LifoQueue()

#     for c in s:
#         if c in k.keys():
#             lq.put(k[c])
#         elif c == ')':
#             t = 0
#             while lq.queue[-1] != 0:
#                 t += lq.get()
#             lq.queue[-1] = t
#         else:
#             lq.queue[-1] = lq.queue[-1] * int(c)
        
#     res = sum(lq.queue)
#     print(res)

    #Chao don K59
# from queue import LifoQueue

# def func(A, rang):
#     lq = LifoQueue()
#     lq.put((-1, 2e9))
#     res = [0] * len(A)

#     for i, x in zip(rang, A):
#         while x >= lq.queue[-1][1]:
#             lq.get()
#         res[i] = lq.queue[-1][0]
#         lq.put((i, x))
#     return res


# n = int(input())
# a = list(map(int, input().split()))

# L = func(a, range(0, n, 1))
# R = func(a[::-1], range(n - 1, -1, -1))

# for i in range(n):
#     if L[i] > -1 and R[i] > -1:
#         print(L[i] if i - L[i] <= R[i] - i else R[i], end=" ")
#     else:
#         print(L[i] + R[i] + 1, end=" ")

    # Xep hang
# from queue import LifoQueue

# S = LifoQueue()
# n = int(input())
# res = 0
# a = list(map(int, input().split()))
# for x in a:
#     while S.qsize() and S.queue[-1][0] < x:
#         res += S.queue[-1][1]
#         S.get()
#     if S.qsize() and S.queue[-1][0] == x:
#         res += S.queue[-1][1] + (S.qsize() > 1)
#         S.queue[-1][1] += 1
#     else:
#         res += (S.qsize() > 0)
#         S.put([x, 1])
# print(res)

# Hang doi
    #Day con lien tuc co tong cho truoc
# from queue import Queue
# n, t = map(int, input().split())
# a = list(map(int, input().split()))

# q = Queue()
# c = 0
# res = 0

# for x in a:
#     c += x
#     q.get(x)

#     while c > t:
#         c -= q.get()

#     if c == t:
#         res = max(res, q.qsize())

# print(res)

# Hang doi uu tien
    # Lam bong tuyet
# from queue import PriorityQueue
# n = int(input())
# V = list(map(int, input().split()))
# T = list(map(int, input().split()))

# pq = PriorityQueue()
# offset = 0

# for v, t in zip(V, T):
#     pq.put(v + offset)
#     melted = 0
#     while pq.qsize() and pq.queue[0] - offset <= t:
#         melted += pq.get() - offset
#     melted += t * pq.qsize()
#     offset += t
#     print(melted, end=" ")

    # Lap ghep ong nuoc
# from queue import PriorityQueue
# n, k = map(int, input().split())
# pq = PriorityQueue()
# for x in list(map(int, input().split())):
#     pq.put(x)

# res = 0
# while pq.qsize() > 1:
#     t = 0
#     for i in range(min(k, pq.qsize())):
#         t += pq.get()
#     pq.put(t)
#     res += t

# print(res)

    # Thuat toan huffman
# from queue import PriorityQueue
# s = input()
# freq = {}
# for c in s:
#     freq[c] = freq.get(c, 0) + 1

# pq = PriorityQueue()
# for x in freq.values():
#     pq.put(x)

# res = 0
# while pq.qsize() > 1:
#     x = pq.get()
#     y = pq.get()
#     total = x + y
#     res += total
#     pq.put(total)

# print(res)

# Hang doi 2 dau
    # Trinh tham
# from collections import deque 
# n, k = map(int, input().split())
# a = list(map(int, input().split()))

# dq = deque()

# for i in range(n):
#     while dq and a[dq[0]] <= a[i]:
#         dq.popleft()
#     dq.appendleft(i)

#     if dq[-1] <= i - k:
#         dq.pop()
    
#     if (i >= k - 1):
#         print(a[dq[-1]], end = " ")

# Dictionary
    # Day con lien tuc khac biet
n = int(input())
a = list(map(int, input().split()))

d = {}
l = 0
res = 0

for i in range(n):
    if a[i] in d and d[a[i]] >= l:
        l = d[a[i]]    
    d[a[i]] = i
    
    res = max(res, i - l)

print(res)

