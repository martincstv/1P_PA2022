import msvcrt
import clr
clr.AddReference("Resources/Ejemplo13_BibliotecaClases")
from Ejemplo13_BibliotecaClases import Operaciones
obj = Operaciones()
number1 = float(100)
number2 = float(4)
print("             Metodos consumidos desde dll")
print()
print("Suma: 100 y 4 = ",obj.Sumar(number1,number2))
print("Resta: 100 y 4 = ",obj.Restar(number1,number2))
print("Multiplicacion: 100 y 4 = ",obj.Multiplicar(number1,number2))
print("Division: 100 y 4 = ",obj.Dividir(number1,number2))
print("Potencia: 100 y 4 = ",obj.Potencia(number1,number2))
print("Residuo: 100 y 4 = ",obj.Residuo(number1,number2))
print("Mayor: 100 y 4 = ",obj.MayorDeDosNumeros(number1,number2))
msvcrt.getch()