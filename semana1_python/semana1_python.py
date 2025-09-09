def ejer1():
    nombre = input("ingrese su name: ")
    carrera = input("ingrese su caerra: ")

    print(f"{nombre}, bienbenido a FA de {carrera}")
def ejer2():
    print("\"cristhofer\"")

def ejer3():
    x = int(input("Ingresar el valor de x: "))
    y = int(input("Ingresar el valor de y: "))

    print("suma: ", (x+y))
    print("resta: ", (x-y))
    print("multiplicacion: ", (x*y))
    print("division: ", (x/y))

import math

def ejer4():
    num = float(input("Ingrese un numero decimal: "))

    print("raiz 2: ", math.sqrt(num))
    print("redondeado: ", round(num,0))
    print("al cubo: ", math.pow(num,3))
    print("raiz 3: ", num ** (1/3))

def ejer5():
    num = input("Ingrese numero: ")

    entero = int(num)
    deci = float(num)

    print("resto: ",(entero%2))
    print("division: ",(deci/2))


ejer5()