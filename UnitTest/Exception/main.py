import sys

try:
    print("enter first number")
    a = float(input())

    print("Enter second number")
    b = float(input())

    result = a / b
    print("result " + str(result))
except Exception as ex:
    print("error " + str(ex))

print("size of integer: " + str(sys.getsizeof(int())) + " bytes")
print("size of float: " + str(sys.getsizeof(float())) + " bytes")
