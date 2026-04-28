import math


print("--------SISTEMA DE CALCULO DE ÁREA--------\n");

print("1. Área del Cuadrado");
print("2. Área del Triángulo");
print("3. Área del Rectángulo");
print("4. Área del Circulo");


opc = int(input("Ingrese una opción: "));

match opc:
    case 1:
        l = int(input("\nIngresa el lado del cuadrado: "));
        area = l * l;
        print("\nÁrea del cuadrado: " , area);
    case 2:
        b = int(input("\nIngresa la base del triángulo: "))
        h = int(input("\nIngresa la altura del triángulo: "))
        area = b * h / 2
        print ("\nÁrea del rectángulo: " , area)
    case 3:
        br = int(input("\nIngresa la base del rectángulo: "))
        hr = int(input("\nIngresa la altura del rectángulo: "))
        area = br * hr
        print ("\nÁrea del rectángulo: " , area)
    case 4:
        r = int(input("\nIngresa el radio del circulo: "))
        area = math.pi * math.pow (r , 2)
        print ("\nÁrea del circulo: " , area)